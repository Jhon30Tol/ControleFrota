using System;

namespace PimServices.Model
    {

    public class Motorista : Endereco
        {

        public string nome { get; set; }
        public string cnh { get; set; }
        public String cpf { get; set; }
        public DateTime dtaValidadeCpf { get; set; }
        public DateTime dtaNascimento { get; set; }
        public decimal Cep { get; set; }
        public string rua { get; set; }
        public decimal numero { get; set; }
        public string complementoRua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string estado { get; set; }
        public DateTime dtaEmissaoCnh { get; set; }
        public DateTime dtaVencimentoCnh { get; set; }

        public int telefoneFixo { get; set; }
        public int celular { get; set; }


        }
    }
