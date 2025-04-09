namespace WindowsFormsApp2
{
    partial class WorkForm
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
            this.labelUnlogin = new System.Windows.Forms.Label();
            this.labelContactFullname = new System.Windows.Forms.Label();
            this.labelOrganizationName = new System.Windows.Forms.Label();
            this.clearAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TerminalTimeslotVehicleIdError = new System.Windows.Forms.Label();
            this.TerminalTimeslotVehicleId = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.terminalWeightUnloadedNettoError = new System.Windows.Forms.Label();
            this.terminalWeightUnloadedNetto = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.terminalHadLeftDateTimeError = new System.Windows.Forms.Label();
            this.terminalHadLeftDateTime = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.terminalWeightUnloadedBruttoError = new System.Windows.Forms.Label();
            this.terminalWeightUnloadedBrutto = new System.Windows.Forms.TextBox();
            this.errorlable = new System.Windows.Forms.Label();
            this.sendRequest = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUnlogin
            // 
            this.labelUnlogin.AutoSize = true;
            this.labelUnlogin.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelUnlogin.Location = new System.Drawing.Point(694, 33);
            this.labelUnlogin.Name = "labelUnlogin";
            this.labelUnlogin.Size = new System.Drawing.Size(128, 16);
            this.labelUnlogin.TabIndex = 1;
            this.labelUnlogin.Text = "Выйти из профиля";
            this.labelUnlogin.Click += new System.EventHandler(this.labelUnlogin_Click);
            this.labelUnlogin.MouseLeave += new System.EventHandler(this.mouseLeaveUnloginLable);
            this.labelUnlogin.MouseHover += new System.EventHandler(this.mouseHoverUnloginLable);
            // 
            // labelContactFullname
            // 
            this.labelContactFullname.AutoSize = true;
            this.labelContactFullname.Location = new System.Drawing.Point(13, 13);
            this.labelContactFullname.Name = "labelContactFullname";
            this.labelContactFullname.Size = new System.Drawing.Size(137, 16);
            this.labelContactFullname.TabIndex = 2;
            this.labelContactFullname.Text = "labelContactFullname";
            // 
            // labelOrganizationName
            // 
            this.labelOrganizationName.AutoSize = true;
            this.labelOrganizationName.Location = new System.Drawing.Point(13, 33);
            this.labelOrganizationName.Name = "labelOrganizationName";
            this.labelOrganizationName.Size = new System.Drawing.Size(149, 16);
            this.labelOrganizationName.TabIndex = 3;
            this.labelOrganizationName.Text = "labelOrganizationName";
            // 
            // clearAll
            // 
            this.clearAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearAll.Location = new System.Drawing.Point(30, 313);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(162, 29);
            this.clearAll.TabIndex = 0;
            this.clearAll.Text = "Очистить форму";
            this.clearAll.UseVisualStyleBackColor = false;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TerminalTimeslotVehicleIdError);
            this.groupBox1.Controls.Add(this.TerminalTimeslotVehicleId);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(27, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Номер назначения";
            // 
            // TerminalTimeslotVehicleIdError
            // 
            this.TerminalTimeslotVehicleIdError.AutoSize = true;
            this.TerminalTimeslotVehicleIdError.ForeColor = System.Drawing.Color.Red;
            this.TerminalTimeslotVehicleIdError.Location = new System.Drawing.Point(25, 70);
            this.TerminalTimeslotVehicleIdError.Name = "TerminalTimeslotVehicleIdError";
            this.TerminalTimeslotVehicleIdError.Size = new System.Drawing.Size(85, 20);
            this.TerminalTimeslotVehicleIdError.TabIndex = 1;
            this.TerminalTimeslotVehicleIdError.Text = "                   ";
            // 
            // TerminalTimeslotVehicleId
            // 
            this.TerminalTimeslotVehicleId.Location = new System.Drawing.Point(22, 40);
            this.TerminalTimeslotVehicleId.Name = "TerminalTimeslotVehicleId";
            this.TerminalTimeslotVehicleId.Size = new System.Drawing.Size(346, 27);
            this.TerminalTimeslotVehicleId.TabIndex = 0;
            this.TerminalTimeslotVehicleId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.timeslotVehicleIdInputBoxKeyDown);
            this.TerminalTimeslotVehicleId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeslotVehicleIdInputBoxKeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.terminalWeightUnloadedNettoError);
            this.groupBox3.Controls.Add(this.terminalWeightUnloadedNetto);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(27, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 93);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вес Нетто (в тоннах, разделитель - запятая)";
            // 
            // terminalWeightUnloadedNettoError
            // 
            this.terminalWeightUnloadedNettoError.AutoSize = true;
            this.terminalWeightUnloadedNettoError.ForeColor = System.Drawing.Color.Red;
            this.terminalWeightUnloadedNettoError.Location = new System.Drawing.Point(25, 70);
            this.terminalWeightUnloadedNettoError.Name = "terminalWeightUnloadedNettoError";
            this.terminalWeightUnloadedNettoError.Size = new System.Drawing.Size(85, 20);
            this.terminalWeightUnloadedNettoError.TabIndex = 6;
            this.terminalWeightUnloadedNettoError.Text = "                   ";
            // 
            // terminalWeightUnloadedNetto
            // 
            this.terminalWeightUnloadedNetto.Location = new System.Drawing.Point(22, 40);
            this.terminalWeightUnloadedNetto.Name = "terminalWeightUnloadedNetto";
            this.terminalWeightUnloadedNetto.Size = new System.Drawing.Size(346, 27);
            this.terminalWeightUnloadedNetto.TabIndex = 1;
            this.terminalWeightUnloadedNetto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.terminalWeightUnloadedNettoKeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.terminalHadLeftDateTimeError);
            this.groupBox2.Controls.Add(this.terminalHadLeftDateTime);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(433, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 93);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дата выезда (заполняется автоматически)";
            // 
            // terminalHadLeftDateTimeError
            // 
            this.terminalHadLeftDateTimeError.AutoSize = true;
            this.terminalHadLeftDateTimeError.ForeColor = System.Drawing.Color.Red;
            this.terminalHadLeftDateTimeError.Location = new System.Drawing.Point(26, 70);
            this.terminalHadLeftDateTimeError.Name = "terminalHadLeftDateTimeError";
            this.terminalHadLeftDateTimeError.Size = new System.Drawing.Size(85, 20);
            this.terminalHadLeftDateTimeError.TabIndex = 5;
            this.terminalHadLeftDateTimeError.Text = "                   ";
            // 
            // terminalHadLeftDateTime
            // 
            this.terminalHadLeftDateTime.Enabled = false;
            this.terminalHadLeftDateTime.Location = new System.Drawing.Point(22, 40);
            this.terminalHadLeftDateTime.Name = "terminalHadLeftDateTime";
            this.terminalHadLeftDateTime.ReadOnly = true;
            this.terminalHadLeftDateTime.Size = new System.Drawing.Size(346, 27);
            this.terminalHadLeftDateTime.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.terminalWeightUnloadedBruttoError);
            this.groupBox4.Controls.Add(this.terminalWeightUnloadedBrutto);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(433, 194);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(389, 93);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Вес Брутто (в тоннах, разделитель - запятая)";
            // 
            // terminalWeightUnloadedBruttoError
            // 
            this.terminalWeightUnloadedBruttoError.AutoSize = true;
            this.terminalWeightUnloadedBruttoError.ForeColor = System.Drawing.Color.Red;
            this.terminalWeightUnloadedBruttoError.Location = new System.Drawing.Point(26, 70);
            this.terminalWeightUnloadedBruttoError.Name = "terminalWeightUnloadedBruttoError";
            this.terminalWeightUnloadedBruttoError.Size = new System.Drawing.Size(85, 20);
            this.terminalWeightUnloadedBruttoError.TabIndex = 7;
            this.terminalWeightUnloadedBruttoError.Text = "                   ";
            // 
            // terminalWeightUnloadedBrutto
            // 
            this.terminalWeightUnloadedBrutto.Location = new System.Drawing.Point(22, 40);
            this.terminalWeightUnloadedBrutto.Name = "terminalWeightUnloadedBrutto";
            this.terminalWeightUnloadedBrutto.Size = new System.Drawing.Size(346, 27);
            this.terminalWeightUnloadedBrutto.TabIndex = 2;
            this.terminalWeightUnloadedBrutto.Text = "1,0";
            this.terminalWeightUnloadedBrutto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.terminalWeightUnloadedBruttoKeyPress);
            // 
            // errorlable
            // 
            this.errorlable.AutoSize = true;
            this.errorlable.Location = new System.Drawing.Point(27, 294);
            this.errorlable.Name = "errorlable";
            this.errorlable.Size = new System.Drawing.Size(64, 16);
            this.errorlable.TabIndex = 5;
            this.errorlable.Text = "                   ";
            // 
            // sendRequest
            // 
            this.sendRequest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendRequest.Location = new System.Drawing.Point(708, 313);
            this.sendRequest.Name = "sendRequest";
            this.sendRequest.Size = new System.Drawing.Size(114, 29);
            this.sendRequest.TabIndex = 3;
            this.sendRequest.Text = "Отправить";
            this.sendRequest.UseVisualStyleBackColor = true;
            this.sendRequest.Click += new System.EventHandler(this.sendRequest_Click);
            // 
            // WorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 379);
            this.ControlBox = false;
            this.Controls.Add(this.sendRequest);
            this.Controls.Add(this.errorlable);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.labelOrganizationName);
            this.Controls.Add(this.labelContactFullname);
            this.Controls.Add(this.labelUnlogin);
            this.Name = "WorkForm";
            this.Text = "WorkForm";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.terminalWeightUnloadedNettoKeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelUnlogin;
        private System.Windows.Forms.Label labelContactFullname;
        private System.Windows.Forms.Label labelOrganizationName;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TerminalTimeslotVehicleId;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox terminalWeightUnloadedNetto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox terminalHadLeftDateTime;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox terminalWeightUnloadedBrutto;
        private System.Windows.Forms.Label TerminalTimeslotVehicleIdError;
        private System.Windows.Forms.Label terminalWeightUnloadedNettoError;
        private System.Windows.Forms.Label terminalHadLeftDateTimeError;
        private System.Windows.Forms.Label terminalWeightUnloadedBruttoError;
        private System.Windows.Forms.Label errorlable;
        private System.Windows.Forms.Button sendRequest;
    }
}