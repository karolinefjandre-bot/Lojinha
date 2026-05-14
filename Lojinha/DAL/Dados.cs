using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha.DAL
{
    public class Dados
    {
        public static string StringConexao
        {
            get 
            {
                // Fixed connection string: use backslash for LocalDB instance name
                string conexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dblojinha;Integrated Security=True;Encrypt=False";
                return conexao;
            }       
        }
    }
}
