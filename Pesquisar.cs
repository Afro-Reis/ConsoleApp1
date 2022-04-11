using PdfClientes.Uteis;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PdfClientes
{
    public partial class Pesquisar : Form
    {
        List<string> listaClientes = new List<string>();
        List<ArquivosCliente> listaDocumentosClientes = new List<ArquivosCliente>();        
        private string clienteSelecionado;        

        public Pesquisar()
        {
            InitializeComponent();
        }

        private void Pesquisar_Load(object sender, EventArgs e)
        {
            CarregaListaClientes();           
        }

        private void CarregaListaClientes()
        {
            try
            {
                listaClientes = new List<string>();

                if (Directory.Exists(Constante.pastaClientes))//se existe
                {
                    DirectoryInfo dinfo = new DirectoryInfo(Constante.pastaClientes); // Populates field with all Sub Folders
                    DirectoryInfo[] directorys = dinfo.GetDirectories();
                    foreach (DirectoryInfo directory in directorys)
                    {
                        listaClientes.Add(directory.Name);
                    }
                }
            }
            catch
            {
                MessageBox.Show($"Erro ao carregar a lista de clientes da pasta: {Constante.pastaClientes}!");
            }
        }

        private void PesquisaCliente(string term = "")
        {
            var result = listaClientes.Where(_ => _.Contains(term.ToUpper())).ToList();
            listBoxResultado.DataSource = result;
            axAcroPDF1.Visible = false;
        }

        private void textBoxPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPesquisa.Text))
            {
                PesquisaCliente(textBoxPesquisa.Text);
                listBoxResultado.Visible = true;
            }
            else
            {
                listBoxResultado.DataSource = new List<string>();
                listBoxResultado.Visible = false;
            }
        }

        private void listBoxResultado_Click(object sender, EventArgs e)
        {
            CarregaListaBoxClientes();
        }

        private void listBoxResultado_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CarregaListaBoxClientes();
        }

        private void CarregaListaBoxClientes()
        {
            textBoxPesquisa.Text = "";
            listBoxResultado.Visible = false;
            clienteSelecionado = listBoxResultado.SelectedItem.ToString();
            CarregaPastaCliente(listBoxResultado.SelectedItem.ToString());
        }

        private void CarregaPastaCliente(string nomeCliente)
        {
            try
            {
                listaDocumentosClientes = new List<ArquivosCliente>();

                string pastaCliente = Path.Combine(Constante.pastaClientes, nomeCliente);

                if (Directory.Exists(pastaCliente))//se existe
                {
                    DirectoryInfo dinfo = new DirectoryInfo(pastaCliente);
                    FileInfo[] Files = dinfo.GetFiles("*.pdf");

                    foreach (FileInfo file in Files)
                    {
                        listaDocumentosClientes.Add(new ArquivosCliente
                        {
                            Arquivo = file.Name,
                            Selecionado = null
                        });
                    }
                }                      
            }
            catch
            {
                MessageBox.Show($"Erro ao carregar a pasta do cliente: {nomeCliente}");
            }
            dataGridPastaClientes.DataSource = listaDocumentosClientes;
            dataGridPastaClientes.Columns[0].Width = 378;
            dataGridPastaClientes.Columns[1].Width = 100;
            dataGridPastaClientes.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void PesquisaDocumentosCliente(string term = "")
        {
            var result = listaDocumentosClientes.Where(_ => _.Arquivo.Contains(term.ToUpper())).ToList();
            dataGridPastaClientes.DataSource = result;            
        }

        private void textBoxPesquisaPastaCliente_KeyUp(object sender, KeyEventArgs e)
        {
            PesquisaDocumentosCliente(textBoxPesquisaPastaCliente.Text);
        }
        
        private void MostraCopiaPdf(string pdfClicado)
        {
            string caminhoPdf = Path.Combine(Constante.pastaClientes, clienteSelecionado);
            if(pdfClicado != null)
            {
                caminhoPdf = Path.Combine(caminhoPdf, pdfClicado);
                axAcroPDF1.Visible = true;
                axAcroPDF1.LoadFile(caminhoPdf);
                Clipboard.SetText(caminhoPdf);
            }
        }

        private void Pesquisar_Shown(object sender, EventArgs e)
        {
            textBoxPesquisa.Focus();            
        }

        private void dataGridPastaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var pdfClicado = dataGridPastaClientes.Rows[e.RowIndex].Cells[0];
            MostraCopiaPdf(pdfClicado.Value.ToString());
            
            if (e.ColumnIndex == 1)//Verifica se clicou na coluna Selecionado
            {
                var cellSelecionada = dataGridPastaClientes.Rows[e.RowIndex].Cells[1];
                cellSelecionada.Value = cellSelecionada.Value == null ? "X" : null;
            }
        }        

        //private void CarregaListaClientes()
        //{
        //    try
        //    {
        //        OleDbConnection oConn = new OleDbConnection();
        //        oConn.ConnectionString =
        //                  $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Constante.pastaDbf};Extended Properties=dBASE IV;";

        //        oConn.Open();
        //        OleDbCommand oCmd = oConn.CreateCommand();
        //        oCmd.CommandText = $@"SELECT CL FROM {Constante.pastaDbf}\Empresa.dbf";
        //        DataTable dt = new DataTable();
        //        dt.Load(oCmd.ExecuteReader());
        //        oConn.Close();

        //        foreach (DataRow row in dt.Rows)
        //        {
        //            listaClientes.Add(row.ItemArray[0].ToString());
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show($"Erro ao carregar os clientes. ERRO: {e.Message}");
        //    }
        //}

        //private void listBoxPastaClientes_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //        MostraCopiaPdf();
        //}
    }
}
