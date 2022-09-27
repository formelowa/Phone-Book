namespace Phone_Book
{
    partial class Reg_Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg_Data));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Info_Button = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.info_gBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_tb = new System.Windows.Forms.TextBox();
            this.First_N_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Last_N_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tel_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cell_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.adress_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comment_tb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.info_gBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Info_Button,
            this.saveButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(327, 41);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Info_Button
            // 
            this.Info_Button.Image = ((System.Drawing.Image)(resources.GetObject("Info_Button.Image")));
            this.Info_Button.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Info_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Info_Button.Name = "Info_Button";
            this.Info_Button.Size = new System.Drawing.Size(94, 38);
            this.Info_Button.Text = "New Data";
            this.Info_Button.Click += new System.EventHandler(this.Info_Button_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(116, 38);
            this.saveButton.Text = "Save Changes";
            this.saveButton.ToolTipText = "Save Changes";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // info_gBox
            // 
            this.info_gBox.Controls.Add(this.comment_tb);
            this.info_gBox.Controls.Add(this.label8);
            this.info_gBox.Controls.Add(this.adress_tb);
            this.info_gBox.Controls.Add(this.label7);
            this.info_gBox.Controls.Add(this.email_tb);
            this.info_gBox.Controls.Add(this.label6);
            this.info_gBox.Controls.Add(this.cell_tb);
            this.info_gBox.Controls.Add(this.label5);
            this.info_gBox.Controls.Add(this.tel_tb);
            this.info_gBox.Controls.Add(this.label4);
            this.info_gBox.Controls.Add(this.Last_N_tb);
            this.info_gBox.Controls.Add(this.label3);
            this.info_gBox.Controls.Add(this.First_N_tb);
            this.info_gBox.Controls.Add(this.label2);
            this.info_gBox.Controls.Add(this.ID_tb);
            this.info_gBox.Controls.Add(this.label1);
            this.info_gBox.Location = new System.Drawing.Point(12, 44);
            this.info_gBox.Name = "info_gBox";
            this.info_gBox.Size = new System.Drawing.Size(303, 350);
            this.info_gBox.TabIndex = 0;
            this.info_gBox.TabStop = false;
            this.info_gBox.Text = "Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // ID_tb
            // 
            this.ID_tb.Location = new System.Drawing.Point(75, 47);
            this.ID_tb.Name = "ID_tb";
            this.ID_tb.Size = new System.Drawing.Size(205, 20);
            this.ID_tb.TabIndex = 1;
            // 
            // First_N_tb
            // 
            this.First_N_tb.Location = new System.Drawing.Point(75, 73);
            this.First_N_tb.Name = "First_N_tb";
            this.First_N_tb.Size = new System.Drawing.Size(205, 20);
            this.First_N_tb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Last_N_tb
            // 
            this.Last_N_tb.Location = new System.Drawing.Point(75, 99);
            this.Last_N_tb.Name = "Last_N_tb";
            this.Last_N_tb.Size = new System.Drawing.Size(205, 20);
            this.Last_N_tb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tel_tb
            // 
            this.tel_tb.Location = new System.Drawing.Point(75, 125);
            this.tel_tb.Name = "tel_tb";
            this.tel_tb.Size = new System.Drawing.Size(205, 20);
            this.tel_tb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tel :";
            // 
            // cell_tb
            // 
            this.cell_tb.Location = new System.Drawing.Point(75, 151);
            this.cell_tb.Name = "cell_tb";
            this.cell_tb.Size = new System.Drawing.Size(205, 20);
            this.cell_tb.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cell :";
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(75, 177);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(205, 20);
            this.email_tb.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email :";
            // 
            // adress_tb
            // 
            this.adress_tb.Location = new System.Drawing.Point(75, 203);
            this.adress_tb.Name = "adress_tb";
            this.adress_tb.Size = new System.Drawing.Size(205, 20);
            this.adress_tb.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address :";
            // 
            // comment_tb
            // 
            this.comment_tb.Location = new System.Drawing.Point(75, 229);
            this.comment_tb.Name = "comment_tb";
            this.comment_tb.Size = new System.Drawing.Size(205, 20);
            this.comment_tb.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Comment:";
            // 
            // Reg_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 406);
            this.Controls.Add(this.info_gBox);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Reg_Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reg_Data";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Reg_Data_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.info_gBox.ResumeLayout(false);
            this.info_gBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Info_Button;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.GroupBox info_gBox;
        private System.Windows.Forms.TextBox comment_tb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox adress_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cell_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tel_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Last_N_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox First_N_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID_tb;
        private System.Windows.Forms.Label label1;
    }
}