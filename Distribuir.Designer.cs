
namespace PdfClientes
{
    partial class Distribuir
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
            this.buttonDistribuir = new System.Windows.Forms.Button();
            this.listBoxDocDig = new System.Windows.Forms.ListBox();
            this.buttonCarregaDocDig = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelDocDig = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDistribuir
            // 
            this.buttonDistribuir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDistribuir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDistribuir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonDistribuir.Location = new System.Drawing.Point(810, 109);
            this.buttonDistribuir.Name = "buttonDistribuir";
            this.buttonDistribuir.Size = new System.Drawing.Size(147, 66);
            this.buttonDistribuir.TabIndex = 0;
            this.buttonDistribuir.Text = "Arquivar";
            this.buttonDistribuir.UseVisualStyleBackColor = true;
            this.buttonDistribuir.Click += new System.EventHandler(this.buttonDistribuir_Click);
            // 
            // listBoxDocDig
            // 
            this.listBoxDocDig.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBoxDocDig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDocDig.FormattingEnabled = true;
            this.listBoxDocDig.ItemHeight = 20;
            this.listBoxDocDig.Location = new System.Drawing.Point(328, 65);
            this.listBoxDocDig.Name = "listBoxDocDig";
            this.listBoxDocDig.Size = new System.Drawing.Size(476, 184);
            this.listBoxDocDig.TabIndex = 2;
            // 
            // buttonCarregaDocDig
            // 
            this.buttonCarregaDocDig.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCarregaDocDig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCarregaDocDig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCarregaDocDig.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCarregaDocDig.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonCarregaDocDig.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonCarregaDocDig.Location = new System.Drawing.Point(810, 65);
            this.buttonCarregaDocDig.Name = "buttonCarregaDocDig";
            this.buttonCarregaDocDig.Size = new System.Drawing.Size(147, 38);
            this.buttonCarregaDocDig.TabIndex = 4;
            this.buttonCarregaDocDig.Text = "Atualizar";
            this.buttonCarregaDocDig.UseVisualStyleBackColor = true;
            this.buttonCarregaDocDig.Click += new System.EventHandler(this.buttonCarregaDocDig_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(30, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1140, 352);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            // 
            // labelDocDig
            // 
            this.labelDocDig.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDocDig.AutoSize = true;
            this.labelDocDig.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDocDig.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelDocDig.Location = new System.Drawing.Point(323, 30);
            this.labelDocDig.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDocDig.Name = "labelDocDig";
            this.labelDocDig.Size = new System.Drawing.Size(99, 29);
            this.labelDocDig.TabIndex = 6;
            this.labelDocDig.Text = "DocDig";
            this.labelDocDig.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Distribuir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.labelDocDig);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCarregaDocDig);
            this.Controls.Add(this.listBoxDocDig);
            this.Controls.Add(this.buttonDistribuir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Distribuir";
            this.Text = "Distribuir";
            this.Load += new System.EventHandler(this.Distribuir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDistribuir;
        private System.Windows.Forms.ListBox listBoxDocDig;
        private System.Windows.Forms.Button buttonCarregaDocDig;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelDocDig;
    }
}