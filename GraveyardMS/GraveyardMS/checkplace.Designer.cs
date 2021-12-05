
namespace GraveyardMS
{
    partial class checkplace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkplace));
            this.cpldistrict_label = new System.Windows.Forms.Label();
            this.cpl_button = new System.Windows.Forms.Button();
            this.cpldivision_label = new System.Windows.Forms.Label();
            this.cpldivision_comboBox = new System.Windows.Forms.ComboBox();
            this.cpldistrict_comboBox = new System.Windows.Forms.ComboBox();
            this.cplback_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cpldistrict_label
            // 
            this.cpldistrict_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.cpldistrict_label, "cpldistrict_label");
            this.cpldistrict_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cpldistrict_label.Name = "cpldistrict_label";
            // 
            // cpl_button
            // 
            resources.ApplyResources(this.cpl_button, "cpl_button");
            this.cpl_button.Image = global::GraveyardMS.Properties.Resources.Asset_3_3x;
            this.cpl_button.Name = "cpl_button";
            this.cpl_button.UseVisualStyleBackColor = true;
            this.cpl_button.Click += new System.EventHandler(this.cpl_button_Click);
            // 
            // cpldivision_label
            // 
            this.cpldivision_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.cpldivision_label, "cpldivision_label");
            this.cpldivision_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cpldivision_label.Name = "cpldivision_label";
            // 
            // cpldivision_comboBox
            // 
            resources.ApplyResources(this.cpldivision_comboBox, "cpldivision_comboBox");
            this.cpldivision_comboBox.FormattingEnabled = true;
            this.cpldivision_comboBox.Items.AddRange(new object[] {
            resources.GetString("cpldivision_comboBox.Items")});
            this.cpldivision_comboBox.Name = "cpldivision_comboBox";
            // 
            // cpldistrict_comboBox
            // 
            resources.ApplyResources(this.cpldistrict_comboBox, "cpldistrict_comboBox");
            this.cpldistrict_comboBox.FormattingEnabled = true;
            this.cpldistrict_comboBox.Items.AddRange(new object[] {
            resources.GetString("cpldistrict_comboBox.Items"),
            resources.GetString("cpldistrict_comboBox.Items1")});
            this.cpldistrict_comboBox.Name = "cpldistrict_comboBox";
            // 
            // cplback_button
            // 
            resources.ApplyResources(this.cplback_button, "cplback_button");
            this.cplback_button.Image = global::GraveyardMS.Properties.Resources.Asset_9_3x;
            this.cplback_button.Name = "cplback_button";
            this.cplback_button.UseVisualStyleBackColor = true;
            this.cplback_button.Click += new System.EventHandler(this.cplback_button_Click);
            // 
            // checkplace
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GraveyardMS.Properties.Resources._5786eb1e_d672_4cfb_8cf5_283703cc0b3f;
            this.Controls.Add(this.cplback_button);
            this.Controls.Add(this.cpldistrict_comboBox);
            this.Controls.Add(this.cpldivision_comboBox);
            this.Controls.Add(this.cpldistrict_label);
            this.Controls.Add(this.cpl_button);
            this.Controls.Add(this.cpldivision_label);
            this.Name = "checkplace";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.checkplace_FormClosing);
            this.Load += new System.EventHandler(this.checkplace_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cpldistrict_label;
        private System.Windows.Forms.Button cpl_button;
        private System.Windows.Forms.Label cpldivision_label;
        private System.Windows.Forms.ComboBox cpldivision_comboBox;
        private System.Windows.Forms.ComboBox cpldistrict_comboBox;
        private System.Windows.Forms.Button cplback_button;
    }
}