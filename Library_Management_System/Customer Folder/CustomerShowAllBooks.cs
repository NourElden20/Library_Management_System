using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.Customer_Folder
{
    public partial class CustomerShowAllBooks : Form
    {
        public CustomerShowAllBooks()
        {
            InitializeComponent();
        }

        private void Btn_ShowAvailableBooks_Click(object sender, EventArgs e)
        {
            textBox1.Text = Library.AvailableBooks.ToString();
        }
    }
}
