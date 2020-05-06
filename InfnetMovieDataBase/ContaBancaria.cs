using System;

namespace InfnetBanking
{
    class ContaBancaria
    {
        // Classes possuem membros
        // Membros podem ser campos / propriedades ou métodos
        private double _saldo;

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
                return _saldo;
            }
        }

        //Poderíamos ter criado Saldo como uma autopropriedade apenas com método get. Teríamos:
        //public double Saldo { get; } // <- Sem um set

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (_saldo >= valor)
            {
                _saldo -= valor;
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
