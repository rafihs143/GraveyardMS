
namespace GraveyardMS
{
    partial class buy
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
            this.buyname_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buyplace_label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buyback_button = new System.Windows.Forms.Button();
            this.buyenter_button = new System.Windows.Forms.Button();
            this.buypayment_comboBox = new System.Windows.Forms.ComboBox();
            this.buypayment_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buyname_label
            // 
            this.buyname_label.AutoSize = true;
            this.buyname_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buyname_label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyname_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buyname_label.Location = new System.Drawing.Point(213, 84);
            this.buyname_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buyname_label.Name = "buyname_label";
            this.buyname_label.Size = new System.Drawing.Size(53, 19);
            this.buyname_label.TabIndex = 0;
            this.buyname_label.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(289, 81);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 26);
            this.textBox1.TabIndex = 1;
            // 
            // buyplace_label
            // 
            this.buyplace_label.AutoSize = true;
            this.buyplace_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buyplace_label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyplace_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buyplace_label.Location = new System.Drawing.Point(213, 125);
            this.buyplace_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buyplace_label.Name = "buyplace_label";
            this.buyplace_label.Size = new System.Drawing.Size(51, 19);
            this.buyplace_label.TabIndex = 2;
            this.buyplace_label.Text = "Place";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(289, 125);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 26);
            this.comboBox1.TabIndex = 3;
            // 
            // buyback_button
            // 
            this.buyback_button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyback_button.Image = global::GraveyardMS.Properties.Resources.Asset_9_3x;
            this.buyback_button.Location = new System.Drawing.Point(234, 251);
            this.buyback_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buyback_button.Name = "buyback_button";
            this.buyback_button.Size = new System.Drawing.Size(77, 29);
            this.buyback_button.TabIndex = 4;
            this.buyback_button.Text = "Back";
            this.buyback_button.UseVisualStyleBackColor = true;
            this.buyback_button.Click += new System.EventHandler(this.buyback_button_Click);
            // 
            // buyenter_button
            // 
            this.buyenter_button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyenter_button.Image = global::GraveyardMS.Properties.Resources.Asset_7_3x;
            this.buyenter_button.Location = new System.Drawing.Point(342, 250);
            this.buyenter_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buyenter_button.Name = "buyenter_button";
            this.buyenter_button.Size = new System.Drawing.Size(83, 31);
            this.buyenter_button.TabIndex = 5;
            this.buyenter_button.Text = "Enter";
            this.buyenter_button.UseVisualStyleBackColor = true;
            // 
            // buypayment_comboBox
            // 
            this.buypayment_comboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buypayment_comboBox.FormattingEnabled = true;
            this.buypayment_comboBox.Items.AddRange(new object[] {
            "Bkash (10,000taka)",
            "Rocket (10,000taka)",
            "Nogod (10,000taka)",
            "Janata Bank/Brac Bank/Dhaka Bank (9800taka)"});
            this.buypayment_comboBox.Location = new System.Drawing.Point(289, 176);
            this.buypayment_comboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buypayment_comboBox.Name = "buypayment_comboBox";
            this.buypayment_comboBox.Size = new System.Drawing.Size(137, 26);
            this.buypayment_comboBox.TabIndex = 7;
            // 
            // buypayment_label
            // 
            this.buypayment_label.AutoSize = true;
            this.buypayment_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buypayment_label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buypayment_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buypayment_label.Location = new System.Drawing.Point(189, 177);
            this.buypayment_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buypayment_label.Name = "buypayment_label";
            this.buypayment_label.Size = new System.Drawing.Size(76, 19);
            this.buypayment_label.TabIndex = 6;
            this.buypayment_label.Text = "Payment";
            // 
            // buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GraveyardMS.Properties.Resources.create_this_zombie_grave_horror_video_intro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 363);
            this.Controls.Add(this.buypayment_comboBox);
            this.Controls.Add(this.buypayment_label);
            this.Controls.Add(this.buyenter_button);
            this.Controls.Add(this.buyback_button);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buyplace_label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buyname_label);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "buy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "buy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.buy_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label buyname_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label buyplace_label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buyback_button;
        private System.Windows.Forms.Button buyenter_button;
        private System.Windows.Forms.ComboBox buypayment_comboBox;
        private System.Windows.Forms.Label buypayment_label;
    }
}