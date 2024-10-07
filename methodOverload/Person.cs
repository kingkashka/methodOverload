using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOverload
{
    public abstract class Person
    {
        public string firstName {  get; set; }
        public string lastName { get; set; }


        public void sayName()
        {
            Console.WriteLine($"Name: {this.firstName} {this.lastName}");
        }
    }
}
