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

      
        #endregion

        #region construtor
        public Garagem(int id, string local)
        {
            this.id = id;
            this.local = local;
            veiculos = new Stack<Veiculo>();
            
        }
        public Garagem(int id)
        {
            this.id = id;
            this.local = "";
            veiculos = new Stack<Veiculo>();

        }
        public Garagem()
        {
            this.id = 0;
            this.local = "";
            veiculos = new Stack<Veiculo>();

        }
        #endregion

        #region métodos
        public int qtdeDeVeiculos()
        {
            if (veiculos.Count() != 0)
            {
                return veiculos.Count();
            }
            else
            {
                return 0;
            }
        }
        public int potencialDeTranspote()
        {
            int pot = 0;
            if (veiculos.Count() != 0)
            {
                foreach (var v in veiculos)
                {
                    pot += v.Lotacao;
                }
            }
            return pot;
        }
        public void adicionarVeiculo(Veiculo veiculo)
        {
            veiculos.Push(veiculo);
        }
        public string toString()
        {
            return "id: " + id + " " + " Local: " + local;
        }
        #endregion

        #region Sobreescritas
        public override bool Equals(object obj)
        {
            Garagem g = (Garagem)obj;
            return this.id.Equals(g.id);
        }
        #endregion
    }
}
