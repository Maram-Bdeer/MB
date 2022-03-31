using Ass3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.ModelView
{
     internal class UserModelView
    {
        private List<User> users= new List<User>();
        private List<AdminUser> usersAdmain1 = new List<AdminUser>();
        private List<StaffUser> usersStaff = new List<StaffUser>();
       
        public UserModelView()
        {
            users = new List<User>();
            usersAdmain1 = new List<AdminUser>();
            usersStaff = new List<StaffUser>();
        }
        internal void Add(User user)
        {
            users.Add(user);
            Console.WriteLine("User  Add");

        }
        internal void Add(AdminUser adminUser)
        {
            usersAdmain1.Add(adminUser);
            Console.WriteLine("user  Admain  Add");
        }
       internal void Add(StaffUser staff)
        {
            usersStaff.Add(staff);
            Console.WriteLine("user  Staff Add");
        }

        internal void edit(int ID , int Age , string Name , User u)
        {
            if (ID == u.id)
            {
                u.age = Age;
                u.name = Name;

            }
           
        }
        internal void edit(int ID, int Age, string Name, AdminUser A)
        {
            if (ID == A.id)
            {
                A.age = Age;
                A.name = Name;

            }

        }

        internal void edit(int ID, int Age, string Name, StaffUser S)
        {
            if (ID == S.id)
            {
                S.age = Age;
                S.name = Name;

            }

        }



        public void Remove(int indexUser)
        {
            if (users.Count == 0)
            {
                throw new Exception("the list is empty");
            }
            else if(indexUser >= users.Count)
            {
                throw new Exception($"index[{indexUser}] out of bound exception");
            }
            users.RemoveAt(indexUser);
        }
        public void Remove(double indexAdmain)
        {
            if (users.Count == 0)
            {
                throw new Exception("the list is empty");
            }
            else if (indexAdmain >= users.Count)
            {
                throw new Exception($"index[{indexAdmain}] out of bound exception");
            }
            users.RemoveAt((int)indexAdmain);
        }

        public void Remove(float indexStaff)
        {
            if (users.Count == 0)
            {
                throw new Exception("the list is empty");
            }
            else if (indexStaff >= users.Count)
            {
                throw new Exception($"index[{indexStaff}] out of bound exception");
            }
            users.RemoveAt((int)indexStaff);
        }
    }
}
