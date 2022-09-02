
namespace TGG.Representacoes
{
    partial class EnviarPedidoEmail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRemetente = new System.Windows.Forms.Label();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblAnexo = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtRemetente = new System.Windows.Forms.TextBox();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.lblAttachments = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblRemetente
            // 
            this.lblRemetente.AutoSize = true;
            this.lblRemetente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemetente.Location = new System.Drawing.Point(55, 93);
            this.lblRemetente.Name = "lblRemetente";
            this.lblRemetente.Size = new System.Drawing.Size(98, 20);
            this.lblRemetente.TabIndex = 0;
            this.lblRemetente.Text = "Remetente";
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinatario.Location = new System.Drawing.Point(46, 138);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(107, 20);
            this.lblDestinatario.TabIndex = 1;
            this.lblDestinatario.Text = "Destinatário";
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssunto.Location = new System.Drawing.Point(78, 186);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(75, 20);
            this.lblAssunto.TabIndex = 2;
            this.lblAssunto.Text = "Assunto";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(58, 312);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(96, 20);
            this.lblMensagem.TabIndex = 3;
            this.lblMensagem.Text = "Mensagem";
            // 
            // lblAnexo
            // 
            this.lblAnexo.AutoSize = true;
            this.lblAnexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnexo.Location = new System.Drawing.Point(94, 443);
            this.lblAnexo.Name = "lblAnexo";
            this.lblAnexo.Size = new System.Drawing.Size(59, 20);
            this.lblAnexo.TabIndex = 4;
            this.lblAnexo.Text = "Anexo";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnviar.Location = new System.Drawing.Point(163, 513);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(503, 39);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtRemetente
            // 
            this.txtRemetente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRemetente.Location = new System.Drawing.Point(163, 90);
            this.txtRemetente.Name = "txtRemetente";
            this.txtRemetente.Size = new System.Drawing.Size(503, 26);
            this.txtRemetente.TabIndex = 6;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDestinatario.Location = new System.Drawing.Point(163, 135);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(503, 26);
            this.txtDestinatario.TabIndex = 7;
            // 
            // txtAssunto
            // 
            this.txtAssunto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAssunto.Location = new System.Drawing.Point(163, 183);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(503, 26);
            this.txtAssunto.TabIndex = 8;
            // 
            // txtMensagem
            // 
            this.txtMensagem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMensagem.Location = new System.Drawing.Point(163, 234);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMensagem.Size = new System.Drawing.Size(503, 184);
            this.txtMensagem.TabIndex = 9;
            // 
            // lblAttachments
            // 
            this.lblAttachments.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAttachments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAttachments.Location = new System.Drawing.Point(163, 442);
            this.lblAttachments.Name = "lblAttachments";
            this.lblAttachments.Size = new System.Drawing.Size(503, 30);
            this.lblAttachments.TabIndex = 10;
            this.lblAttachments.Click += new System.EventHandler(this.lblAttachments_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enviar Email";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // EnviarPedidoEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(758, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAttachments);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.txtDestinatario);
            this.Controls.Add(this.txtRemetente);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblAnexo);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblAssunto);
            this.Controls.Add(this.lblDestinatario);
            this.Controls.Add(this.lblRemetente);
            this.Name = "EnviarPedidoEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnviarPedidoEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRemetente;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblAnexo;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtRemetente;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Label lblAttachments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}