using System;
using System.Collections;
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

            GerenciadorVeiculos gerVeiculos = new GerenciadorVeiculos();

            Veiculo v1 = new Veiculo("MMM-0000", 2016, 0, "GM", "Cruze");
            Veiculo v2 = new Veiculo("MMM-1111", 1991, 300000, "GM", "Monza");
            Veiculo v3 = new Veiculo("MMM-2222", 2010, 150000, "GM", "Vectra");
            Veiculo v4 = new Veiculo("MMM-3333", 1999, 275000, "Peugeot", "206");
            Veiculo v5 = new Veiculo("MMM-4444", 2016, 0, "Renault", "Sandero");
            Veiculo v6 = new Veiculo("MMM-5555", 2015, 68000, "VW", "Amarok");
            Veiculo v7 = new Veiculo("MMM-6666", 2016, 0, "Nissan", "Frontier");

            gerVeiculos.adicionar(v1);
            gerVeiculos.adicionar(v2);
            gerVeiculos.adicionar(v3);
            gerVeiculos.adicionar(v4);
            gerVeiculos.adicionar(v5);
            gerVeiculos.adicionar(v6);
            gerVeiculos.adicionar(v7);


            ArrayList lista = gerVeiculos.listarTodos();

            Console.WriteLine("lista todos veiculos:");

            foreach (Veiculo v in lista)
            {
                Console.WriteLine(v.ToString());
            }
            
            ArrayList listaZeros = gerVeiculos.veiculosZeroKm();

            Console.WriteLine("\nLista carros 0 km:");
            foreach (Veiculo v in listaZeros)
            {
                Console.WriteLine(v.ToString());
            }

            Console.WriteLine("\nBusca placa MMM-6666: " + gerVeiculos.buscarPorPlaca("MMM-6666"));

            ArrayList listaOrdenada = gerVeiculos.ordenaModeloVeiculos();

            Console.WriteLine("\nlista ordenada por modelo:");

            foreach (Veiculo v in listaOrdenada)
            {
                Console.WriteLine(v.ToString());
            }


        }


    }
}
