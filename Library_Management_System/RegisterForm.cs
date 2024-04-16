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
    public partial class RegisterForm : Form
    {

        public RegisterForm()
        {
            InitializeComponent();
           
        }

       

      

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            if (Txt_Password.Text.Length < 8)
            {
                MessageBox.Show("Too small password", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            if(UI.Login(Txt_Mail.Text, Txt_Password.Text) == "Librarian" || UI.Login(Txt_Mail.Text, Txt_Password.Text) == "Customer")
            {
                MessageBox.Show("Account already registered", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }


        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Login_Form form = new Login_Form();
            this.Hide();
            form.ShowDialog();
            this.Close();

        }
    }
}
