using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TGG.Representacoes
{
    public class clsDataBase
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;
       string ligacao = @"Data Source=DESKTOP-9THF0FO;Initial Catalog=Tgg;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public clsDataBase()
        {
            conexao = new SqlConnection(ligacao);
        }

        public DataTable ExecutarSQL(string query)
        {
            da = new SqlDataAdapter(query, ligacao);

            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message + " ao localizar produtos");
                throw;
            }

            return dt;


            
        }

    }
}
