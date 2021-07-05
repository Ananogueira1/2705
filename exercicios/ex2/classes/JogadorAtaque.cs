using System;

namespace ex2.classes
{
    public class JogadorAtaque : Jogador
    {
         public string Aposentar(int idade)
        {
            int idadeJogador = CalcularIdade(idade);
            {
                if(idadeJogador <=35)
                {
                    return $"Falta {35- idade} anos para você conoseguir se aposentar";
                }
                else
                {
                    return "Você ja pode se aposentar";
                }
            }
        }

        internal string Aposentar()
        {
            throw new NotImplementedException();
        }
    }
}