using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Transporte_Pilha
{
    class Veiculos
    {
        #region atributos
        private List<Veiculo> listaVeiculos;



        #endregion

        #region propriedades
        internal List<Veiculo> ListaVeiculos
        {
            get
            {
                return listaVeiculos;
            }

            set
            {
                listaVeiculos = value;
            }
        }
        #endregion

        #region construtor
        public Veiculos()
        {
            listaVeiculos = new List<Veiculo>();
        }
        #endregion

        #region métodos
        public void adicionar (Veiculo veiculo)
        {
            listaVeiculos.Add(veiculo);
        }
        #endregion


    }
}
