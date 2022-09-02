using PdfiumViewer;
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
    public partial class frmVerPedido : Form
    {
        PdfiumViewer.PdfViewer pdf;
        public frmVerPedido()
        {
            InitializeComponent();
            pdf = new PdfViewer();
            pdf.Width = this.Width - 20;
            pdf.Height = this.Height - 40;
            this.Controls.Add(pdf);
        }

        public void OpenFile(string filepath)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(filepath);
            var stream = new System.IO.MemoryStream(bytes);
            PdfDocument pdfDocument = PdfDocument.Load(stream);
            pdf.Document = pdfDocument;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                OpenFile(dialog.FileName);
            }
        }

        
    }
}
