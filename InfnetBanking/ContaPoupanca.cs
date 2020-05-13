using System;
using System.Diagnostics.CodeAnalysis;

namespace InfnetBanking
{
    public class ContaPoupanca : ContaBancaria , IComparable<ContaPoupanca>, IEquatable<ContaPoupanca>
    {
        public DateTime DataAniversario { get; set; }

        public void CalcularRentabilidade()
        {
            if (Aniversario())
            {
                Depositar(Saldo * 0.0017);
            }
        }

        public Boolean Aniversario()
        {
            if (DataAniversario.Day == DateTime.Now.Day)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CompareTo(ContaPoupanca c)
        {
            return this.DataAniversario.CompareTo(c.DataAniversario);
        }

        public bool Equals(ContaPoupanca c)
        {
            if (this.Agencia.Equals(c.Agencia) 
                && this.Numero.Equals(c.Numero) 
                && this.Titular.Equals(c.Titular))
            {
                return true;
            } else
            {
                return false; 
            }
        }
    }
}
