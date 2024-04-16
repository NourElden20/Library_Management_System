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

        private void Purchase_Click(object sender, EventArgs e)
        {
            
        }
     
        private void Borrow_Click(object sender, EventArgs e)
        {
            
        }

        private void ShowAvailableBooks_Click(object sender, EventArgs e)
        {
            BtnBorrow.Visible = false;
            Btn_purchase.Visible = false;

        }

        

        
    }
}
