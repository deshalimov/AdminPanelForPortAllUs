using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class WorkForm : Form
    {
        private readonly StartForm form1;
        private readonly DBHelper dBHelper;
        private readonly UrlQueries urlQueries;
        public WorkForm(StartForm owner)
        {
            form1 = owner;
            dBHelper = new DBHelper();
            urlQueries = new UrlQueries();

            InitializeComponent();
            Organizations_Info();
        }
        private void Organizations_Info()
        {
            (string name, string org) org = dBHelper.Get_fullname_and_orgname_from_db();
            labelContactFullname.Text = org.name;
            labelOrganizationName.Text = org.org;
        }

            private void labelUnlogin_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверенны, что хотите выйти из профиля?", "Выход из профиля", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                AuthForm authForm = new AuthForm(form1);
                form1.OpenFormInPanel(authForm);
                dBHelper.Clear_data_in_db();
            }
        }

        // мыша в фокусе кнопки разлогина
        private void mouseHoverUnloginLable(object sender, EventArgs e)
        {
            labelUnlogin.ForeColor = Color.Black;
            this.Cursor = Cursors.Hand;
        }

        // мыша вышла из фокуса кнопки разлогина
        private void mouseLeaveUnloginLable(object sender, EventArgs e)
        {
            labelUnlogin.ForeColor = Color.Gray;
            this.Cursor = Cursors.Default;
        }

        // Кнопка очистить форму
        private void clearAll_Click(object sender, EventArgs e)
        {
            // очистить введенные значения из полей ввода
            terminalHadLeftDateTime.Text = "";
            //
            terminalWeightUnloadedBrutto.Text = "";
            terminalWeightUnloadedNetto.Text = "";
            TerminalTimeslotVehicleId.Text = "";

            // очистить введенные значения из полей "ошибок"
            TerminalTimeslotVehicleIdError.Text = "";
            terminalWeightUnloadedNettoError.Text = "";
            terminalWeightUnloadedBruttoError.Text = "";
            terminalHadLeftDateTimeError.Text = "";

            errorlable.Text = "";
        }

        private void timeslotVehicleIdInputBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void timeslotVehicleIdInputBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch((sender as TextBox).Text + e.KeyChar, @"^[1-9]\d*$") && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void terminalWeightUnloadedNettoKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch((sender as TextBox).Text + e.KeyChar, @"^[1-9]\d*[,]?\d{0,2}$") && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void terminalWeightUnloadedBruttoKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch((sender as TextBox).Text + e.KeyChar, @"^[1-9]\d*[,]?\d{0,2}$") && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void sendRequest_Click(object sender, EventArgs e)
        {
            // проверить заполнен ли номер назначения
            if (TerminalTimeslotVehicleId.Text == "")
            {
                TerminalTimeslotVehicleIdError.Text = "Заполните номер назначения";
            }
            else if (TerminalTimeslotVehicleId.Text.Length < 8)
            {
                TerminalTimeslotVehicleIdError.Text = "Кол-во символов должно быть больше 8";
            }
            else TerminalTimeslotVehicleIdError.Text = "";

            // проверить заполнена ли масса нетто
            if (terminalWeightUnloadedNetto.Text == "")
                terminalWeightUnloadedNettoError.Text = "Заполните массу нетто";
            else terminalWeightUnloadedNettoError.Text = "";

            // проверить заполнена ли масса брутто
            if (terminalWeightUnloadedBrutto.Text == "")
                terminalWeightUnloadedBruttoError.Text = "Заполните массу брутто";
            else terminalWeightUnloadedBruttoError.Text = "";


            

            // если все поля заполнены и валидны
            if (
                TerminalTimeslotVehicleId.Text != ""
                && terminalWeightUnloadedNetto.Text != ""
                && terminalWeightUnloadedBrutto.Text != ""
                && terminalHadLeftDateTime.Text != ""
                && TerminalTimeslotVehicleId.Text.Length >= 8
                )
            {
                // обновить токен
                (int code, string resp) resp_refresh_token = urlQueries.RefreshToken(dBHelper.Get_refresh_token_from_db());

                // если токен обновлен успешно
                if (resp_refresh_token.code == 200)
                {
                    // проверить заполнена ли дата выезда
                    string dateTimeUTC = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss");
                    terminalHadLeftDateTime.Text = DateTime.Now.ToString();

                    // записать новый токен в БД
                    var jsonDocRefresh = JsonDocument.Parse(resp_refresh_token.resp).RootElement;
                    string access_token = jsonDocRefresh.GetProperty("access_token").GetString();
                    string refresh_token = jsonDocRefresh.GetProperty("refresh_token").GetString();

                    dBHelper.Set_refresh_token_from_db(access_token, refresh_token);

                    // отправить запрос в ЭО
                    (int code, string resp) resp_req_eq = urlQueries.SendQuerry(access_token, dateTimeUTC);

                    
                }
                else
                {
                    MessageBox.Show(
                        "Возникла ошибка при получении данных авторизации. Повторите попытку отправку запроса. \n\n" + "Код ошибки: " + resp_refresh_token.code + ", ответ сервера: " + resp_refresh_token.resp,
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                // отключить кнопку на время выполнения запроса
                //sendRequest.Enabled = false;
                // use wait cursor
                //Form1.ActiveForm.UseWaitCursor = true;
                // Получить токен пользователя
                //(string resp_code, string resp_jsn) get_access_token = GetAccessToken();
                //if (get_access_token.resp_code == "OK")
                //{
                //    (string resp_code, string resp_jsn) send_req = sendQuerry(get_access_token.resp_jsn, dateTimeUTC);
                //    errorlable.Text = send_req.resp_jsn;
                //    if (send_req.resp_code == "OK")
                //    {
                //        MessageBox.Show(
                //            send_req.resp_jsn,
                //            "Сообщение",
                //            MessageBoxButtons.OK,
                //            MessageBoxIcon.Information);
                //        sendRequest.Enabled = true;
                //        // use wait cursor
                //        //Form1.ActiveForm.UseWaitCursor = false;
                //    }
                //    else
                //    {
                //        MessageBox.Show(
                //            send_req.resp_jsn,
                //            "Ошибка",
                //            MessageBoxButtons.OK,
                //            MessageBoxIcon.Error);
                //        sendRequest.Enabled = true;
                //        // use wait cursor
                //        //Form1.ActiveForm.UseWaitCursor = false;
                //    }
                //}
                //else
                //{
                //    errorlable.Text = get_access_token.resp_jsn;
                //    MessageBox.Show(
                //        get_access_token.resp_jsn,
                //        "Ошибка авторизации",
                //        MessageBoxButtons.OK,
                //        MessageBoxIcon.Error);
                //    sendRequest.Enabled = true;
                //    // use wait cursor
                //    //Form1.ActiveForm.UseWaitCursor = false;
                //}
            }
        }
    }
}
