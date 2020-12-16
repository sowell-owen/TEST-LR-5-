using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string myStr;
            string myStr2;

            int a, b;
            
            Console.WriteLine("Введите числа: ") ;

            myStr = Console.ReadLine();
            myStr2 = Console.ReadLine();
          

            a = Convert.ToInt32(myStr);
            b = Convert.ToInt32(myStr2);


            int result = (a + b) / 2;

            Console.WriteLine(result);



        }
    }
}
