using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    partial class LibrarianForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianForm));
            this.Btn_UpdateBook = new System.Windows.Forms.Button();
            this.Btn_ShowAllBooks = new System.Windows.Forms.Button();
            this.Btn_Logout = new System.Windows.Forms.Button();
            this.Btn_DeleteBook = new System.Windows.Forms.Button();
            this.Btn_AddNewBook = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_UpdateBook
            // 
            this.Btn_UpdateBook.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_UpdateBook.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.Btn_UpdateBook.Location = new System.Drawing.Point(101, 224);
            this.Btn_UpdateBook.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_UpdateBook.Name = "Btn_UpdateBook";
            this.Btn_UpdateBook.Size = new System.Drawing.Size(162, 40);
            this.Btn_UpdateBook.TabIndex = 5;
            this.Btn_UpdateBook.Text = "UpdateBook";
            this.Btn_UpdateBook.UseVisualStyleBackColor = false;
            this.Btn_UpdateBook.Click += new System.EventHandler(this.Btn_UpdateBook_Click);
            // 
            // Btn_ShowAllBooks
            // 
            this.Btn_ShowAllBooks.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_ShowAllBooks.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.Btn_ShowAllBooks.Location = new System.Drawing.Point(101, 349);
            this.Btn_ShowAllBooks.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ShowAllBooks.Name = "Btn_ShowAllBooks";
            this.Btn_ShowAllBooks.Size = new System.Drawing.Size(162, 39);
            this.Btn_ShowAllBooks.TabIndex = 4;
            this.Btn_ShowAllBooks.Text = "ShowAllBooks";
            this.Btn_ShowAllBooks.UseVisualStyleBackColor = false;
            this.Btn_ShowAllBooks.Click += new System.EventHandler(this.Btn_ShowAllBooks_Click);
            // 
            // Btn_Logout
            // 
            this.Btn_Logout.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Logout.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.Btn_Logout.Location = new System.Drawing.Point(101, 417);
            this.Btn_Logout.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Logout.Name = "Btn_Logout";
            this.Btn_Logout.Size = new System.Drawing.Size(162, 39);
            this.Btn_Logout.TabIndex = 3;
            this.Btn_Logout.Text = "Logout";
            this.Btn_Logout.UseVisualStyleBackColor = false;
            this.Btn_Logout.Click += new System.EventHandler(this.Btn_Logout_Click);
            // 
            // Btn_DeleteBook
            // 
            this.Btn_DeleteBook.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_DeleteBook.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.Btn_DeleteBook.Location = new System.Drawing.Point(101, 286);
            this.Btn_DeleteBook.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_DeleteBook.Name = "Btn_DeleteBook";
            this.Btn_DeleteBook.Size = new System.Drawing.Size(162, 39);
            this.Btn_DeleteBook.TabIndex = 2;
            this.Btn_DeleteBook.Text = "DeleteBook";
            this.Btn_DeleteBook.UseVisualStyleBackColor = false;
            this.Btn_DeleteBook.Click += new System.EventHandler(this.Btn_DeleteBook_Click);
            // 
            // Btn_AddNewBook
            // 
            this.Btn_AddNewBook.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_AddNewBook.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.Btn_AddNewBook.Location = new System.Drawing.Point(101, 164);
            this.Btn_AddNewBook.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_AddNewBook.Name = "Btn_AddNewBook";
            this.Btn_AddNewBook.Size = new System.Drawing.Size(162, 39);
            this.Btn_AddNewBook.TabIndex = 1;
            this.Btn_AddNewBook.Text = "AddNewBook";
            this.Btn_AddNewBook.UseVisualStyleBackColor = false;
            this.Btn_AddNewBook.Click += new System.EventHandler(this.Btn_AddNewBook_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Back
            // 
            this.Btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.Location = new System.Drawing.Point(101, 461);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(162, 41);
            this.Btn_Back.TabIndex = 25;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // LibrarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 514);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_UpdateBook);
            this.Controls.Add(this.Btn_ShowAllBooks);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Logout);
            this.Controls.Add(this.Btn_AddNewBook);
            this.Controls.Add(this.Btn_DeleteBook);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LibrarianForm";
            this.Text = "LibrarianForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button Btn_UpdateBook;
        private Button Btn_ShowAllBooks;
        private Button Btn_Logout;
        private Button Btn_DeleteBook;
        private Button Btn_AddNewBook;
        private PictureBox pictureBox1;
        private Button Btn_Back;
    }
}