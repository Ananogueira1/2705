using System;

namespace ex2.classes
{
    public class JogadorMeio : Jogador
    {
        public string Aposentar()
        {
            int idadeJogador = CalcularIdade(idade);
            
            if(CalcularIdade(idade) <=38)
                {
                    return $"Falta {38- idade} anos para você conoseguir se aposentar";
                }
                else
                {
                    return "Você ja pode se aposentar";
                }
        }
    }
}