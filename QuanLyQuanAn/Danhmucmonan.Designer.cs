namespace QuanLyQuanAn
{
    partial class Danhmucmonan
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtNameCategory = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbCategoryID = new System.Windows.Forms.TextBox();
            this.btnShowCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnDeleteCateGory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.dtgvCategory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExitCategory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên danh mục:";
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNameCategory.Location = new System.Drawing.Point(149, 159);
            this.txtNameCategory.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.Size = new System.Drawing.Size(190, 26);
            this.txtNameCategory.TabIndex = 1;
            this.txtNameCategory.TextChanged += new System.EventHandler(this.txtNameCategory_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 115);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID:";
            // 
            // txbCategoryID
            // 
            this.txbCategoryID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbCategoryID.Location = new System.Drawing.Point(149, 112);
            this.txbCategoryID.Margin = new System.Windows.Forms.Padding(4);
            this.txbCategoryID.Name = "txbCategoryID";
            this.txbCategoryID.Size = new System.Drawing.Size(190, 26);
            this.txbCategoryID.TabIndex = 1;
            // 
            // btnShowCategory
            // 
            this.btnShowCategory.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCategory.Location = new System.Drawing.Point(275, 204);
            this.btnShowCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowCategory.Name = "btnShowCategory";
            this.btnShowCategory.Size = new System.Drawing.Size(65, 34);
            this.btnShowCategory.TabIndex = 0;
            this.btnShowCategory.Text = "Xem";
            this.btnShowCategory.UseVisualStyleBackColor = true;
            this.btnShowCategory.Click += new System.EventHandler(this.btnShowCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCategory.Location = new System.Drawing.Point(108, 204);
            this.btnEditCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(65, 34);
            this.btnEditCategory.TabIndex = 2;
            this.btnEditCategory.Text = "Sửa";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnDeleteCateGory
            // 
            this.btnDeleteCateGory.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCateGory.Location = new System.Drawing.Point(191, 204);
            this.btnDeleteCateGory.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCateGory.Name = "btnDeleteCateGory";
            this.btnDeleteCateGory.Size = new System.Drawing.Size(65, 34);
            this.btnDeleteCateGory.TabIndex = 1;
            this.btnDeleteCateGory.Text = "Xóa";
            this.btnDeleteCateGory.UseVisualStyleBackColor = true;
            this.btnDeleteCateGory.Click += new System.EventHandler(this.btnDeleteCateGory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.Location = new System.Drawing.Point(28, 204);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(65, 34);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // dtgvCategory
            // 
            this.dtgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCategory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvCategory.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategory.Location = new System.Drawing.Point(348, 71);
            this.dtgvCategory.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvCategory.Name = "dtgvCategory";
            this.dtgvCategory.RowHeadersWidth = 51;
            this.dtgvCategory.Size = new System.Drawing.Size(381, 184);
            this.dtgvCategory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 41);
            this.label1.TabIndex = 10;
            this.label1.Text = "DANH MỤC MÓN ĂN";
            // 
            // btnExitCategory
            // 
            this.btnExitCategory.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitCategory.Location = new System.Drawing.Point(654, 263);
            this.btnExitCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitCategory.Name = "btnExitCategory";
            this.btnExitCategory.Size = new System.Drawing.Size(75, 28);
            this.btnExitCategory.TabIndex = 11;
            this.btnExitCategory.Text = "Thoát";
            this.btnExitCategory.UseVisualStyleBackColor = true;
            this.btnExitCategory.Click += new System.EventHandler(this.btnExitCategory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Thông tin danh mục";
            // 
            // Danhmucmonan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(742, 294);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgvCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNameCategory);
            this.Controls.Add(this.btnShowCategory);
            this.Controls.Add(this.txbCategoryID);
            this.Controls.Add(this.btnExitCategory);
            this.Controls.Add(this.btnEditCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteCateGory);
            this.Controls.Add(this.btnAddCategory);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Danhmucmonan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục món ăn";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNameCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbCategoryID;
        private System.Windows.Forms.Button btnShowCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnDeleteCateGory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.DataGridView dtgvCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExitCategory;
        private System.Windows.Forms.Label label2;
    }
}