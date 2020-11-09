namespace QuanLyDienApp
{
    partial class FormTimKiemHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTimKiemHD));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxMaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LDTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "TÌM KIẾM THÔNG TIN HÓA ĐƠN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBoxMaHD);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(299, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 54);
            this.panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::QuanLyDienApp.Properties.Resources.search;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(411, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tìm kiếm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxMaHD
            // 
            this.textBoxMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaHD.Location = new System.Drawing.Point(135, 12);
            this.textBoxMaHD.Name = "textBoxMaHD";
            this.textBoxMaHD.Size = new System.Drawing.Size(270, 27);
            this.textBoxMaHD.TabIndex = 0;
            this.textBoxMaHD.TextChanged += new System.EventHandler(this.textBoxMaHD_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn:";
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
            this.LDTT,
            this.Tien});
            this.dataGridView1.Location = new System.Drawing.Point(52, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1110, 454);
            this.dataGridView1.TabIndex = 5;
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
            // LDTT
            // 
            this.LDTT.DataPropertyName = "LDTT";
            this.LDTT.HeaderText = "Lượng điện tiêu thụ";
            this.LDTT.Name = "LDTT";
            this.LDTT.ReadOnly = true;
            this.LDTT.Width = 150;
            // 
            // Tien
            // 
            this.Tien.DataPropertyName = "Tien";
            this.Tien.HeaderText = "Thành tiền";
            this.Tien.Name = "Tien";
            this.Tien.ReadOnly = true;
            this.Tien.Width = 200;
            // 
            // FormTimKiemHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 698);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTimKiemHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tiền Điện";
            this.Activated += new System.EventHandler(this.FormTimKiemHD_Activated);
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
        private System.Windows.Forms.TextBox textBoxMaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn LDTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tien;
    }
}