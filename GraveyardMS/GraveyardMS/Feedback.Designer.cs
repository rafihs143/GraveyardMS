
namespace GraveyardMS
{
    partial class Feedback
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
            this.feddback_submit = new System.Windows.Forms.Button();
            this.feedback_textBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // feddback_submit
            // 
            this.feddback_submit.BackColor = System.Drawing.Color.Lime;
            this.feddback_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feddback_submit.Location = new System.Drawing.Point(217, 302);
            this.feddback_submit.Name = "feddback_submit";
            this.feddback_submit.Size = new System.Drawing.Size(119, 38);
            this.feddback_submit.TabIndex = 0;
            this.feddback_submit.Text = "Enter";
            this.feddback_submit.UseVisualStyleBackColor = false;
            this.feddback_submit.Click += new System.EventHandler(this.feddback_submit_Click);
            // 
            // feedback_textBox
            // 
            this.feedback_textBox.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedback_textBox.Location = new System.Drawing.Point(217, 140);
            this.feedback_textBox.Multiline = true;
            this.feedback_textBox.Name = "feedback_textBox";
            this.feedback_textBox.Size = new System.Drawing.Size(452, 140);
            this.feedback_textBox.TabIndex = 1;
            this.feedback_textBox.Text = "Write your opinion";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(217, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 35);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Write your email id";
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GraveyardMS.Properties.Resources._203_2033791_different_colour_full_background_hd;
            this.ClientSize = new System.Drawing.Size(818, 459);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.feedback_textBox);
            this.Controls.Add(this.feddback_submit);
            this.Name = "Feedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Feedback_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button feddback_submit;
        private System.Windows.Forms.TextBox feedback_textBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}