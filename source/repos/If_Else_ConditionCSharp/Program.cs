using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else_ConditionCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Kids Age: ");
            int age = int.Parse(Console.ReadLine());
           switch(age)
            {
                case 5:
                    
                    Console.WriteLine("Eligible for School");
                    break;
                case 4:
                    Console.WriteLine("Eligible for PreSchool");
                    break;
                default:
                    Console.WriteLine("Not Eligible for School");
                    break;
                

            }

        }
    }
}
