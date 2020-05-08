using System;

namespace InfnetBanking
{
    public class ContaPoupanca : ContaBancaria 
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
    }
}
