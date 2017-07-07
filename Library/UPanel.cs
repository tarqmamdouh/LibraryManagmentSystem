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
    public partial class UPanel : Form
    {
        User Owner;
        List<Book> LOB = new List<Book>();
        public UPanel(User P)
        {
            Owner = P;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form r = new Edit_profile(Owner);
            r.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f = new Search((User)Owner);
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indx = CB.SelectedIndex;
            Form a = new View(LOB[indx],Owner);
            a.ShowDialog();
            a.Dispose();
        }

        private void UPanel_Load(object sender, EventArgs e)
        {
            NameLbl.Text = Owner.FirstName + " " + Owner.LastName;
            LOB = Owner.CurrentBooks();
            foreach(Book B in LOB)
            {
                CB.Items.Add(B.Title);
            }

        }
    }
}
