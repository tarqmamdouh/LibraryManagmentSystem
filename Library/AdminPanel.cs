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
    public partial class AdminPanel : Form
    {

        
        Admin owner ;
        List<Book> current = new List<Book>();
        List<User> users = new List<User>();
        List<User> blockedUsers = new List<User>();
        public AdminPanel(Admin p)
        {
            owner = p;
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

            current = owner.CurrentBooks();
            try
            {
                foreach (Book B in current)
                {
                    CB.Items.Add(B.Title);
                }
            }
            catch
            {
                MessageBox.Show("No books added yet!");
            }


            
            try
            {
                owner.fill_users(users , blockedUsers);
                foreach (User U in users)
                {
                   
                    CU.Items.Add(U.FirstName + " " + U.LastName);
                }
                if (blockedUsers.Count != 0)
                {
                    foreach (User U in blockedUsers)
                    {
                        ListBLockedUSers.Items.Add(U.FirstName + " " + U.LastName);
                    }
                }
            }
            catch
            {
                MessageBox.Show("mafesh users!!");
            }


        }

        private void ANB_Click(object sender, EventArgs e)
        {
            Form a = new Add_book(owner);
            a.ShowDialog();
            this.Close();
            this.Refresh();
            
        }

        private void SFB_Click(object sender, EventArgs e)
        {
            Form q = new Search_For_book(owner);
            q.ShowDialog();
            this.Refresh();
            this.Close();
        }

        private void RB_Click(object sender, EventArgs e)
        {
            try
            {

                int indx = CB.SelectedIndex;
                owner.RemoveBook(current[indx].ISBN);
                CB.Items.RemoveAt(indx);
            }
            catch
            {
                MessageBox.Show("No Books To Remove");
            }
        }

        private void BU_Click(object sender, EventArgs e)
        {
            try
            {

                int indx = CU.SelectedIndex;
                owner.BlockUser(users[indx].UserName);
                ListBLockedUSers.Items.Add(CU.SelectedItem);
                CU.Items.RemoveAt(indx);
                blockedUsers.Add(users[indx]);
                users.RemoveAt(indx);

            }
            catch
            {
                MessageBox.Show("No Users To Block");
           }
        }

        private void RU_Click(object sender, EventArgs e)
        {
            try
            {
                int indx = ListBLockedUSers.SelectedIndex;
                owner.unBlocked(blockedUsers[indx].UserName);
                CU.Items.Add(ListBLockedUSers.SelectedItem);
                ListBLockedUSers.Items.RemoveAt(indx);
                users.Add(blockedUsers[indx]);
                blockedUsers.RemoveAt(indx);
            }
            catch
            {
                MessageBox.Show("Operation Fail");
            }

        }

        private void SFU_Click(object sender, EventArgs e)
        {
            Search_for_user S = new Search_for_user();
            S.ShowDialog();
        }

        private void PR_Click(object sender, EventArgs e)
        {
            pending_requests P = new pending_requests(owner);
            P.ShowDialog();

        }
    }
}
