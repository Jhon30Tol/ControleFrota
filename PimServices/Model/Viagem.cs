using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimServices.Model
{
    public class Viagem
    {

        public int Id_viagem { get; set; }

        public int Id_motorista { get; set; }

        public String Id_motorista_pesquisa { get; set; }

        public int Id_veiculo { get; set; }

        public String Id_veiculo_pesquisa { get; set; }

        public int Id_cidadeSaida { get; set; }

        public String uf_cidade { get; set; }

        public String Id_cidadeSaida_pesquisa { get; set; }

        public int Id_cidadeDestino { get; set; }

        public String Id_cidadeDestino_pesquisa { get; set; }

        public DateTime DtaSaida { get; set; }

        public DateTime DtaRetorno { get; set; }

        public int Id_cidadeRetorno { get; set; }

        public int KmSaida { get; set; }

        public int KmSaidaTeste { get; set; }

        public int KmRetorno { get; set; }

        public String passageiro { get; set; }



    }
}
