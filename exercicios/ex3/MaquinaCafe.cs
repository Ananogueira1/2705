using System;

namespace ex3
{
    public class MaquinaCafe
    {
        public int acucarDisponivel = 100;

        public int quantidadeEscolida;

        public void FazerCafe()
        {
            if (acucarDisponivel >= 10)
            {
                Console.WriteLine("Você não colocou nenhum valor, o padrão da máquina por café é 10 gramas de açúcar. Portanto seu café tem 10 gramas de açúcar.");
                acucarDisponivel = acucarDisponivel - 10;
            }
            else
            {
                Console.WriteLine("O café foi feito sem açúcar, pois não há açúcar suficiente na máquina. Desculpe.");
            }
        }

        public void FazerCafe(string querOuNao = "s")
        {
            bool opcaoValida = true;
            do
            {

                if (quantidadeEscolida >= 0)
                {
                    if (acucarDisponivel >= quantidadeEscolida)
                    {
                        Console.WriteLine($"Quantas gramas de açúcar você deseja colocar? ({acucarDisponivel} gramas de açúcar que está disponivel)");
                        quantidadeEscolida = int.Parse(Console.ReadLine());

                    }

                    if (quantidadeEscolida >= 0)
                    {
                        Console.WriteLine($"Café com {quantidadeEscolida} gramas de açúcar feito!");
                        acucarDisponivel = acucarDisponivel - quantidadeEscolida;
                    }
                    else
                    {
                        Console.WriteLine("O café foi feito sem açúcar, pois não há açúcar suficiente na máquina. Desculpe.");
                    }
                    opcaoValida = false;
                }
                else
                {
                    Console.WriteLine($"Insira um valor válido por favor.");
                }
                
            } while (opcaoValida);

        }


    }

}