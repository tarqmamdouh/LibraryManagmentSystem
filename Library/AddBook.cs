using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient; 

namespace Library
{
    public partial class Add_book : Form
    {
        Admin a;
        public Add_book(Admin aa)
        {
            a = aa;
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtISBN.Text == "" || txtBookName.Text == "" || txtAuthor.Text == "" || cmbCategory.Text == "" || txtCopies.Text == "" || txtLanguage.Text == "" || txtPrice.Text == "" || txtDate.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
            }
            else
            {
                if (a.BookExist(txtISBN.Text))
                {
                    MessageBox.Show("Book ISBN already exist.");
                }
                else {
                    Book newBook = new Book(txtISBN.Text, txtBookName.Text, txtAuthor.Text, cmbCategory.Text, txtCopies.Text, txtLanguage.Text, txtPrice.Text, txtDate.Text);
                    a.AddBook(newBook);

                    this.Close();
                }

                
            }



            
        }
        private void Add_book_Load(object sender, EventArgs e)
        {

        }
    }
}
