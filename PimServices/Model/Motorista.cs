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



    }
}
