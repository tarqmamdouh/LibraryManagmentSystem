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
    public partial class Edit_profile : Form
    {
        Pearson user;
        public Edit_profile(Pearson user1)
        {
            InitializeComponent();
            user = user1;
        }

        private void Edit_profile_Load(object sender, EventArgs e)
        {
            FN.Text = user.FirstName;
            LN.Text = user.LastName;
            Email.Text = user.Email;
            Phone.Text = user.Phone;
            string all = user.Adress;
            string[] tokens = all.Split(',');
            Country.Text = tokens[0];
            City.Text = tokens[1];
        }


        private void Chg_Click(object sender, EventArgs e)
        {
            if ((NewPw.Text != "" && CPw.Text != "" && RepNewPw.Text != ""))
            {
                if (CPw.Text == user.Password)
                {
                    if (NewPw.Text == RepNewPw.Text)
                    {
                        user.ChangePw(user.UserName, NewPw.Text);
                    }
                    else
                    {
                        MessageBox.Show("Password Missmatch", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                     MessageBox.Show("Password INCORECCT", "INCORECCT", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            else
            {
                MessageBox.Show("Fields is Empty", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void EditBtn_Click_1(object sender, EventArgs e)
        {
            string address = Country.Text.ToString() + "," + City.Text.ToString();
            User user2 = new User(user.UserName, NewPw.Text, "User", FN.Text, LN.Text, address, Phone.Text, Email.Text);
            user.EditProfille(user2);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = @"C:\";
            ofd.Title = "Browse For Profile Photo";

            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            ofd.DefaultExt = "JPG";
            ofd.Filter = "Image files (jpg , png , jpeg)|*.png|*.jpeg|*.jpg";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;

            ofd.ReadOnlyChecked = true;
            ofd.ShowReadOnly = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image file = Image.FromFile(ofd.FileName);
                PB.BackgroundImage = file;
                //path = Path.GetFullPath(ofd.FileName);
                //image = true;
            }
        }
    }
}
