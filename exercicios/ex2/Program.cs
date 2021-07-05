using System;
using ex2.classes;

namespace ex2
{
    class Program 
    {
         static void Main(string[] args)
        {

            bool opcaoValida = true;
            do
            {
                Console.WriteLine(@"
    O jogador joga no:
    1 - Ataque
    2 - Defesa
    3 - Meio-Campo
            ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        JogadorAtaque jogadorAtaque = new JogadorAtaque();
                        Console.WriteLine(jogadorAtaque.Dados());
                        Console.WriteLine(jogadorAtaque.Aposentar());
                        break;
                        
                    case "2":

                        JogadorDefesa jogadorDefesa = new JogadorDefesa();
                        Console.WriteLine(jogadorDefesa.Dados());
                        Console.WriteLine(jogadorDefesa.Aposentar());
                        break;

                    case "3":
                        JogadorMeio jogadorMeio = new JogadorMeio();
                        Console.WriteLine(jogadorMeio.Dados());
                        Console.WriteLine(jogadorMeio.Aposentar());
                        break;

                    default:
                        Console.WriteLine("Opção invalida, por favor selecione uma opção valida!");
                        opcaoValida = false;
                        break;
                }

            } while (!opcaoValida);
        }
    }
}
