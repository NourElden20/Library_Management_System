namespace Library_Management_System.Customer_Folder
{
    partial class CustomerShowAllBooks
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
            this.Btn_ShowAvailableBooks = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_ShowAvailableBooks
            // 
            this.Btn_ShowAvailableBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ShowAvailableBooks.Location = new System.Drawing.Point(95, 388);
            this.Btn_ShowAvailableBooks.Name = "Btn_ShowAvailableBooks";
            this.Btn_ShowAvailableBooks.Size = new System.Drawing.Size(217, 50);
            this.Btn_ShowAvailableBooks.TabIndex = 38;
            this.Btn_ShowAvailableBooks.Text = "Show Available Books";
            this.Btn_ShowAvailableBooks.UseVisualStyleBackColor = true;
            this.Btn_ShowAvailableBooks.Click += new System.EventHandler(this.Btn_ShowAvailableBooks_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 94);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(611, 271);
            this.textBox1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(288, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 38);
            this.label1.TabIndex = 36;
            this.label1.Text = "Show All Books";
            // 
            // Btn_Back
            // 
            this.Btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.Location = new System.Drawing.Point(584, 388);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(122, 50);
            this.Btn_Back.TabIndex = 39;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            // 
            // CustomerShowAllBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_ShowAvailableBooks);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "CustomerShowAllBooks";
            this.Text = "CustomerShowAllBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_ShowAvailableBooks;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Back;
    }
}