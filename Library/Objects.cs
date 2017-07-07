using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{
   public abstract class Pearson
    {
        public string UserName;
        public string Password { get; set; }
        protected string Type;
        public string FirstName;
        public string LastName;
        public string Adress;
        public string Phone;
        public string Email;
        protected Connection con;
        protected Operation op;
        public Pearson()
        {
            con = Connection.getInstance();
            op = new OperationCreator();
        }
        public Form Login(string UN,string PW) {
            string c = "select * from Login where Login_name='" + UN + "' And Password = '" + PW + "'";
            SqlCommand cmd = new SqlCommand(c , con.connect);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                if (rdr.Read())
                {
                    if ((string)rdr["Type"] == "Admin")
                    {
                        c = "select * from Users where Login_name='" + UN + "'";
                        SqlCommand cmd2 = new SqlCommand(c, con.connect);
                        rdr.Close();
                        SqlDataReader rdr2 = cmd2.ExecuteReader();
                        while (rdr2.Read())
                        {
                            Admin tmp = new Admin((string)rdr2["Login_name"], PW, "Admin", (string)rdr2["FirstName"], (string)rdr2["LastName"], (string)rdr2["Address"], (string)rdr2["PhoneNumber"], (string)rdr2["Email"]);
                            rdr2.Close();
                            return new AdminPanel(tmp);
                        }
                     }
                    else
                    {
                        if ((string)rdr["Block"] == "Yes")
                        {
                            rdr.Close();
                            return new Blocked();
                        }
                        else
                        {
                            c = "select * from Users where Login_name='" + UN + "'";
                            SqlCommand cmd2 = new SqlCommand(c, con.connect);
                            rdr.Close();
                            SqlDataReader rdr2 = cmd2.ExecuteReader();
                            while (rdr2.Read())
                            {
                                User tmp = new User((string)rdr2["Login_name"], PW, "User", (string)rdr2["FirstName"], (string)rdr2["LastName"], (string)rdr2["Address"], (string)rdr2["PhoneNumber"], (string)rdr2["Email"]);
                                rdr2.Close();
                                return new UPanel(tmp);
                            }
                        }
                    }
                }
            }
            else
            {
                rdr.Close();
                MessageBox.Show("No User Name or Password Exists ! , Please Check User Name And Password Then Try Again", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return null;
        } 
        public bool UserExist(string UN) {
            string c = "select Login_name from Login where Login_name='" + UN + "'";
            SqlCommand cmd = new SqlCommand(c, con.connect);
            SqlDataReader rdr = cmd.ExecuteReader();
            if(rdr.HasRows)
            {
                rdr.Close();
                return true;
            }
            else
            {
                rdr.Close();
                return false;
            }
        }
        public void Register(Pearson p) {
            string s = "INSERT INTO Login (Login_name, Password, Block, Type)" +
                       "VALUES ('" + p.UserName + "','" + p.Password + "', 'No' , '" + p.Type + "');";
            SqlCommand cmd = new SqlCommand(s,con.connect);
            cmd.ExecuteNonQuery();
            s = "INSERT INTO Users(Login_name ,  FirstName , LastName , PhoneNumber , Address , Email ,Password, Type) " +
                "VALUES ('" + p.UserName + "','" + p.FirstName + "', '" + p.LastName + "' ,  '" + p.Phone + "' ,  '" + p.Adress + "' ,  '" + p.Email + "','"+p.Password +"', '"+ p.Type+"');";
            cmd = new SqlCommand(s,con.connect);
            cmd.ExecuteNonQuery();
        }
        public void EditProfille(Pearson p) {
            string s = "UPDATE Users  " +
                       "set FirstName = '" + p.FirstName + "' , LastName = '" + p.LastName + "'  , Email = '" + p.Email + "'  , Address = '" + p.Adress + "'  , PhoneNumber = '" + p.Phone + "'  " + 
                       "where Login_name = '" + p.UserName + "'";
            SqlCommand cmd = new SqlCommand(s, con.connect);

            cmd.ExecuteNonQuery();
        }
        public void ChangePw(string UN , string PW)
        {
            string s = "UPDATE Login" +
                       "set Password = '"+ PW +"'" +   
                       "where Login_name = '" + UN + "'";
            SqlCommand cmd = new SqlCommand(s, con.connect);
            cmd.ExecuteNonQuery();
        }
    }
    public class Admin : Pearson
    {
        public Admin(string UserName, string passWord, string Type, string firstName, string lastName, string Adress, string Phone, string Email)
        {
            this.UserName = UserName;
            this.Password = passWord;
            this.Type = Type;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Adress = Adress;
            this.Phone = Phone;
            this.Email = Email;
        }
        
        public void fill_users(List<User> U , List<User> BU)
        {


            string cm = "select * from Users where Type = 'User' ";
            SqlCommand cmd = new SqlCommand(cm, con.connect);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                   if (isBlocked((string)rdr["Login_name"]))
                    {
                        User tmp = new User((string)rdr["Login_name"], (string)rdr["Password"], (string)rdr["Type"], (string)rdr["FirstName"], (string)rdr["LastName"], (string)rdr["Address"], (string)rdr["PhoneNumber"], (string)rdr["Email"]);
                        BU.Add(tmp);
                    }
                   else
                    {
                        User tmp = new User((string)rdr["Login_name"], (string)rdr["Password"], (string)rdr["Type"], (string)rdr["FirstName"], (string)rdr["LastName"], (string)rdr["Address"], (string)rdr["PhoneNumber"], (string)rdr["Email"]);
                        U.Add(tmp);
                    }
                    
                }
                rdr.Close();
            }
        }
       
        public string NameByISBN(string ISBN)
        {
            string s = "select Title from Books where ISBN = '"+ISBN+"' ";
            SqlCommand cmd = new SqlCommand(s,con.connect);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string tmp;
                tmp = (string)rdr["Title"];
                return tmp;
            }
            return null;
        }
        public List<Request> Pendings()
        {
            List<Request> List = new List<Request>();
            string cm = "select * from Requests ";
            SqlCommand cmd = new SqlCommand(cm, con.connect);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    if ((string)rdr["Status"] == "Pending")
                    {
                        Request tmp = new Request((string)rdr["Login_name"], (string)rdr["ISBN"], (string)rdr["Due_date"], (string)rdr["Request_date"], (string)rdr["Status"]);
                        List.Add(tmp);
                    }

                }
                rdr.Close();
                return List;
            }
            else
            {
                return null;
            }
        }
        public List<Book> CurrentBooks()
        {
            List<Book> List = new List<Book>();
            string cm = "select * from Books ";
            SqlCommand cmd = new SqlCommand(cm, con.connect);
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
        public void RequestStatus(string s,string rNum) {
            string q = "UPDATE Requests " +
           "set Status = '" + s + "'" +
           "where Request_no = '" + rNum + "'";
            SqlCommand cmd = new SqlCommand(q, con.connect);
            cmd.ExecuteNonQuery();
        }
        public bool BookExist(string ISBN)
        {
            string c = "select * from Books where ISBN='" + ISBN + "'";
            SqlCommand cmd = new SqlCommand(c, con.connect);
            SqlDataReader rdr = cmd.ExecuteReader();
            if(rdr.HasRows)
            {
                rdr.Close();
                return true;
            }
            else
            {
                rdr.Close();
                return false;
            }
        }
        public void BlockUser(string UN) {
            AdminRemoving D = op.AdminRemove("BU");
            D.Remove(UN, con);
        }
        public void AddBook(Book B) {
            AdminAddition ADD = op.AdminAdd("B");
            ADD.Add(null, B, con);
        }
        public void EditBook(Book B) {
            AdminEditing E = op.AdminEdit("B");
            E.Edit(B, con);
        }
        public void RemoveBook(string ISBN) {
            AdminRemoving AR = op.AdminRemove("B");
            AR.Remove(ISBN , con);
        }
        public bool isBlocked (string name)
        {
            string s = "select Block from Login where Login_name = '" + name + "' ";
            SqlCommand smd = new SqlCommand(s, con.connect);
            SqlDataReader rdr = smd.ExecuteReader();
            while (rdr.Read())
            {
                if ((string)rdr["Block"] == "Yes") 
                {
                    rdr.Close();
                    return true;
                }
                else
                {
                    rdr.Close();
                    return false;
                }
            }
            rdr.Close();
            return false;
        }
        public void unBlocked (string name)
        {
            string s = "UPDATE Login  " +
                       "set Block = 'No' " +
                      "where Login_name = '" + name + "'";
            SqlCommand cmd = new SqlCommand(s, con.connect);
            cmd.ExecuteNonQuery();
        }

        public List<Book> SearchForBookByName(string name) {
            AdminSearching AS = op.AdminSearch("BBN");
            return AS.search(name, con);
        }
        public List<Book> SearchForBookByCat(string cat)
        {
            AdminSearching AS = op.AdminSearch("BBC");
            return AS.search(cat, con);
        }
        public User SearchForUser(string UserName) {
            AdminSearching AS = op.AdminSearch("U");
            return AS.search(UserName, con);
        }
        public void Userinlist(Borrow BO) {
            AdminAddition AA = op.AdminAdd("UTL");
            AA.Add(BO, null, con);
        }
        public void UserOutList(string UN) {
            AdminRemoving AR = op.AdminRemove("UFL");
            AR.Remove(UN, con);
        }
    }
   public class User:Pearson
    {   
        public User(string UserName, string passWord, string Type, string firstName, string lastName, string Adress, string Phone, string Email)
        {
            this.UserName = UserName;
            this.Password = passWord;
            this.Type = Type;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Adress = Adress;
            this.Phone = Phone;
            this.Email = Email;
        }
        public User(string UserName , string Type, string firstName, string lastName, string Adress, string Phone, string Email)
        {
            this.UserName = UserName;
            this.Type = Type;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Adress = Adress;
            this.Phone = Phone;
            this.Email = Email;
        }
        public User( string Type, string firstName, string lastName, string Adress, string Phone, string Email)
        {
            this.Type = Type;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Adress = Adress;
            this.Phone = Phone;
            this.Email = Email;
        }

        public User()
        {

        }

        public List<Book> CurrentBooks()
        {
            List<Book> List = new List<Book>();
            string cm = "select * from Books ";
            SqlCommand cmd = new SqlCommand(cm, con.connect);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Book tmp = new Book((string)rdr["ISBN"],(string)rdr["Title"], (string)rdr["Author"], (string)rdr["Category"], (string)rdr["Copies"] , (string)rdr["Language"], (string)rdr["Price"], (string)rdr["Publish_date"]);
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
        public void RequestBook(Request R) {
            UserAddition UA = op.UserAdd("R");
            UA.add(R, con);
        }
        public void RemoveFromList(string  RequestNum) {
            UserRemoving UR = op.UserRemove("SFL");
            UR.Remove(RequestNum, con);
        }
        public void RemoveRequest(string RequestNum) {
            UserRemoving UR = op.UserRemove("R");
            UR.Remove(RequestNum, con);
        }
        public List<Book> SearchForBookByName(string name)
        {
            UserSearching US = op.UserSearch("BBN");
            return US.search(name, con);
        }
        public List<Book> SearchForBookByCat(string cat)
        {
            UserSearching US = op.UserSearch("BBC");
            return US.search( cat , con );
        }
        public User SearchForUser(string UserName) {
            UserSearching US = op.UserSearch("U");
            return US.search(UserName, con);
        }

        public string ReturningDate(string ISBN)
        {
            string Q = "select Return_Date from Borrow where Login_name = '" + UserName + "' and ISBN = '" + ISBN + "'";
            SqlCommand cmd = new SqlCommand(Q, con.connect);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string no = rdr["Return_Date"].ToString();
                rdr.Close();
                return no;

            }
            rdr.Close();
            return null;
        }
        public string getReqNum(string ISBN)
        {
            string Q = "select Request_no from Requests where Login_name = '" + UserName + "' and ISBN = '" + ISBN + "'";
            SqlCommand cmd = new SqlCommand(Q, con.connect);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string no = rdr["Request_no"].ToString();
                rdr.Close();
                return no;
               
            }
            rdr.Close();
            return null;
        }

        public string Stat(string UN , string ISBN)
        {
            string Q = "select Status from Requests where Login_name = '" + UN + "' and ISBN = '" + ISBN + "'";
            SqlCommand cmd = new SqlCommand(Q , con.connect);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string tmp = (string)rdr["Status"];
                rdr.Close();
                return tmp;
            }
            rdr.Close();
            return null;
        }
    }
   public class Book
    {
        public string ISBN;
        public string Title;
        public string Author;
        public string Category;
        public string NumOfCopies;
        public string Language;
        public string Price;
        public string publish_date;

        public Book()
        {

        }
        public Book(string ISBN, string Title, string Author, string category, string numOfCopies, string Language, string Price , string publish_date)
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.Author = Author;
            this.Category = category;
            this.NumOfCopies = numOfCopies;
            this.Language = Language;
            this.Price = Price;
            this.publish_date = publish_date;
        }

        public Book(string Title, string Author, string category, string Language, string Price, string publish_date)
        {
            this.Title = Title;
            this.Author = Author;
            this.Category = category;
            this.Language = Language;
            this.Price = Price;
            this.publish_date = publish_date;
        }

    }

  public class Request
    {
        Connection con;
        public string Request_Num;
        public string UserName;
        public string RequestDate;
        public string DueDate;
        public string status;
        public string ISBN;
        public Request( string UserName, string ISBN,  string DueDate , string RequestDate,string status )
        {
            this.UserName = UserName;
            this.RequestDate = RequestDate;
            this.DueDate = DueDate;
            this.status = status;
            this.ISBN = ISBN;
            con = Connection.getInstance();
            Set_Number();
        }

        void Set_Number()
        {
            string Q = "select Request_no from Requests where Login_name = '" + UserName + "' and ISBN = '" + ISBN + "'";
            SqlCommand cmd = new SqlCommand(Q, con.connect);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Request_Num = rdr["Request_no"].ToString();
                rdr.Close();
                return;
            }
            rdr.Close();
        }
    }
  public class Borrow
    {
        public string ISBN;
        public string UN;
        public string RequestNum;
        public string BorrowDate;
        public string ReturnDate;
        public string Returned;
        private object obj;

        public Borrow(string ISBN, string UN, string RequestNum, string BorrowDate, string ReturnDate, string Returned)
        {
            this.ISBN = ISBN;
            this.UN = UN;
            this.RequestNum = RequestNum;
            this.BorrowDate = BorrowDate;
            this.ReturnDate = ReturnDate;
            this.Returned = Returned;
        }

        public Borrow(object obj)
        {
            this.obj = obj;
        }
    }
}
