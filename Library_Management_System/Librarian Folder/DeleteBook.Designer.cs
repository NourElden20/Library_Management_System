namespace Library_Management_System.Librarian_Folder
{
    partial class DeleteBook
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
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ID_lbl = new System.Windows.Forms.Label();
            this.Txt_BookName = new System.Windows.Forms.TextBox();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.labbook = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Location = new System.Drawing.Point(39, 220);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(122, 50);
            this.Btn_Delete.TabIndex = 34;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            // 
            // Btn_Back
            // 
            this.Btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.Location = new System.Drawing.Point(382, 220);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(122, 50);
            this.Btn_Back.TabIndex = 33;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(175, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 38);
            this.label1.TabIndex = 32;
            this.label1.Text = "Delete Book";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.ID_lbl);
            this.groupBox1.Controls.Add(this.Txt_BookName);
            this.groupBox1.Controls.Add(this.Txt_ID);
            this.groupBox1.Controls.Add(this.labbook);
            this.groupBox1.Location = new System.Drawing.Point(39, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(465, 109);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // ID_lbl
            // 
            this.ID_lbl.AutoSize = true;
            this.ID_lbl.BackColor = System.Drawing.Color.Transparent;
            this.ID_lbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.ID_lbl.Location = new System.Drawing.Point(0, 58);
            this.ID_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID_lbl.Name = "ID_lbl";
            this.ID_lbl.Size = new System.Drawing.Size(32, 25);
            this.ID_lbl.TabIndex = 22;
            this.ID_lbl.Text = "ID";
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
            // Txt_ID
            // 
            this.Txt_ID.Location = new System.Drawing.Point(170, 58);
            this.Txt_ID.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_ID.Multiline = true;
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(271, 22);
            this.Txt_ID.TabIndex = 15;
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
            // DeleteBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 301);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "DeleteBook";
            this.Text = "DeleteBook";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ID_lbl;
        private System.Windows.Forms.TextBox Txt_BookName;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Label labbook;
    }
}