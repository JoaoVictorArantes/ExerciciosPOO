namespace ExerciciosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.Write("Dados da primeira pessoa: ");
            pessoa1.Nome = Console.ReadLine();

            Console.Write("Idade: ");
            pessoa1.Idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dados da Segunda Pessoa: ");
            pessoa2.Nome = Console.ReadLine();

            Console.Write("Idade: ");
            pessoa2.Idade = Convert.ToInt32(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine($"A pessoa mais velha é a {pessoa1.Nome} com {pessoa1.Idade} anos.");
            }
            else if (pessoa2.Idade > pessoa1.Idade)
            {
                Console.WriteLine($"A pessoa mais velha é a {pessoa2.Nome} com {pessoa2.Idade} anos.");
            }
            else
            {
                Console.WriteLine($"Tanto a {pessoa1.Nome} quanto {pessoa2.Nome} tem a mesma idade. :)");
            }

            Console.ReadKey();
        }
    }
}
