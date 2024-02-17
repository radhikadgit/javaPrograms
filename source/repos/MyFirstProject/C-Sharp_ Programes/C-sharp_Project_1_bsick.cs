using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class Program
    {    //Programing on calcilater
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            int firstnumer =int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int secondnumber = int.Parse(Console.ReadLine());
            Console.Write("Sum Of Two Numbers are: " );
            int sumofNumbers = firstnumer + secondnumber ;
            Console.WriteLine(sumofNumbers);
            Console.Write("Multiply Of Two Numbers are: ");
            int multtiplyofNumbers = firstnumer * secondnumber;
            Console.WriteLine(multtiplyofNumbers);
            Console.Write("Division  Of Two Numbers are: ");
            int divisionofNumbers = firstnumer / secondnumber;
            Console.WriteLine(divisionofNumbers);
        }
    }
}
