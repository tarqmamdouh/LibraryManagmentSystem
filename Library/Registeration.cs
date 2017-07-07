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
    public partial class Registeration : Form
    {
        Pearson P = new User("15", "15", "15", "15", "15", "15");
        public int RgCoun = 0;
        string ADD;
        bool okay = false;
        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (tick.Visible == true)
            {
                tick.Visible = false;
                btnCheck.Visible = true;
            }
            else if (Cross.Visible == true)
            {
                btnCheck.Visible = true;
                Cross.Visible = false;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "")
            {
                if (!P.UserExist(txtUser.Text))
                {
                    btnCheck.Visible = false;
                    tick.Visible = true;
                }
                else
                {
                    btnCheck.Visible = false;
                    Cross.Visible = true;
                }
            }

        }

        public Registeration()
        {
            InitializeComponent();
        }

        private void Registeration_Load(object sender, EventArgs e)
        {
            lblFN.Visible = true;
            lblLN.Visible = true;
            txtFN.Visible = true;
            txtLN.Visible = true;

            lblEmail.Visible = false;
            lblPhone.Visible = false;
            txtEmail.Visible = false;
            txtPhone.Visible = false;


            lblCountry.Visible = false;
            lblCity.Visible = false;
            cmbCity.Visible = false;
            cmbCountry.Visible = false;

            lblUser.Visible = false;
            lblPW.Visible = false;
            lblrp.Visible = false;
            txtUser.Visible = false;
            txtPW.Visible = false;
            txtrp.Visible = false;
            btnCheck.Visible = false;
            tick.Visible = false;
            Cross.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           if (RgCoun == 0)
            {
                if (txtFN.Text != "" && txtLN.Text != "")
                {
                lblEmail.Visible = true;
                lblPhone.Visible = true;
                txtEmail.Visible = true;
                txtPhone.Visible = true;

                lblFN.Visible = false;
                lblLN.Visible = false;
                txtFN.Visible = false;
                txtLN.Visible = false;

                    RgCoun++;
                }

            }
            else if (RgCoun == 1)
            {
                if (txtEmail.Text != "" && txtPhone.Text != "")
                {
                    lblEmail.Visible = false;
                    lblPhone.Visible = false;
                    txtEmail.Visible = false;
                    txtPhone.Visible = false;

                    lblCountry.Visible = true;
                    lblCity.Visible = true;
                    cmbCity.Visible = true;
                    cmbCountry.Visible = true;
                    RgCoun++;
                }
            }
            else if (RgCoun == 2)
            {
                if (cmbCity.Text != "" && cmbCountry.Text != "")
                {
                    lblCountry.Visible = false;
                    lblCity.Visible = false;
                    cmbCity.Visible = false;
                    cmbCountry.Visible = false;

                    lblUser.Visible = true;
                    lblPW.Visible = true;
                    lblrp.Visible = true;
                    txtUser.Visible = true;
                    txtPW.Visible = true;
                    txtrp.Visible = true;
                    btnCheck.Visible = true;
                    RgCoun++;
                    btnNext.Text = "Finish";
                }
            }
            else if (RgCoun == 3)
            {
                if (txtUser.Text != "" && txtPW.Text != "" && txtrp.Text != "")
                {
                    if (tick.Visible && txtPW.Text == txtrp.Text)
                    {
                        ADD = cmbCity.Text + "," + cmbCountry.Text;
                        Pearson n = new User(txtUser.Text,txtPW.Text,cmbType.Text,txtFN.Text,txtLN.Text,ADD,txtPhone.Text,txtEmail.Text);
                        P.Register(n);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password Mismatch or the user already exists , have you checked the user name ?", "Register Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }

        }
    }
}
