
namespace GraveyardMS
{
    partial class VisitorsInfo
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
            this.visitorsInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.visitorsInfoGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.visitorsInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitorsInfoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // visitorsInfoGroupBox
            // 
            this.visitorsInfoGroupBox.Controls.Add(this.label1);
            this.visitorsInfoGroupBox.Controls.Add(this.visitorsInfoGridView);
            this.visitorsInfoGroupBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorsInfoGroupBox.Location = new System.Drawing.Point(108, 41);
            this.visitorsInfoGroupBox.Name = "visitorsInfoGroupBox";
            this.visitorsInfoGroupBox.Size = new System.Drawing.Size(569, 354);
            this.visitorsInfoGroupBox.TabIndex = 0;
            this.visitorsInfoGroupBox.TabStop = false;
            // 
            // visitorsInfoGridView
            // 
            this.visitorsInfoGridView.AllowUserToAddRows = false;
            this.visitorsInfoGridView.AllowUserToDeleteRows = false;
            this.visitorsInfoGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.visitorsInfoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitorsInfoGridView.Location = new System.Drawing.Point(6, 38);
            this.visitorsInfoGridView.Name = "visitorsInfoGridView";
            this.visitorsInfoGridView.ReadOnly = true;
            this.visitorsInfoGridView.Size = new System.Drawing.Size(557, 335);
            this.visitorsInfoGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Visitors Info";
            // 
            // VisitorsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.visitorsInfoGroupBox);
            this.Name = "VisitorsInfo";
            this.Text = "VisitorsInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VisitorsInfo_FormClosing);
            this.Load += new System.EventHandler(this.VisitorsInfo_Load);
            this.visitorsInfoGroupBox.ResumeLayout(false);
            this.visitorsInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitorsInfoGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox visitorsInfoGroupBox;
        private System.Windows.Forms.DataGridView visitorsInfoGridView;
        private System.Windows.Forms.Label label1;
    }
}