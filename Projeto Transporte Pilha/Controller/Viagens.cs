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
        internal Queue<Viagem> Listaviagens { get => listaviagens; set => listaviagens = value; }
        #endregion

        #region construtor

        #endregion

        #region métodos
        public void incluir  (Viagem viagem)
        {
            listaviagens.Enqueue(viagem);
        }
        #endregion


    }
}
