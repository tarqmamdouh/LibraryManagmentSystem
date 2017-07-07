using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Library
{
    /************************* ADD ***************************/

    public interface AdminAddition
    {
         void Add(Borrow BO , Book B , Connection c);
    }

    class AddUserToList : AdminAddition
    {
        public void Add(Borrow BO, Book B, Connection c) {
            string s = "INSERT INTO Borrow( ISBN , Login_name ,  Request_no , Borrow_date  , Return_date , Returned)  " +
           "VALUES ('" + BO.ISBN + "','" + BO.UN + "', '" + BO.RequestNum + "' ,  '" + BO.BorrowDate + "' ,  '" + BO.ReturnDate + "' ,  '" + BO.Returned + "'); ";
            SqlCommand cmd = new SqlCommand(s, c.connect);
            cmd.ExecuteNonQuery();
        }
    }

    class addBook : AdminAddition
    {
        public void Add(Borrow BO, Book B, Connection c) {
            
            string s = "INSERT INTO Books( ISBN , Title ,  Author , Publish_date , Language  , Copies , Price , Category )" +
            "VALUES ('" + B.ISBN + "','" + B.Title + "', '" + B.Author + "' ,  '" + B.publish_date + "' ,  '" + B.Language + "' ,  '" + B.NumOfCopies + "' , '" + B.Price + "' , '" + B.Category + "' ); ";
            SqlCommand cmd = new SqlCommand(s, c.connect);
            cmd.ExecuteNonQuery();
        } 
    }

    class AddUser : AdminAddition
    {
        public void Add(Borrow BO, Book B, Connection c) {
        
            string s = "INSERT INTO Borrow( ISBN , Login_name ,  Request_no , Borrow_date  , Return_date , Returned)" +
           "VALUES ('" + BO.ISBN + "','" + BO.UN + "', '" + BO.RequestNum + "' ,  '" + BO.BorrowDate + "' ,  '" + BO.ReturnDate + "' ,  '" + BO.Returned + "'); ";
            SqlCommand cmd = new SqlCommand(s, c.connect);
            cmd.ExecuteNonQuery();
        }
    }


    /************************* Remove ***************************/

    public interface AdminRemoving 
    {
         void Remove(string G , Connection c);
    }

    class RemoveUserFromlist : AdminRemoving
    {
        public void Remove(string G, Connection c) {
            string s = "DELETE FROM Borrow" +
            "where Request_no = '" + G + "'";
            SqlCommand cmd = new SqlCommand(s, c.connect);
            cmd.ExecuteNonQuery();
        }
    }

    class RemoveBook : AdminRemoving
    {
        public void Remove(string G, Connection c) {
           
            string s = "DELETE FROM Books  " +
            "where ISBN = '" + G + "'";
            SqlCommand cmd = new SqlCommand(s, c.connect);
            cmd.ExecuteNonQuery();
        }
    }

    class BlockUser : AdminRemoving
    {
        public void Remove(string G, Connection c) {
            
            string s = "UPDATE Login  " +
                       "set Block = 'Yes' " +
                      "where Login_name = '" + G + "'";
            SqlCommand cmd = new SqlCommand(s, c.connect);
            cmd.ExecuteNonQuery();
        }
    }
    

    /************************* Search ***************************/
    public interface AdminSearching 
    {
         dynamic search(string G, Connection c);
    }
    class AdminSearchBookByName : AdminSearching
    {
        public dynamic search(string G, Connection c) {
            List<Book> List = new List<Book>();
            string cm = "select * from Books where Title='" + G + "'";
            SqlCommand cmd = new SqlCommand(cm, c.connect);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Book tmp = new Book((string)rdr["ISBN"], (string)rdr["Title"], (string)rdr["Author"], (string)rdr["Category"], (string)rdr["Copies"], (string)rdr["Language"], (string)rdr["Price"], (string)rdr["Publish_date"]);
                    List.Add(tmp);
                }
                rdr.Close();
                return List;
            }
            else
            {
                return null;
            }

        }
    }
    class AdminSearchBookByCat : AdminSearching
    {
        public dynamic search(string G, Connection c)
        {
            List<Book> List = new List<Book>();
            string cm = "select * from Books where Title='" + G + "'";
            SqlCommand cmd = new SqlCommand(cm, c.connect);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Book tmp = new Book((string)rdr["ISBN"],(string)rdr["Title"], (string)rdr["Author"], (string)rdr["Category"],(string)rdr["Copies"] , (string)rdr["Language"], (string)rdr["Price"], (string)rdr["Publish_date"]);
                    List.Add(tmp);
                }
                rdr.Close();
                return List;
            }
            else
            {
                return null;
            }
        }
    }
    class AdminSearchUser : AdminSearching
    {
        public dynamic search(string G, Connection c) {
            string type;

            string s = "select * from Login where Login_name='" + G + "'";
            SqlCommand cmd = new SqlCommand(s, c.connect);
            SqlDataReader rdr = cmd.ExecuteReader();
            type = (string)rdr["Type"];
            string cm = "select * from Users where Login_name='" + G + "'";
            SqlCommand cmd2 = new SqlCommand(cm, c.connect);
            SqlDataReader rdr2 = cmd2.ExecuteReader();
            return new User(type, (string)rdr2["FirstName"], (string)rdr2["LastName"], (string)rdr2["Address"], (string)rdr2["PhoneNumber"], (string)rdr2["Email"]); ;

        }
    }

    /************************* Edit ***************************/
    public interface AdminEditing
    {
         void Edit(Book B, Connection c);
    }
    class EditBook : AdminEditing
    {
        public void Edit(Book B, Connection c)
        {
                 string s = "UPDATE Books" +
                "set Title = '" + B.Title + "' , Author = '" + B.Author + "'  , Publish_date = '" + B.publish_date + "'  , Language ='" + B.Language + "'  , Copies = '" + B.NumOfCopies + "' , Price = '" + B.Price + "' , Category = '" + B.Category + "' " +
                "where ISBN = '" + B.ISBN + "'";
                 SqlCommand cmd = new SqlCommand(s, c.connect);
            cmd.ExecuteNonQuery();
        } 
    }
}
