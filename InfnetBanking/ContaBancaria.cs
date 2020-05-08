using System;

namespace InfnetBanking
{
    public class ContaBancaria
    {
        //Construtor para a classe:
        public ContaBancaria()
        {
            Titular = new Pessoa();
        }

        public ContaBancaria(double saldo, string nome, string sobrenome)
        {
            this.saldo = saldo;
            Titular = new Pessoa();
            Titular.Nome = nome;
            Titular.Sobrenome = sobrenome;
        }


        // Classes possuem membros
        // Membros podem ser campos / propriedades ou métodos
        private double saldo;

        //Autopropriedade (C# 3.0 ou superior)
        public int Agencia { get; set; }

        //Autopropriedade (C# 3.0 ou superior)
        public int Numero { get; set; }

        //Autopropriedade (C# 3.0 ou superior)
        public Pessoa Titular { get; set; }

        public double Saldo
        {
            get
            {
                return saldo;
            }
        }

        //Poderíamos ter criado Saldo como uma autopropriedade apenas com método get. Teríamos:
        //public double Saldo { get; } // <- Sem um set

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
            } else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public void Transferir(double valor, ContaBancaria conta)
        {
            // Programar as regras...
        }
    }
}
