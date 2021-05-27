namespace MedicalDBProject
{
    partial class EmployeeRegForm
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
            this.textBoxNewLogin = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.acceptRegButton = new System.Windows.Forms.Button();
            this.checkBoxPrivacyPolicy = new System.Windows.Forms.CheckBox();
            this.label = new System.Windows.Forms.Label();
            this.labelPrivacyPolicy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNewLogin
            // 
            this.textBoxNewLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNewLogin.Location = new System.Drawing.Point(230, 70);
            this.textBoxNewLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNewLogin.Name = "textBoxNewLogin";
            this.textBoxNewLogin.Size = new System.Drawing.Size(168, 29);
            this.textBoxNewLogin.TabIndex = 6;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNewPassword.Location = new System.Drawing.Point(230, 102);
            this.textBoxNewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(168, 29);
            this.textBoxNewPassword.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(167, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Регистрация сотрудника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(92, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Новый пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(103, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Новый логин:";
            // 
            // acceptRegButton
            // 
            this.acceptRegButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.acceptRegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptRegButton.FlatAppearance.BorderSize = 0;
            this.acceptRegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptRegButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.acceptRegButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.acceptRegButton.Location = new System.Drawing.Point(213, 176);
            this.acceptRegButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.acceptRegButton.Name = "acceptRegButton";
            this.acceptRegButton.Size = new System.Drawing.Size(130, 28);
            this.acceptRegButton.TabIndex = 7;
            this.acceptRegButton.Text = "Подтвердить";
            this.acceptRegButton.UseVisualStyleBackColor = false;
            this.acceptRegButton.Click += new System.EventHandler(this.acceptRegButton_Click);
            // 
            // checkBoxPrivacyPolicy
            // 
            this.checkBoxPrivacyPolicy.AutoSize = true;
            this.checkBoxPrivacyPolicy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxPrivacyPolicy.Location = new System.Drawing.Point(95, 143);
            this.checkBoxPrivacyPolicy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxPrivacyPolicy.Name = "checkBoxPrivacyPolicy";
            this.checkBoxPrivacyPolicy.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPrivacyPolicy.TabIndex = 8;
            this.checkBoxPrivacyPolicy.UseVisualStyleBackColor = true;
            this.checkBoxPrivacyPolicy.CheckedChanged += new System.EventHandler(this.checkBoxPrivacyPolicy_CheckedChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(111, 140);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(118, 20);
            this.label.TabIndex = 9;
            this.label.Text = "Я ознакомлен с";
            // 
            // labelPrivacyPolicy
            // 
            this.labelPrivacyPolicy.AutoSize = true;
            this.labelPrivacyPolicy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPrivacyPolicy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelPrivacyPolicy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelPrivacyPolicy.Location = new System.Drawing.Point(230, 140);
            this.labelPrivacyPolicy.Name = "labelPrivacyPolicy";
            this.labelPrivacyPolicy.Size = new System.Drawing.Size(239, 20);
            this.labelPrivacyPolicy.TabIndex = 9;
            this.labelPrivacyPolicy.Text = "политикой конфиденциальности";
            this.labelPrivacyPolicy.Click += new System.EventHandler(this.labelPrivacyPolicy_Click);
            // 
            // EmployeeRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(566, 237);
            this.Controls.Add(this.labelPrivacyPolicy);
            this.Controls.Add(this.label);
            this.Controls.Add(this.checkBoxPrivacyPolicy);
            this.Controls.Add(this.acceptRegButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.textBoxNewLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeRegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация нового сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewLogin;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button acceptRegButton;
        private System.Windows.Forms.CheckBox checkBoxPrivacyPolicy;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelPrivacyPolicy;
    }
}