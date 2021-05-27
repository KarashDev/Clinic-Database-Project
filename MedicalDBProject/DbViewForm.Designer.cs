namespace MedicalDBProject.Forms
{
    partial class DbViewForm
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
            this.dataGridViewDbView = new System.Windows.Forms.DataGridView();
            this.textBoxDbViewSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DbViewSortButton = new System.Windows.Forms.Button();
            this.comboBoxSortDbView = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DbViewSearchButton = new System.Windows.Forms.Button();
            this.DbViewClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDbView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDbView
            // 
            this.dataGridViewDbView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDbView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDbView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDbView.Location = new System.Drawing.Point(10, 145);
            this.dataGridViewDbView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDbView.Name = "dataGridViewDbView";
            this.dataGridViewDbView.RowHeadersWidth = 51;
            this.dataGridViewDbView.Size = new System.Drawing.Size(800, 257);
            this.dataGridViewDbView.TabIndex = 0;
            this.dataGridViewDbView.Text = "dataGridView1";
            // 
            // textBoxDbViewSearch
            // 
            this.textBoxDbViewSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDbViewSearch.Location = new System.Drawing.Point(259, 114);
            this.textBoxDbViewSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDbViewSearch.Name = "textBoxDbViewSearch";
            this.textBoxDbViewSearch.Size = new System.Drawing.Size(350, 27);
            this.textBoxDbViewSearch.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(130, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Поиск по базе:";
            // 
            // DbViewSortButton
            // 
            this.DbViewSortButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DbViewSortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DbViewSortButton.FlatAppearance.BorderSize = 0;
            this.DbViewSortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DbViewSortButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DbViewSortButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DbViewSortButton.Location = new System.Drawing.Point(322, 61);
            this.DbViewSortButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DbViewSortButton.Name = "DbViewSortButton";
            this.DbViewSortButton.Size = new System.Drawing.Size(200, 28);
            this.DbViewSortButton.TabIndex = 1;
            this.DbViewSortButton.Text = "Сортировка";
            this.DbViewSortButton.UseVisualStyleBackColor = false;
            this.DbViewSortButton.Click += new System.EventHandler(this.DbViewSortButton_Click);
            // 
            // comboBoxSortDbView
            // 
            this.comboBoxSortDbView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSortDbView.FormattingEnabled = true;
            this.comboBoxSortDbView.Items.AddRange(new object[] {
            "По имени",
            "По году рождения",
            "По телефону",
            "По группе крови",
            "По диагнозу",
            "По палате"});
            this.comboBoxSortDbView.Location = new System.Drawing.Point(405, 28);
            this.comboBoxSortDbView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSortDbView.Name = "comboBoxSortDbView";
            this.comboBoxSortDbView.Size = new System.Drawing.Size(159, 29);
            this.comboBoxSortDbView.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(277, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Отсортировать:";
            // 
            // DbViewSearchButton
            // 
            this.DbViewSearchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DbViewSearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DbViewSearchButton.FlatAppearance.BorderSize = 0;
            this.DbViewSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DbViewSearchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DbViewSearchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DbViewSearchButton.Location = new System.Drawing.Point(615, 116);
            this.DbViewSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DbViewSearchButton.Name = "DbViewSearchButton";
            this.DbViewSearchButton.Size = new System.Drawing.Size(82, 22);
            this.DbViewSearchButton.TabIndex = 8;
            this.DbViewSearchButton.Text = "Найти";
            this.DbViewSearchButton.UseVisualStyleBackColor = false;
            this.DbViewSearchButton.Click += new System.EventHandler(this.DbViewSearchButton_Click);
            // 
            // DbViewClearButton
            // 
            this.DbViewClearButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DbViewClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DbViewClearButton.FlatAppearance.BorderSize = 0;
            this.DbViewClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DbViewClearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DbViewClearButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DbViewClearButton.Location = new System.Drawing.Point(703, 116);
            this.DbViewClearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DbViewClearButton.Name = "DbViewClearButton";
            this.DbViewClearButton.Size = new System.Drawing.Size(82, 22);
            this.DbViewClearButton.TabIndex = 9;
            this.DbViewClearButton.Text = "Сброс";
            this.DbViewClearButton.UseVisualStyleBackColor = false;
            this.DbViewClearButton.Click += new System.EventHandler(this.DbViewClearButton_Click);
            // 
            // DbViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(821, 411);
            this.Controls.Add(this.DbViewClearButton);
            this.Controls.Add(this.DbViewSearchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSortDbView);
            this.Controls.Add(this.DbViewSortButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDbViewSearch);
            this.Controls.Add(this.dataGridViewDbView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DbViewForm";
            this.Text = "Просмотр базы данных";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDbView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDbView;
        private System.Windows.Forms.TextBox textBoxDbViewSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DbViewSortButton;
        private System.Windows.Forms.ComboBox comboBoxSortDbView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DbViewSearchButton;
        private System.Windows.Forms.Button DbViewClearButton;
    }
}