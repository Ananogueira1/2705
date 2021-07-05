using System;

namespace ex2.classes
{
    public class JogadorDefesa : Jogador
    {
        public string Aposentar(int idade)
        {
            int idadeJogador = CalcularIdade(idade);

            if (CalcularIdade(idade) < 40)
            {
                return $"Falta {40 - idade} anos para você conoseguir se aposentar";
            }
            else
            {
                return "Você ja pode se aposentar";
            }
        }

        internal string Aposentar()
        {
            throw new NotImplementedException();
        }
    }
}