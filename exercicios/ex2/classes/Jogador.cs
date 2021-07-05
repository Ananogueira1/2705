using System; 

namespace ex2.classes
{
    public abstract class Jogador
    {
        protected string nome;
        protected int ano;
        protected string nacionalidade;
        protected string altura;
        protected int peso;
        protected int idade;

        public string Dados()
        {
            Console.WriteLine("\nQual o nome do jogador?");
            nome = Console.ReadLine();

            Console.WriteLine("\nEm que ano o jogador nasceu?");
            ano =  int.Parse(Console.ReadLine());

            Console.WriteLine("\nQual a nacionalidade do jogador?");
            nacionalidade = Console.ReadLine();

            Console.WriteLine("\nQual a altura do jogador?");
            altura = Console.ReadLine();

            Console.WriteLine("\nQual o peso do jogador?");
            peso= int.Parse(Console.ReadLine());

            return ($@"Nome:{nome}
            ano de nascimento {ano}
            nacionalidade {nacionalidade}
            altura {altura} centimetros
            peso {peso} kilos");
        }
        
        public int CalcularIdade(int ano)
        {
            return idade = DateTime.Now.Year - ano;
        }
    }
}