using System;

namespace InfnetBanking
{
    public class Endereco
    {
        public string TipoLogradouro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public string Pais { get; set; }

        public override string ToString()
        {
            string endereco = TipoLogradouro + " " +
                Logradouro + ", " +
                Numero;

            if(Complemento.Trim() != "" && !Complemento.Equals(null))
            {
                endereco += ", "+ Complemento;
            }
            
            endereco += Environment.NewLine +
                Bairro + ", " +
                Municipio + ", " +
                Uf + ", " +
                Pais + " " + Environment.NewLine +
                "CEP " + Cep;

            return endereco;
        }
    }
}