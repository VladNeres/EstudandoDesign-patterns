using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattes2.Capitulo1
{
    public class ConnectionFactory
    {

        public IDbConnection GetConnection()
        {
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = "User id=root;Password=root;Server=localhost;Database=meuBanco";
            conexao.Open();

            return conexao;
        }
    }
}
