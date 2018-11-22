using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Transporte_Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            int resp = 0;
            int idgaragem;
            int idgaragem2;
            string placa;
            int lotacao;
            
            string local;
            int auxiliar = 0;
          
            Veiculos controlerVeiculos = new Veiculos();
            Garagens ControlerGaragens = new Garagens();
            Viagens controlerViagens = new Viagens();
            #region pretederminações
            //adicionando os veiculos já predeterminados

            for (int a = 1; a <= 8; a++)
            {
                controlerVeiculos.adicionar(new Veiculo(a.ToString(), 10));
            }
            //adicionar as garagens já predeterminadas

            ControlerGaragens.incluir(new Garagem(1, "Congonhas"));

            ControlerGaragens.incluir(new Garagem(2, "Guarulhos"));
            #endregion

            do
            {
                Console.WriteLine("1.Cadastrar veiculos.");
                Console.WriteLine("2.Cadastrar garagem.");
                Console.WriteLine("3.Iniciar Jornada.");
                Console.WriteLine("4.Encerrar jornada.");
                Console.WriteLine("5.Listar garagens.");
                Console.WriteLine("6.Listar veiculos em uma garagem.");
                Console.WriteLine("7.Listar veiculos.");
                Console.WriteLine("8.Adicionar veiculos a uma garagem especifica.");
                Console.WriteLine("9.Liberar viagem de uma determinada origem para um determinado destino.");
                resp = Convert.ToInt32(Console.ReadLine());


              

                switch (resp)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Programa sera Encerrando");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 1:
                        Console.Clear();
                        if (!ControlerGaragens.JornadaAtiva)
                        {
                            Console.WriteLine("Digite a placa do veiculo");
                            placa = Console.ReadLine();
                            Console.WriteLine("Digite a capacidade do veiculo");
                            lotacao = Convert.ToInt32(Console.ReadLine());

                            controlerVeiculos.adicionar(new Veiculo(placa, lotacao));

                            Console.WriteLine("veiculos cadastrados porem não alocados em garagens:");
                            foreach (Veiculo veiculo in controlerVeiculos.ListaVeiculos)
                            {
                                Console.WriteLine(veiculo.toString());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Jornada já iniciada");
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:

                        Console.Clear();
                        Console.WriteLine("Digite o local da garagem");
                        local = Console.ReadLine();
                        Console.WriteLine("Digite o id");
                        idgaragem = Convert.ToInt32(Console.ReadLine());


                        ControlerGaragens.incluir(new Garagem(idgaragem,local));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Jornada Iniciada");

                        ControlerGaragens.iniciarJornada();
                        while (auxiliar < (controlerVeiculos.ListaVeiculos.Count() - 1))
                        {
                            foreach (Garagem garagem in ControlerGaragens.ListaGaragens)
                            {
                                Console.WriteLine(garagem.toString());
                                Console.WriteLine(controlerVeiculos.ListaVeiculos[auxiliar].toString());
                                garagem.adicionarVeiculo(controlerVeiculos.ListaVeiculos[auxiliar]);
                                auxiliar++;
                                
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        ControlerGaragens.encerrarJornada();
                        Console.WriteLine("Jornada Encerrada");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();

                        
                        foreach (Garagem garagem in ControlerGaragens.ListaGaragens)
                        {
                            Console.WriteLine(garagem.toString());
                        }

                        //aqui controler
                        Garagem garagemPesquisada =  ControlerGaragens.Pesquisar(new Garagem(1));
                        Console.WriteLine(garagemPesquisada.toString());

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Digite o Codigo da Garagem:");
                        idgaragem = Convert.ToInt32(Console.ReadLine());


                        //pesquisar garagem
                        Garagem aux = ControlerGaragens.Pesquisar(new Garagem(idgaragem));

                        //listarveiculo
                        foreach (Veiculo veiculo in aux.Veiculos)
                        {
                            Console.WriteLine(veiculo.toString() + "\n");
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Programa sera Encerrando");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Digite a placa do veiculo");
                        placa = Console.ReadLine();
                        Console.WriteLine("Digite a capacidade do veiculo");
                        lotacao = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o codigo da garagem");
                        idgaragem = Convert.ToInt32(Console.ReadLine());

                        ControlerGaragens.Pesquisar(new Garagem(idgaragem));



                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Digite o id da Garagem Origem");
                        idgaragem = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o id da Garagem Origem");
                        idgaragem2 = Convert.ToInt32(Console.ReadLine());

                        //pesquisar garagem destino
                        ControlerGaragens.Pesquisar(new Garagem(idgaragem));
                        //pesquisar garagem origem
                        ControlerGaragens.Pesquisar(new Garagem(idgaragem2));
                        //pop da origem e push do destino
                        ControlerGaragens.Pesquisar(new Garagem(idgaragem2)).Veiculos.Push(ControlerGaragens.Pesquisar(new Garagem(idgaragem)).Veiculos.Pop());

                        controlerViagens.incluir(new Viagem(ControlerGaragens.Pesquisar(new Garagem(idgaragem)), ControlerGaragens.Pesquisar(new Garagem(idgaragem2)), ControlerGaragens.Pesquisar(new Garagem(idgaragem2)).Veiculos.Pop()));
                        break;
                    default:
                        Console.Clear();
                        
                        Console.Clear();
                        break;
                }

            } while (resp != 0);

        }
    }
}
