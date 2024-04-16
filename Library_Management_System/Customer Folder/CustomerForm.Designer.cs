using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Library_Management_System
{
    partial class CustomerForm : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.Btn_Logout = new System.Windows.Forms.Button();
            this.Btn_Show = new System.Windows.Forms.Button();
            this.Btn_Borrow = new System.Windows.Forms.Button();
            this.Btn_purchase = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Logout
            // 
            this.Btn_Logout.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Logout.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Btn_Logout.Location = new System.Drawing.Point(79, 388);
            this.Btn_Logout.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Logout.Name = "Btn_Logout";
            this.Btn_Logout.Size = new System.Drawing.Size(173, 44);
            this.Btn_Logout.TabIndex = 28;
            this.Btn_Logout.Text = "Logout";
            this.Btn_Logout.UseVisualStyleBackColor = false;
            this.Btn_Logout.Click += new System.EventHandler(this.Btn_Logout_Click);
            // 
            // Btn_Show
            // 
            this.Btn_Show.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Show.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Show.Location = new System.Drawing.Point(79, 271);
            this.Btn_Show.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Show.Name = "Btn_Show";
            this.Btn_Show.Size = new System.Drawing.Size(173, 54);
            this.Btn_Show.TabIndex = 27;
            this.Btn_Show.Text = "Show Available Books";
            this.Btn_Show.UseVisualStyleBackColor = false;
            this.Btn_Show.Click += new System.EventHandler(this.Btn_Show_Click);
            // 
            // Btn_Borrow
            // 
            this.Btn_Borrow.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Borrow.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Btn_Borrow.Location = new System.Drawing.Point(79, 197);
            this.Btn_Borrow.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Borrow.Name = "Btn_Borrow";
            this.Btn_Borrow.Size = new System.Drawing.Size(173, 54);
            this.Btn_Borrow.TabIndex = 26;
            this.Btn_Borrow.Text = "Borrow";
            this.Btn_Borrow.UseVisualStyleBackColor = false;
            this.Btn_Borrow.Click += new System.EventHandler(this.Btn_Borrow_Click);
            // 
            // Btn_purchase
            // 
            this.Btn_purchase.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_purchase.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Btn_purchase.Location = new System.Drawing.Point(79, 127);
            this.Btn_purchase.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_purchase.Name = "Btn_purchase";
            this.Btn_purchase.Size = new System.Drawing.Size(173, 54);
            this.Btn_purchase.TabIndex = 25;
            this.Btn_purchase.Text = "Purchase";
            this.Btn_purchase.UseVisualStyleBackColor = false;
            this.Btn_purchase.Click += new System.EventHandler(this.Btn_purchase_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 479);
            this.Controls.Add(this.Btn_Logout);
            this.Controls.Add(this.Btn_Show);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Borrow);
            this.Controls.Add(this.Btn_purchase);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBox1;
        private Button Btn_Borrow;
        private Button Btn_purchase;
        private Button Btn_Logout;
        private Button Btn_Show;
    }
}