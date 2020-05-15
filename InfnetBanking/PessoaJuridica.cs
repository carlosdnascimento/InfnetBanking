using System;
using System.Collections.Generic;
using System.Text;

namespace InfnetBanking
{
    public class PessoaJuridica : Pessoa
    {
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public DateTime DataFundacao { get; set; }
        public PessoaFisica RepresentanteLegal { get; set; }
        public string NaturezaJuridica { get; set; }
        public List<PessoaFisica> SociosAdministradores { get; set; }
        public List<PessoaJuridica> Franqueados { get; set; }

        public override bool CalcularAniversario()
        {
            if (DateTime.Now.Day == DataFundacao.Day && DateTime.Now.Month == DataFundacao.Month)
            {
                return true;
            }
            return false;
        }

        //Outros membros - propriedades ou métodos...
    }
}
