namespace MedicalDBProject
{
    partial class ChangeDbWardsForm
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
            this.dataGridViewChangeWards = new System.Windows.Forms.DataGridView();
            this.textBoxWardToAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxWardToDelete = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonDeleteWard = new System.Windows.Forms.Button();
            this.buttonAddWard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChangeWards)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewChangeWards
            // 
            this.dataGridViewChangeWards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChangeWards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChangeWards.Location = new System.Drawing.Point(10, 172);
            this.dataGridViewChangeWards.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewChangeWards.Name = "dataGridViewChangeWards";
            this.dataGridViewChangeWards.RowHeadersWidth = 51;
            this.dataGridViewChangeWards.Size = new System.Drawing.Size(606, 218);
            this.dataGridViewChangeWards.TabIndex = 0;
            this.dataGridViewChangeWards.Text = "dataGridView1";
            // 
            // textBoxWardToAdd
            // 
            this.textBoxWardToAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxWardToAdd.Location = new System.Drawing.Point(183, 80);
            this.textBoxWardToAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxWardToAdd.Name = "textBoxWardToAdd";
            this.textBoxWardToAdd.Size = new System.Drawing.Size(110, 29);
            this.textBoxWardToAdd.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(66, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Новый номер:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(86, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "Добавить палату";
            // 
            // textBoxWardToDelete
            // 
            this.textBoxWardToDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxWardToDelete.Location = new System.Drawing.Point(430, 80);
            this.textBoxWardToDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxWardToDelete.Name = "textBoxWardToDelete";
            this.textBoxWardToDelete.Size = new System.Drawing.Size(110, 29);
            this.textBoxWardToDelete.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(363, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 21);
            this.label9.TabIndex = 5;
            this.label9.Text = "Номер:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(368, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 30);
            this.label10.TabIndex = 0;
            this.label10.Text = "Удалить палату";
            // 
            // buttonDeleteWard
            // 
            this.buttonDeleteWard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDeleteWard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteWard.FlatAppearance.BorderSize = 0;
            this.buttonDeleteWard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteWard.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteWard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDeleteWard.Location = new System.Drawing.Point(413, 120);
            this.buttonDeleteWard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteWard.Name = "buttonDeleteWard";
            this.buttonDeleteWard.Size = new System.Drawing.Size(82, 22);
            this.buttonDeleteWard.TabIndex = 10;
            this.buttonDeleteWard.Text = "Удалить";
            this.buttonDeleteWard.UseVisualStyleBackColor = false;
            this.buttonDeleteWard.Click += new System.EventHandler(this.buttonDeleteWard_Click);
            // 
            // buttonAddWard
            // 
            this.buttonAddWard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddWard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddWard.FlatAppearance.BorderSize = 0;
            this.buttonAddWard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddWard.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddWard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddWard.Location = new System.Drawing.Point(134, 120);
            this.buttonAddWard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddWard.Name = "buttonAddWard";
            this.buttonAddWard.Size = new System.Drawing.Size(82, 22);
            this.buttonAddWard.TabIndex = 10;
            this.buttonAddWard.Text = "Добавить";
            this.buttonAddWard.UseVisualStyleBackColor = false;
            this.buttonAddWard.Click += new System.EventHandler(this.buttonAddWard_Click);
            // 
            // ChangeDbWardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(626, 400);
            this.Controls.Add(this.buttonAddWard);
            this.Controls.Add(this.buttonDeleteWard);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxWardToDelete);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxWardToAdd);
            this.Controls.Add(this.dataGridViewChangeWards);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChangeDbWardsForm";
            this.Text = "Управление палатами";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChangeWards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewChangeWards;
        private System.Windows.Forms.TextBox textBoxWardToAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxWardToDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonDeleteWard;
        private System.Windows.Forms.Button buttonAddWard;
    }
}