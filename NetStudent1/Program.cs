using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudent1
{
    class Student
    {
        public int points;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student Keonna = new Student();
            Keonna.points = 0; 
            Console.WriteLine ("Keonna's beginning points is {0}", Keonna.points);
        }
    }
}
