using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_examples
{
    public class Veiculo
    {

        private string placa;
        private int ano;
        private int km;
        private string marca;
        private string modelo;
        
        public Veiculo(string placa, int ano, int km, string marca, string modelo)
        {
            this.placa = placa;
            this.ano = ano;
            this.km = km;
            this.marca = marca;
            this.modelo = modelo;
        }

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public int Km
        {
            get { return km; }
            set { km = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public override string ToString()
        {
            return "Placa ["+placa+"] - Ano "+ano+". "+km+" KM. -> "+marca+" - "+modelo+".";
        }

    }
}
