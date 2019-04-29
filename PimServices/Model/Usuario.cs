using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PimServices.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Ativo { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }

        public static string Cripitografar(string senha)
        {
            SHA512 shaM = new SHA512Managed();
            byte[] hash = shaM.ComputeHash(Encoding.UTF8.GetBytes(senha));

            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)
                sb.AppendFormat("{0:x2}", b);

            return sb.ToString();

        }
    }
}
