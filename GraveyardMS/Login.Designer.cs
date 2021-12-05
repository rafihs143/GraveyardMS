
namespace GraveyardMS
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
            this.Logininfo = new System.Windows.Forms.GroupBox();
            this.login_comboBox = new System.Windows.Forms.ComboBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.loginpass_textBox = new System.Windows.Forms.TextBox();
            this.loginpassword = new System.Windows.Forms.Label();
            this.loginusername_textBox = new System.Windows.Forms.TextBox();
            this.loginusername = new System.Windows.Forms.Label();
            this.Logininfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logininfo
            // 
            this.Logininfo.BackgroundImage = global::GraveyardMS.Properties.Resources.create_this_zombie_grave_horror_video_intro;
            this.Logininfo.Controls.Add(this.login_comboBox);
            this.Logininfo.Controls.Add(this.loginbutton);
            this.Logininfo.Controls.Add(this.loginpass_textBox);
            this.Logininfo.Controls.Add(this.loginpassword);
            this.Logininfo.Controls.Add(this.loginusername_textBox);
            this.Logininfo.Controls.Add(this.loginusername);
            this.Logininfo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logininfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Logininfo.Location = new System.Drawing.Point(110, 33);
            this.Logininfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Logininfo.Name = "Logininfo";
            this.Logininfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Logininfo.Size = new System.Drawing.Size(375, 242);
            this.Logininfo.TabIndex = 0;
            this.Logininfo.TabStop = false;
            this.Logininfo.Text = "Login Info";
            // 
            // login_comboBox
            // 
            this.login_comboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_comboBox.FormattingEnabled = true;
            this.login_comboBox.Items.AddRange(new object[] {
            "1. Admin",
            "2. Visitor"});
            this.login_comboBox.Location = new System.Drawing.Point(247, 55);
            this.login_comboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login_comboBox.Name = "login_comboBox";
            this.login_comboBox.Size = new System.Drawing.Size(111, 26);
            this.login_comboBox.TabIndex = 5;
            this.login_comboBox.SelectedIndexChanged += new System.EventHandler(this.login_comboBox_SelectedIndexChanged);
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.loginbutton.Image = global::GraveyardMS.Properties.Resources.Asset_1_3x;
            this.loginbutton.Location = new System.Drawing.Point(103, 191);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(125, 36);
            this.loginbutton.TabIndex = 4;
            this.loginbutton.Text = "Enter";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // loginpass_textBox
            // 
            this.loginpass_textBox.BackColor = System.Drawing.Color.White;
            this.loginpass_textBox.Location = new System.Drawing.Point(147, 137);
            this.loginpass_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginpass_textBox.Name = "loginpass_textBox";
            this.loginpass_textBox.PasswordChar = '*';
            this.loginpass_textBox.Size = new System.Drawing.Size(171, 29);
            this.loginpass_textBox.TabIndex = 3;
            // 
            // loginpassword
            // 
            this.loginpassword.AutoSize = true;
            this.loginpassword.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginpassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginpassword.Location = new System.Drawing.Point(32, 137);
            this.loginpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginpassword.Name = "loginpassword";
            this.loginpassword.Size = new System.Drawing.Size(103, 22);
            this.loginpassword.TabIndex = 2;
            this.loginpassword.Text = "Password";
            // 
            // loginusername_textBox
            // 
            this.loginusername_textBox.BackColor = System.Drawing.Color.White;
            this.loginusername_textBox.Location = new System.Drawing.Point(147, 103);
            this.loginusername_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginusername_textBox.Name = "loginusername_textBox";
            this.loginusername_textBox.Size = new System.Drawing.Size(171, 29);
            this.loginusername_textBox.TabIndex = 1;
            // 
            // loginusername
            // 
            this.loginusername.AutoSize = true;
            this.loginusername.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginusername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginusername.Location = new System.Drawing.Point(29, 103);
            this.loginusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginusername.Name = "loginusername";
            this.loginusername.Size = new System.Drawing.Size(104, 22);
            this.loginusername.TabIndex = 0;
            this.loginusername.Text = "Username";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GraveyardMS.Properties.Resources.create_this_zombie_grave_horror_video_intro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.Logininfo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Logininfo.ResumeLayout(false);
            this.Logininfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Logininfo;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.TextBox loginpass_textBox;
        private System.Windows.Forms.Label loginpassword;
        private System.Windows.Forms.TextBox loginusername_textBox;
        private System.Windows.Forms.Label loginusername;
        private System.Windows.Forms.ComboBox login_comboBox;
    }
}