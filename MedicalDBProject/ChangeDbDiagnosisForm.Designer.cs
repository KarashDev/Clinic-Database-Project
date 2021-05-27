namespace MedicalDBProject
{
    partial class ChangeDbDiagnosisForm
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
            this.dataGridViewChangeDiagnosis = new System.Windows.Forms.DataGridView();
            this.textBoxDSNameToAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDSNameToDelete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDeleteDiagnosis = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAddDiagnosis = new System.Windows.Forms.Button();
            this.textBoxDSCodeToAdd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChangeDiagnosis)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewChangeDiagnosis
            // 
            this.dataGridViewChangeDiagnosis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChangeDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChangeDiagnosis.Location = new System.Drawing.Point(10, 198);
            this.dataGridViewChangeDiagnosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewChangeDiagnosis.Name = "dataGridViewChangeDiagnosis";
            this.dataGridViewChangeDiagnosis.RowHeadersWidth = 51;
            this.dataGridViewChangeDiagnosis.Size = new System.Drawing.Size(606, 227);
            this.dataGridViewChangeDiagnosis.TabIndex = 0;
            this.dataGridViewChangeDiagnosis.Text = "dataGridView1";
            // 
            // textBoxDSNameToAdd
            // 
            this.textBoxDSNameToAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDSNameToAdd.Location = new System.Drawing.Point(164, 76);
            this.textBoxDSNameToAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDSNameToAdd.Name = "textBoxDSNameToAdd";
            this.textBoxDSNameToAdd.Size = new System.Drawing.Size(155, 29);
            this.textBoxDSNameToAdd.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Наименование:";
            // 
            // textBoxDSNameToDelete
            // 
            this.textBoxDSNameToDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDSNameToDelete.Location = new System.Drawing.Point(408, 99);
            this.textBoxDSNameToDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDSNameToDelete.Name = "textBoxDSNameToDelete";
            this.textBoxDSNameToDelete.Size = new System.Drawing.Size(155, 29);
            this.textBoxDSNameToDelete.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(398, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Точное наименование:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(388, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Удалить диагноз";
            // 
            // buttonDeleteDiagnosis
            // 
            this.buttonDeleteDiagnosis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDeleteDiagnosis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteDiagnosis.FlatAppearance.BorderSize = 0;
            this.buttonDeleteDiagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteDiagnosis.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteDiagnosis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDeleteDiagnosis.Location = new System.Drawing.Point(442, 149);
            this.buttonDeleteDiagnosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteDiagnosis.Name = "buttonDeleteDiagnosis";
            this.buttonDeleteDiagnosis.Size = new System.Drawing.Size(82, 22);
            this.buttonDeleteDiagnosis.TabIndex = 10;
            this.buttonDeleteDiagnosis.Text = "Удалить";
            this.buttonDeleteDiagnosis.UseVisualStyleBackColor = false;
            this.buttonDeleteDiagnosis.Click += new System.EventHandler(this.buttonDeleteDiagnosis_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(93, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 30);
            this.label9.TabIndex = 0;
            this.label9.Text = "Добавить диагноз";
            // 
            // buttonAddDiagnosis
            // 
            this.buttonAddDiagnosis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddDiagnosis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddDiagnosis.FlatAppearance.BorderSize = 0;
            this.buttonAddDiagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddDiagnosis.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddDiagnosis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddDiagnosis.Location = new System.Drawing.Point(145, 149);
            this.buttonAddDiagnosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddDiagnosis.Name = "buttonAddDiagnosis";
            this.buttonAddDiagnosis.Size = new System.Drawing.Size(82, 22);
            this.buttonAddDiagnosis.TabIndex = 10;
            this.buttonAddDiagnosis.Text = "Добавить";
            this.buttonAddDiagnosis.UseVisualStyleBackColor = false;
            this.buttonAddDiagnosis.Click += new System.EventHandler(this.buttonAddDiagnosis_Click);
            // 
            // textBoxDSCodeToAdd
            // 
            this.textBoxDSCodeToAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDSCodeToAdd.Location = new System.Drawing.Point(164, 111);
            this.textBoxDSCodeToAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDSCodeToAdd.Name = "textBoxDSCodeToAdd";
            this.textBoxDSCodeToAdd.Size = new System.Drawing.Size(155, 29);
            this.textBoxDSCodeToAdd.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(58, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 21);
            this.label10.TabIndex = 5;
            this.label10.Text = "Код МКБ-10:";
            // 
            // ChangeDbDiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(626, 434);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxDSCodeToAdd);
            this.Controls.Add(this.buttonAddDiagnosis);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonDeleteDiagnosis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDSNameToDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDSNameToAdd);
            this.Controls.Add(this.dataGridViewChangeDiagnosis);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChangeDbDiagnosisForm";
            this.Text = "Управление диагнозами";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChangeDiagnosis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewChangeDiagnosis;
        private System.Windows.Forms.TextBox textBoxDSNameToAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDSNameToDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDeleteDiagnosis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAddDiagnosis;
        private System.Windows.Forms.TextBox textBoxDSCodeToAdd;
        private System.Windows.Forms.Label label10;
    }
}