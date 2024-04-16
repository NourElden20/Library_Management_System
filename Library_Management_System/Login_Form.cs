//using lastgui;
//using library_system.Properties;
//using Array = lastgui.Array;
using System;
using System.Windows.Forms;
using System.Drawing;
namespace Library_Management_System
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void logincli_Click(object sender, EventArgs e)
        {

        }

        private void registercli_Click(object sender, EventArgs e)
        {





        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void registerform11_Load(object sender, EventArgs e)
        {

        }

        private void registerform1_Load(object sender, EventArgs e)
        {

        }

        private void loginform1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Librarian_Click(object sender, EventArgs e)
        {
            /*if (Array.Find(Etext1.Text, Ptext1.Text))
            {
                MessageBox.Show($"Welcome,{Etext1.Text}", "Hello", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                string s = Etext1.Text;
               // librForm form3 = new librForm();
                //form3.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Invalid Email or password", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }*/
        }

        private void Btn_Customer_Click(object sender, EventArgs e)
        {/*
            if (Array.Find(Etext1.Text, Ptext1.Text))
            {
                MessageBox.Show($"Welcome,{Etext1.Text}", "Hello", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                string s = Etext1.Text;
              //  custform form2 = new custform();
               // form2.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Invalid Email or password", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            */
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
          //  Regisform form = new Regisform();
          //  form.ShowDialog();
            this.Close();
        }
    }
}