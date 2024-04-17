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
    public partial class CustomerPurchaseForm : Form
    {
        public CustomerPurchaseForm()
        {
            InitializeComponent();
        }

        private void Btn_Purchase_Click(object sender, EventArgs e)
        {
            Library.PurchaseBook(Txt_BookName.Text, int.Parse(Txt_Quantity.Text));
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
