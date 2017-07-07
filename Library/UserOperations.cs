using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Library
{
    /************************* ADD ***************************/
    public interface UserAddition
    {
        void add(Request obj , Connection c);
    }

    class AddRequest : UserAddition
    {
        public void add(Request R, Connection c) {
            string s = "INSERT INTO Requests( Request_date ,  Login_name , ISBN  , Due_date , Status)  " +
               "VALUES ('" + R.RequestDate + "', '" + R.UserName + "' ,  '" + R.ISBN + "' ,  '" + R.DueDate + "' ,  'Pending' ); ";
            SqlCommand cmd = new SqlCommand(s, c.connect);
            cmd.ExecuteNonQuery();
        }
    }

    /************************* Remove ***************************/
    public interface UserRemoving
    {
        void Remove(string obj , Connection c);
    }

    class RemoveSelfFromList : UserRemoving
    {
        public void Remove(string RequestNum, Connection c) {
            string s = "DELETE FROM Borrow  " +
            "where Request_no = '" + RequestNum + "'";
            SqlCommand cmd = new SqlCommand(s, c.connect);
            cmd.ExecuteNonQuery();
        }
    }

    class RemoveRequest : UserRemoving
    {
        public void Remove(string RequestNum, Connection c)
        {
            string s = "DELETE FROM Requests " +
            "where Request_no = '" + RequestNum + "'";
            SqlCommand cmd = new SqlCommand(s, c.connect);
            cmd.ExecuteNonQuery();
        } 
    }

    /************************* Search ***************************/
    public interface UserSearching
    {
        dynamic search(string G , Connection c);
    }

    class userSearchUser : UserSearching
    {
        public dynamic search(string UserName, Connection c)
        {
                string type;
                string s = "select * from Login where Login_name='" + UserName + "'";
                SqlCommand cmd = new SqlCommand(s , c.connect);
                SqlDataReader rdr = cmd.ExecuteReader();
                type = (string)rdr["Type"];
                string cm = "select * from Users where Login_name='" + UserName + "'";
                SqlCommand cmd2 = new SqlCommand(cm , c.connect);
                SqlDataReader rdr2 = cmd2.ExecuteReader();
                return new User(type, (string)rdr2["FirstName"], (string)rdr2["LastName"], (string)rdr2["Address"], (string)rdr2["PhoneNumber"], (string)rdr2["Email"]); ;
        }
    }

    class userSearchBookByName : UserSearching
    {
        public dynamic search(string name, Connection c)
        {
            List<Book> List = new List<Book>();
            string cm = "select * from Books where Title='" + name + "'";
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

    class userSearchBookByCat : UserSearching
    {
        public dynamic search(string Cat, Connection c)
        {
            List<Book> List = new List<Book>();
            string cm = "select * from Books where Category='" + Cat + "'";
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

}
