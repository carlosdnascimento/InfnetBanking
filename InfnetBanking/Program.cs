using System;

namespace InfnetBanking
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca conta1 = new ContaPoupanca();
            conta1.DataAniversario = new DateTime(2020, 01, 08);
            conta1.Depositar(1000);
            Console.WriteLine(conta1.Saldo);
            conta1.CalcularRentabilidade();
            Console.WriteLine(conta1.Saldo);
        }

        private static void Exemplo20200506()
        {
            ContaBancaria conta1 = new ContaBancaria();
            //conta1.Titular = new Pessoa(); // Não quero mais isso aqui!

            Console.WriteLine("Informe o nome do titular: ");
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
