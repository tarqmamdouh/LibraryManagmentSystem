using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Library
{
    public partial class View : Form
    {
        Book B = new Book();
        User p = new User();
        public View(Book B , User U)
        {
            InitializeComponent();
            this.B = B;
            p = U;
            CR.Visible = false;
            Info.Visible = false;
            RSFL.Visible = false;
            string S = p.Stat(p.UserName , B.ISBN);
            if (S == "Approved")
            {
                Pending.Visible = false;
                Approved.Visible = true;
                RB.Visible = false;
                Info.Text = "Your Request Has Been Approved , You Are Now on The List \n You Have To Return The Book Before " + p.ReturningDate(B.ISBN);
                Info.Visible = true;
                RSFL.Visible = true;
            }
            else if (S == "Pending")
            {
                Pending.Visible = true;
                Approved.Visible = false;
                RB.Visible = false;
                CR.Visible = true;
                Info.Text = "Request Has Been Sent , Waiting For The Librarian Approval";
                Info.Visible = true;
            }
            else
            {
                Pending.Visible = false;
                Approved.Visible = false;
                RB.Visible = true;
            }
            BN.Text = B.Title;
            Author.Text = B.Author;
            Cat.Text = B.Category;
            Author.Text = B.Author;
            Lang.Text = B.Language;
            Price.Text = B.Price;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RB_Click(object sender, EventArgs e)
        {
              DateTime CurrDate  = new DateTime();
              DateTime DueDate = new DateTime();
                CurrDate = DateTime.Now;
                DueDate = CurrDate.AddDays(2);
                string CD = CurrDate.ToString("M/d/yyyy");
                string DD = DueDate.ToString("M/d/yyyy");
                Request RR = new Request(p.UserName,B.ISBN,DD,CD,"Pending");
               p.RequestBook(RR);
               RB.Visible = false;
               Pending.Visible = true;
               Info.Visible = true;
               CR.Visible = true;
               Info.Text = "Request Has Been Sent , Waiting For The Librarian Approval";
        }

        private void View_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void Author_Click(object sender, EventArgs e)
        {

        }

        private void CR_Click(object sender, EventArgs e)
        {
            p.RemoveRequest(p.getReqNum(B.ISBN).ToString());
            Info.Visible = false;
            CR.Visible = false;
            RB.Visible = true;
            Pending.Visible = false;
        }

        private void RSFL_Click(object sender, EventArgs e)
        {
            p.RemoveRequest(p.getReqNum(B.ISBN).ToString());
            p.RemoveFromList(p.getReqNum(B.ISBN).ToString());
            Info.Visible = false;
            RSFL.Visible = false;
            RB.Visible = true;
            Approved.Visible = false;
        }
    }
}
