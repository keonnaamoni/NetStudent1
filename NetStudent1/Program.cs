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

            keonnaEvans.CurrentPoints = +1;
            keonnaEvans.HelperPoints = +2;
           // keonnaEvans.TotalPoints = 0;


            Console.WriteLine("How many programs did you complete today?");
            int userValue = int.Parse (Console.ReadLine());

            { 
            if (userValue  == 1 ) 
            {
                Console.WriteLine("You have earned " + Rank.Grasshopper + "status!");


            }

            }

            Console.WriteLine("Did you help a student today?");
            int userValue1 = int.Parse (Console.ReadLine());


            if (userValue == 1 + keonnaEvans.HelperPoints) 
            {

                Console.WriteLine("You have earned " + Rank.Journeyman + "status!");
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
            set { currentPoints = 0; }
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

