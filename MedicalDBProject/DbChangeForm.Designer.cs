namespace MedicalDBProject
{
    partial class DbChangeForm
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
            this.dataGridViewDbChange = new System.Windows.Forms.DataGridView();
            this.DbChangeSortButton = new System.Windows.Forms.Button();
            this.comboBoxSortDbChange = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxModifyDbChange = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDbChangeSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DbChangeModifyButton = new System.Windows.Forms.Button();
            this.DbChangeSearchButton = new System.Windows.Forms.Button();
            this.DbChangeClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDbChange)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDbChange
            // 
            this.dataGridViewDbChange.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDbChange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDbChange.Location = new System.Drawing.Point(10, 145);
            this.dataGridViewDbChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDbChange.Name = "dataGridViewDbChange";
            this.dataGridViewDbChange.RowHeadersWidth = 51;
            this.dataGridViewDbChange.Size = new System.Drawing.Size(800, 257);
            this.dataGridViewDbChange.TabIndex = 0;
            this.dataGridViewDbChange.Text = "dataGridView1";
            // 
            // DbChangeSortButton
            // 
            this.DbChangeSortButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DbChangeSortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DbChangeSortButton.FlatAppearance.BorderSize = 0;
            this.DbChangeSortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DbChangeSortButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DbChangeSortButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DbChangeSortButton.Location = new System.Drawing.Point(129, 59);
            this.DbChangeSortButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DbChangeSortButton.Name = "DbChangeSortButton";
            this.DbChangeSortButton.Size = new System.Drawing.Size(200, 28);
            this.DbChangeSortButton.TabIndex = 1;
            this.DbChangeSortButton.Text = "Сортировка";
            this.DbChangeSortButton.UseVisualStyleBackColor = false;
            this.DbChangeSortButton.Click += new System.EventHandler(this.DbChangeSortButton_Click);
            // 
            // comboBoxSortDbChange
            // 
            this.comboBoxSortDbChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSortDbChange.FormattingEnabled = true;
            this.comboBoxSortDbChange.Items.AddRange(new object[] {
            "По имени",
            "По году рождения",
            "По телефону",
            "По группе крови",
            "По диагнозу",
            "По палате"});
            this.comboBoxSortDbChange.Location = new System.Drawing.Point(228, 22);
            this.comboBoxSortDbChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSortDbChange.Name = "comboBoxSortDbChange";
            this.comboBoxSortDbChange.Size = new System.Drawing.Size(159, 29);
            this.comboBoxSortDbChange.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(78, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Отсортировать по:";
            // 
            // comboBoxModifyDbChange
            // 
            this.comboBoxModifyDbChange.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxModifyDbChange.FormattingEnabled = true;
            this.comboBoxModifyDbChange.Items.AddRange(new object[] {
            "Пациенты и их данные",
            "Диагнозы",
            "Палаты"});
            this.comboBoxModifyDbChange.Location = new System.Drawing.Point(599, 26);
            this.comboBoxModifyDbChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxModifyDbChange.Name = "comboBoxModifyDbChange";
            this.comboBoxModifyDbChange.Size = new System.Drawing.Size(159, 23);
            this.comboBoxModifyDbChange.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(473, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Изменить базу:";
            // 
            // textBoxDbChangeSearch
            // 
            this.textBoxDbChangeSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDbChangeSearch.Location = new System.Drawing.Point(259, 114);
            this.textBoxDbChangeSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDbChangeSearch.Name = "textBoxDbChangeSearch";
            this.textBoxDbChangeSearch.Size = new System.Drawing.Size(350, 27);
            this.textBoxDbChangeSearch.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(138, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Поиск по базе:";
            // 
            // DbChangeModifyButton
            // 
            this.DbChangeModifyButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DbChangeModifyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DbChangeModifyButton.FlatAppearance.BorderSize = 0;
            this.DbChangeModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DbChangeModifyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DbChangeModifyButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DbChangeModifyButton.Location = new System.Drawing.Point(513, 59);
            this.DbChangeModifyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DbChangeModifyButton.Name = "DbChangeModifyButton";
            this.DbChangeModifyButton.Size = new System.Drawing.Size(200, 28);
            this.DbChangeModifyButton.TabIndex = 1;
            this.DbChangeModifyButton.Text = "Изменить данные";
            this.DbChangeModifyButton.UseVisualStyleBackColor = false;
            this.DbChangeModifyButton.Click += new System.EventHandler(this.DbChangeModifyButton_Click);
            // 
            // DbChangeSearchButton
            // 
            this.DbChangeSearchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DbChangeSearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DbChangeSearchButton.FlatAppearance.BorderSize = 0;
            this.DbChangeSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DbChangeSearchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DbChangeSearchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DbChangeSearchButton.Location = new System.Drawing.Point(615, 116);
            this.DbChangeSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DbChangeSearchButton.Name = "DbChangeSearchButton";
            this.DbChangeSearchButton.Size = new System.Drawing.Size(82, 22);
            this.DbChangeSearchButton.TabIndex = 8;
            this.DbChangeSearchButton.Text = "Найти";
            this.DbChangeSearchButton.UseVisualStyleBackColor = false;
            this.DbChangeSearchButton.Click += new System.EventHandler(this.DbChangeSearchButton_Click);
            // 
            // DbChangeClearButton
            // 
            this.DbChangeClearButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DbChangeClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DbChangeClearButton.FlatAppearance.BorderSize = 0;
            this.DbChangeClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DbChangeClearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DbChangeClearButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DbChangeClearButton.Location = new System.Drawing.Point(703, 116);
            this.DbChangeClearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DbChangeClearButton.Name = "DbChangeClearButton";
            this.DbChangeClearButton.Size = new System.Drawing.Size(82, 22);
            this.DbChangeClearButton.TabIndex = 9;
            this.DbChangeClearButton.Text = "Сброс";
            this.DbChangeClearButton.UseVisualStyleBackColor = false;
            this.DbChangeClearButton.Click += new System.EventHandler(this.DbChangeClearButton_Click);
            // 
            // DbChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(821, 411);
            this.Controls.Add(this.DbChangeClearButton);
            this.Controls.Add(this.DbChangeSearchButton);
            this.Controls.Add(this.DbChangeModifyButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDbChangeSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxModifyDbChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSortDbChange);
            this.Controls.Add(this.DbChangeSortButton);
            this.Controls.Add(this.dataGridViewDbChange);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DbChangeForm";
            this.Text = "Просмотр и редактирование базы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDbChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DbChangeSortButton;
        private System.Windows.Forms.ComboBox comboBoxSortDbChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxModifyDbChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDbChangeSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DbChangeModifyButton;
        private System.Windows.Forms.Button DbChangeSearchButton;
        private System.Windows.Forms.Button DbChangeClearButton;
        internal System.Windows.Forms.DataGridView dataGridViewDbChange;
    }
}