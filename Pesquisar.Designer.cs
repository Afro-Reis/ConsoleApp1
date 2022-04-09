
namespace PdfClientes
{
    partial class Pesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisar));
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.listBoxPastaClientes = new System.Windows.Forms.ListBox();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.textBoxPesquisaPastaCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pesquisar Cliente:";
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(192, 23);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(362, 24);
            this.textBoxPesquisa.TabIndex = 1;
            this.textBoxPesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPesquisa_KeyUp);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 18;
            this.listBoxResultado.Location = new System.Drawing.Point(192, 53);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(558, 292);
            this.listBoxResultado.TabIndex = 2;
            this.listBoxResultado.Visible = false;
            this.listBoxResultado.Click += new System.EventHandler(this.listBoxResultado_Click);
            this.listBoxResultado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBoxResultado_KeyUp);
            // 
            // listBoxPastaClientes
            // 
            this.listBoxPastaClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxPastaClientes.FormattingEnabled = true;
            this.listBoxPastaClientes.ItemHeight = 18;
            this.listBoxPastaClientes.Location = new System.Drawing.Point(34, 96);
            this.listBoxPastaClientes.Name = "listBoxPastaClientes";
            this.listBoxPastaClientes.Size = new System.Drawing.Size(520, 508);
            this.listBoxPastaClientes.TabIndex = 3;
            this.listBoxPastaClientes.Click += new System.EventHandler(this.listBoxPastaClientes_Click);
            this.listBoxPastaClientes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBoxPastaClientes_KeyUp);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(571, 22);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(617, 582);
            this.axAcroPDF1.TabIndex = 5;
            this.axAcroPDF1.Visible = false;
            // 
            // textBoxPesquisaPastaCliente
            // 
            this.textBoxPesquisaPastaCliente.Location = new System.Drawing.Point(227, 66);
            this.textBoxPesquisaPastaCliente.Name = "textBoxPesquisaPastaCliente";
            this.textBoxPesquisaPastaCliente.Size = new System.Drawing.Size(255, 24);
            this.textBoxPesquisaPastaCliente.TabIndex = 2;
            this.textBoxPesquisaPastaCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPesquisaPastaCliente_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar documento:";
            // 
            // Pesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.listBoxPastaClientes);
            this.Controls.Add(this.textBoxPesquisaPastaCliente);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pesquisar";
            this.Text = "Pesquisar";
            this.Load += new System.EventHandler(this.Pesquisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.ListBox listBoxPastaClientes;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.TextBox textBoxPesquisaPastaCliente;
        private System.Windows.Forms.Label label1;
    }
}