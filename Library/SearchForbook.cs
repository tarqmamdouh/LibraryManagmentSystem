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
    
    public partial class Search_For_book : Form
    {
        Admin b;
        List<Book> result = new List<Book>();
        public Search_For_book(Admin wde)
        {
            b = wde;
            InitializeComponent();
        }

     

        private void Search_For_book_Load(object sender, EventArgs e)
        {
            
          

          
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            int indx = listBooks.SelectedIndex;
            b.RemoveBook(result[indx].ISBN);
            listBooks.Items.RemoveAt(indx);
        }
        private void button1_Click(object sender, EventArgs e)
        {
              try
            {
                if (result.Count != 0)
                {
                    result.Clear();
                }
                result = b.SearchForBookByName(txtSearchForBook.Text);
                listBooks.Items.Clear();
                foreach (Book item in result)
                {
                    listBooks.Items.Add(item.Title.ToString());
                }
            }
            catch
            {
                listBooks.Items.Clear();
            }
        }

        private void Search_For_book_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Search_For_book_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form w = new AdminPanel(b);
            w.Show();

        }
    }
}
