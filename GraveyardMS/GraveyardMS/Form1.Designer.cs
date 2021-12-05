
namespace GraveyardMS
{
    partial class Form1
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
            this.NewAcc = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewAcc
            // 
            this.NewAcc.BackColor = System.Drawing.Color.Black;
            this.NewAcc.BackgroundImage = global::GraveyardMS.Properties.Resources.create_this_zombie_grave_horror_video_intro;
            this.NewAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewAcc.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewAcc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewAcc.Image = global::GraveyardMS.Properties.Resources.Asset_5_3x;
            this.NewAcc.Location = new System.Drawing.Point(545, 356);
            this.NewAcc.Name = "NewAcc";
            this.NewAcc.Size = new System.Drawing.Size(310, 81);
            this.NewAcc.TabIndex = 2;
            this.NewAcc.Text = "Create New Account";
            this.NewAcc.UseVisualStyleBackColor = false;
            this.NewAcc.Click += new System.EventHandler(this.NewAcc_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Black;
            this.Login.BackgroundImage = global::GraveyardMS.Properties.Resources.create_this_zombie_grave_horror_video_intro;
            this.Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Image = global::GraveyardMS.Properties.Resources.Asset_8_3x;
            this.Login.Location = new System.Drawing.Point(570, 198);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(263, 96);
            this.Login.TabIndex = 3;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GraveyardMS.Properties.Resources.create_this_zombie_grave_horror_video_intro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1249, 586);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.NewAcc);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GraveyardMS";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewAcc;
        private System.Windows.Forms.Button Login;
    }
}

