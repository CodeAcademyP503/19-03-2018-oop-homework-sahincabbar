using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Man kishi = new Man();

            kishi.Ichmek();

            kishi.Yatmaq();

            kishi.Yemek();


            Woman qadin = new Woman();

            qadin.Yemek();


            qadin.Yatmaq();


            qadin.Ichmek();
        }
    }



    class Human {

        public void Yemek()
        {
            Console.WriteLine("yemek");
        }

        public void Ichmek()
        {

            Console.WriteLine("ichmek");
        }
        
        public void Yatmaq()
        {
            Console.WriteLine("yatmaq");
        }



    }

    class Man : Human
    {

        public void MashinSurmek()
        {
            Console.WriteLine("mashinsurmek");


        }

        public void EsgerlikEtmek()
        {
            Console.WriteLine("esgerliketmek");

        }



    }

    class Woman: Human
    {
        public void MakeupEtmek()
        {
            Console.WriteLine("makeupetmek");

        }


        public void QeybetEtmek()
        {
            Console.WriteLine("qeybetetmek");


        }





    }
}



