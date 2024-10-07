using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOverload
{
    public class Employee : Person
    {
        // Define the ID property
        public int ID { get; set; }

        // Constructor
        public void sayID() 
        {
            Console.WriteLine($"ID: {this.ID}");
          
        }
    }
}
