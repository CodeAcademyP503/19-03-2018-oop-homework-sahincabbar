using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {


            // continue aid numune

            for (int i = 0; i <= 15; i++)
            {

                if (i == 10)
                {
                    continue;
                }
                Console.WriteLine(i);
            }



            // break aid numune

            for (int i = 0; i <= 15; i++)
            {

                if (i == 10)
                {
                    break;
                }
                Console.WriteLine(i);
            }



        }
    }
}
