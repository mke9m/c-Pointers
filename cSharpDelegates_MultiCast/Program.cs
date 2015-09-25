using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDelegates_MultiCast
{
    class Program
    {
        static delegate void calculate(int value1, int value2);
        static void Main(string[] args)
        {
            myUtil MyUtilObject = new myUtil();
            int i, j;
            calculate CalFunction = new calculate(MyUtilObject.addMethod);

            CalFunction = CalFunction + new calculate(MyUtilObject.subMethod);
            CalFunction = CalFunction + new calculate(MyUtilObject.divMethod);
            CalFunction = CalFunction + new calculate(MyUtilObject.multiMethod);


            Console.Write("enter a number:");
            i = int.Parse(Console.ReadLine());

            Console.Write("enter another number:");
            j = int.Parse(Console.ReadLine());

            CalFunction(i, j);

            Console.ReadLine();

        }
    }
}
