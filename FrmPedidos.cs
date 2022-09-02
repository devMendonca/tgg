using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;



namespace TGG.Representacoes
{
    public partial class FrmPedidos : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;
        string strSQL;


        public FrmPedidos()
        {
            InitializeComponent();
            ObterData();
           
            Random randNum = new Random();

            txtId.Text = randNum.Next().ToString();

        }

        public void ObterData()
        {
            txtData.Text = DateTime.Now.ToString();
        }

        private void MostrarValor()
        {
            double valor1, valor2, valor3, valor4, valor5, valor6, valor7, valor8, resultado;

            valor1 = Convert.ToDouble("0" + txtTotal1.Text);
            valor2 = Convert.ToDouble("0" + txtTotal2.Text);
            valor3 = Convert.ToDouble("0" + txtTotal3.Text);
            valor4 = Convert.ToDouble("0" + txtTotal4.Text);
            valor5 = Convert.ToDouble("0" + txtTotal5.Text);
            valor6 = Convert.ToDouble("0" + txtTotal6.Text);
            valor7 = Convert.ToDouble("0" + txtTotal7.Text);
            valor8 = Convert.ToDouble("0" + txtTotal8.Text);
            resultado = valor1 + valor2 + valor3 + valor4 + valor5 + valor6 + valor7 + valor8;

            txtValorTotal.Text = resultado.ToString("N2");
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                string xml = @"http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", txtCep.Text);

                ds.ReadXml(xml);

                txtEndereco.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                txtEstado.Text = ds.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Nao foi possivel encontrar o CEP", ex.Message);
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        public void LimparFormulario()
        {
            txtCliente.Text = "";
            txtCep.Text = "";
            txtCnpj.Text = "";
            txtContato.Text = "";
            txtEndereco.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtId.Text = "";
            txtNumero.Text = "";
            txtInscricao.Text = "";
            txtTransportadora.Text = "";
            txtEstado.Text = "";
            txtContatoTelefone.Text = "";


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MostrarValorProdutos();
            MostrarValor();
        }

        public void MostrarValorProdutos()
        {
            
            //Produto 1 
            double valor1, valor2, valor3, resultado;

            valor1 = Convert.ToDouble("0" + txtQuantidade1.Text);
            valor2 = Convert.ToDouble("0" + txtUnitario1.Text);
            valor3 = Convert.ToDouble("0" + txtPrecoKg1.Text);

            resultado = valor1 * valor2 * valor3;

            txtTotal1.Text = resultado.ToString("N2");

            //Produto 2
            double valor4, valor5, valor6, resultado1;

            valor4 = Convert.ToDouble("0" + txtQuantidade2.Text);
            valor5 = Convert.ToDouble("0" + txtUnitario2.Text);
            valor6 = Convert.ToDouble("0" + txtPrecoKg2.Text);

            resultado1 = valor4 * valor5 * valor6;

            txtTotal2.Text = resultado1.ToString("N2");


            //Produto 3
            double valor7, valor8, valor9, resultado3;

            valor7 = Convert.ToDouble("0" + txtQuantidade3.Text);
            valor8 = Convert.ToDouble("0" + txtUnitario3.Text);
            valor9 = Convert.ToDouble("0" + txtPrecoKg3.Text);

            resultado3 = valor7 * valor8 * valor9;

            txtTotal3.Text = resultado3.ToString("N2");


            //Produto 4
            double valor10, valor11, valor12, resultado4;

            valor10 = Convert.ToDouble("0" + txtQuantidade4.Text);
            valor11 = Convert.ToDouble("0" + txtUnitario4.Text);
            valor12 = Convert.ToDouble("0" + txtPrecoKg4.Text);

            resultado4 = valor10 * valor11 * valor12;

            txtTotal4.Text = resultado4.ToString("N2");

            //Produto 5
            double valor13, valor14, valor15, resultado5;

            valor13 = Convert.ToDouble("0" + txtQuantidade5.Text);
            valor14 = Convert.ToDouble("0" + txtUnitario5.Text);
            valor15 = Convert.ToDouble("0" + txtPrecoKg5.Text);

            resultado5 = valor13 * valor14 * valor15;

            txtTotal5.Text = resultado5.ToString("N2");

            //Produto 6
            double valor16, valor17, valor18, resultado6;

            valor16 = Convert.ToDouble("0" + txtQuantidade6.Text);
            valor17 = Convert.ToDouble("0" + txtUnitario6.Text);
            valor18 = Convert.ToDouble("0" + txtPrecoKg6.Text);

            resultado6 = valor4 * valor17 * valor18;

            txtTotal6.Text = resultado6.ToString("N2");

            //Produto 7
            double valor19, valor20, valor21, resultado7;

            valor19 = Convert.ToDouble("0" + txtQuantidade7.Text);
            valor20 = Convert.ToDouble("0" + txtUnitario7.Text);
            valor21 = Convert.ToDouble("0" + txtPrecoKg7.Text);

            resultado7 = valor19 * valor20 * valor21;

            txtTotal7.Text = resultado7.ToString("N2");

            //Produto 8
            double valor22, valor23, valor24, resultado8;

            valor22 = Convert.ToDouble("0" + txtQuantidade8.Text);
            valor23 = Convert.ToDouble("0" + txtUnitario8.Text);
            valor24 = Convert.ToDouble("0" + txtPrecoKg8.Text);

            resultado8 = valor22 * valor23 * valor24;

            txtTotal8.Text = resultado8.ToString("N2");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviarPedidoEmail enviarEmail = new EnviarPedidoEmail();
            enviarEmail.Show();
        }

