using Library_Management_System.Customer_Folder;
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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

         
        private void Btn_Borrow_Click(object sender, EventArgs e)
        {
            CustomerBorrow form = new CustomerBorrow();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Btn_Show_Click(object sender, EventArgs e)
        {
            CustomerShowAllBooks form = new CustomerShowAllBooks();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Btn_purchase_Click(object sender, EventArgs e)
        {
          CustomerPurchaseForm form = new CustomerPurchaseForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            Login_Form form = new Login_Form();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
