using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.Model
{
    internal class AdminUser : User
    {
        public AdminUser(int Id, string Name, int Age) : base(Id, Name, Age)
        {
            this.id = Id;
            this.name = Name;
            this.age = Age;
        }
        
        public override string ToString()
        {
            return $"Id : {this.id} -Name:{this.name} -Age:{this.age}";
        }
#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        public override bool Equals(object obj)
#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        {
            // If the passed object is null
            if (obj == null)
            {
                return false;
            }
            if (!(obj is AdminUser))
            {
                return false;
            }
            return (this.id == ((AdminUser)obj).id)&&
                (this.name == ((AdminUser)obj).name)
                && (this.age == ((AdminUser)obj).age)
                
                ;
        }

        
    }
    }

