namespace WindowsFormsApp2
{
    partial class AuthForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.groupBoxPassword = new System.Windows.Forms.GroupBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelIfroreq = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxLogin.SuspendLayout();
            this.groupBoxPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(23, 43);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(346, 22);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.Text = "Test.port@bk.ru";
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.labelLogin);
            this.groupBoxLogin.Controls.Add(this.textBoxLogin);
            this.groupBoxLogin.Location = new System.Drawing.Point(95, 35);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(395, 100);
            this.groupBoxLogin.TabIndex = 0;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Логин";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.ForeColor = System.Drawing.Color.Red;
            this.labelLogin.Location = new System.Drawing.Point(23, 78);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(46, 16);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "             ";
            // 
            // groupBoxPassword
            // 
            this.groupBoxPassword.Controls.Add(this.labelPassword);
            this.groupBoxPassword.Controls.Add(this.textBoxPassword);
            this.groupBoxPassword.Location = new System.Drawing.Point(95, 156);
            this.groupBoxPassword.Name = "groupBoxPassword";
            this.groupBoxPassword.Size = new System.Drawing.Size(395, 100);
            this.groupBoxPassword.TabIndex = 0;
            this.groupBoxPassword.TabStop = false;
            this.groupBoxPassword.Text = "Пароль";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.ForeColor = System.Drawing.Color.Red;
            this.labelPassword.Location = new System.Drawing.Point(23, 81);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(64, 16);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "                   ";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(23, 45);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(346, 22);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Text = "124578A!";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(95, 275);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(130, 35);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Авторизация";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelIfroreq
            // 
            this.labelIfroreq.AutoSize = true;
            this.labelIfroreq.Location = new System.Drawing.Point(92, 313);
            this.labelIfroreq.Name = "labelIfroreq";
            this.labelIfroreq.Size = new System.Drawing.Size(64, 16);
            this.labelIfroreq.TabIndex = 2;
            this.labelIfroreq.Text = "                   ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(615, 59);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 240);
            this.textBox1.TabIndex = 4;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 379);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelIfroreq);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.groupBoxPassword);
            this.Controls.Add(this.groupBoxLogin);
            this.Name = "AuthForm";
            this.Text = "AuthForm";
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.groupBoxPassword.ResumeLayout(false);
            this.groupBoxPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.GroupBox groupBoxPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelIfroreq;
        private System.Windows.Forms.TextBox textBox1;
    }
}