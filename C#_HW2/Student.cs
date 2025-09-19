using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HW2
{
    internal class Student: Person
    {
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
