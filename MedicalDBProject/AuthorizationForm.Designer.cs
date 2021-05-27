namespace MedicalDBProject
{
    partial class AuthorizationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.OpenDbChangeButton = new System.Windows.Forms.Button();
            this.OpenDbViewButton = new System.Windows.Forms.Button();
            this.labelEmployeeReg = new System.Windows.Forms.Label();
            this.labelPrivacyPolicy = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(190, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(181, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(208, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "База данных клиники";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(309, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "ИЛИ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(273, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Авторизация";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(258, 145);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(168, 29);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLogin.Location = new System.Drawing.Point(258, 115);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(168, 29);
            this.textBoxLogin.TabIndex = 6;
            // 
            // OpenDbChangeButton
            // 
            this.OpenDbChangeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenDbChangeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenDbChangeButton.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.OpenDbChangeButton.FlatAppearance.BorderSize = 0;
            this.OpenDbChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenDbChangeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpenDbChangeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OpenDbChangeButton.Location = new System.Drawing.Point(294, 185);
            this.OpenDbChangeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpenDbChangeButton.Name = "OpenDbChangeButton";
            this.OpenDbChangeButton.Size = new System.Drawing.Size(89, 28);
            this.OpenDbChangeButton.TabIndex = 7;
            this.OpenDbChangeButton.Text = "Войти";
            this.OpenDbChangeButton.UseVisualStyleBackColor = false;
            this.OpenDbChangeButton.Click += new System.EventHandler(this.OpenDbChangeButton_Click);
            // 
            // OpenDbViewButton
            // 
            this.OpenDbViewButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenDbViewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenDbViewButton.FlatAppearance.BorderSize = 0;
            this.OpenDbViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenDbViewButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpenDbViewButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OpenDbViewButton.Location = new System.Drawing.Point(253, 255);
            this.OpenDbViewButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpenDbViewButton.Name = "OpenDbViewButton";
            this.OpenDbViewButton.Size = new System.Drawing.Size(178, 32);
            this.OpenDbViewButton.TabIndex = 8;
            this.OpenDbViewButton.Text = "Режим просмотра";
            this.OpenDbViewButton.UseVisualStyleBackColor = false;
            this.OpenDbViewButton.Click += new System.EventHandler(this.OpenDbViewButton_Click);
            // 
            // labelEmployeeReg
            // 
            this.labelEmployeeReg.AutoSize = true;
            this.labelEmployeeReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEmployeeReg.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelEmployeeReg.ForeColor = System.Drawing.Color.Blue;
            this.labelEmployeeReg.Location = new System.Drawing.Point(462, 7);
            this.labelEmployeeReg.Name = "labelEmployeeReg";
            this.labelEmployeeReg.Size = new System.Drawing.Size(212, 19);
            this.labelEmployeeReg.TabIndex = 9;
            this.labelEmployeeReg.Text = "Регистрация нового сотрудника";
            this.labelEmployeeReg.Click += new System.EventHandler(this.labelEmployeeReg_Click);
            // 
            // labelPrivacyPolicy
            // 
            this.labelPrivacyPolicy.AutoSize = true;
            this.labelPrivacyPolicy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPrivacyPolicy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelPrivacyPolicy.ForeColor = System.Drawing.Color.Blue;
            this.labelPrivacyPolicy.Location = new System.Drawing.Point(462, 292);
            this.labelPrivacyPolicy.Name = "labelPrivacyPolicy";
            this.labelPrivacyPolicy.Size = new System.Drawing.Size(211, 19);
            this.labelPrivacyPolicy.TabIndex = 10;
            this.labelPrivacyPolicy.Text = "Политика конфиденциальности";
            this.labelPrivacyPolicy.Click += new System.EventHandler(this.labelPrivacyPolicy_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 318);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 20);
            this.panel1.TabIndex = 11;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPrivacyPolicy);
            this.Controls.Add(this.labelEmployeeReg);
            this.Controls.Add(this.OpenDbViewButton);
            this.Controls.Add(this.OpenDbChangeButton);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База данных клиники";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button OpenDbChangeButton;
        private System.Windows.Forms.Button OpenDbViewButton;
        private System.Windows.Forms.Label labelEmployeeReg;
        private System.Windows.Forms.Label labelPrivacyPolicy;
        private System.Windows.Forms.Panel panel1;
    }
}

