using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Transporte_Pilha
{
    class Veiculo
    {
        #region atributos
        private string placa;
        private string capacidade;
        #endregion

        #region propriedades
        public string Placa
        {
            get
            {
                return placa;
            }

            set
            {
                placa = value;
            }
        }

        public string Capacidade
        {
            get
            {
                return capacidade;
            }

            set
            {
                capacidade = value;
            }
        }
        #endregion

        #region construtor
        public Veiculo(string placa, string capacidade)
        {
            this.placa = placa;
            this.capacidade = capacidade;
        }
        #endregion

        #region métodos
        public string toString()
        {
            return "Placa: " + placa + "///" + "Capacidade: " + capacidade;
        }
        #endregion


    }
}
