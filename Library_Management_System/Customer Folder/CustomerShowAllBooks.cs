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
            MyFile.ShowFile(@"AvailableBooksCustomer.txt", textBox1);
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
