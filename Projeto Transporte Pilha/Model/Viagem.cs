using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Transporte_Pilha
{
    class Viagem
    {
        #region atributos
        private Garagem origem;
        private Garagem destino;
        private Veiculo veiculo;
        static private int id = 0;






        #endregion

        #region propriedades
        internal Garagem Origem
        {
            get
            {
                return origem;
            }

            set
            {
                origem = value;
            }
        }

        internal Garagem Destino
        {
            get
            {
                return destino;
            }

            set
            {
                destino = value;
            }
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

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        #endregion

        #region construtor

        public Viagem(Garagem origem, Garagem destino, Veiculo veiculo)
        {
            this.Origem = origem;
            this.Destino = destino;
            this.Veiculo = veiculo;
            this.Id++;
        }
        #endregion

        #region métodos
        public string toString()
        {
            return "Id: " + this.Id + " // Destino: " + this.Destino + " //Origem: " + this.Origem + " // ";
        }
        #endregion


    }
}
