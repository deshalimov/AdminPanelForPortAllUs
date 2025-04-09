using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class StartForm : Form
    {
        private readonly DBHelper dBHelper;
        AuthForm openFofmAuth;
        WorkForm workForm;

        public StartForm()
        {
            openFofmAuth = new AuthForm(this);
            workForm = new WorkForm(this);
            InitializeComponent();
            dBHelper = new DBHelper();
            LoadInitialForm();
        }

        private void LoadInitialForm()
        {
            if (dBHelper.Is_user_auth())
            {
                OpenFormInPanel(workForm);
            }
            else
            {
                OpenFormInPanel(openFofmAuth);
            }
        }

        

        // открыть необходимую форму
        public void OpenFormInPanel(Form form)
        {
            // Очищаем панель от предыдущих контролов
            panel1.Controls.Clear();

            // Устанавливаем свойства формы
            form.TopLevel = false; // Делаем форму подчиненной панелю
            form.FormBorderStyle = FormBorderStyle.None; // Убираем рамку формы
            form.Dock = DockStyle.Fill; // Заполняем панель

            // Добавляем форму на панель
            panel1.Controls.Add(form);
            form.Show(); // Отображаем форму
        }

        private void buttonUnlogin_Click(object sender, EventArgs e)
        {
            AuthForm openFofmAuth = new AuthForm(this);
            OpenFormInPanel(openFofmAuth);
            dBHelper.Clear_data_in_db();
        }
    }
}
