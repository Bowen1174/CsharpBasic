# CsharpBasic
```ruby
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
            char integral = '\u22B';
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
            Console.WriteLine("force = {0}", force);
            Console.WriteLine("{0} is the distance.", distance);
            Console.ReadLine();
        }
    }
}
```
