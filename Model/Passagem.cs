using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportaDados.Model
{
    public class Passagem
    {
        private string placa;
        private string data;
        private string hora;
        private string equipamento;
        private string faixa;

        public string Placa { get => placa; set => placa = value; }
        public string Data { get => data; set => data = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Equipamento { get => equipamento; set => equipamento = value; }
        public string Faixa { get => faixa; set => faixa = value; }
    }
}
