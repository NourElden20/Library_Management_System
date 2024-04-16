using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.Librarian_Folder
{
    public partial class DeleteBook : Form
    {
        public DeleteBook()
        {
            InitializeComponent();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Library.RemoveBook(int.Parse(Txt_ID.Text));
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            LibrarianForm librarianForm = new LibrarianForm();
            this.Hide();
            librarianForm.ShowDialog();
            this.Close();
        }
    }
}
