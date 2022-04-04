namespace QuanLyQuanAn
{
    partial class frmReportBill
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rpvReportBill = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbShowonemonth = new System.Windows.Forms.CheckBox();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpkTodateForReport = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpkFromdateForReport = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rpvReportBill);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(945, 407);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Hóa Đơn";
            // 
            // rpvReportBill
            // 
            this.rpvReportBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvReportBill.Location = new System.Drawing.Point(3, 18);
            this.rpvReportBill.Name = "rpvReportBill";
            this.rpvReportBill.ServerReport.BearerToken = null;
            this.rpvReportBill.Size = new System.Drawing.Size(939, 386);
            this.rpvReportBill.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.cbShowonemonth);
            this.groupBox1.Controls.Add(this.btnShowReport);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpkTodateForReport);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpkFromdateForReport);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo Cáo Thống Kê Hóa Đơn";
            // 
            // cbShowonemonth
            // 
            this.cbShowonemonth.AutoSize = true;
            this.cbShowonemonth.Location = new System.Drawing.Point(425, 29);
            this.cbShowonemonth.Name = "cbShowonemonth";
            this.cbShowonemonth.Size = new System.Drawing.Size(131, 19);
            this.cbShowonemonth.TabIndex = 4;
            this.cbShowonemonth.Text = "Xem tháng hiện tại";
            this.cbShowonemonth.UseVisualStyleBackColor = true;
            this.cbShowonemonth.CheckedChanged += new System.EventHandler(this.cbShowonemonth_CheckedChanged);
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(425, 67);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(75, 23);
            this.btnShowReport.TabIndex = 2;
            this.btnShowReport.Text = "Xem";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến Ngày";
            // 
            // dtpkTodateForReport
            // 
            this.dtpkTodateForReport.Location = new System.Drawing.Point(171, 68);
            this.dtpkTodateForReport.Name = "dtpkTodateForReport";
            this.dtpkTodateForReport.Size = new System.Drawing.Size(228, 21);
            this.dtpkTodateForReport.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ Ngày";
            // 
            // dtpkFromdateForReport
            // 
            this.dtpkFromdateForReport.Location = new System.Drawing.Point(171, 29);
            this.dtpkFromdateForReport.Name = "dtpkFromdateForReport";
            this.dtpkFromdateForReport.Size = new System.Drawing.Size(228, 21);
            this.dtpkFromdateForReport.TabIndex = 1;
            // 
            // frmReportBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(964, 537);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReportBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem Báo Cáo Thống Kê Hóa Đơn";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        public Microsoft.Reporting.WinForms.ReportViewer rpvReportBill;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbShowonemonth;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkTodateForReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpkFromdateForReport;
    }
}