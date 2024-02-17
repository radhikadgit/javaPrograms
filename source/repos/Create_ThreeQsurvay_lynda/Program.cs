using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_ThreeQsurvay_lynda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is Your Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("How old are you: ");
            var age = Console.ReadLine();
            Console.WriteLine("What month were You born in: ");
            var month = Console.ReadLine();

            Console.WriteLine("Your Name: " + name);
            Console.WriteLine("Your Age: " + age);
            Console.WriteLine("Your Birth Month: " + month);

            if (month == "march")
            {
                Console.WriteLine("your jodicsign is Arial");
            }
            else if (month == "april")
            {
                Console.WriteLine("yoir jodiacsign is Torus");
            }
            else if (month == "may")
            {
                Console.WriteLine("yoir jodiacsign is Gemini");
            }

        }
    }
}
