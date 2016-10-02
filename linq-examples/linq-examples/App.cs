using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_examples
{
    class App
    {




        static void Main(string[] args)
        {


            string[] lista = new string[] { "Matheus", "Moreira", "Morcinek" };

            var stringQuery = from s in lista
                              where s.Equals("Morcinek")
                              select s;

            foreach(string str in stringQuery)
            {
                Console.WriteLine("Resulatdo -> : " + str);
            } 

        }


    }
}
