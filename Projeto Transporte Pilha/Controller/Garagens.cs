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
        public bool JornadaAtiva { get => jornadaAtiva; set => jornadaAtiva = value; }
        internal List<Garagem> ListaGaragens { get => listaGaragens; set => listaGaragens = value; }

        #endregion

        #region construtor
        public Garagens()
        {
            listaGaragens = new List<Garagem>();
            jornadaAtiva = false;
        }

        #endregion

        #region métodos
        public void incluir (Garagem garagem)
        {
            listaGaragens.Add(garagem);
        }

        public void iniciarJornada()
        {
            if (jornadaAtiva)
            {
                Console.WriteLine("Garagem já iniciou a jornada.");

            }
            else
            {
                JornadaAtiva = true;

                Console.WriteLine("Jornada iniciada com sucesso.");
            }
        }

        /*public List<Transporte> encerrarJornada()
        {

        }
        */
        #endregion


    }
}
