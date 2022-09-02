using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TGG.Representacoes
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedidos pedidos = new FrmPedidos();
            pedidos.WindowState = FormWindowState.Maximized;
            pedidos.Show();
        }

        private void relatorioDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorioPedidos ped = new FrmRelatorioPedidos();
            ped.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutos f = new frmProdutos();
            f.Show();

        }
    }
}
