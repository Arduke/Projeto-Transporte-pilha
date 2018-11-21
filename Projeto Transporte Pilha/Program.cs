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
            string placa;
            int lotacao;
            int id;
            string local;
            int auxiliar = 0;
            Garagem aux = new Garagem();

            Veiculos controlerVeiculos = new Veiculos();
            Garagens ControlerGaragens = new Garagens();

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

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:

                        Console.Clear();
                        Console.WriteLine("Digite o local da garagem");
                        local = Console.ReadLine();
                        Console.WriteLine("Digite o id");
                        id = Convert.ToInt32(Console.ReadLine());


                        ControlerGaragens.incluir(new Garagem(id,local));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Jornada Iniciada");


                        while (auxiliar < (controlerVeiculos.ListaVeiculos.Count() - 1))
                        {
                            foreach (Garagem garagem in ControlerGaragens.ListaGaragens)
                            {
                                Console.WriteLine(garagem.toString());
                                Console.WriteLine(controlerVeiculos.ListaVeiculos[auxiliar]);
                                garagem.adicionarVeiculo(controlerVeiculos.ListaVeiculos[auxiliar]);
                                auxiliar++;
                            }
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Programa sera Encerrando");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                       
                        foreach (Garagem garagem in ControlerGaragens.ListaGaragens)
                        {
                            Console.WriteLine(garagem.toString());
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Digite o Codigo da Garagem:");
                        idgaragem = Convert.ToInt32(Console.ReadLine());

                        
                        //pesquisar garagem
                        foreach (Garagem garagem in ControlerGaragens.ListaGaragens)
                        {
                            if (garagem.Equals(new Garagem(idgaragem)))
                            {
                                aux = garagem;
                            }
                        }                        
                        
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

                        //pesquisar garagem
                        foreach (Garagem garagem in ControlerGaragens.ListaGaragens)
                        {
                            if (garagem.Equals(new Garagem(idgaragem)))
                            {
                                aux = garagem;
                            }
                        }
                        aux.adicionarVeiculo(new Veiculo(placa, lotacao));

                        Console.ReadKey();
                        Console.Clear();
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
