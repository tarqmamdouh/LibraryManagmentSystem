using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Library
{
    public class Connection
    {
        private static Connection instance;
        public SqlConnection connect;
        private Connection() {
            connect = new SqlConnection("Data Source=DESKTOP-NBL62J0\\ZZPORTAL;Initial Catalog=LMS;Integrated Security=True;MultipleActiveResultSets=True");
            connect.Open();
        }
        public static Connection getInstance()
        {
            if (instance == null)
            {
                instance = new Connection();
            }
            return instance;
        }
    }
   public interface Operation
    {
        AdminAddition AdminAdd(string t);
        AdminRemoving AdminRemove(string t);
        AdminSearching AdminSearch(string t);
        AdminEditing AdminEdit(string t);
        UserAddition UserAdd(string t);
        UserRemoving UserRemove(string t);
        UserSearching UserSearch(string t);
    }
    class OperationCreator : Operation
    {
        public AdminAddition AdminAdd(string t)
        {
            if (t == "B")
            {
                return new addBook();
            }
            else if (t == "U")
            {
                return new AddUser();
            }
            else if (t == "UTL")
            {
                return new AddUserToList();
            }
            else
                return null;
        }

        public AdminRemoving AdminRemove(string t)
        {
            if (t == "B")
            {
                return new RemoveBook();
            }
            else if (t == "UFL")
            {
                return new RemoveUserFromlist();
            }
            else if (t == "BU")
            {
                return new BlockUser();
            }
            else
                return null;
        }

        public AdminSearching AdminSearch(string t)
        {
            if (t == "BBN")
            {
                return new AdminSearchBookByName();
            }
            else if (t == "BBC")
            {
                return new AdminSearchBookByCat();
            }
            else if (t == "U")
            {
                return new AdminSearchUser();
            }
            else
                return null;
        }

        public AdminEditing AdminEdit(string t)
        { 
             if (t == "B")
            {
                return new EditBook();
            }
            else
                return null;
        }

        public UserAddition UserAdd(string t)
        {
            if (t == "R")
            {
                return new AddRequest();
            }
            else
                return null;
        }

        public UserRemoving UserRemove(string t)
        {
            if (t == "R")
            {
                return new RemoveRequest();
            }
            else if (t == "SFL")
            {
                return new RemoveSelfFromList();
            }
            else
                return null;
        }

        public UserSearching UserSearch(string t)
        {
            if (t == "BBN")
            {
                return new userSearchBookByName();
            }
            else if (t == "BBC" )
            {
                return new userSearchBookByCat();
            }
            else if (t == "U")
            {
                return new userSearchUser();
            }
            else
                return null;
        }
    }

}
