
namespace TGG.Representacoes
{
    partial class FrmPrincipal
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
            System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem operacoesToolStripMenuItem;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            operacoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            inicioToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            inicioToolStripMenuItem.BackgroundImage = global::TGG.Representacoes.Properties.Resources.home;
            inicioToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            inicioToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            inicioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            inicioToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4);
            inicioToolStripMenuItem.MergeIndex = 2;
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            inicioToolStripMenuItem.ShowShortcutKeys = false;
            inicioToolStripMenuItem.Size = new System.Drawing.Size(84, 70);
            inicioToolStripMenuItem.Text = "Inicio Home";
            inicioToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // operacoesToolStripMenuItem
            // 
            operacoesToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            operacoesToolStripMenuItem.BackgroundImage = global::TGG.Representacoes.Properties.Resources.Gear;
            operacoesToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            operacoesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.relatorioDePedidosToolStripMenuItem,
            this.produtosToolStripMenuItem});
            operacoesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            operacoesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4);
            operacoesToolStripMenuItem.Name = "operacoesToolStripMenuItem";
            operacoesToolStripMenuItem.ShowShortcutKeys = false;
            operacoesToolStripMenuItem.Size = new System.Drawing.Size(75, 70);
            operacoesToolStripMenuItem.Text = "Operacoes";
            operacoesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // relatorioDePedidosToolStripMenuItem
            // 
            this.relatorioDePedidosToolStripMenuItem.Name = "relatorioDePedidosToolStripMenuItem";
            this.relatorioDePedidosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.relatorioDePedidosToolStripMenuItem.Text = "Relatorio de pedidos";
            this.relatorioDePedidosToolStripMenuItem.Click += new System.EventHandler(this.relatorioDePedidosToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Azure;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            inicioToolStripMenuItem,
            operacoesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(921, 80);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(921, 508);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(941, 551);
            this.MinimumSize = new System.Drawing.Size(941, 551);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T G G   REPRESENTACOES";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDePedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
    }
}

