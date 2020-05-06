using System;

namespace InfnetBanking
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta1 = new ContaBancaria();
            conta1.Titular = new Pessoa();

            Console.Write("Informe o nome do titular: ");
            string nome = Console.ReadLine();
            conta1.Titular.Nome = nome;
            Console.Write("Informe o sobrenome do titular: ");
            string sobrenome = Console.ReadLine();
            conta1.Titular.Sobrenome = sobrenome;
            
            Console.WriteLine(conta1.Titular.ImprimirNome() + " | Saldo: R$ {0:0,0.00}", conta1.Saldo);
            Console.Write("Informe o valor do depósito inicial: ");
            double valor = Convert.ToDouble(Console.ReadLine());
            conta1.Depositar(valor);
            Console.WriteLine("Depositados R$" + valor);
            Console.WriteLine(conta1.Titular + " | Saldo: R$ {0:0,0.00}", conta1.Saldo);
            Console.Write("Informe o valor do saque: R$ ");
            valor = Convert.ToDouble(Console.ReadLine());
            conta1.Sacar(valor);
            Console.WriteLine("Efetuado o saque de R$ {0:0,0.00}", valor);
            Console.WriteLine(conta1.Titular + " | Saldo: R$ {0:0,0.00}", conta1.Saldo);
        }
    }
}
