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
        private int id;

        


        #endregion

        #region propriedades
        public int Id { get => id; set => id = value; }
        internal Garagem Origem { get => origem; set => origem = value; }
        internal Garagem Destino { get => destino; set => destino = value; }
        internal Veiculo Veiculo { get => veiculo; set => veiculo = value; }
        #endregion

        #region construtor

        public Viagem(Garagem origem, Garagem destino, Veiculo veiculo, int id)
        {
            this.origem = origem;
            this.destino = destino;
            this.veiculo = veiculo;
            this.id = id;
        }
        #endregion

        #region métodos

        #endregion


    }
}