        private void EnviarSql()
        {
            var cliente = clsFuncoes.RemoverEspeciais(txtCliente.Text);
            var contato = clsFuncoes.RemoverEspeciais(txtContato.Text);
            var endereco = clsFuncoes.RemoverEspeciais(txtEndereco.Text);
            var cidade = clsFuncoes.RemoverEspeciais(txtCidade.Text);
            var bairro = clsFuncoes.RemoverEspeciais(txtBairro.Text);
            if (txtValorTotal.Text == "")
                txtValorTotal.Text = 0.ToString();
            var valorTotal = Convert.ToDecimal(txtValorTotal.Text);

            if (txtValorComissao.Text == "")
                txtValorComissao.Text = 0.ToString();
            var ComissaoTotal = Convert.ToDecimal(txtValorComissao.Text);

            try
            {
                conexao = new SqlConnection(@"Data Source=DEVMENDONCA;Initial Catalog=TGG;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                strSQL = "INSERT INTO Pedidos (Id, Cliente, CEP, CNPJ, Contato, ContatoTelefone, Inscricao, Endereco, Cidade, Bairro, Numero, Estado, ValorPedido, ValorComissao, Transportadora, Data) " +
                    "VALUES (@Id, @Cliente, @CEP, @CNPJ, @Contato, @ContatoTelefone, @Inscricao, @Endereco, @Cidade,@Bairro, @Numero, @Estado, @ValorPedido, @ValorComissao,@Transportadora, @Data)";
                comando = new SqlCommand(strSQL, conexao);

                conexao.Open();

                comando.Parameters.AddWithValue("@id", txtId.Text);
                comando.Parameters.AddWithValue("@Cliente", cliente);
                comando.Parameters.AddWithValue("@CEP", txtCep.Text);
                comando.Parameters.AddWithValue("@CNPJ", txtCnpj.Text);
                comando.Parameters.AddWithValue("@Contato", contato);
                comando.Parameters.AddWithValue("@ContatoTelefone", txtContatoTelefone.Text);
                comando.Parameters.AddWithValue("@Inscricao", txtInscricao.Text);
                comando.Parameters.AddWithValue("@Endereco", endereco);
                comando.Parameters.AddWithValue("@Cidade", cidade);
                comando.Parameters.AddWithValue("@Bairro", bairro);
                comando.Parameters.AddWithValue("@Numero", txtNumero.Text);
                comando.Parameters.AddWithValue("@Estado", txtEstado.Text);
                comando.Parameters.AddWithValue("@ValorPedido", valorTotal);
                comando.Parameters.AddWithValue("@ValorComissao", ComissaoTotal);
                comando.Parameters.AddWithValue("@Transportadora", txtTransportadora.Text);
                comando.Parameters.AddWithValue("@Data", txtData.Text);

                

                comando.ExecuteNonQuery();

                conexao.Close();

                MessageBox.Show("Pedido cadastrado com sucesso", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

       public void button2_Click(object sender, EventArgs e)
        {
            this.Close();
                
        }

        private void txtEnviarPDF_Click(object sender, EventArgs e)
        {
            GerarPdf();
        }

       

    private void GerarPdf()
        {

            var arquivo = @"C:\Users\david\OneDrive\Documentos\tgg_Novo\tgg_Novo\Pedidos\Pedido_" + txtId.Text + ".pdf";

            using(PdfWriter wPdf = new PdfWriter(arquivo, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wPdf);

                var document = new Document(pdfDocument, PageSize.A4);

                ImageData imageData = ImageDataFactory.Create(@"C:\Users\david\OneDrive\Documentos\tgg_Novo\tgg_Novo\tgg.jpeg");

                Image image = new Image(imageData).ScaleAbsolute(200, 200).SetFixedPosition(1, 25, 25);
                document.Add(image);

                float[] tamanhoColuna = {100,100,100};
                Table tabelaTitulo = new Table(UnitValue.CreatePercentArray(tamanhoColuna));
                var fonte = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
                
                /// INSERIR CABEÇALHO DA TABELA
                tabelaTitulo.AddHeaderCell(new Cell(1,3).SetBackgroundColor(ColorConstants.WHITE).SetFontColor(ColorConstants.BLACK)
                    .Add(new Paragraph("TGG   -   REPRESENTAÇÕES \n").SetFontSize(14)
                    .Add(new Paragraph("CNPJ: 39.399.628/0001-47            Atividade principal: (CNAE 7319-0/02) ").SetFontSize(12))
                    .SetFont(fonte)
                    .SetPadding(10)
                    .SetTextAlignment(TextAlignment.CENTER)));

                //INSERIR OS PRIMEIROS DADOS DA TABELA
                tabelaTitulo.AddHeaderCell(new Cell(2,3)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .Add(new Paragraph("   Data: " + txtData.Text + "                                                                  Vendedor: Tatiane   ")));
                    

                // INSERIR DADOS DO CLIENTE
                tabelaTitulo.AddCell(new Cell(3,3).SetTextAlignment(TextAlignment.LEFT)
                    .Add(new Paragraph("Pedido: " + txtId.Text + "         \n").SetFontSize(10)
                    .Add(new Paragraph("Razão Social: " + txtCliente.Text + " - CNPJ: " + txtCnpj.Text + "\n Inscrição: " + txtInscricao.Text + "\n").SetFontSize(10)
                    .Add(new Paragraph("Endereço: rua " + txtEndereco.Text + ", " + txtNumero.Text + ", CEP: " + txtCep.Text + "\n").SetFontSize(10)
                    .Add(new Paragraph("Bairro: " + txtBairro.Text + ", " + txtCidade.Text + "-" + txtEstado.Text + "\n").SetFontSize(10)
                    .Add(new Paragraph("Contato nome: " + txtContato.Text + "       Contato telefone: " + txtContatoTelefone.Text + "\n").SetFontSize(10)
                    .Add(new Paragraph("Transportadora: " + txtTransportadora.Text + "                                        Prazo: " + txtPrazo.Text + "\n").SetFontSize(10))))))));
                
                tabelaTitulo.SetSkipFirstHeader(false);
                
                document.Add(tabelaTitulo);



                ///Criar tabela 
                float[] columnWidths = { 5, 5, 20, 10, 10 };
                Table tabela = new Table(UnitValue.CreatePercentArray(columnWidths));


                //TITULO do cabeçalho 
                
                tabela.AddHeaderCell(new Cell(1, 5).Add(new Paragraph(" Lista de produtos")
                    .SetFontSize(12)
                    .SetBackgroundColor(ColorConstants.WHITE)
                    .SetFontColor(ColorConstants.BLACK)
                    .SetTextAlignment(TextAlignment.CENTER)));

                //Adicionar os titulos das colunas

                tabela.AddHeaderCell(new Cell()
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .Add(new Paragraph("Qtde").SetFontSize(10)));

                tabela.AddHeaderCell(new Cell()
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetPaddingLeft(5)
                    .Add(new Paragraph("Peso KG").SetFontSize(10)));

                tabela.AddHeaderCell(new Cell()
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph("Descrição do produto").SetFontSize(10)));

                tabela.AddHeaderCell(new Cell()
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph("Preço KG").SetFontSize(10)));

                tabela.AddHeaderCell(new Cell()
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph("Valor Total").SetFontSize(10)));
                tabela.SetSkipFirstHeader(false);


                //1 produto 
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(txtQuantidade1.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(txtUnitario1.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph(txtDescricao1.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.RIGHT).Add(new Paragraph(txtPrecoKg1.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.RIGHT).Add(new Paragraph(txtTotal1.Text).SetFontSize(10)));

                //2 produto 
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(txtQuantidade2.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(txtUnitario2.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph(txtDescricao2.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.RIGHT).Add(new Paragraph(txtPrecoKg2.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.RIGHT).Add(new Paragraph(txtTotal2.Text).SetFontSize(10)));

                //3 produto 
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(txtQuantidade3.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(txtUnitario3.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph(txtDescricao3.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.RIGHT).Add(new Paragraph(txtPrecoKg3.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.RIGHT).Add(new Paragraph(txtTotal3.Text).SetFontSize(10)));

                //4 produto 
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(txtQuantidade4.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(txtUnitario4.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph(txtDescricao4.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.RIGHT).Add(new Paragraph(txtPrecoKg4.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.RIGHT).Add(new Paragraph(txtTotal4.Text).SetFontSize(10)));

                //5 produto 
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(txtQuantidade5.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(txtUnitario5.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph(txtDescricao5.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.RIGHT).Add(new Paragraph(txtPrecoKg5.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.RIGHT).Add(new Paragraph(txtTotal5.Text).SetFontSize(10)));

                //6 produto 
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(txtQuantidade6.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(txtUnitario6.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph(txtDescricao6.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.RIGHT).Add(new Paragraph(txtPrecoKg6.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.RIGHT).Add(new Paragraph(txtTotal6.Text).SetFontSize(10)));

                //7 produto 
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(txtQuantidade7.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(txtUnitario7.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph(txtDescricao7.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.RIGHT).Add(new Paragraph(txtPrecoKg7.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.RIGHT).Add(new Paragraph(txtTotal7.Text).SetFontSize(10)));

                //8 produto 
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(txtQuantidade8.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(txtUnitario8.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph(txtDescricao8.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.RIGHT).Add(new Paragraph(txtPrecoKg8.Text).SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.RIGHT).Add(new Paragraph(txtTotal8.Text).SetFontSize(10)));

                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("").SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("").SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("").SetFontSize(10)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).SetBackgroundColor(ColorConstants.LIGHT_GRAY).Add(new Paragraph("Total Pedido").SetFontSize(13)));
                tabela.AddCell(new Cell().SetTextAlignment(TextAlignment.RIGHT).SetBackgroundColor(ColorConstants.LIGHT_GRAY).Add(new Paragraph("R$      " + txtValorTotal.Text).SetFontSize(13)));


                document.Add(tabela);

                Paragraph paragrafo = new Paragraph();
                
                paragrafo.Add("\n PEDIDO COM PUXADA").SetFontSize(18);

                document.Add(paragrafo);

                document.Close();

                EnviarSql();
            }
        }

        private void txtValorTotal_DoubleClick(object sender, EventArgs e)
        {
            MostrarValorProdutos();
            MostrarValor();

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            frmVerPedido verPedido = new frmVerPedido();
            verPedido.Show(this);
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
