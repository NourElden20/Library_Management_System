using Library_Management_System.Librarian_Folder;
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
    public partial class LibrarianForm : Form
    {
        public LibrarianForm()
        {
            InitializeComponent();
           
        }    
        private void Btn_AddNewBook_Click(object sender, EventArgs e)
        {
            AddNewBookForm form = new AddNewBookForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Btn_DeleteBook_Click(object sender, EventArgs e)
        {
            DeleteBook form = new DeleteBook();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Btn_ShowAllBooks_Click(object sender, EventArgs e)
        {
            ShowAllBooks form = new ShowAllBooks();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Btn_UpdateBook_Click(object sender, EventArgs e)
        {
            UpdateBook form = new UpdateBook();
            this.Hide();
            form.ShowDialog();
            this.Close ();
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            Login_Form form = new Login_Form();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Login_Form form = new Login_Form();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void LibrarianForm_Load(object sender, EventArgs e)
        {

        }
    }
}
