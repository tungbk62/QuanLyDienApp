namespace QuanLyDienApp
{
    partial class FormHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoaDon));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiSoCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiSoMoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThang2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LDTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bảng chỉ số điện:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(458, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bảng thông tin hóa đơn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhập mã hóa đơn:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(221, 433);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 27);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::QuanLyDienApp.Properties.Resources.align;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(58, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Xuất hóa đơn";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.MaThang,
            this.LoaiDien,
            this.ChiSoCu,
            this.ChiSoMoi});
            this.dataGridView1.Location = new System.Drawing.Point(12, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(445, 291);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Width = 60;
            // 
            // MaThang
            // 
            this.MaThang.DataPropertyName = "MaThang";
            this.MaThang.HeaderText = "Mã tháng";
            this.MaThang.Name = "MaThang";
            this.MaThang.ReadOnly = true;
            this.MaThang.Width = 60;
            // 
            // LoaiDien
            // 
            this.LoaiDien.DataPropertyName = "LoaiDien";
            this.LoaiDien.HeaderText = "Loại điện";
            this.LoaiDien.Name = "LoaiDien";
            this.LoaiDien.ReadOnly = true;
            this.LoaiDien.Width = 60;
            // 
            // ChiSoCu
            // 
            this.ChiSoCu.DataPropertyName = "ChiSoCu";
            this.ChiSoCu.HeaderText = "Chỉ số cũ";
            this.ChiSoCu.Name = "ChiSoCu";
            this.ChiSoCu.ReadOnly = true;
            this.ChiSoCu.Width = 60;
            // 
            // ChiSoMoi
            // 
            this.ChiSoMoi.DataPropertyName = "ChiSoMoi";
            this.ChiSoMoi.HeaderText = "Chỉ số mới";
            this.ChiSoMoi.Name = "ChiSoMoi";
            this.ChiSoMoi.ReadOnly = true;
            this.ChiSoMoi.Width = 60;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKH2,
            this.MaThang2,
            this.LDTT,
            this.Tien});
            this.dataGridView2.Location = new System.Drawing.Point(463, 108);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(700, 352);
            this.dataGridView2.TabIndex = 20;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            this.MaHD.Width = 110;
            // 
            // MaKH2
            // 
            this.MaKH2.DataPropertyName = "MaKH";
            this.MaKH2.HeaderText = "Mã khách hàng";
            this.MaKH2.Name = "MaKH2";
            this.MaKH2.ReadOnly = true;
            this.MaKH2.Width = 110;
            // 
            // MaThang2
            // 
            this.MaThang2.DataPropertyName = "MaThang";
            this.MaThang2.HeaderText = "Mã tháng";
            this.MaThang2.Name = "MaThang2";
            this.MaThang2.ReadOnly = true;
            // 
            // LDTT
            // 
            this.LDTT.DataPropertyName = "LDTT";
            this.LDTT.HeaderText = "Lượng điện tiêu thụ";
            this.LDTT.Name = "LDTT";
            this.LDTT.ReadOnly = true;
            this.LDTT.Width = 110;
            // 
            // Tien
            // 
            this.Tien.DataPropertyName = "Tien";
            this.Tien.HeaderText = "Thành tiền";
            this.Tien.Name = "Tien";
            this.Tien.ReadOnly = true;
            this.Tien.Width = 160;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::QuanLyDienApp.Properties.Resources.delete;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(266, 532);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 664);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tiền Điện";
            this.Activated += new System.EventHandler(this.FormHoaDon_Activated);
            this.Click += new System.EventHandler(this.FormHoaDon_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiSoCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiSoMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThang2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LDTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tien;
    }
}