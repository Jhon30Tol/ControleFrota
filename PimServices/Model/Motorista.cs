using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimServices.Model
{
    public class Motorista : Endereco
    {

       

        public int id { get; set; }
        public string nome { get; set; }

        public int cpf { get; set; }

        public int cnh { get; set; }

        public string dtaNascimento { get; set; }

        public string dtaVencimentoCnh { get; set; }

        /*

        private string _nome;
        private decimal _cnh;
        private decimal _cpf;
        private DateTime _dtaValidadeCpf;
        private DateTime _dtaNascimento;
        private decimal _cep;
        private string _rua;
        private decimal _numero;
        private string _complementoRua;
        private string _bairro;
        private string _cidade;
        private string _estado;


        public string get_nome()
        {
            return _nome;
        }
        public void set_nome(string _nome)
        {
            this._nome = _nome;
        }
        public decimal get_cnh()
        {
            return _cnh;
        }
        public void set_cnh(decimal _cnh)
        {
            this._cnh = _cnh;
        }
        public decimal get_cpf()
        {
            return _cpf;
        }
        public void set_cpf(decimal _cpf)
        {
            this._cpf = _cpf;
        }
        public DateTime get_dtaValidadeCpf()
        {
            return _dtaValidadeCpf;
        }
        public void set_dtaValidadeCpf(DateTime _dtaValidadeCpf)
        {
            this._dtaValidadeCpf = _dtaValidadeCpf;
        }
        public DateTime get_dtaNascimento()
        {
            return _dtaNascimento;
        }
        public void set_dtaNascimento(DateTime _dtaNascimento)
        {
            this._dtaNascimento = _dtaNascimento;
        }
        public decimal get_cep()
        {
            return _cep;
        }
        public void set_cep(decimal _cep)
        {
            this._cep = _cep;
        }
        public string get_rua()
        {
            return _rua;
        }
        public void set_rua(string _rua)
        {
            this._rua = _rua;
        }
        public decimal get_numero()
        {
            return _numero;
        }
        public void set_numero(decimal _numero)
        {
            this._numero = _numero;
        }
        public string get_complementoRua()
        {
            return _complementoRua;
        }
        public void set_complementoRua(string _complementoRua)
        {
            this._complementoRua = _complementoRua;
        }
        public string get_bairro()
        {
            return _bairro;
        }
        public void set_bairro(string _bairro)
        {
            this._bairro = _bairro;
        }
        public string get_cidade()
        {
            return _cidade;
        }
        public void set_cidade(string _cidade)
        {
            this._cidade = _cidade;
        }
        public string get_estado()
        {
            return _estado;
        }
        public void set_estado(string _estado)
        {
            this._estado = _estado;
        }

    */

    }
}
