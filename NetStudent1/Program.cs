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
            
            keonnaEvans.CurrentPoints = + 1;
            keonnaEvans.HelperPoints = + 2;
           // keonnaEvans.Level = null;
            

            Console.WriteLine("How many programs did you complete today?");
            string userValue = Console.ReadLine();
            
            
            if (keonnaEvans.CurrentPoints == 1) 
            {
                Console.WriteLine( (Rank.Grasshopper));
            }
            
            else if ((keonnaEvans.CurrentPoints > 1) && (keonnaEvans.HelperPoints) >=3) 
            {
                Console.WriteLine(Rank.Journeyman);
            }
            
            
          
           
            //Console.WriteLine(keonnaEvans.Helper + keonnaEvans.CompletedProgram);            
        }
    
    }
    

    class Student
    {
        public int CurrentPoints 
        {
            get { return CurrentPoints;} 
            set {CurrentPoints = 0;}
        }

        public int HelperPoints
        {
            get { return HelperPoints;}
            set { HelperPoints = 2;}
        }
    
    } 

    }
}
