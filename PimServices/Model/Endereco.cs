using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimServices.Model
{
    public class Endereco
    {
        public string nomeRua { get; set; }

        public string numeroRua { get; set; }

        public int cep { get; set; }

        public string bairro { get; set; }

        public int idCidade { get; set; }

    }
}
