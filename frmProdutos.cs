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
    public partial class frmProdutos : Form
    {

        int id_produto;

        SqlCommand comando;
        clsDataBase dataBase = new clsDataBase();
        string sql;
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            MostrarProdutos();
        }

        public void MostrarProdutos()
        {
            clsDataBase dataBase = new clsDataBase();

            string tabela;
           

            //if (cmbProdutos.Text == "")
            //    MessageBox.Show("Escolha uma tabela para buscar produtos");return;

            tabela = cmbProdutos.Text;

            switch (tabela)
            {
                case "Iberica":
                    sql = "SELECT * FROM iberica ORDER BY nome";
                    break;
                case "jtc":
                    sql = "SELECT * FROM jtc ORDER BY nome";
                    break;
                case "benini":
                    sql = "SELECT * FROM benini ORDER BY nome";
                    break;
                default:
                    return;
                    break;
            }

            DataTable dados = dataBase.ExecutarSQL(sql);

            dgvProdutos.DataSource = dados;


        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var tabela = cmbProdutos.Text;

            sql = "SELECT * FROM " + cmbProdutos.Text + "WHERE nome LIKE '%" + txtProduto.Text + "%'";

            DataTable dados = dataBase.ExecutarSQL(sql);

            dgvProdutos.DataSource = dados;


        }

        private void btnFator_Click(object sender, EventArgs e)
        {
            frmAlterarFator f = new frmAlterarFator();
            f.ShowDialog();
        }

        

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

            if (e.RowIndex == -1) return;

            id_produto = (int)dgvProdutos["id_produto", e.RowIndex].Value;

            SqlConnection ligacao = new SqlConnection(@"Data Source=DEVMENDONCA;Initial Catalog=TGG;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            ligacao.Open();

            comando = new SqlCommand("SELECT * FROM " + cmbProdutos.Text + " WHERE id_produto = " + id_produto, ligacao);
            SqlDataReader dr = comando.ExecuteReader();
            dr.Read();

            if(cmbProdutos.Text == "Iberica")
            {
                txtProdutoJtc.Text = txtProduto.Text = "";
                txtValorForaSp.Text = "";
                txtSimplesNacional.Text = "";
                txtEmbalagemJtc.Text = "";
                txtTipo.Text = "";
                txtProdutoBenini.Text = "";
                txtPesoLiq.Text = "";
                txtPallet.Text = "";
                txtForaEstado.Text = "";
                txtDentoEstado.Text = "";



                 txtProduto.Text = dr["nome"].ToString();
                 txtEmbalagem.Text = dr["embalagem"].ToString();
                 txtValorPrazo.Text = dr["preco_aprazo"].ToString();
                 txtValorVista.Text = dr["preco_avista"].ToString();
            }

            if(cmbProdutos.Text == "jtc")
            {
                txtProduto.Text = "";
                txtEmbalagem.Text = "";
                txtValorPrazo.Text = "";
                txtValorVista.Text = "";
                txtProdutoBenini.Text = "";
                txtPesoLiq.Text = "";
                txtPallet.Text = "";
                txtForaEstado.Text = "";
                txtDentoEstado.Text = "";


                txtProdutoJtc.Text = txtProduto.Text = dr["nome"].ToString();
                txtValorForaSp.Text = dr["valor_fora_sp"].ToString();
                txtSimplesNacional.Text = dr["simples_nacional"].ToString();
                txtEmbalagemJtc.Text = dr["embalagem"].ToString();
                txtTipo.Text = dr["tipo"].ToString();
            }
            if(cmbProdutos.Text == "benini")
            {

                txtProduto.Text = "";
                txtEmbalagem.Text = "";
                txtValorPrazo.Text = "";
                txtValorVista.Text = "";
                txtProdutoJtc.Text = "";
                txtValorForaSp.Text = "";
                txtSimplesNacional.Text = "";
                txtEmbalagemJtc.Text = "";
                txtTipo.Text = "";


                txtProdutoBenini.Text = dr["nome"].ToString();
                txtPesoLiq.Text = dr["peso_liq"].ToString();
                txtPallet.Text = dr["pallet"].ToString();
                txtForaEstado.Text = dr["fora_estado"].ToString();
                txtDentoEstado.Text = dr["dentro_estado"].ToString();
            }
            else
            {
                return;
            }

            ligacao.Close();

        }
    }
}
