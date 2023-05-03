
namespace DoAnTracNghiem
{
    partial class register
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
            this.label1 = new System.Windows.Forms.Label();
            this.rguser = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rgpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cfpass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rgemail = new System.Windows.Forms.TextBox();
            this.rgcancel = new System.Windows.Forms.Button();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.rp = new System.Windows.Forms.Label();
            this.rgdob = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbposition = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // rguser
            // 
            this.rguser.Location = new System.Drawing.Point(148, 43);
            this.rguser.Name = "rguser";
            this.rguser.Size = new System.Drawing.Size(228, 22);
            this.rguser.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Regester";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Regester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // rgpass
            // 
            this.rgpass.Location = new System.Drawing.Point(148, 79);
            this.rgpass.Name = "rgpass";
            this.rgpass.PasswordChar = '*';
            this.rgpass.Size = new System.Drawing.Size(228, 22);
            this.rgpass.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm Password";
            // 
            // cfpass
            // 
            this.cfpass.Location = new System.Drawing.Point(148, 112);
            this.cfpass.Name = "cfpass";
            this.cfpass.PasswordChar = '*';
            this.cfpass.Size = new System.Drawing.Size(228, 22);
            this.cfpass.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // rgemail
            // 
            this.rgemail.Location = new System.Drawing.Point(148, 151);
            this.rgemail.Name = "rgemail";
            this.rgemail.Size = new System.Drawing.Size(228, 22);
            this.rgemail.TabIndex = 9;
            // 
            // rgcancel
            // 
            this.rgcancel.Location = new System.Drawing.Point(254, 281);
            this.rgcancel.Name = "rgcancel";
            this.rgcancel.Size = new System.Drawing.Size(87, 36);
            this.rgcancel.TabIndex = 10;
            this.rgcancel.Text = "Cancel";
            this.rgcancel.UseVisualStyleBackColor = true;
            this.rgcancel.Click += new System.EventHandler(this.rgcancel_Click);
            // 
            // showpass
            // 
            this.showpass.AutoSize = true;
            this.showpass.Location = new System.Drawing.Point(382, 86);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(64, 21);
            this.showpass.TabIndex = 11;
            this.showpass.Text = "Show";
            this.showpass.UseVisualStyleBackColor = true;
            this.showpass.CheckedChanged += new System.EventHandler(this.checkpass_CheckedChanged);
            // 
            // rp
            // 
            this.rp.AutoSize = true;
            this.rp.ForeColor = System.Drawing.SystemColors.Control;
            this.rp.Location = new System.Drawing.Point(140, 330);
            this.rp.Name = "rp";
            this.rp.Size = new System.Drawing.Size(46, 17);
            this.rp.TabIndex = 12;
            this.rp.Text = "label6";
            // 
            // rgdob
            // 
            this.rgdob.Location = new System.Drawing.Point(148, 186);
            this.rgdob.Name = "rgdob";
            this.rgdob.Size = new System.Drawing.Size(228, 22);
            this.rgdob.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Date of birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Position";
            // 
            // cbposition
            // 
            this.cbposition.FormattingEnabled = true;
            this.cbposition.Items.AddRange(new object[] {
            "Teacher",
            "Student",
            "Admin"});
            this.cbposition.Location = new System.Drawing.Point(148, 225);
            this.cbposition.Name = "cbposition";
            this.cbposition.Size = new System.Drawing.Size(121, 24);
            this.cbposition.TabIndex = 16;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 381);
            this.Controls.Add(this.cbposition);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rgdob);
            this.Controls.Add(this.rp);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.rgcancel);
            this.Controls.Add(this.rgemail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cfpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rgpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rguser);
            this.Controls.Add(this.label1);
            this.Name = "register";
            this.Text = "register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rguser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rgpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cfpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rgemail;
        private System.Windows.Forms.Button rgcancel;
        private System.Windows.Forms.CheckBox showpass;
        private System.Windows.Forms.Label rp;
        private System.Windows.Forms.TextBox rgdob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbposition;
    }
}