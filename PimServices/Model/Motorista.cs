using System;
using PimServices.RepositorySql.PimServices.RepositorySql;
namespace PimServices.Model
    {
    public class Motorista
        {

        public string nome { get; set; }
        public string cnh { get; set; }
        public String cpf { get; set; }
        public DateTime dtaValidadeCpf { get; set; }
        public DateTime dtaNascimento { get; set; }
        public String Cep { get; set; }
        public string rua { get; set; }
        public String numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public DateTime dtaEmissaoCnh { get; set; }
        public DateTime dtaVencimentoCnh { get; set; }
        public int id_motorista { get; set; }
        public String telefoneFixo { get; set; }
        public String celular { get; set; }

        }
    }
