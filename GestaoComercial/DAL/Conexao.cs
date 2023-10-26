using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class Conexao
    {
        private static string stringDeConexao = "User ID=SA;Initial Catalog=Mercearia;Data Source=.\\SQLESXPRESS2019;Password=Senailab02";
        public static string StringDeConexao
        {
            get
            {
                return stringDeConexao;
            }
        }
    }
}
