
namespace GraveyardMS
{
    partial class Person
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listOfVisitorsGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addDivisonButton = new System.Windows.Forms.Button();
            this.addDistrictTextBox = new System.Windows.Forms.TextBox();
            this.addPaymentTextBox = new System.Windows.Forms.TextBox();
            this.addPlaceTextBox = new System.Windows.Forms.TextBox();
            this.addDivisonTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.updateVisitorsIdTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.updateDistrictTextBox = new System.Windows.Forms.TextBox();
            this.updatePaymentTextBox = new System.Windows.Forms.TextBox();
            this.updatePlaceTextBox = new System.Windows.Forms.TextBox();
            this.updateDivisonTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteVisitorIdTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfVisitorsGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listOfVisitorsGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(462, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Of Visitors";
            // 
            // listOfVisitorsGridView
            // 
            this.listOfVisitorsGridView.AllowUserToAddRows = false;
            this.listOfVisitorsGridView.AllowUserToDeleteRows = false;
            this.listOfVisitorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfVisitorsGridView.Location = new System.Drawing.Point(6, 21);
            this.listOfVisitorsGridView.Name = "listOfVisitorsGridView";
            this.listOfVisitorsGridView.ReadOnly = true;
            this.listOfVisitorsGridView.Size = new System.Drawing.Size(240, 150);
            this.listOfVisitorsGridView.TabIndex = 0;
            this.listOfVisitorsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listOfVisitorsGridView_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addDivisonButton);
            this.groupBox2.Controls.Add(this.addDistrictTextBox);
            this.groupBox2.Controls.Add(this.addPaymentTextBox);
            this.groupBox2.Controls.Add(this.addPlaceTextBox);
            this.groupBox2.Controls.Add(this.addDivisonTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(42, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Visitor";
            // 
            // addDivisonButton
            // 
            this.addDivisonButton.Location = new System.Drawing.Point(211, 87);
            this.addDivisonButton.Name = "addDivisonButton";
            this.addDivisonButton.Size = new System.Drawing.Size(89, 28);
            this.addDivisonButton.TabIndex = 8;
            this.addDivisonButton.Text = "Add";
            this.addDivisonButton.UseVisualStyleBackColor = true;
            this.addDivisonButton.Click += new System.EventHandler(this.addDivisonButton_Click);
            // 
            // addDistrictTextBox
            // 
            this.addDistrictTextBox.Location = new System.Drawing.Point(105, 135);
            this.addDistrictTextBox.Name = "addDistrictTextBox";
            this.addDistrictTextBox.Size = new System.Drawing.Size(100, 28);
            this.addDistrictTextBox.TabIndex = 7;
            // 
            // addPaymentTextBox
            // 
            this.addPaymentTextBox.Location = new System.Drawing.Point(105, 104);
            this.addPaymentTextBox.Name = "addPaymentTextBox";
            this.addPaymentTextBox.Size = new System.Drawing.Size(100, 28);
            this.addPaymentTextBox.TabIndex = 6;
            // 
            // addPlaceTextBox
            // 
            this.addPlaceTextBox.Location = new System.Drawing.Point(105, 71);
            this.addPlaceTextBox.Name = "addPlaceTextBox";
            this.addPlaceTextBox.Size = new System.Drawing.Size(100, 28);
            this.addPlaceTextBox.TabIndex = 5;
            // 
            // addDivisonTextBox
            // 
            this.addDivisonTextBox.Location = new System.Drawing.Point(105, 35);
            this.addDivisonTextBox.Name = "addDivisonTextBox";
            this.addDivisonTextBox.Size = new System.Drawing.Size(100, 28);
            this.addDivisonTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "District";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Place";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Divison";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.loadButton);
            this.groupBox3.Controls.Add(this.updateVisitorsIdTextBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.updateButton);
            this.groupBox3.Controls.Add(this.updateDistrictTextBox);
            this.groupBox3.Controls.Add(this.updatePaymentTextBox);
            this.groupBox3.Controls.Add(this.updatePlaceTextBox);
            this.groupBox3.Controls.Add(this.updateDivisonTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(43, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 212);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Visitor";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(161, 28);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 28);
            this.loadButton.TabIndex = 11;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // updateVisitorsIdTextBox
            // 
            this.updateVisitorsIdTextBox.Location = new System.Drawing.Point(104, 27);
            this.updateVisitorsIdTextBox.Name = "updateVisitorsIdTextBox";
            this.updateVisitorsIdTextBox.Size = new System.Drawing.Size(51, 28);
            this.updateVisitorsIdTextBox.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "VisitorsID";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(221, 104);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(95, 34);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateDistrictTextBox
            // 
            this.updateDistrictTextBox.Location = new System.Drawing.Point(104, 172);
            this.updateDistrictTextBox.Name = "updateDistrictTextBox";
            this.updateDistrictTextBox.Size = new System.Drawing.Size(100, 28);
            this.updateDistrictTextBox.TabIndex = 7;
            // 
            // updatePaymentTextBox
            // 
            this.updatePaymentTextBox.Location = new System.Drawing.Point(104, 138);
            this.updatePaymentTextBox.Name = "updatePaymentTextBox";
            this.updatePaymentTextBox.Size = new System.Drawing.Size(100, 28);
            this.updatePaymentTextBox.TabIndex = 6;
            // 
            // updatePlaceTextBox
            // 
            this.updatePlaceTextBox.Location = new System.Drawing.Point(105, 104);
            this.updatePlaceTextBox.Name = "updatePlaceTextBox";
            this.updatePlaceTextBox.Size = new System.Drawing.Size(100, 28);
            this.updatePlaceTextBox.TabIndex = 5;
            // 
            // updateDivisonTextBox
            // 
            this.updateDivisonTextBox.Location = new System.Drawing.Point(104, 67);
            this.updateDivisonTextBox.Name = "updateDivisonTextBox";
            this.updateDivisonTextBox.Size = new System.Drawing.Size(100, 28);
            this.updateDivisonTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "District";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Payment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Place";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Divison";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.deleteButton);
            this.groupBox4.Controls.Add(this.deleteVisitorIdTextBox);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(437, 288);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(326, 172);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete Visitor";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(231, 36);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(89, 28);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteVisitorIdTextBox
            // 
            this.deleteVisitorIdTextBox.Location = new System.Drawing.Point(105, 35);
            this.deleteVisitorIdTextBox.Name = "deleteVisitorIdTextBox";
            this.deleteVisitorIdTextBox.Size = new System.Drawing.Size(100, 28);
            this.deleteVisitorIdTextBox.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "VisitorsID";
            // 
            // Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 578);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Person";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listOfVisitorsGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView listOfVisitorsGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addDivisonButton;
        private System.Windows.Forms.TextBox addDistrictTextBox;
        private System.Windows.Forms.TextBox addPaymentTextBox;
        private System.Windows.Forms.TextBox addPlaceTextBox;
        private System.Windows.Forms.TextBox addDivisonTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox updateVisitorsIdTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox updateDistrictTextBox;
        private System.Windows.Forms.TextBox updatePaymentTextBox;
        private System.Windows.Forms.TextBox updatePlaceTextBox;
        private System.Windows.Forms.TextBox updateDivisonTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox deleteVisitorIdTextBox;
        private System.Windows.Forms.Label label13;
    }
}