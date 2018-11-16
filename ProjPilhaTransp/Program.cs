using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjPilhaTransp
{
    class Program
    {
        #region MAIN
        static void Main(string[] args)
        {
            Garagens garagens = new Garagens();

            garagens.incluir(new Garagem(1, "Congonhas"));
            garagens.incluir(new Garagem(2, "Guarulhos"));

            garagens.incluirVeic(new Veiculo(1, "CARRO1", 20));
            garagens.incluirVeic(new Veiculo(2, "CARRO2", 30));
            garagens.incluirVeic(new Veiculo(3, "CARRO3", 22));
            garagens.incluirVeic(new Veiculo(4, "CARRO4", 15));
            garagens.incluirVeic(new Veiculo(5, "CARRO5", 2));
            garagens.incluirVeic(new Veiculo(6, "CARRO6", 48));
            garagens.incluirVeic(new Veiculo(7, "CARRO7", 12));
            garagens.incluirVeic(new Veiculo(8, "CARRO8", 20));

            int opc = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("0.Sair");
                Console.WriteLine("1.Cadastrar veículo");
                Console.WriteLine("2.Cadastrar garagem");
                Console.WriteLine("3.Iniciar jornada");
                Console.WriteLine("4.Encerrar jornada");
                Console.WriteLine("5.Listar veículos em determinada garagem");
                Console.WriteLine("6.Listar viagens");
                Console.WriteLine("7.Listar garagens");
                Console.WriteLine("8.Adicionar pessoas");
                Console.WriteLine("\nDigite a sua opção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    #region 1.Cadastrar veículo
                    case 1:
                        if (!garagens.jornadaAtiva)
                        {
                            Console.Clear();
                            Console.WriteLine("Digite a placa do veículo: ");
                            string placa = Console.ReadLine();
                            Console.WriteLine("Digite a lotação máxima do veículo: ");
                            int lotacao = int.Parse(Console.ReadLine());
                            garagens.incluirVeic(new Veiculo(garagens.novoIdVeiculo(), placa, lotacao));
                            Console.Clear();
                            Console.WriteLine("Veículo cadastrado com sucesso...");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Não é possível cadastrar veículos enquanto a jornada estiver ativa...");
                        }
                        Console.ReadKey();
                        break;
                    #endregion

                    #region 2.Cadastrar garagem
                    case 2:
                        if (!garagens.jornadaAtiva)
                        {
                            Console.Clear();
                            Console.WriteLine("Digite o nome da garagem: ");
                            string nomeG = Console.ReadLine();
                            garagens.incluir(new Garagem(garagens.novoIdGaragem(), nomeG));
                            Console.Clear();
                            Console.WriteLine("Garagem cadastrada com sucesso...");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Não é possível cadastrar garagens enquanto a jornada estiver ativa...");
                        }
                        Console.ReadKey();
                        break;
                    #endregion

                    #region 3.Iniciar jornada
                    case 3:
                        if (garagens.jornadaAtiva)
                        {
                            Console.Clear();
                            Console.WriteLine("A jornada já está ativa!");
                        }
                        else if (garagens.veiculos.Count <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Não existem veiculos para iniciar a jornada!");
                        }
                        else if (garagens.garagens.Count <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Não existem garagens para iniciar a jornada!");
                        }
                        else
                        {
                            Console.Clear();
                            garagens.iniciarJornada();
                            Console.WriteLine("A jornada foi iniciada!");
                        }
                        Console.ReadKey();
                        break;
                    #endregion

                    #region 4.Encerrar Jornada
                    case 4:
                        if (!garagens.jornadaAtiva)
                        {
                            Console.Clear();
                            Console.WriteLine("A jornada já está encerrada!");
                        }
                        else
                        {
                            Console.Clear();
                            garagens.encerrarJornada();
                            Console.WriteLine("A jornada foi encerrada!");
                        }
                        Console.ReadKey();
                        break;
                    #endregion

                    #region 5.Listar veículos em determinada garagem
                    case 5:
                        Console.Clear();
                        if (garagens.jornadaAtiva)
                        {
                            Console.WriteLine("Selecione a garagem a qual deseja consultar os veículos: ");
                            int pos = int.Parse(Console.ReadLine());
                            pos--;
                            Console.Clear();
                            foreach (Veiculo v in garagens.garagens[pos].veiculos)
                            {
                                Console.WriteLine("ID: " + v.Id + " | Placa: " + v.Placa + " | Lotação: " + v.Lotacao);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Não há veículos nas garagens pois a jornada está ativa");
                        }
                        Console.ReadKey();
                        break;
                    #endregion

                    #region 6.Listar viagens
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Viagens: ");
                        foreach (Viagem v in garagens.viagens.Viagems)
                        {
                            Console.WriteLine("\nID: " + v.Id);
                            Console.WriteLine("Garagem de origem: " + v.Origem.Local);
                            Console.WriteLine("Garagem de destino: " + v.Destino.Local);
                            Console.WriteLine("Veículo: " + v.Veiculo.Placa);

                        }
                        Console.ReadKey();
                        break;
                    #endregion

                    #region 7.Listar garagens
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Garagens: ");
                        foreach (Garagem g in garagens.garagens)
                        {
                            Console.WriteLine("\nID: " + g.Id);
                            Console.WriteLine("Local: " + g.Local);
                            Console.WriteLine("Fila: " + g.pessoas.Count + " pessoas");
                        }
                        Console.ReadKey();
                        break;
                    #endregion

                    #region 8.Adicionar pessoas
                    case 8:
                        Console.Clear();
                        if (garagens.jornadaAtiva)
                        {
                            Console.WriteLine("Digite o ID da garagem de origem: ");
                            int idG = int.Parse(Console.ReadLine());
                            idG--;

                            if (idG < garagens.garagens.Count)
                            {
                                Garagem gOrigem = garagens.garagens[idG];

                                gOrigem.addPessoas();
                                Console.Clear();
                                Console.WriteLine("Adicionada uma pessoa na fila");

                                if (gOrigem.veiculos.Count > 0)
                                {

                                    if (gOrigem.vaiViajar())
                                    {
                                        //NOVO
                                        int indexGDestino = gOrigem.Id + 1;
                                        if (indexGDestino == garagens.garagens.Count())
                                        {
                                            indexGDestino = 0;
                                        }

                                        Garagem gDestino = garagens.garagens[indexGDestino];

                                        Veiculo vVeiculo = gOrigem.veiculos.Peek();

                                        for (int i = 0; i < gOrigem.veiculos.First().Lotacao; i++)
                                        {
                                            gOrigem.removePessoas();
                                        }

                                        garagens.executaViagem(gOrigem, gDestino, vVeiculo);

                                        while (gDestino.veiculos.Count == 1 && vVeiculo.Lotacao >= gDestino.pessoas.Count)
                                        {
                                            gOrigem = gDestino;

                                            indexGDestino = gOrigem.Id + 1;
                                            if (indexGDestino == garagens.garagens.Count())
                                            {
                                                indexGDestino = 0;
                                            }

                                            gDestino = garagens.garagens[indexGDestino];

                                            vVeiculo = gOrigem.veiculos.Peek();

                                            for (int i = 0; i < gOrigem.veiculos.First().Lotacao; i++)
                                            {
                                                gOrigem.removePessoas();
                                            }

                                            garagens.executaViagem(gOrigem, gDestino, vVeiculo);
                                        }

                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Não há veículos disponíveis");
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Não existe uma garagem com o ID informado!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Não é possível entrar na fila enquanto a jornada não estiver ativa!");
                        }
                        Console.ReadKey();
                        break;
                        #endregion
                }

            } while (opc != 0);
        }
        #endregion
    }//CLASS
}//NAMESPACE
