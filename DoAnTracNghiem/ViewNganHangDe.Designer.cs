
namespace DoAnTracNghiem
{
    partial class ViewNganHangDe
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
            this.fltNganHangDe = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.vnhdBangDieuKhien = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fltNganHangDe
            // 
            this.fltNganHangDe.AutoScroll = true;
            this.fltNganHangDe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fltNganHangDe.Location = new System.Drawing.Point(12, 12);
            this.fltNganHangDe.Name = "fltNganHangDe";
            this.fltNganHangDe.Size = new System.Drawing.Size(602, 426);
            this.fltNganHangDe.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vnhdBangDieuKhien);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(620, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 426);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quay Lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vnhdBangDieuKhien
            // 
            this.vnhdBangDieuKhien.Location = new System.Drawing.Point(34, 271);
            this.vnhdBangDieuKhien.Name = "vnhdBangDieuKhien";
            this.vnhdBangDieuKhien.Size = new System.Drawing.Size(101, 87);
            this.vnhdBangDieuKhien.TabIndex = 1;
            this.vnhdBangDieuKhien.Text = "Bảng Điều Khiển";
            this.vnhdBangDieuKhien.UseVisualStyleBackColor = true;
            // 
            // ViewNganHangDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fltNganHangDe);
            this.Name = "ViewNganHangDe";
            this.Text = "ViewNganHangDe";
            this.Load += new System.EventHandler(this.ViewNganHangDe_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fltNganHangDe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button vnhdBangDieuKhien;
    }
}