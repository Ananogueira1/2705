using System;

namespace ex1.classes
{
    public abstract class Elevador
    {
        public int andarAtual = 0;
        public int andarDestino;
        public int totalAndares;
        public int capacidadeElevador = 10;
        public int pessoasPresentes;
        public int pessoasPresentesEntraram;
        public int pessoasEntrar;
        public int pessoasSair;

        public void Inicializar()
        {
            bool OpcaoValidarInicializar = true;

            do
            {
                Console.WriteLine("\n\nQuantos andares o prédio tem?");
                totalAndares = int.Parse(Console.ReadLine());

                if (totalAndares < 0)
                {
                    Console.WriteLine("Número inválido?");
                }

                else
                {
                    Console.WriteLine($"O prédio tem {totalAndares} andares");
                    OpcaoValidarInicializar = false;
                }
            } while (OpcaoValidarInicializar);

        }
        public void Entrar()
        {
            bool OpcaoValidarEntrar = true;
            do
            {
                if (pessoasPresentes < 10)
                {
                    Console.WriteLine($"\nO elevador tem {pessoasPresentes} pessoas dentro\nQuantas pessoas vão entrar?");
                    pessoasEntrar = int.Parse(Console.ReadLine());

                    pessoasPresentesEntraram = pessoasPresentes + pessoasEntrar;

                    if (pessoasEntrar >= 0)
                    {
                        if (capacidadeElevador >= pessoasPresentesEntraram)
                        {
                            Console.WriteLine($"\nO elevador agora tem {pessoasPresentesEntraram} pessoas");
                            pessoasPresentes = pessoasPresentesEntraram;
                            OpcaoValidarEntrar = false;
                        }
                        else
                        {
                            Console.WriteLine($"\nO elevador não não comporta {pessoasPresentesEntraram} pessoas no momento");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("O elevador já está cheio");
                    OpcaoValidarEntrar = false;
                }

            } while (OpcaoValidarEntrar);
        }

        public void Sair()
        {
            if (pessoasPresentes != 0 && pessoasPresentes > -1)
            {
                bool OpcaoValidarSair = true;

                do
                {
                    Console.WriteLine($"\nO elevador tem {pessoasPresentes} pessoas dentro\nQuantas pessoas vão sair");
                    pessoasSair = int.Parse(Console.ReadLine());

                    if (pessoasSair >= 0)
                    {
                        pessoasPresentes = pessoasPresentes - pessoasSair;

                        if (pessoasPresentes >= 0)
                        {
                            Console.WriteLine($"\nO elevador agora tem {pessoasPresentes} pessoas");
                            OpcaoValidarSair = false;
                        }
                        else
                        {
                            pessoasPresentes = pessoasPresentes + pessoasSair;
                            Console.WriteLine("Impossivel sair essa quantidade de pessoas, insira um número válido");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Insira um número válido");
                    }
                } while (OpcaoValidarSair);
            }
            else
            {
                Console.WriteLine("O elevador está vazio");
            }
        }

        public void Subir()
        {
            if (andarAtual != totalAndares)
            {
                bool OpcaoValidarSubir = true;

                do
                {
                    Console.WriteLine($"\nO prédio tem {totalAndares} andares\nPara qual andar você deseja subir?");
                    andarDestino = int.Parse(Console.ReadLine());

                    if (andarDestino > andarAtual && andarDestino <= totalAndares)
                    {
                        andarAtual = andarDestino;
                        Console.WriteLine($"\nSubindo para o {andarAtual}º andar");
                        Console.WriteLine($"\nVocê chegou no {andarAtual}º andar");
                        OpcaoValidarSubir = false;
                    }
                    else
                    {
                        Console.WriteLine("Impossível subir para esse andar");
                    }
                } while (OpcaoValidarSubir);
            }
            else
            {
                Console.WriteLine("\nVocê já está no último andar");
            }
        }

        public void Descer()
        {
            if (andarAtual != 0)
            {
                bool OpcaoValidaDescer = true;

                do
                {
                    Console.WriteLine($"\nDescendo para o {andarAtual}º andar");
                    andarDestino = int.Parse(Console.ReadLine());

                    if (andarDestino >= 0 && andarDestino <= andarAtual)
                    {
                        andarAtual = andarDestino;
                        Console.WriteLine($"\nDescendo para o {andarAtual}º andar");
                        Console.WriteLine($"\nVocê chegou no {andarAtual}º andar");
                        OpcaoValidaDescer = false;
                    }
                    else
                    {
                        Console.WriteLine("Impossível descer para esse andar");
                    }
                } while (OpcaoValidaDescer);
            }
        }

        public void Fazer()
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

                    string opcaoFazerDentro = Console.ReadLine();

                    switch (opcaoFazerDentro)
                    {
                        case "1":
                            Entrar();
                            OpcaoValidaElevador = false;
                            break;
                        case "2":
                            Sair();
                            OpcaoValidaElevador = false;
                            break;
                        case "3":
                            Subir();
                            OpcaoValidaElevador = false;
                            break;
                        case "4":
                            Descer();
                            OpcaoValidaElevador = false;
                            break;
                        case "5":
                            Console.WriteLine("Até mais");
                            OpcaoValidaElevador = false;
                            break;
                        default:
                            Console.WriteLine("\nSelecione uma opçãço valída");
                            OpcaoValidaElevador = false;
                            break;
                    }
            } while (OpcaoValidaElevador);
        }
    }
}