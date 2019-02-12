using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    class CsharpBasics
    {
        static void Main(string[] args)
        {
            float mass = 2.53f;
            float acceleration = 2.85f;
            byte sample1 = 0x3A;
            byte sample2 = 58;
            byte heartRate = 85;
            double deposits = 135002796;
            double distance = 129.763001;
            bool lost = true;
            bool expensive = true;
            int choice = 2;
            char integral = '\u222B';
            String greetings = "Hello";
            String name = "Karen";
            float force = mass * acceleration;

            if (sample1 == sample2)
            {
                Console.WriteLine("The samples are equal.");
            } else
            {
                Console.WriteLine("The samples are not equal.");
            }
            if ((heartRate >= 40) && (heartRate <= 80))
            {
                Console.WriteLine("Heart rate is normal.");
            } else {
                Console.WriteLine("Heart rate is not normal.");
            }
            if (deposits >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy.");
            } else
            {
                Console.WriteLine("Sorry you are so poor.");
            }
            if (lost && expensive == true)
            {
                Console.WriteLine("I am really sorry! I will get the manager.");
            } else if (lost == true && expensive == false)
            {
                Console.WriteLine("Here is coupon for 10% off.");
            }
            Console.WriteLine("force = {0}", force);
            Console.WriteLine("{0} is the distance.", distance);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose 1.");
                    break;
                case 2:
                    Console.WriteLine("You chose 2.");
                    break;
                case 3:
                    Console.WriteLine("You chose 3.");
                    break;
                default:
                    Console.WriteLine("You made an unknown choice.");
                    break;
            }
            Console.WriteLine("Your choice was {0}", choice);
            Console.WriteLine("{0} is an integral", integral);
            //Brendan Krekeler said this was fine, my computer doesnt support this unicode
            for (int i = 5; i < 11; i = i + 1)
            {
                Console.WriteLine("i = {0}", i);
;            }
            int age = 0;
            while (age < 6)
            {
                Console.WriteLine("age = {0}", age);
                age++;
            }
            Console.WriteLine("{0} {1}", greetings, name);
            Console.ReadLine();
        }
    }
}
