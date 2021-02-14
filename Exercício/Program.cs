using System;

namespace Exercício
{
    class Program
    {
        static void Main(string[] args)
        {
            int continuar = 1;

            Console.WriteLine("Seja bem vindo à lista de exercícios de classes e atributos. A seguir será fornecido o tópico dos 6 exercícios onde você poderá escolher um deles para testar.");

            while (continuar != 0)
            {
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                Console.WriteLine("Exercício 1 - Atributos para uma classe de pessoa.");
                Console.WriteLine("Exercício 2 - Atributos para uma classe de funcionário.");
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

                Console.Write("Escola a opção do exercício desejado (se desejar encerrar o programa digite qualquer outro número):");
                int opcao = int.Parse(Console.ReadLine());

                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

                if (opcao == 1)
                {
                    Pessoa p1 = new Pessoa();
                    Pessoa p2 = new Pessoa();

                    Console.WriteLine("Dados da primeira pessoa:");
                    Console.Write("Nome: ");
                    p1.Nome = Console.ReadLine();
                    Console.Write("Idade: ");
                    p1.Idade = int.Parse(Console.ReadLine());

                    Console.WriteLine("Dados da segunda pessoa:");
                    Console.Write("Nome: ");
                    p2.Nome = Console.ReadLine();
                    Console.Write("Idade: ");
                    p2.Idade = int.Parse(Console.ReadLine());

                    if (p1.Idade > p2.Idade)
                        Console.WriteLine("Pessoa mais velha: " + p1.Nome);
                    else if (p2.Idade > p1.Idade)
                        Console.WriteLine("Pessoa mais velha: " + p2.Nome);
                    else
                        Console.WriteLine("Os dois possuem a mesma idade.");
                }
                else if (opcao == 2)
                {
                    Funcionario f1 = new Funcionario();
                    Funcionario f2 = new Funcionario();

                    Console.WriteLine("Dados do primeiro funcionário:");
                    Console.Write("Nome: ");
                    f1.Nome = Console.ReadLine();
                    Console.Write("Salário: ");
                    f1.Salario = double.Parse(Console.ReadLine());

                    Console.WriteLine("Dados do segundo funcionário:");
                    Console.Write("Nome: ");
                    f2.Nome = Console.ReadLine();
                    Console.Write("Salário: ");
                    f2.Salario = double.Parse(Console.ReadLine());

                    double media = (f1.Salario + f2.Salario) / 2;

                    Console.WriteLine($"Salário médio = {media.ToString("F2")}");
                }
                else
                {
                    break;
                }
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

                Console.Write("Digite 1 caso queira verificar outro exercício ou 0 para encerrar: ");
                continuar = int.Parse(Console.ReadLine());

                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

                Console.Clear();
            }
            
        }
    }
}
