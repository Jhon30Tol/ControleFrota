﻿using System;
using PimServices.RepositorySql.PimServices.RepositorySql;
namespace PimServices.Model
    {

    public class Motorista : Endereco
        {

        public string nome { get; set; }
        public string cnh { get; set; }
        public String cpf { get; set; }
        public DateTime dtaValidadeCpf { get; set; }
        public DateTime dtaNascimento { get; set; }
        public int Cep { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        public string complementoRua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public DateTime dtaEmissaoCnh { get; set; }
        public DateTime dtaVencimentoCnh { get; set; }
        public int id_motorista { get; set; }

        public int telefoneFixo { get; set; }
        public int celular { get; set; }

       




        }
    }
