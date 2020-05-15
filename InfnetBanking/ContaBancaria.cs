using System;

namespace InfnetBanking
{
    public class ContaBancaria
    {
        // Classes possuem membros
        // Membros podem ser campos / propriedades ou métodos
        private double saldo;

        public double Saldo
        {
            get
            {
                return saldo;
            }
        }

        //Poderíamos ter criado Saldo como uma autopropriedade apenas com método get. Teríamos:
        //public double Saldo { get; } // <- Sem um set

        //Autopropriedades (C# 3.0 ou superior)
        public int Agencia { get; set; }
        public int Numero { get; set; }

        public Pessoa Titular { get; set; }

        //Construtores para a classe:
        public ContaBancaria()
        {
            // Construtor padrão explicitado.
        }

        //Métodos da classe:
        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
            }
            else
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
