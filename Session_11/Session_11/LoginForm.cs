using SecurityLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Session_11
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }
        private void Authenticate()
        {
            Credentials credentials = new Credentials();
            credentials.Username = textBox1.Text;
            credentials.Password = textBox2.Text;

            if (credentials.Auth())
            {
                ManagerForm managerForm = new ManagerForm();
                managerForm.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password, please try again.", "Try Again");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authenticate();
           
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Authenticate();
            }
        }

        private void CancelButtonManager_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This window will close now", "Cancel");
            this.Close();
        }
    }
}
