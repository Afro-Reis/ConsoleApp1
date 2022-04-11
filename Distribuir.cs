using PdfClientes.Uteis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PdfClientes
{
    public partial class Distribuir : Form
    {
        List<string> listaDocdig = new List<string>();
        List<Log> listaLogs = new List<Log>();

        private int TotalArquivado = 0;
        private int TotalAlertas = 0;

        public Distribuir()
        {
            InitializeComponent();
        }

        private void buttonCarregaDocDig_Click(object sender, EventArgs e)
        {
            CarregaDocDig();
        }

        private void HabilitaDesabilitaBotoes(bool acao)
        {
            if (acao == false)
            {
                buttonDistribuir.Text = "Arquivando...";
                buttonDistribuir.BackColor = Color.Red;
                buttonDistribuir.ForeColor = Color.White;
            }
            else
            {
                buttonDistribuir.Text = "Arquivar";
                buttonDistribuir.BackColor = Color.LightGray;
                buttonDistribuir.ForeColor = Color.Black;
            }
            buttonDistribuir.Enabled = acao;
            buttonCarregaDocDig.Enabled = acao;
        }

        private void buttonDistribuir_Click(object sender, EventArgs e)
        {
            if (listaDocdig.Count == 0) return;
            
            HabilitaDesabilitaBotoes(false);
            try
            {
                int cod;
                string cl;
                listaLogs = new List<Log>();
                dataGridView1.Visible = false;
                ResetaTotais();
                foreach (var nomeArquivo in listaDocdig)
                {
                    cod = ObtemCodigoDoNomeDoArquivo(nomeArquivo);

                    if (cod > 0)//Conseguiu pegar o código do nome do arquivo
                    {
                        cl = ObtemNomeDoCliente(cod);
                        if (!cl.Equals(""))//Conseguiu o nome do cliente
                        {
                            if (CriaPastaDoClienteSeNaoExistir(cl))//Se retornar true, a pasta foi criada ou já existia
                            {
                                if (CopiaArquivoParaPastaDoCliente(nomeArquivo, cl))//Se conseguiu copiar o arquivo para a pasta do cliente
                                {
                                    if (CopiaArquivoParaPastaReserva(nomeArquivo))//Se conseguiu copiar arquivo para pasta reserva
                                    {
                                        if (!DeletaArquivoPastaDocDig(nomeArquivo))//Se não conseguiu deletar o arquivo da pasta DocDig
                                        {
                                            AdicionaNovoLog($"{nomeArquivo} Cliente: {cl}", "Não foi possível deletar o arquivo da pasta DocDig!");
                                            TotalAlertas++;
                                        }
                                        else
                                        {
                                            //AdicionaNovoLog($"{nomeArquivo}", "Arquivado com sucesso!");
                                            TotalArquivado++;
                                        }
                                    }
                                    else
                                    {
                                        AdicionaNovoLog($"{nomeArquivo} Cliente: {cl}", "Não foi possível copiar o arquivo para a pasta reserva!");
                                        TotalAlertas++;
                                    }
                                }
                                else
                                {
                                    AdicionaNovoLog($"{nomeArquivo} Cliente: {cl}", "Não foi possível copiar o arquivo para a pasta do cliente!");
                                    TotalAlertas++;
                                }
                            }
                            else
                            {
                                AdicionaNovoLog($"{nomeArquivo} Cliente: {cl}", "Não foi possível criar a pasta do cliente!");
                                TotalAlertas++;
                            }
                        }
                        else
                        {
                            AdicionaNovoLog($"{nomeArquivo}", "Cliente não encontrado ou inativo!");
                            TotalAlertas++;
                        }
                    }
                    else
                    {
                        AdicionaNovoLog(nomeArquivo, "Erro ao identificar o código do cliente");
                        TotalAlertas++;
                    }
                }
                CarregaDocDig();
                dataGridView1.DataSource = listaLogs;
                dataGridView1.Visible = true;               
                
                MostraResultado();
            }
            catch (Exception err)
            {
                MessageBox.Show("Algo deu muito errado! \n" + err.Message);
                throw;
            }
            HabilitaDesabilitaBotoes(true);
        }

        //Recebe o nome do PDF e pega o codigo do cliente(4 caracteres a esquerda)
        public int ObtemCodigoDoNomeDoArquivo(string nomeArquivo)
        {
            int result;
            Int32.TryParse(nomeArquivo.Substring(0, 4), out result);
            return result;
        }       

        public string ObtemNomeDoCliente(int codigo)
        {
            OleDbConnection oConn = new OleDbConnection();
            //Colocar o caminho do banco do access clientes
            oConn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Access\clientes_be.accdb;Persist Security Info=False;";

            oConn.Open();
            OleDbCommand oCmd = oConn.CreateCommand();
            oCmd.CommandText = $@"SELECT COD, CL, ATIVO FROM Cclientes where cod={codigo} and ATIVO = {true}";
            DataTable dt = new DataTable();
            dt.Load(oCmd.ExecuteReader());
            oConn.Close();

            return dt.Rows.Count > 0 ? dt.Rows[0]["CL"].ToString() : "";
        }

        public bool CriaPastaDoClienteSeNaoExistir(string nomeCliente)
        {
            string pastaNomeCliente = Path.Combine(Constante.pastaClientes, nomeCliente);
            try
            {
                if (!Directory.Exists(pastaNomeCliente))//se não existe
                {
                    Directory.CreateDirectory(pastaNomeCliente);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CopiaArquivoParaPastaDoCliente(string nomeArquivo, string nomeCliente)
        {
            try
            {                
                string origemArquivo = Path.Combine(Constante.pastaDocDig, nomeArquivo);

                string destinoArquivo = Path.Combine(Constante.pastaClientes, nomeCliente);
                destinoArquivo = Path.Combine(destinoArquivo, nomeArquivo);

                File.Copy(origemArquivo, destinoArquivo, true); //copia o arquivo e sobrescreve se ja existir

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CopiaArquivoParaPastaReserva(string nomeArquivo)
        {
            try
            {
                string origemArquivo = Path.Combine(Constante.pastaDocDig, nomeArquivo);
                string destinoReserva = Path.Combine(Constante.pastaReserva, nomeArquivo);

                File.Copy(origemArquivo, destinoReserva, true); //copia o arquivo e sobrescreve se ja existir

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeletaArquivoPastaDocDig(string nomeArquivo)
        {
            try
            {
                string origemArquivo = Path.Combine(Constante.pastaDocDig, nomeArquivo);

                File.Delete(origemArquivo); //deleta o arquivo

                return true;
            }
            catch
            {
                return false;
            }
        }

        public void AdicionaNovoLog(string arquivo, string mensagem)
        {
            listaLogs.Add(new Log
            {
                Arquivo = arquivo,
                Mensagem = mensagem
            });
        }

        private void CarregaDocDig()
        {
            try
            {
                listaDocdig = new List<string>();
                listBoxDocDig.Items.Clear();
                panelResultado.Visible = false;
                dataGridView1.Visible = false;

                if (Directory.Exists(Constante.pastaDocDig))//se existe
                {
                    DirectoryInfo dinfo = new DirectoryInfo(Constante.pastaDocDig);
                    FileInfo[] Files = dinfo.GetFiles("*.pdf");

                    foreach (FileInfo file in Files)
                    {
                        listaDocdig.Add(file.Name);
                        listBoxDocDig.Items.Add(file.Name);
                    }

                    labelDocDig.Text = "Pasta DocDig: " + Files.Count() + " arquivos";
                    if (listaDocdig.Count == 0)
                    {
                        buttonDistribuir.Enabled = false;
                    }
                    else
                    {
                        buttonDistribuir.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show($"Pasta: {Constante.pastaDocDig}, não encontrada!");
                }
            }
            catch
            {
                MessageBox.Show("Erro ao carregar a pasta DocDig!");
            }
        }

        private void Distribuir_Load(object sender, EventArgs e)
        {
            CarregaDocDig();
        }

        //Reseta os contadores da listBoxResultado
        private void ResetaTotais()
        {
            listBoxResultado.Items.Clear();
            panelResultado.Visible = false;
            TotalArquivado = 0;
            TotalAlertas = 0;
        }

        private void MostraResultado()
        {            
            listBoxResultado.Items.Add($"Arquivados com sucesso = {TotalArquivado}");
            listBoxResultado.Items.Add($"Alertas = {TotalAlertas}");
            panelResultado.Visible = true;
        }

        //public string ObtemNomeDoCliente(int codigo)
        //{
        //    OleDbConnection oConn = new OleDbConnection();
        //    oConn.ConnectionString =
        //     $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Constante.pastaDbf};Extended Properties=dBASE IV;";

        //    //oConn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Access\clientes_be.accdb;Persist Security Info=False;";

        //    oConn.Open();
        //    OleDbCommand oCmd = oConn.CreateCommand();
        //    oCmd.CommandText = $@"SELECT * FROM {Constante.pastaDbf}\Empresa.dbf where cod={codigo} and ATIVO = 'SIM'";
        //    DataTable dt = new DataTable();
        //    dt.Load(oCmd.ExecuteReader());
        //    oConn.Close();

        //    return dt.Rows.Count > 0 ? dt.Rows[0]["CL"].ToString() : "";
        //}
    }
}
