namespace TS_2018.View
{
    partial class FormExport
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
            this.cbbBanThuHS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbBuoi = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkExportAll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbbBanThuHS
            // 
            this.cbbBanThuHS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBanThuHS.FormattingEnabled = true;
            this.cbbBanThuHS.Location = new System.Drawing.Point(111, 16);
            this.cbbBanThuHS.Name = "cbbBanThuHS";
            this.cbbBanThuHS.Size = new System.Drawing.Size(178, 21);
            this.cbbBanThuHS.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn bàn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chọn buổi";
            // 
            // cbbBuoi
            // 
            this.cbbBuoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBuoi.FormattingEnabled = true;
            this.cbbBuoi.Items.AddRange(new object[] {
            "Cả ngày",
            "Sáng",
            "Chiều"});
            this.cbbBuoi.Location = new System.Drawing.Point(111, 99);
            this.cbbBuoi.Name = "cbbBuoi";
            this.cbbBuoi.Size = new System.Drawing.Size(178, 21);
            this.cbbBuoi.TabIndex = 4;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(86, 168);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(111, 58);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(178, 20);
            this.dateTimePicker.TabIndex = 8;
            // 
            // checkExportAll
            // 
            this.checkExportAll.AutoSize = true;
            this.checkExportAll.Location = new System.Drawing.Point(51, 137);
            this.checkExportAll.Name = "checkExportAll";
            this.checkExportAll.Size = new System.Drawing.Size(159, 17);
            this.checkExportAll.TabIndex = 9;
            this.checkExportAll.Text = "Xuất dữ liệu tất cả các ngày";
            this.checkExportAll.UseVisualStyleBackColor = true;
            // 
            // FormExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 212);
            this.Controls.Add(this.checkExportAll);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbBuoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbBanThuHS);
            this.Name = "FormExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export to excel";
            this.Load += new System.EventHandler(this.FormExport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbBanThuHS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbBuoi;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.CheckBox checkExportAll;
    }
}