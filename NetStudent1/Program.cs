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
            string userValue = Console.ReadLine();


            if (keonnaEvans.CurrentPoints == 1)
            {
                Console.WriteLine("You have made" + Rank.Grasshopper);


            }
            else if (keonnaEvans.CurrentPoints > 1) 
            {

                Console.WriteLine("You have made" + Rank.Journeyman);
            }

        } 

    public class Student
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
    
       // public int TotalPoints
        //{
          //  get { return TotalPoints; }
            //set { TotalPoints = value; }
        }
    } 

    }
//}

