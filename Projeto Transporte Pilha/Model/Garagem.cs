using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Transporte_Pilha
{
    class Garagem
    {
        #region atributos
        private int id;
        private string local;
        private Stack<Veiculo> veiculos;
        private int qtdeDeVeiculos;
        private int potencialDeTransporte;

       
        #endregion

        #region propriedades
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

        public string Local
        {
            get
            {
                return local;
            }

            set
            {
                local = value;
            }
        }

        internal Stack<Veiculo> Veiculos
        {
            get
            {
                return veiculos;
            }

            set
            {
                veiculos = value;
            }
        }

        public int QtdeDeVeiculos
        {
            get
            {
                return qtdeDeVeiculos;
            }

            set
            {
                qtdeDeVeiculos = value;
            }
        }

        public int PotencialDeTransporte
        {
            get
            {
                return potencialDeTransporte;
            }

            set
            {
                potencialDeTransporte = value;
            }
        }
        #endregion

        #region construtor
        public Garagem(int id, string local, Stack<Veiculo> veiculos, int qtdeDeVeiculos, int potencialDeTransporte)
        {
            this.id = id;
            this.local = local;
            this.veiculos = veiculos;
            this.qtdeDeVeiculos = qtdeDeVeiculos;
            this.potencialDeTransporte = potencialDeTransporte;
        }
        #endregion

        #region métodos
        public void incluir(Garagem garagem)
        {

        }
        public void iniciarJornada()
        {

        }
        public List<Transporte> encerrarJornada()
        {
            return List < Transporte > a;
        }
        #endregion


    }
}
