using System;

namespace ex3
{
    class Program
    {
         static void Main(string[] args)
        {
            MaquinaCafe m = new MaquinaCafe();
            string opcaoCafe;
            bool querMaisCafe = true;
            bool opcaoValida = true;

            do
            {
                Console.WriteLine(@"Deseja ter seu café com uma quantidade específica de açúcar?
 Se sim aperte o 's' para informar a quantidade desejada, caso contrario aperte enter para continuar.
            ");
               string querOuNao = Console.ReadLine().ToLower();
               
               switch (querOuNao)
               {
                 case "":
                    m.FazerCafe();
                    do
                    {
                        Console.WriteLine("Deseja mais um café? s/n");
                        opcaoCafe = Console.ReadLine();
                        
                        if (opcaoCafe == "s")
                        {
                            querMaisCafe = true;
                            opcaoValida = false;
                        }
                        else if (opcaoCafe == "n")
                        {
                            Console.WriteLine("Espero que o café esteja bom, até mais!");
                            querMaisCafe = false;
                            opcaoValida = false;
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida");
                            opcaoValida = false;
                        }
                    } while (opcaoValida);
                    break;
                case "s":
                    m.FazerCafe(querOuNao = "s");
                    do
                    {
                        Console.WriteLine("Deseja mais um café? s/n");
                        opcaoCafe = Console.ReadLine();

                        if (opcaoCafe == "s")
                        {
                            querMaisCafe = true;
                            opcaoValida = false;
                        }
                        else if (opcaoCafe == "n")
                        {
                            querMaisCafe = false;
                            opcaoValida = false;
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida");
                            opcaoValida = false;
                        }
                    } while (opcaoValida); 
                    break;
                default:
                  m.FazerCafe();
                  do
                  {
                      Console.WriteLine("Deseja mais um café? s/n");
                      opcaoCafe = Console.ReadLine();

                      if (opcaoCafe == "s")
                      {
                          querMaisCafe = true;
                          opcaoValida = false;
                      }
                      else if (opcaoCafe == "n")
                      {
                          Console.WriteLine("Espero que o café esteja bom, até mais!");
                          querMaisCafe = false;
                          opcaoValida = false;
                      }
                      else
                      {
                          Console.WriteLine("Opção inválida");
                          opcaoValida = false;
                      }
                  } while (opcaoValida); 
                  break;

               }
            } while (querMaisCafe);
        }
    }
}
