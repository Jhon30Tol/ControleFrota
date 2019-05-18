using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimServices.Model
{
    public class Cidade
    {
        public int id_cidade { get; set; }

        public String id_cidade_pesquisa { get; set; }


        public String nome_cidade { get; set; }

        public int cod_ibge { get; set; }

        public String uf_estado{ get; set; } 
    }
}
