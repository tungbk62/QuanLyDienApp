namespace QuanLyDienApp
{
    partial class FormThongKeThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKeThanhToan));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxMaThang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaNop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(759, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH KHÁCH HÀNG ĐÃ / CHƯA THANH TOÁN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBoxMaThang);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(331, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 54);
            this.panel2.TabIndex = 3;
            // 
            // textBoxMaThang
            // 
            this.textBoxMaThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaThang.Location = new System.Drawing.Point(112, 12);
            this.textBoxMaThang.Name = "textBoxMaThang";
            this.textBoxMaThang.Size = new System.Drawing.Size(270, 27);
            this.textBoxMaThang.TabIndex = 0;
            this.textBoxMaThang.TextChanged += new System.EventHandler(this.textBoxMaThang_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã tháng:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKH,
            this.MaThang,
            this.Tien,
            this.DaNop});
            this.dataGridView1.Location = new System.Drawing.Point(143, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(927, 422);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            this.MaHD.Width = 150;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Width = 150;
            // 
            // MaThang
            // 
            this.MaThang.DataPropertyName = "MaThang";
            this.MaThang.HeaderText = "Mã tháng";
            this.MaThang.Name = "MaThang";
            this.MaThang.ReadOnly = true;
            // 
            // Tien
            // 
            this.Tien.DataPropertyName = "Tien";
            this.Tien.HeaderText = "Thành tiền";
            this.Tien.Name = "Tien";
            this.Tien.ReadOnly = true;
            this.Tien.Width = 150;
            // 
            // DaNop
            // 
            this.DaNop.DataPropertyName = "DaNop";
            this.DaNop.HeaderText = "Đã nộp";
            this.DaNop.Name = "DaNop";
            this.DaNop.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::QuanLyDienApp.Properties.Resources.close;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(689, 602);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 54);
            this.button3.TabIndex = 9;
            this.button3.Text = "Chưa thanh toán";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::QuanLyDienApp.Properties.Resources.done;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(348, 602);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 54);
            this.button2.TabIndex = 8;
            this.button2.Text = "Đã thanh toán";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::QuanLyDienApp.Properties.Resources.search;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(397, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tìm kiếm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormThongKeThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 698);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormThongKeThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tiền Điện";
            this.Activated += new System.EventHandler(this.FormThongKeThanhToan_Activated);
            this.Click += new System.EventHandler(this.FormThongKeThanhToan_Click);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxMaThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaNop;
    }
}