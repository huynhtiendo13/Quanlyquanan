namespace QuanLyQuanAn
{
    partial class Danhsachmonan
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
            this.txbSearchFoodName = new System.Windows.Forms.TextBox();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nmFoodprice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbFoodname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbFoodId = new System.Windows.Forms.TextBox();
            this.btnShowFood = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnDeteleFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExitMenu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // txbSearchFoodName
            // 
            this.txbSearchFoodName.BackColor = System.Drawing.SystemColors.Menu;
            this.txbSearchFoodName.Location = new System.Drawing.Point(164, 65);
            this.txbSearchFoodName.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearchFoodName.Name = "txbSearchFoodName";
            this.txbSearchFoodName.Size = new System.Drawing.Size(168, 26);
            this.txbSearchFoodName.TabIndex = 2;
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFood.Location = new System.Drawing.Point(339, 63);
            this.btnSearchFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(48, 27);
            this.btnSearchFood.TabIndex = 1;
            this.btnSearchFood.Text = "Tìm";
            this.btnSearchFood.UseVisualStyleBackColor = true;
            this.btnSearchFood.Click += new System.EventHandler(this.btnSearchFood_Click);
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.BackColor = System.Drawing.SystemColors.Menu;
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(144, 168);
            this.cbFoodCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(244, 27);
            this.cbFoodCategory.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh mục:";
            // 
            // nmFoodprice
            // 
            this.nmFoodprice.BackColor = System.Drawing.SystemColors.Menu;
            this.nmFoodprice.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmFoodprice.Location = new System.Drawing.Point(144, 204);
            this.nmFoodprice.Margin = new System.Windows.Forms.Padding(4);
            this.nmFoodprice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmFoodprice.Name = "nmFoodprice";
            this.nmFoodprice.Size = new System.Drawing.Size(116, 26);
            this.nmFoodprice.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên món:";
            // 
            // txbFoodname
            // 
            this.txbFoodname.BackColor = System.Drawing.SystemColors.Menu;
            this.txbFoodname.Location = new System.Drawing.Point(144, 138);
            this.txbFoodname.Margin = new System.Windows.Forms.Padding(4);
            this.txbFoodname.Name = "txbFoodname";
            this.txbFoodname.Size = new System.Drawing.Size(244, 26);
            this.txbFoodname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // txbFoodId
            // 
            this.txbFoodId.BackColor = System.Drawing.SystemColors.Menu;
            this.txbFoodId.Location = new System.Drawing.Point(144, 106);
            this.txbFoodId.Margin = new System.Windows.Forms.Padding(4);
            this.txbFoodId.Name = "txbFoodId";
            this.txbFoodId.ReadOnly = true;
            this.txbFoodId.Size = new System.Drawing.Size(244, 26);
            this.txbFoodId.TabIndex = 1;
            this.txbFoodId.TextChanged += new System.EventHandler(this.txbFoodId_TextChanged);
            // 
            // btnShowFood
            // 
            this.btnShowFood.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFood.Location = new System.Drawing.Point(320, 250);
            this.btnShowFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.Size = new System.Drawing.Size(68, 32);
            this.btnShowFood.TabIndex = 0;
            this.btnShowFood.Text = "Xem";
            this.btnShowFood.UseVisualStyleBackColor = true;
            this.btnShowFood.Click += new System.EventHandler(this.btnShowFood_Click);
            // 
            // btnEditFood
            // 
            this.btnEditFood.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditFood.Location = new System.Drawing.Point(232, 250);
            this.btnEditFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(68, 32);
            this.btnEditFood.TabIndex = 2;
            this.btnEditFood.Text = "Sửa";
            this.btnEditFood.UseVisualStyleBackColor = true;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // btnDeteleFood
            // 
            this.btnDeteleFood.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeteleFood.Location = new System.Drawing.Point(144, 250);
            this.btnDeteleFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeteleFood.Name = "btnDeteleFood";
            this.btnDeteleFood.Size = new System.Drawing.Size(68, 32);
            this.btnDeteleFood.TabIndex = 1;
            this.btnDeteleFood.Text = "Xóa";
            this.btnDeteleFood.UseVisualStyleBackColor = true;
            this.btnDeteleFood.Click += new System.EventHandler(this.btnDeteleFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Location = new System.Drawing.Point(63, 250);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(68, 32);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // dtgvFood
            // 
            this.dtgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvFood.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(395, 65);
            this.dtgvFood.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.RowHeadersWidth = 51;
            this.dtgvFood.Size = new System.Drawing.Size(537, 262);
            this.dtgvFood.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(314, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(356, 43);
            this.label5.TabIndex = 8;
            this.label5.Text = "DANH SÁCH MÓN ĂN";
            // 
            // btnExitMenu
            // 
            this.btnExitMenu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitMenu.Location = new System.Drawing.Point(857, 335);
            this.btnExitMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitMenu.Name = "btnExitMenu";
            this.btnExitMenu.Size = new System.Drawing.Size(75, 33);
            this.btnExitMenu.TabIndex = 9;
            this.btnExitMenu.Text = "Thoát";
            this.btnExitMenu.UseVisualStyleBackColor = true;
            this.btnExitMenu.Click += new System.EventHandler(this.btnshowcategory_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Thông tin món ăn";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(282, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 48);
            this.button1.TabIndex = 11;
            this.button1.Text = "Xem Báo Cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Danhsachmonan
            // 
            this.AcceptButton = this.btnSearchFood;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(945, 378);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowFood);
            this.Controls.Add(this.btnEditFood);
            this.Controls.Add(this.txbSearchFoodName);
            this.Controls.Add(this.btnDeteleFood);
            this.Controls.Add(this.btnSearchFood);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbFoodname);
            this.Controls.Add(this.txbFoodId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFoodCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmFoodprice);
            this.Controls.Add(this.dtgvFood);
            this.Controls.Add(this.btnExitMenu);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Danhsachmonan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách Món Ăn ";
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbSearchFoodName;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmFoodprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbFoodname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbFoodId;
        private System.Windows.Forms.Button btnShowFood;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnDeteleFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExitMenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}