﻿namespace Library_Management_System.Customer_Folder
{
    partial class CustomerBorrow
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
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Btn_Borrow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Author = new System.Windows.Forms.TextBox();
            this.Txt_BookName = new System.Windows.Forms.TextBox();
            this.labauther = new System.Windows.Forms.Label();
            this.Txt_Pubdate = new System.Windows.Forms.TextBox();
            this.labpub = new System.Windows.Forms.Label();
            this.labbook = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Back
            // 
            this.Btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.Location = new System.Drawing.Point(416, 286);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(122, 50);
            this.Btn_Back.TabIndex = 28;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Btn_Borrow
            // 
            this.Btn_Borrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Borrow.Location = new System.Drawing.Point(73, 286);
            this.Btn_Borrow.Name = "Btn_Borrow";
            this.Btn_Borrow.Size = new System.Drawing.Size(122, 50);
            this.Btn_Borrow.TabIndex = 27;
            this.Btn_Borrow.Text = "Borrow";
            this.Btn_Borrow.UseVisualStyleBackColor = true;
            this.Btn_Borrow.Click += new System.EventHandler(this.Btn_Borrow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(222, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 38);
            this.label1.TabIndex = 26;
            this.label1.Text = "Borrow Book";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Txt_Author);
            this.groupBox1.Controls.Add(this.Txt_BookName);
            this.groupBox1.Controls.Add(this.labauther);
            this.groupBox1.Controls.Add(this.Txt_Pubdate);
            this.groupBox1.Controls.Add(this.labpub);
            this.groupBox1.Controls.Add(this.labbook);
            this.groupBox1.Location = new System.Drawing.Point(73, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(465, 164);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // Txt_Author
            // 
            this.Txt_Author.Location = new System.Drawing.Point(170, 57);
            this.Txt_Author.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Author.Multiline = true;
            this.Txt_Author.Name = "Txt_Author";
            this.Txt_Author.Size = new System.Drawing.Size(271, 22);
            this.Txt_Author.TabIndex = 21;
            // 
            // Txt_BookName
            // 
            this.Txt_BookName.Location = new System.Drawing.Point(170, 15);
            this.Txt_BookName.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_BookName.Multiline = true;
            this.Txt_BookName.Name = "Txt_BookName";
            this.Txt_BookName.Size = new System.Drawing.Size(271, 22);
            this.Txt_BookName.TabIndex = 8;
            // 
            // labauther
            // 
            this.labauther.AutoSize = true;
            this.labauther.BackColor = System.Drawing.Color.Transparent;
            this.labauther.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.labauther.Location = new System.Drawing.Point(0, 54);
            this.labauther.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labauther.Name = "labauther";
            this.labauther.Size = new System.Drawing.Size(132, 25);
            this.labauther.TabIndex = 12;
            this.labauther.Text = "Author Name";
            // 
            // Txt_Pubdate
            // 
            this.Txt_Pubdate.Location = new System.Drawing.Point(170, 107);
            this.Txt_Pubdate.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Pubdate.Multiline = true;
            this.Txt_Pubdate.Name = "Txt_Pubdate";
            this.Txt_Pubdate.Size = new System.Drawing.Size(271, 22);
            this.Txt_Pubdate.TabIndex = 13;
            // 
            // labpub
            // 
            this.labpub.AutoSize = true;
            this.labpub.BackColor = System.Drawing.Color.Transparent;
            this.labpub.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.labpub.Location = new System.Drawing.Point(0, 104);
            this.labpub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labpub.Name = "labpub";
            this.labpub.Size = new System.Drawing.Size(156, 25);
            this.labpub.TabIndex = 10;
            this.labpub.Text = "Publication year";
            // 
            // labbook
            // 
            this.labbook.AutoSize = true;
            this.labbook.BackColor = System.Drawing.Color.Transparent;
            this.labbook.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.labbook.Location = new System.Drawing.Point(-11, 15);
            this.labbook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labbook.Name = "labbook";
            this.labbook.Size = new System.Drawing.Size(136, 25);
            this.labbook.TabIndex = 11;
            this.labbook.Text = "  Book Name  ";
            // 
            // CustomerBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 381);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Borrow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerBorrow";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_Borrow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_Author;
        private System.Windows.Forms.TextBox Txt_BookName;
        private System.Windows.Forms.Label labauther;
        private System.Windows.Forms.TextBox Txt_Pubdate;
        private System.Windows.Forms.Label labpub;
        private System.Windows.Forms.Label labbook;
    }
}