using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimServices.Model
{
    public class Cliente
    {
        private String _nome;
        public String Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private String _cpf;
        public String CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        private DateTime _dtNascimento;
        public DateTime Dt_Nascimento
        {
            get { return _dtNascimento; }
            set { _dtNascimento = value; }
        }

        private String _celular;
        public String Celular
        {
            get { return _celular; }
            set { _celular = value; }
        }

        private String _rua;
        public String Rua
        {
            get { return _rua; }
            set { _rua = value; }
        }

        private int _numero;
        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        private String _cep;
        public String CEP
        {
            get { return _cep; }
            set { _cep = value; }
        }

        private String _bairro;
        public String Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }

        private String _cidade;
        public String Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        private String _uf;
        public String UF
        {
            get { return _uf; }
            set { _uf = value; }
        }
    }
}
