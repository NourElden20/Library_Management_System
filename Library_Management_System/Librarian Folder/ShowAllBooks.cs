using Library_Management_System.Classes;
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
    public partial class ShowAllBooks : Form
    {
        public ShowAllBooks()
        {
            InitializeComponent();
        }

        private void Btn_ShowAvailableBooks_Click(object sender, EventArgs e)
        {
            MyFile.ShowFile(@"AvailableBooks.txt", textBox1);
        }
    }
}
