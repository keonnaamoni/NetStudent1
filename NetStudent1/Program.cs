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
            Grasshopper = 1,
            Journeyman = 2,
            RockStar = 3,
            Ninja = 4,
            Jedi = 5
            
        }

        
        
    
        static void Main(string[] args)
        {
            Student keonnaEvans = new Student();
            
            keonnaEvans.CompletedProgram = + 1;
            keonnaEvans.Helper = + 2;
            keonnaEvans.Level = null;
            

            Console.WriteLine("How many programs did you complete today?");
            string userValue = Console.ReadLine();
            
            if (keonnaEvans.CompletedProgram  == 1) 
            {
                Console.WriteLine("You have made Grasshopper staus.");
            }
            
            else if ((keonnaEvans.CompletedProgram == 1) && (keonnaEvans.Helper) >=3) 
            {
                Console.WriteLine("You have made Journeyman status");
            }
            
            
          
           
            //Console.WriteLine(keonnaEvans.Helper + keonnaEvans.CompletedProgram);            
        }
        
                

        
    
    }
    

    class Student
    {
        public int CompletedProgram { get; set; }
        public int Helper { get; set; }
        public string Level { get; set; }
        

    }
}
