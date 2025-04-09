using System;
using System.Text.Json;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AuthForm : Form
    {
        private readonly DBHelper dBHelper;
        private readonly UrlQueries urlQueries;
        readonly StartForm startForm;

        public AuthForm(StartForm owner)
        {
            startForm = owner;
            InitializeComponent();
            urlQueries = new UrlQueries();
            dBHelper = new DBHelper();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            labelIfroreq.Text = "";

            if (textBoxLogin.Text.Length == 0)
                labelLogin.Text = "Введите логин";
            else labelLogin.Text = "";

            if (textBoxPassword.Text.Length == 0)
                labelPassword.Text = "Введите пароль";
            else labelPassword.Text = "";

            if (textBoxLogin.Text.Length != 0 && textBoxPassword.Text.Length != 0)
            {
                this.Cursor = Cursors.WaitCursor;
                // отправить запрос
                (int code, string resp) auth_response = urlQueries.AuthGetAccessToken(textBoxLogin.Text.ToString(), textBoxPassword.Text.ToString());
                this.Cursor = Cursors.Default;

                if (auth_response.code == 200)
                {
                    var jsonDocAuth = JsonDocument.Parse(auth_response.resp).RootElement;
                    string access_token = jsonDocAuth.GetProperty("access_token").GetString();
                    string refresh_token = jsonDocAuth.GetProperty("refresh_token").GetString();

                    
                    // получить данные профиля пользователя
                    (int code, string resp) resp_me = urlQueries.GetMe(access_token);
                    if (resp_me.code == 200)
                    {
                        var jsonDocMe = JsonDocument.Parse(resp_me.resp).RootElement;
                        string type = jsonDocMe.GetProperty("type").GetString();
                        if (type == "dispatcher")
                        {
                            // получить ФИО и наименование ДТ
                            string contactFullName = jsonDocMe.GetProperty("firstName").GetString() + " " + jsonDocMe.GetProperty("lastName").GetString();
                            string profileDetails = jsonDocMe.GetProperty("terminalAgent").GetProperty("profileDetails").GetProperty("organizationName").GetString();

                            // Сохранить данные в БД
                            dBHelper.Set_auth_data_in_database(contactFullName, profileDetails, access_token, refresh_token);

                            // Закрыть форму авторизации и открыть рабочую форму
                            WorkForm workForm = new WorkForm(startForm);
                            startForm.OpenFormInPanel(workForm);
                        }
                        else
                        {
                            labelIfroreq.Text = "Для данного типа пользователя авторизация недоступна";
                        }
                        //textBox1.Text = type;
                    }
                    else
                    {
                        labelIfroreq.Text = "Возникла ошибка при получении данных профиля";
                    }
                    
                    
                }
                else if (auth_response.code == 400)
                {
                    if(JsonDocument.Parse(auth_response.resp).RootElement.GetProperty("error_description").GetString() == "invalid_username_or_password")
                       labelIfroreq.Text = "Неверный логин или пароль";
                    //labelIfroreq.Text = "Ошибка!!! Код: " + resp.code.ToString() + ", ответ: " + resp.resp;
                }
                else if (auth_response.code == 404)
                {
                    labelIfroreq.Text = "Ошибка авторизации! Код: " + auth_response.code.ToString() + ", ответ: Not found";
                    //labelIfroreq.Text = "Ошибка!!! Код: " + resp.code.ToString() + ", ответ: " + resp.resp;
                }
                else
                {
                    labelIfroreq.Text = "Ошибка авторизации! Код: " + auth_response.code.ToString() + ", ответ: " + auth_response.resp;
                }
            }
        }

        
    }
}
