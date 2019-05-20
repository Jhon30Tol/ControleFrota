using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimServices.Model
{
    public class Veiculo
    {
        private int _id_veiculo;
        public int id_veiculo
        {
            get { return _id_veiculo; }
            set { _id_veiculo = value; }
        }

        private String _marcaVeiculo;
        public String MarcaVeiculo
        {
            get { return _marcaVeiculo; }
            set { _marcaVeiculo = value; }
        }

        private String _modeloVeiculo;
        public String ModeloVeiculo
        {
            get { return _modeloVeiculo; }
            set { _modeloVeiculo = value; }
        }

        private int _anoVeiculo;
        public int AnoVeiculo
        {
            get { return _anoVeiculo; }
            set { _anoVeiculo = value; }
        }

        private int _anoModeloVeiculo;
        public int AnoModeloVeiculo
        {
            get { return _anoModeloVeiculo; }
            set { _anoModeloVeiculo = value; }
        }

        private String _chassi;
        public String Chassi
        {
            get { return _chassi; }
            set { _chassi = value; }
        }

        private String _tipoCombustivel;
        public String TipoCombustivel
        {
            get { return _tipoCombustivel; }
            set { _tipoCombustivel = value; }
        }

        private String _corVeiculo;
        public String CorVeiculo
        {
            get { return _corVeiculo; }
            set { _corVeiculo = value; }
        }

        private String _placa;
        public String Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }
    }
}
