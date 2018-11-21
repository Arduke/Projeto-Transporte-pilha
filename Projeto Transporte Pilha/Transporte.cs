using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Transporte_Pilha
{
    class Transporte
    {
        private Veiculo veiculo;
        private int qtdeTransportada;

        public Transporte(Veiculo veiculo, int qtdeTransportada)
        {
            this.veiculo = veiculo;
            this.qtdeTransportada = qtdeTransportada;
        }
        public Transporte()
        {
            this.veiculo = new Veiculo("a", 1);
            this.qtdeTransportada = 1;
        }
        internal Veiculo Veiculo
        {
            get
            {
                return veiculo;
            }

            set
            {
                veiculo = value;
            }
        }

        public int QtdeTransportada
        {
            get
            {
                return qtdeTransportada;
            }

            set
            {
                qtdeTransportada = value;
            }
        }
    }
}
