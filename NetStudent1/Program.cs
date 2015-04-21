using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStudent1
{
    class Program
    {
        public class Student
        {
            public int ProgramPoints
            {
                get { return programPoints; }
                set { programPoints = +1; }
            }
            private int programPoints;

            public int HelperPoints
            {
                get { return helperPoints; }
                set { helperPoints = +2; }
            }
            private int helperPoints;

            public int TotalPoints
            {
                get { return totalPoints; }
                set {int tp = programPoints + helperPoints; }
            }

            private int totalPoints;

           
            enum Rank
            {
                None,
                Grasshopper,
                Journeyman,
                RockStar,
                Ninja,
                Jedi

            }

             
            static void Main(string[] args)
        {
            Student keonnaEvans = new Student();
           
                       
            Console.WriteLine("How many programs did you complete today?");
            string userValue =  Console.ReadLine();
            Int32.Parse(userValue);




            if (Int32.Parse(userValue) == 1)
            {

                Console.WriteLine("You have earned " + Rank.Grasshopper + " status!");
            }

            else if (Int32.Parse(userValue) >= 2)
            {
                Console.WriteLine("You have earned" + Rank.Journeyman + "status!");
            }

            Console.WriteLine("How many of your peers did you help?");
            int userValue1 = int.Parse(Console.ReadLine());
            int i = 0;
            

            if (userValue1 == 1) 
            {
               i += 2;
               Console.WriteLine(i);
               Console.WriteLine("You've reached" + Rank.Journeyman + "status."); 
            }
            else if ( userValue1 ==2)
            {
                i++;
                Console.WriteLine(i+2);
                Console.WriteLine("You've reached" + Rank.RockStar + "status.");
            }
           
            
            
           
        } 

    }

    }
    }

