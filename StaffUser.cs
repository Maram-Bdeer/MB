using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.Model
{
    internal class StaffUser : User
    {
        public StaffUser(int Id, string Name, int Age) : base(Id, Name, Age)
        {
            this.id = Id;
            this.name = Name;
            this.age = Age;
        }
        public enum Role { };
        public override string ToString()
        {
            return $"Id : {this.id} -Name:{this.name} -Age:{this.age}" ;
        }
        public override bool Equals(object obj)

        {
            // If the passed object is null
            if (obj == null)
            {
                return false;
            }
            if (!(obj is StaffUser))
            {
                return false;
            }
            return (this.id == ((StaffUser)obj).id) &&
                (this.name == ((StaffUser)obj).name)
                && (this.age == ((StaffUser)obj).age)

                ;
        }

    }
}
