using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointers
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 5, j = 99, k = 109;
            unsafe {


                int* myIntPtr;
                myIntPtr = &i;
                Console.WriteLine("memory address for var i:" + (int)myIntPtr);
                Console.WriteLine("memory value for var i:" + *myIntPtr);
                Console.ReadLine();


                myIntPtr = &j;
                Console.WriteLine("memory address for var j:" + (int)myIntPtr);
                Console.WriteLine("memory value for var j:" + *myIntPtr);
                Console.ReadLine();

                myIntPtr = &k;
                Console.WriteLine("memory address for var k:" + (int)myIntPtr);
                Console.WriteLine("memory value for var k:" + *myIntPtr);
                Console.ReadLine();



            }

            

        }
    }
}
