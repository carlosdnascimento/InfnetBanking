using System;
using System.Collections.Generic;

namespace InfnetBanking
{
    class Program
    {
        static void Main(string[] args)
        {
            var clientes = new List<Pessoa>();
            Console.WriteLine("Informe os nomes dos clientes a seguir.");
            while (true)
            {
                Console.Write("CPF: ");
                string cpf = Console.ReadLine();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Sobrenome: ");
                string sobrenome = Console.ReadLine();
                Pessoa p = new Pessoa(cpf, nome, sobrenome);
                clientes.Add(p);
                Console.Write("Digite qualquer tecla para continuar, 0 para sair... ");
                string opcao = Console.ReadLine();
                if (opcao == "0")
                {
                    break;
                }
            }
        }

        private static void Exemplo20200508()
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
