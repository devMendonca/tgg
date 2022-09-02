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
    public partial class frmAlterarFator : Form
    {
        
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;
        string strSQL;

        frmProdutos f = new frmProdutos();
        public frmAlterarFator()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmProdutos f = new frmProdutos();
            var tabela = f.cmbProdutos.Text;

            if (MessageBox.Show("Tem certeza que deseja alterar o valor dos produtos?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            conexao = new SqlConnection(@"Data Source=DEVMENDONCA;Initial Catalog=TGG;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            strSQL = "UPDATE @tabela SET preco_avista = (preco_avista + @fator), preco_aprazo = (preco_aprazo + @fator)";
            comando = new SqlCommand(strSQL, conexao);

            conexao.Open();
            

            comando.Parameters.AddWithValue("@fator", txtFator.Text);
            comando.Parameters.AddWithValue("@tabela", tabela);

            try
            {
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
                throw;
            }
           

            conexao.Close();

            f.MostrarProdutos();

            MessageBox.Show("Valor Alterado Com Sucesso", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
