using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TGG.Representacoes
{
    public partial class FrmRelatorioPedidos : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;
        string strSQL;

        public FrmRelatorioPedidos()
        {
            InitializeComponent();
            MostrarPedidos();
            totalPedidos();
            SomaTodosPedidos();
            ValorTotalComissao();
            ValorMediaComissao();

        }

        public void totalPedidos()
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=DEVMENDONCA;Initial Catalog=TGG;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                strSQL = "SELECT COUNT(id) as id FROM dbo.[pedidos]";

                DataTable ds = new DataTable();

                da = new SqlDataAdapter(strSQL, conexao);


                conexao.Open();
                da.Fill(ds);

                var resultado = ds.Rows[0]["id"];

                lblTotalPedidos.Text = "Quantiade de Pedidos: " + resultado;

                conexao.Close();

            }
            catch (SqlException ex)
            {

                throw ex;
                return;
            }
        }

        public void SomaTodosPedidos()
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=DEVMENDONCA;Initial Catalog=TGG;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                strSQL = "SELECT SUM(ValorPedido) as ValorTotalPedidos FROM dbo.[pedidos]";

                DataTable ds = new DataTable();

                da = new SqlDataAdapter(strSQL, conexao);


                conexao.Open();
                da.Fill(ds);

                var resultado = ds.Rows[0]["ValorTotalPedidos"].ToString();

                lblSomaPedidos.Text = "Soma Todos os pedidos: R$ " + resultado;

                conexao.Close();

            }
            catch (SqlException ex)
            {

                throw ex;
                return;
            }
        }

        public void ValorTotalComissao()
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=DEVMENDONCA;Initial Catalog=TGG;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                strSQL = "SELECT SUM(ValorComissao) as ValorTotalComissao FROM dbo.[pedidos]";

                DataTable ds = new DataTable();

                da = new SqlDataAdapter(strSQL, conexao);


                conexao.Open();
                da.Fill(ds);

                var resultado = ds.Rows[0]["ValorTotalComissao"].ToString();

                lblTotalComissao.Text = "Valor Total Comissão: R$ " + resultado;

                conexao.Close();

            }
            catch (SqlException ex)
            {

                throw ex;
                return;
            }
        }

        public void ValorMediaComissao()
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=DEVMENDONCA;Initial Catalog=TGG;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                strSQL = "SELECT AVG(ValorComissao) as MediaComissao FROM dbo.[pedidos]";

                DataTable ds = new DataTable();

                da = new SqlDataAdapter(strSQL, conexao);


                conexao.Open();
                da.Fill(ds);

                var resultado = ds.Rows[0]["MediaComissao"];

                lblMedia.Text = "Valor Média Comissão: R$ " + resultado;

                conexao.Close();

            }
            catch (SqlException ex)
            {
                throw ex;
                return;
            }
        }

        public void MostrarPedidos()
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=DEVMENDONCA;Initial Catalog=TGG;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                strSQL = "SELECT * FROM Pedidos";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);


                conexao.Open();
                da.Fill(ds);

                dgvDados.DataSource = ds.Tables[0].ToString();
                conexao.Close();


            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                conexao.Close();
                comando = null;
                conexao = null;

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=DEVMENDONCA;Initial Catalog=TGG;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                strSQL = "SELECT * FROM Pedidos WHERE Cliente = '" + txtBuscar.Text + "'";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);


                conexao.Open();
                da.Fill(ds);

                dgvDados.DataSource = ds.Tables[0];
                conexao.Close();


            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                comando = null;
                conexao = null;

            }

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=DEVMENDONCA;Initial Catalog=TGG;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                strSQL = "SELECT * FROM Pedidos";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);


                conexao.Open();
                da.Fill(ds);

                dgvDados.DataSource = ds.Tables[0];
                conexao.Close();


            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                comando = null;
                conexao = null;

            }
        }

        private void botaoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
