using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i_Multi;
            MyMethod();
            Add(4, 6);
             Console.WriteLine(i_Multi = Multiply(1, 3));
           // i_Multi = Multiply(2, 3);
        }
        static void MyMethod()
        {
            Console.WriteLine("i can call methods in 'main methods'");
        }
        static void Add(int num1,int num2)
        {
            Console.WriteLine("Adding two numbers: "+(num1+num2));
        }
        static int Multiply(int num1,int num2)
        {
           int i_result;
            i_result = num1 * num2;
             if ( i_result > 50)
            {
                return i_result;
            }

            Console.WriteLine(i_result = Multiply(i_result, num1));
            return i_result;
           
        }
    }
}
