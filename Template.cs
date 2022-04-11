using PdfClientes.Uteis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PdfClientes
{
    public partial class Template : Form
    {
        public Template()
        {
            InitializeComponent();
        }

        public void OpenFormInPanel(Object formName)
        {
            if (this.panelConteudo.Controls.Count > 0)
                this.panelConteudo.Controls.RemoveAt(0);

            Form frm = formName as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.panelConteudo.Controls.Add(frm);
            this.panelConteudo.Tag = frm;
            frm.Show();
            frm.Activate();
        }

        private void buttonMover_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Distribuir());
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            OpenFormInPanel(new Pesquisar());
        }       

        //Verifica se os diretórios e o arquivo EMPRESA.DBF estão acessíveiS 
        private string VerificaDiretoriosEdbf()
        {
            string erros = null;

            if (!Directory.Exists(Constante.pastaDocDig))            
                erros = $"Pasta {Constante.pastaDocDig} não está acessível";
            
            if (!Directory.Exists(Constante.pastaClientes))            
                erros += $"\n\nPasta {Constante.pastaClientes} não está acessível";            
            
            if (!Directory.Exists(Constante.pastaReserva))
                erros += $"\n\nPasta {Constante.pastaReserva} não está acessível";            
            
            //if (!File.Exists(Path.Combine(Constante.pastaDbf, "Empresa.dbf")))            
            //    erros += $"\n\nArquivo EMPRESA.DBF não está acessível";

            return erros;
        }

        private void Template_Shown(object sender, EventArgs e)
        {
            if (ObtemConfiguracoes())
            {
                string resultado = VerificaDiretoriosEdbf();

                if (resultado != null)
                {
                    resultado += "\n\n Verifique o que está acontecendo para continuar!";
                    MessageBox.Show(resultado);
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Erro ao ler o arquivo de configurações!");
                Application.Exit();
            }
        }

        private bool ObtemConfiguracoes()
        {
            try
            {
                List<string> config = new List<string>();

                string pathConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.txt");                

                foreach (string line in File.ReadLines(pathConfig))
                {
                    config.Add(line.ToString());                    
                }

                Constante.pastaDocDig = config.Find(_=> _.Contains("docdig")).Replace("docdig:","").Trim();
                Constante.pastaReserva = config.Find(_ => _.Contains("reserva")).Replace("reserva:", "").Trim();
                Constante.pastaClientes = config.Find(_ => _.Contains("clientes")).Replace("clientes:", "").Trim();
                Constante.ArquivoAjudaDocDig = config.Find(_ => _.Contains("ajuda")).Replace("ajuda:", "").Trim();
                //Constante.pastaDbf = config.Find(_ => _.Contains("dbf")).Replace("dbf:", "").Trim();

                return true;
            }
            catch
            {
                return false;
            }
            
        }

        private void buttonAjuda_Click(object sender, EventArgs e)
        {
            string caminhoArquivoAjuda = $@"{Constante.ArquivoAjudaDocDig}";

            if (!File.Exists(caminhoArquivoAjuda))
                MessageBox.Show($"Não foi possível encontrar o arquivo de ajuda {caminhoArquivoAjuda}!","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            System.Diagnostics.Process.Start(caminhoArquivoAjuda);
        }
    }
}
