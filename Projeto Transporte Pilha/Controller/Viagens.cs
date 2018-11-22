using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Transporte_Pilha
{
    class Viagens
    {
        #region atributos
        private Queue<Viagem> listaviagens;




        #endregion

        #region propriedades
        internal Queue<Viagem> Listaviagens
        {
            get
            {
                return listaviagens;
            }

            set
            {
                listaviagens = value;
            }
        }
        #endregion
        public Viagens()
        {
            Listaviagens = new Queue<Viagem>();
        }
        #region construtor

        #endregion

        #region métodos
        public void incluir  (Viagem viagem)
        {
            Listaviagens.Enqueue(viagem);
        }
        #endregion


    }
}
