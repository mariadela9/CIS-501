using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_SoftwareArch_Console
{
    class Program
    {

        // echos the user's name and prints a randomly chosen int:
        static void Main(string[] args)
        {
            int p = 0; 
        
            Console.Write("Guess an int, M, in range 0..10:  M = ");
            int m = Int32.Parse(Console.ReadLine());
            
            while(m < 0 || m > 10)
            {

                Console.Write("Only numbers between 1 and 10");
                m = Int32.Parse(Console.ReadLine());

            }

            

            // how to generate random numbers:
            Random r = new Random();
            int min = 0;
            int max = 9;
            int n = r.Next(min, max + 1);

            Console.WriteLine("I guess int, N, in range 0..10-M: N = " + n );
            

            Console.Write("Now you type an int, P, such that M + N + P = 10:  P = ");
            //int p = Int32.Parse(Console.ReadLine());
            p = Int32.Parse(Console.ReadLine());
            

            if((m + n + p) == 10)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }

            Console.ReadLine();

        }
    }
}
