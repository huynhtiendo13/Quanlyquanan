namespace QuanLyQuanAn
{
    partial class Thongke
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.dtpkToday = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFisrtPage = new System.Windows.Forms.Button();
            this.btnReviousPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.txbPageNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(14, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 415);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dtgvBill);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 93);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(825, 319);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AllowUserToOrderColumns = true;
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(3, 3);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersWidth = 51;
            this.dtgvBill.Size = new System.Drawing.Size(822, 316);
            this.dtgvBill.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txbTotalPrice);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnViewBill);
            this.panel2.Controls.Add(this.dtpkToday);
            this.panel2.Controls.Add(this.dtpkFromDate);
            this.panel2.Controls.Add(this.btnShowReport);
            this.panel2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 86);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng Tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đến:";
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Location = new System.Drawing.Point(563, 28);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.Size = new System.Drawing.Size(227, 23);
            this.txbTotalPrice.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ:";
            // 
            // btnViewBill
            // 
            this.btnViewBill.Location = new System.Drawing.Point(365, 44);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(104, 27);
            this.btnViewBill.TabIndex = 2;
            this.btnViewBill.Text = "Xem thống kê";
            this.btnViewBill.UseVisualStyleBackColor = true;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // dtpkToday
            // 
            this.dtpkToday.Location = new System.Drawing.Point(58, 46);
            this.dtpkToday.Name = "dtpkToday";
            this.dtpkToday.Size = new System.Drawing.Size(283, 23);
            this.dtpkToday.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.Location = new System.Drawing.Point(61, 14);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(280, 23);
            this.dtpkFromDate.TabIndex = 0;
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(365, 12);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(104, 27);
            this.btnShowReport.TabIndex = 2;
            this.btnShowReport.Text = "Xuất Report";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "THÔNG KÊ HÓA ĐƠN";
            // 
            // btnFisrtPage
            // 
            this.btnFisrtPage.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFisrtPage.Location = new System.Drawing.Point(287, 468);
            this.btnFisrtPage.Name = "btnFisrtPage";
            this.btnFisrtPage.Size = new System.Drawing.Size(87, 25);
            this.btnFisrtPage.TabIndex = 3;
            this.btnFisrtPage.Text = "Trang đầu";
            this.btnFisrtPage.UseVisualStyleBackColor = true;
            this.btnFisrtPage.Click += new System.EventHandler(this.btnFisrtPage_Click);
            // 
            // btnReviousPage
            // 
            this.btnReviousPage.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReviousPage.Location = new System.Drawing.Point(382, 468);
            this.btnReviousPage.Name = "btnReviousPage";
            this.btnReviousPage.Size = new System.Drawing.Size(87, 25);
            this.btnReviousPage.TabIndex = 3;
            this.btnReviousPage.Text = "Trang trước";
            this.btnReviousPage.UseVisualStyleBackColor = true;
            this.btnReviousPage.Click += new System.EventHandler(this.btnReviousPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.Location = new System.Drawing.Point(476, 468);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(87, 25);
            this.btnNextPage.TabIndex = 3;
            this.btnNextPage.Text = "Trang kê";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastPage.Location = new System.Drawing.Point(571, 468);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(87, 25);
            this.btnLastPage.TabIndex = 3;
            this.btnLastPage.Text = "Trang cuối";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // txbPageNumber
            // 
            this.txbPageNumber.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPageNumber.Location = new System.Drawing.Point(236, 470);
            this.txbPageNumber.Name = "txbPageNumber";
            this.txbPageNumber.ReadOnly = true;
            this.txbPageNumber.Size = new System.Drawing.Size(44, 23);
            this.txbPageNumber.TabIndex = 4;
            this.txbPageNumber.Text = "1";
            this.txbPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbPageNumber.TextChanged += new System.EventHandler(this.txbNumberPage_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Trang hiện tại:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(665, 468);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 25);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(855, 496);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbPageNumber);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnReviousPage);
            this.Controls.Add(this.btnFisrtPage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Thongke";
            this.Text = "Thống Kê";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Button btnShowReport;
        public System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Button btnFisrtPage;
        private System.Windows.Forms.Button btnReviousPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.TextBox txbPageNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.DateTimePicker dtpkToday;
        public System.Windows.Forms.DateTimePicker dtpkFromDate;
    }
}