using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDelegates_MultiCast
{
    public class myUtil
    {


        public void addMethod(int num1, int num2)
        {
            Console.WriteLine("Adding Two Values : " + ( +num1 + num2));


        }

        public void subMethod(int num1, int num2)
        {
            Console.WriteLine("subtracting Two Values : " + ( +num1 - num2));


        }

        public void multiMethod(int num1, int num2)
        {
            Console.WriteLine("multiply Two Values : " + (+num1- num2));


        }

        public void divMethod(int num1, int num2)
        {
            Console.WriteLine("divide Two Values : " + (+num1 / num2));


        }


    }
}
