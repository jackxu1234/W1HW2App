using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1HW3App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                leapyear LP = new leapyear();
                LP.input();
                if (LP.isleapyear())
                {
                    LP.printtrue();
                }
                else
                {
                    LP.printfalse();
                }
            }
        }
    }
    class leapyear
    {
        int year;
        public void input()
        {
            year = Convert.ToInt32(Console.ReadLine());
        } 
        public bool isleapyear()
        {
            
            if ((0 == year % 4 && 0 != year % 100) || (0 == year % 400))
            {
                return true; 
            }
            else
            {
                return false;
            }
        } 
        public void printtrue()
        {
            Console.WriteLine("{0} is a Leap 。\n", year);
        } 
        public void printfalse()
        {
            Console.WriteLine("{0}is not Leap。\n", year);
        } 
    }
    }

