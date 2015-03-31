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
            
            
            //keonnaEvans.CurrentPoints = +1;
            //keonnaEvans.HelperPoints = +2;
           

            Console.WriteLine("How many programs did you complete today?");
            int userValue = int.Parse (Console.ReadLine());
            
            { 
            if (userValue  == 1) 
            {
                Console.WriteLine("You have earned " + Rank.Grasshopper + " status!");
            }

            }

            Console.WriteLine("How many of your peers did you help?");
            int userValue1 = int.Parse(Console.ReadLine());

       
            if (userValue1 == 1) 
            {

               Console.WriteLine((keonnaEvans.HelperPoints));
                Console.WriteLine ("You have earned " + Rank.Journeyman + " status!");
            }
       
            else
            {
                Console.WriteLine("End Program");
            }
        } 

    public class Student
    {
        public int CurrentPoints 
        {
            get { return currentPoints; }
            set { currentPoints = 1; }
        }
        private int currentPoints;

        public int HelperPoints
        {
            get { return helperPoints; }
            set { helperPoints = 2; }
        }
        private int helperPoints;

        

        
    
       
    } 

    }
}

