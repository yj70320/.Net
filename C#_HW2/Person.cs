using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HW2
{
    internal class Person
    {
        private decimal salary;

        public int Id { get; set; }
        private decimal Salary 
        {
            get => salary;
            set
            {
                if (value < 0) throw new ArgumentException("Salary must be positive.");
                salary = value;
            }
        }
        public DateTime DateOfBirth { get; set; }
        public List<String> Address { get; set; } = new List<String>();
    }
}
