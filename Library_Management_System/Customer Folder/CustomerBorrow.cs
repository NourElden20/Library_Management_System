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
    public partial class CustomerBorrow : Form
    {
        public CustomerBorrow()
        {
            InitializeComponent();
        }

        private void Btn_Borrow_Click(object sender, EventArgs e)
        {
            Library.BorrowBook(Txt_BookName.Text);
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
