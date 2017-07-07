using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Login : Form
        
    {
        Pearson P = new User("15", "15", "15", "15", "15", "15");
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new Registeration();
            f.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var F = new Form();
            F = P.Login(UserNameTxt.Text, PasswordTxt.Text);
            if (F != null)
            {
                F.Show();
                this.Hide();
            }

        }
    }
}
