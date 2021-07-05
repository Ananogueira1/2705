using System;

namespace ex1.classes
{
    public class ElevadorServico : Elevador
    {
        private int caixas;
        private int contaCaixas;

        public void FazerServico()
        {
            bool OpcaoValidaElevador = true;

            do
            {
                Console.WriteLine(@"
                Você deseja:
                1- Entrar no elevador
                2- Sair do elevador
                3- Subir
                4- Descer
                5- Sair do sistema
                ");

                int opcaoFazerDentro = int.Parse(Console.ReadLine());

                switch (opcaoFazerDentro)
                {
                    case 1:
                        Entrar();
                        OpcaoValidaElevador = false;
                        break;
                    case 2:
                        Sair();
                        OpcaoValidaElevador = false;
                        break;
                    case 3:
                        Subir();
                        OpcaoValidaElevador = false;
                        break;
                    case 4:
                        Descer();
                        OpcaoValidaElevador = false;
                        break;
                    case 5:
                        Console.WriteLine("Até mais");
                        OpcaoValidaElevador = false;
                        break;
                    default:
                        Console.WriteLine("\nSelecione uma opçãço valída");
                        OpcaoValidaElevador = false;
                        break;
                }
            } while (!OpcaoValidaElevador);
        }


        public void NumeroCaixas()
        {
            bool OpcaoValidaElevadorServico = true;

            do
            {
                Console.WriteLine("Cabem 10 caixas no elevador!!!");

                if (caixas >= 0)
                {
                    int contaCaixa;

                    do
                    {
                        Console.WriteLine($@"
                       Você deseja adicionar ou remover?
                       1- Adicionar
                       2- Remover
                       3- Sair do sistema das caixas
                       ");

                        string opcao = Console.ReadLine();

                        switch (opcao)
                        {
                            case "1":
                                if (caixas < 10 && caixas >= 0)
                                {
                                    Console.WriteLine($"\nCabem 10 no elevador!!\nO elevador tem{caixas} caixas\n");
                                    Console.WriteLine($"\nCabem 10 no elevador!!\nO elevador tem{caixas} caixas\n");
                                    contaCaixa = int.Parse(Console.ReadLine());
                                    if (caixas + contaCaixa <= 10)
                                    {
                                        Console.WriteLine($"O elevador agora tem {caixas + contaCaixa} caixas");
                                        caixas = caixas + contaCaixa;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Impossível colocar mais caixas");

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Impossível colocar mais caixas");
                                }
                                break;

                            case "2":
                                if (caixas <= 10 && caixas > 0)
                                {
                                    Console.WriteLine($"\nCabem 10 caixas no elevador!!\nO elevador temcaixas caixas\n");
                                    Console.WriteLine("Você deseja remover quantas caixas?");
                                    contaCaixa = int.Parse(Console.ReadLine());

                                    if (caixas - contaCaixas >= 0)
                                    {
                                        Console.WriteLine($"O elevador agora tem {caixas - contaCaixas} caixas");
                                        caixas = caixas - contaCaixas;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Impossível remover essa quantidade de caiuxas");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Não é possivel remover mais caixas");
                                }
                                break;
                            case "3":
                                OpcaoValidaElevadorServico = false;
                                Console.WriteLine("Até mais");
                                break;
                            default:
                                Console.WriteLine("Selecionar uma opção valida");
                                break;
                        }

                    } while (OpcaoValidaElevadorServico);
                }
                else if (caixas < 0)
                {
                    Console.WriteLine("Digite um número valido");
                }
            } while (caixas < 0);
        }
    }
}