
namespace PdfClientes
{
    partial class Template
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Template));
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonMover = new System.Windows.Forms.Button();
            this.buttonAjuda = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConteudo
            // 
            this.panelConteudo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelConteudo.Location = new System.Drawing.Point(-3, 72);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(1204, 620);
            this.panelConteudo.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.AutoSize = true;
            this.panelTop.BackColor = System.Drawing.SystemColors.Control;
            this.panelTop.Controls.Add(this.buttonAjuda);
            this.panelTop.Controls.Add(this.buttonPesquisar);
            this.panelTop.Controls.Add(this.buttonMover);
            this.panelTop.Location = new System.Drawing.Point(-3, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1204, 76);
            this.panelTop.TabIndex = 1;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPesquisar.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPesquisar.Location = new System.Drawing.Point(614, 12);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(244, 43);
            this.buttonPesquisar.TabIndex = 0;
            this.buttonPesquisar.Text = "Pesquisar na pasta do cliente";
            this.buttonPesquisar.UseVisualStyleBackColor = false;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // buttonMover
            // 
            this.buttonMover.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonMover.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonMover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMover.Location = new System.Drawing.Point(324, 12);
            this.buttonMover.Name = "buttonMover";
            this.buttonMover.Size = new System.Drawing.Size(258, 43);
            this.buttonMover.TabIndex = 0;
            this.buttonMover.Text = "Arquivar na pasta dos clientes";
            this.buttonMover.UseVisualStyleBackColor = false;
            this.buttonMover.Click += new System.EventHandler(this.buttonMover_Click);
            // 
            // buttonAjuda
            // 
            this.buttonAjuda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAjuda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAjuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAjuda.BackgroundImage")));
            this.buttonAjuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAjuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjuda.Location = new System.Drawing.Point(15, 15);
            this.buttonAjuda.Name = "buttonAjuda";
            this.buttonAjuda.Size = new System.Drawing.Size(42, 40);
            this.buttonAjuda.TabIndex = 1;
            this.buttonAjuda.UseVisualStyleBackColor = true;
            this.buttonAjuda.Click += new System.EventHandler(this.buttonAjuda_Click);
            // 
            // Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelConteudo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Template";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DOCUMENTOS DOS CLIENTES";
            this.Shown += new System.EventHandler(this.Template_Shown);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonMover;
        private System.Windows.Forms.Button buttonAjuda;
    }
}

