using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDelegates
{
    class Program
    {

        public delegate int calculator(int value1, int value2);
        static void Main(string[] args)
        {
            myUtil myUtilObject = new myUtil();

            int i, j;
            calculator addnumbers = new calculator(myUtilObject.addMethod);
            calculator subnumbers = new calculator(myUtilObject.subMethod);

            Console.Write("enter addnumbers number:");
            i = int.Parse(Console.ReadLine());

            Console.Write("enter addnumbers number:");
            j = int.Parse(Console.ReadLine());

            addnumbers(i, j);
            subnumbers(i, j);

            Console.Write("\nadding two values: " + addnumbers(i,j));
            Console.Write("\nsubtracting two values: " + addnumbers(i, j));
            
            Console.Read();

        }
    }
}
