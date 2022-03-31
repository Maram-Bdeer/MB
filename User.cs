using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.Model
{
    internal class User
    {

        public string name { get; set; }
        public int id { get; set; }
        public int age { get; set; }

        public User(int Id, string Name, int Age)
        {
            this.id = Id;
            this.name = Name;
            this.age = Age;
        }
        public override string ToString()
        {
            return $"Id : {this.id} -Name:{this.name} -Age:{this.age}";
        }
        public override bool Equals(object obj) { 

            // If the passed object is null
            if (obj == null)
            {
                return false;
            }
            if (!(obj is User))
            {
                return false;
            }
            return (this.id == ((User)obj).id) &&
                (this.name == ((User)obj).name)
                && (this.age == ((User)obj).age)

                ;
        }
    }
}

   
