using System;

namespace InfnetBanking
{
    class ContaBancaria
    {
        // Classes possuem membros
        // Membros podem ser campos / propriedades ou métodos
        private double _saldo;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
        }

        //Autopropriedade (C# 3.0 ou superior)
        public string Titular { get; set; }

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
