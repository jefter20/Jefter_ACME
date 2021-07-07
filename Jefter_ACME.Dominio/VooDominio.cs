using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jefter_ACME.Dominio
{
    public class VooDominio
    {
        private int id_voo;
        private DateTime data_voo;
        private double custo;
        private int distancia;
        private string captura;
        private int nivel_dor;

        public int Id_voo { get => id_voo; set => id_voo = value; }
        public DateTime Data_voo { get => data_voo; set => data_voo = value; }
        public double Custo { get => custo; set => custo = value; }
        public int Distancia { get => distancia; set => distancia = value; }
        public string Captura { get => captura; set => captura = value; }
        public int Nivel_dor { get => nivel_dor; set => nivel_dor = value; }
    }
}
