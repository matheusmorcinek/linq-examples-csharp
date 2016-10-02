using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace linq_examples
{
    public class GerenciadorVeiculos
    {

        private ArrayList veiculos;

        public GerenciadorVeiculos()
        {
            veiculos = new ArrayList();
        }

        public void adicionar(Veiculo veiculo)
        {
            veiculos.Add(veiculo);
        }

        public ArrayList listarTodos()
        {
            return new ArrayList(veiculos);
        }

        public Veiculo buscarPorPlaca(String placa)
        {

            var veiculoQuery = from Veiculo v in veiculos
                               where v.Placa.Equals(placa)
                               select v;

            if (veiculoQuery.Any())
            {
                return veiculoQuery.First();
            }
            else
            {
                return null;
            }

        }

        public ArrayList veiculosZeroKm()
        {
            ArrayList listaAux;

            var consulta = from Veiculo v in veiculos
                           where v.Km == 0
                           select v;

            return listaAux = new ArrayList(consulta.ToArray()); 
        }

        public ArrayList ordenaModeloVeiculos()
        {
            ArrayList listaAux;

            var consulta = from Veiculo v in veiculos
                           orderby v.Modelo ascending
                           select v;
            if (consulta.Any())
            {
                return listaAux = new ArrayList(consulta.ToArray());
            }
            else
            {
                return null;
            }
            
        }

        

    }
}
