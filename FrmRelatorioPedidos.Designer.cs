
namespace TGG.Representacoes
{
    partial class FrmRelatorioPedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalPedidos = new System.Windows.Forms.Label();
            this.lblSomaPedidos = new System.Windows.Forms.Label();
            this.lblTotalComissao = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.botaoSair = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDados.ColumnHeadersHeight = 28;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDados.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDados.Location = new System.Drawing.Point(250, 80);
            this.dgvDados.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.RowHeadersWidth = 62;
            this.dgvDados.RowTemplate.Height = 28;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(737, 531);
            this.dgvDados.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Cliente";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(250, 42);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(279, 23);
            this.txtBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(534, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 34);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibir.Location = new System.Drawing.Point(888, 39);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(99, 34);
            this.btnExibir.TabIndex = 4;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(728, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Exibir Todos Pedidos";
            // 
            // lblTotalPedidos
            // 
            this.lblTotalPedidos.AutoSize = true;
            this.lblTotalPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPedidos.Location = new System.Drawing.Point(-2, 217);
            this.lblTotalPedidos.Name = "lblTotalPedidos";
            this.lblTotalPedidos.Size = new System.Drawing.Size(110, 17);
            this.lblTotalPedidos.TabIndex = 6;
            this.lblTotalPedidos.Text = "Qtde Pedidos: 0";
            // 
            // lblSomaPedidos
            // 
            this.lblSomaPedidos.AutoSize = true;
            this.lblSomaPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSomaPedidos.Location = new System.Drawing.Point(-2, 147);
            this.lblSomaPedidos.Name = "lblSomaPedidos";
            this.lblSomaPedidos.Size = new System.Drawing.Size(172, 17);
            this.lblSomaPedidos.TabIndex = 7;
            this.lblSomaPedidos.Text = "Soma todos os pedidos: 0";
            // 
            // lblTotalComissao
            // 
            this.lblTotalComissao.AutoSize = true;
            this.lblTotalComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalComissao.Location = new System.Drawing.Point(-2, 182);
            this.lblTotalComissao.Name = "lblTotalComissao";
            this.lblTotalComissao.Size = new System.Drawing.Size(158, 17);
            this.lblTotalComissao.TabIndex = 8;
            this.lblTotalComissao.Text = "Valor Total Comissão: 0";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(-2, 113);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(177, 17);
            this.lblMedia.TabIndex = 9;
            this.lblMedia.Text = "Média(valor) de pedidos: 0";
            // 
            // botaoSair
            // 
            this.botaoSair.AllowDrop = true;
            this.botaoSair.AutoSize = true;
            this.botaoSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.botaoSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botaoSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botaoSair.Location = new System.Drawing.Point(10, 530);
            this.botaoSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(102, 83);
            this.botaoSair.TabIndex = 41;
            this.botaoSair.Text = "Sair";
            this.botaoSair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.botaoSair.UseMnemonic = false;
            this.botaoSair.UseVisualStyleBackColor = false;
            this.botaoSair.Click += new System.EventHandler(this.botaoSair_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(60, 22);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(103, 46);
            this.btnImprimir.TabIndex = 42;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // FrmRelatorioPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.botaoSair);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblTotalComissao);
            this.Controls.Add(this.lblSomaPedidos);
            this.Controls.Add(this.lblTotalPedidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "FrmRelatorioPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRelatorioPedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalPedidos;
        private System.Windows.Forms.Label lblSomaPedidos;
        private System.Windows.Forms.Label lblTotalComissao;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Button botaoSair;
        private System.Windows.Forms.Button btnImprimir;
    }
}