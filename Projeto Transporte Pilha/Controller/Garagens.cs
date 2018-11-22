using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Transporte_Pilha
{
    class Garagens
    {
        #region atributos
        private List<Garagem> listaGaragens;
        private bool jornadaAtiva;



        #endregion

        #region propriedades

        public bool JornadaAtiva
        {
            get
            {
                return jornadaAtiva;
            }

            set
            {
                jornadaAtiva = value;
            }
        }

        internal List<Garagem> ListaGaragens
        {
            get
            {
                return listaGaragens;
            }

            set
            {
                listaGaragens = value;
            }
        }

        #endregion

        #region construtor
        public Garagens()
        {
            ListaGaragens = new List<Garagem>();
            JornadaAtiva = false;
        }

        #endregion

        #region métodos
        public void incluir (Garagem garagem)
        {
            ListaGaragens.Add(garagem);
        }

        public void iniciarJornada()
        {
            if (JornadaAtiva)
            {
                Console.WriteLine("Garagem já iniciou a jornada.");

            }
            else
            {
                JornadaAtiva = true;

                Console.WriteLine("Jornada iniciada com sucesso.");
            }
        }

        public List<Transporte> encerrarJornada()
        {
            jornadaAtiva = false;
            //verificar

            List<Transporte> listTransporte = new List<Transporte>();
            return listTransporte;
        }
        public Garagem Pesquisar(Garagem garagem)
        {
            Garagem aux = new Garagem();

            foreach (Garagem ga in ListaGaragens)
            {
                if (ga.Equals(garagem))
                {
                    aux = ga;
                }
            }
            return aux;
        }
        #endregion
        

    }
}
