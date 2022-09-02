using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;


namespace TGG.Representacoes
{
    public partial class EnviarPedidoEmail : Form
    {
        public EnviarPedidoEmail()
        {
            InitializeComponent();
            CarregarDadosEmail();
            
        }

        public void CarregarDadosEmail()
        {
            txtRemetente.Text = "tatianenogcomercial@gmail.com";
            txtAssunto.Text = "[ Novo Pedido ] - TGG REPRESENTACOES";
            txtMensagem.Text = "";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EmailEnviar();
        }

        public void EmailEnviar()
        {
            try
            {
                using (SmtpClient smtp = new SmtpClient())
                {
                    using (MailMessage email = new MailMessage())
                    {
                        //SMTP 

                        smtp.Host = "smtp.gmail.com";
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new System.Net.NetworkCredential("tatianenogcomercial@gmail.com","Tatiane2904");
                        smtp.Port = 587;
                        smtp.EnableSsl = true;

                        //Email Mensagem
                        email.From = new MailAddress(txtRemetente.Text);
                        email.To.Add(txtDestinatario.Text);

                        email.Subject = txtAssunto.Text;
                        email.IsBodyHtml = false;
                        email.Body = txtMensagem.Text;

                        if (lblAttachments.Text != "")
                        {
                            var anexo = lblAttachments.Text.ToString().Split(';');
                            for(int i = 0; i < anexo.Count(); i++)
                            email.Attachments.Add(new Attachment(anexo[i]));

                        }
                        smtp.Send(email);
                    }
                }

                MessageBox.Show("Email Enviado Com sucesso");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void lblAttachments_Click(object sender, EventArgs e)
        {
            var anexo = new OpenFileDialog();

            anexo.Multiselect = true;
            anexo.Title = "Anexar Arquivos";

            if (anexo.ShowDialog() == DialogResult.OK)
                for (int i = 0; i < anexo.FileNames.Count(); i++)
                    if (i == 0)
                        lblAttachments.Text = anexo.FileNames[i];
                    else
                        lblAttachments.Text = lblAttachments.Text + ";" + anexo.FileNames[i];

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
