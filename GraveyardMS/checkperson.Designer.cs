
namespace GraveyardMS
{
    partial class checkperson
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
            this.cpname_label = new System.Windows.Forms.Label();
            this.cpname_textBox = new System.Windows.Forms.TextBox();
            this.cp_button = new System.Windows.Forms.Button();
            this.cpplace_label = new System.Windows.Forms.Label();
            this.clback_button = new System.Windows.Forms.Button();
            this.cpplace_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cpname_label
            // 
            this.cpname_label.AutoSize = true;
            this.cpname_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cpname_label.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpname_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cpname_label.Location = new System.Drawing.Point(257, 105);
            this.cpname_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpname_label.Name = "cpname_label";
            this.cpname_label.Size = new System.Drawing.Size(62, 22);
            this.cpname_label.TabIndex = 0;
            this.cpname_label.Text = "Name";
            // 
            // cpname_textBox
            // 
            this.cpname_textBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpname_textBox.Location = new System.Drawing.Point(349, 103);
            this.cpname_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cpname_textBox.Name = "cpname_textBox";
            this.cpname_textBox.Size = new System.Drawing.Size(139, 26);
            this.cpname_textBox.TabIndex = 1;
            // 
            // cp_button
            // 
            this.cp_button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cp_button.Image = global::GraveyardMS.Properties.Resources.Asset_3_3x;
            this.cp_button.Location = new System.Drawing.Point(415, 242);
            this.cp_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cp_button.Name = "cp_button";
            this.cp_button.Size = new System.Drawing.Size(84, 31);
            this.cp_button.TabIndex = 2;
            this.cp_button.Text = "Enter";
            this.cp_button.UseVisualStyleBackColor = true;
            this.cp_button.Click += new System.EventHandler(this.cp_button_Click);
            // 
            // cpplace_label
            // 
            this.cpplace_label.AutoSize = true;
            this.cpplace_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cpplace_label.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpplace_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cpplace_label.Location = new System.Drawing.Point(257, 166);
            this.cpplace_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpplace_label.Name = "cpplace_label";
            this.cpplace_label.Size = new System.Drawing.Size(61, 22);
            this.cpplace_label.TabIndex = 3;
            this.cpplace_label.Text = "Place";
            // 
            // clback_button
            // 
            this.clback_button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clback_button.Image = global::GraveyardMS.Properties.Resources.Asset_9_3x;
            this.clback_button.Location = new System.Drawing.Point(325, 244);
            this.clback_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clback_button.Name = "clback_button";
            this.clback_button.Size = new System.Drawing.Size(77, 29);
            this.clback_button.TabIndex = 5;
            this.clback_button.Text = "Back";
            this.clback_button.UseVisualStyleBackColor = true;
            this.clback_button.Click += new System.EventHandler(this.clback_button_Click);
            // 
            // cpplace_comboBox
            // 
            this.cpplace_comboBox.Font = new System.Drawing.Font("Arial", 12F);
            this.cpplace_comboBox.FormattingEnabled = true;
            this.cpplace_comboBox.Items.AddRange(new object[] {
            "1.Dhaka"});
            this.cpplace_comboBox.Location = new System.Drawing.Point(349, 164);
            this.cpplace_comboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cpplace_comboBox.Name = "cpplace_comboBox";
            this.cpplace_comboBox.Size = new System.Drawing.Size(139, 26);
            this.cpplace_comboBox.TabIndex = 10;
            // 
            // checkperson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GraveyardMS.Properties.Resources._5786eb1e_d672_4cfb_8cf5_283703cc0b3f;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 368);
            this.Controls.Add(this.cpplace_comboBox);
            this.Controls.Add(this.clback_button);
            this.Controls.Add(this.cpplace_label);
            this.Controls.Add(this.cp_button);
            this.Controls.Add(this.cpname_textBox);
            this.Controls.Add(this.cpname_label);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "checkperson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "checkperson";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.checkperson_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cpname_label;
        private System.Windows.Forms.TextBox cpname_textBox;
        private System.Windows.Forms.Button cp_button;
        private System.Windows.Forms.Label cpplace_label;
        private System.Windows.Forms.Button clback_button;
        private System.Windows.Forms.ComboBox cpplace_comboBox;
    }
}