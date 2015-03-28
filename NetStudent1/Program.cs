using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudent1
{
    class Program
    {

        enum Rank
        {
            Grasshopper,
            Journeyman,
            RockStar,
            Ninja,
            Jedi
        }
    
        static void Main(string[] args)
        {
            Student keonnaEvans = new Student();
            
            keonnaEvans.CompletedProgram = + 1;
            keonnaEvans.Helper = + 2;
            keonnaEvans.Level = null;

            
            

            Console.WriteLine("Did you help a student today?");
            string line = Console.ReadLine();
          
           
            Console.WriteLine(keonnaEvans.Helper + keonnaEvans.CompletedProgram);            
        }
        
                

        
    
    }
    

    class Student
    {
        public int CompletedProgram { get; set; }
        public int Helper { get; set; }
        public string Level { get; set; }
        

    }
}
