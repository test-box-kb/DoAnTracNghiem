
namespace DoAnTracNghiem
{
    partial class Login
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
            this.tuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btlogin = new System.Windows.Forms.Button();
            this.btregister = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // tuser
            // 
            this.tuser.Location = new System.Drawing.Point(154, 86);
            this.tuser.Name = "tuser";
            this.tuser.Size = new System.Drawing.Size(351, 22);
            this.tuser.TabIndex = 1;
            this.tuser.TextChanged += new System.EventHandler(this.tuser_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // tpass
            // 
            this.tpass.Location = new System.Drawing.Point(154, 137);
            this.tpass.Name = "tpass";
            this.tpass.Size = new System.Drawing.Size(351, 22);
            this.tpass.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "LOGIN";
            // 
            // btlogin
            // 
            this.btlogin.Location = new System.Drawing.Point(177, 190);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(90, 34);
            this.btlogin.TabIndex = 6;
            this.btlogin.Text = "login";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // btregister
            // 
            this.btregister.Location = new System.Drawing.Point(356, 190);
            this.btregister.Name = "btregister";
            this.btregister.Size = new System.Drawing.Size(90, 34);
            this.btregister.TabIndex = 7;
            this.btregister.Text = "register";
            this.btregister.UseVisualStyleBackColor = true;
            this.btregister.Click += new System.EventHandler(this.btregister_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(252, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "if you can\'t login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(627, 310);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btregister);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tuser);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button btregister;
        private System.Windows.Forms.Label label4;
    }
}

