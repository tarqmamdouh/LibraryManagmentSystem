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
    public partial class Search : Form
    {
        List<Book> book = new List<Book>();
        User user;
        public Search(User U)
        {
            user = U;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (book.Count != 0)
                {
                    book.Clear();
                }
                book = user.SearchForBookByCat(comboBox1.Text.ToString());
                SR.Items.Clear();
                foreach (Book item in book)
                {
                    SR.Items.Add(item.Title.ToString());
                }
            }
            catch(NullReferenceException)
            {
                SR.Items.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (book.Count != 0)
                {
                    book.Clear();
                }
                book = user.SearchForBookByName(textBox1.Text);
                SR.Items.Clear();
                foreach (Book item in book)
                {
                    SR.Items.Add(item.Title.ToString());
                }
            }
            catch
            {
                SR.Items.Clear();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int indx = SR.SelectedIndex;
                Form F = new View(book[indx] , (User)user);
                F.Show();
            }
            catch
            {

            }

        }

        private void Search_Load(object sender, EventArgs e)
        {

        }
    }
}
