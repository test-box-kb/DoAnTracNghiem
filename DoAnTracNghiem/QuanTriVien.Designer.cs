
namespace DoAnTracNghiem
{
    partial class QuanTriVien
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
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.XemDanhSachGiangVien = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvAccount);
            this.panel1.Controls.Add(this.XemDanhSachGiangVien);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(3, 3);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.RowHeadersWidth = 51;
            this.dtgvAccount.RowTemplate.Height = 24;
            this.dtgvAccount.Size = new System.Drawing.Size(489, 420);
            this.dtgvAccount.TabIndex = 9;
            // 
            // XemDanhSachGiangVien
            // 
            this.XemDanhSachGiangVien.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.XemDanhSachGiangVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XemDanhSachGiangVien.Location = new System.Drawing.Point(557, 3);
            this.XemDanhSachGiangVien.Name = "XemDanhSachGiangVien";
            this.XemDanhSachGiangVien.Size = new System.Drawing.Size(214, 53);
            this.XemDanhSachGiangVien.TabIndex = 3;
            this.XemDanhSachGiangVien.Text = "Xem Danh Sách Giảng Viên";
            this.XemDanhSachGiangVien.UseVisualStyleBackColor = false;
            this.XemDanhSachGiangVien.Click += new System.EventHandler(this.XemDanhSachGiangVien_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(559, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Xem Danh Sách Sinh Viên";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // QuanTriVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "QuanTriVien";
            this.Text = "QuanTriVien";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button XemDanhSachGiangVien;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtgvAccount;
    }
}