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
    public partial class pending_requests : Form
    {
        List<Request> LR = new List<Request>();
        Admin op;
        public pending_requests(Admin o)
        {
            InitializeComponent();
            op = o;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RD.Text != "")
            {
                try
                {
                    int i = PR.SelectedIndex;
                    op.RequestStatus("Approved", LR[i].Request_Num);
                    Borrow tmp = new Borrow(LR[i].ISBN, LR[i].UserName, LR[i].Request_Num, LR[i].DueDate, RD.Text, "Pending");
                    op.Userinlist(tmp);
                    LR.RemoveAt(i);
                    PR.Items.RemoveAt(i);
                }
                catch
                {
                    MessageBox.Show("Invalid or No Request to approve");
                }

            }
            else
            {
                MessageBox.Show("To Approve Requests You Must enter The Return Date");
            }

            
        }

        private void pending_requests_Load(object sender, EventArgs e)
        {
            LR = op.Pendings();
            if(LR.Count >0)
            {
                foreach(Request R in LR)
                {
                    PR.Items.Add(R.UserName + " Has Requested " + op.NameByISBN(R.ISBN));
                }
            }
        }

        private void Dec_Click(object sender, EventArgs e)
        {
                try
                {
                    int i = PR.SelectedIndex;
                    op.RequestStatus("Declined", LR[i].Request_Num);
                    LR.RemoveAt(i);
                    PR.Items.RemoveAt(i);
                }
                catch
                {
                    MessageBox.Show("Invalid or No Request to Decline");
                }

            


        }
    }
}
