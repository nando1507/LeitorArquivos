using LeitorArquivosGrandes.Interfaces;
using LeitorArquivosGrandes.Services;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace LeitorArquivosGrandes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //double height = SystemParameters.FullPrimaryScreenHeight;
            //double width = SystemParameters.FullPrimaryScreenWidth;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }




        private void MenuArquivo_Click(object sender, EventArgs e)
        {

        }

        private void CsvAbrirMenu_Click(object sender, EventArgs e)
        {
            string filtro = "Csv files (*.csv)|*.CSV|All files (*.*)|*.*";
            List<FileInfo>? arq = new Arquivos().SelecionaArquivo(filtro, MultiplosArquivos: true);
            if (arq == null)
            {
                return;
            }
            if (arq.Count == 1)
            {
                cboArquivos.Text = arq[0].ToString();
                CarregaGrid(arq);
            }
            else
            {
                CarregaCombo(arq);
            }
        }



        private void TxtAbrirMenu_Click(object sender, EventArgs e)
        {
            string filtro = "Txt files (*.Txt)|*.Txt|All files (*.*)|*.*";
            List<FileInfo>? arq = new Arquivos().SelecionaArquivo(filtro, true);
            if (arq == null)
            {
                return;
            }
            if (arq.Count == 1)
            {
                cboArquivos.Text = arq[0].ToString();
                CarregaGrid(arq);
            }
            else
            {
                CarregaCombo(arq);
            }
        }

        private void ArquivoAbrirMenu_Click(object sender, EventArgs e)
        {
            string filtro = "All files (*.*)|*.*";
            List<FileInfo>? arq = new Arquivos().SelecionaArquivo(filtro, true);
            if(arq == null)
            {
                return;
            }
            if (arq.Count == 1)
            {
                cboArquivos.Text = arq[0].ToString();
                CarregaGrid(arq);
            }
            else
            {
                CarregaCombo(arq);
            }
        }

        private void pastasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string? caminho = new Pastas().SelecionaSubPasta();
            DirectoryInfo[]? aux = new Pastas().ListaSubPastas(caminho);
            if (aux == null)
            {
                return;
            }
            cboArquivos.DataSource = new List<string>() { caminho };
            dgvLeitor.DataSource = aux;
            lblQuantidade.Text = aux.Length.ToString("N0");
        }

        private void chkLimite_CheckedChanged(object sender, EventArgs e)
        {
            NumValues.Enabled = chkLimite.Checked;
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            CarregaGrid(new List<FileInfo>() { new FileInfo(cboArquivos.SelectedValue.ToString()) });
        }

        private void CarregaGrid(List<FileInfo> arq)
        {
            var arquivo = new Models.LayoutArquivo()
            {
                File = arq,
                LimiteLinhas = chkLimite.Checked,
                Linhas = NumValues.Value,
                Enco = Encoding.UTF8,
                Header = true,
                Delimitador = cboDelimitador.SelectedItem.ToString()
            };

            dgvLeitor.DataSource = new Leitura().LeituraArquivo(arquivo);
            lblQuantidade.Text = new Leitura().LinhasArquivos(arquivo).ToString("N0");
        }

        private void CarregaCombo(List<FileInfo> arq)
        {
            btnCarregar.Visible = true;
            cboArquivos.DataSource = arq;
        }

        private void dgvLeitor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {          
            if(dgvLeitor.Columns.Count < 3)
            {
                return;
            }

            if (MessageBox.Show("Deseja listar Pastas?", "Arquivos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string? PastaSelecionada = dgvLeitor[dgvLeitor.Columns["FullName"].Index, e.RowIndex].Value.ToString();
                string filtro = "*.*";
                var arquivo = new Models.LayoutArquivo()
                {
                    File = new List<FileInfo>() { new FileInfo(PastaSelecionada) },
                    LimiteLinhas = chkLimite.Checked,
                    Linhas = NumValues.Value,
                    Enco = Encoding.UTF8,
                    Header = true,
                    Delimitador = cboDelimitador.SelectedItem.ToString()
                };
                cboArquivos.DataSource = new List<string>() { PastaSelecionada };
                dgvLeitor.DataSource = new Leitura().LeituraArquivo(arquivo);
                lblQuantidade.Text = new Leitura().LinhasArquivos(arquivo).ToString("N0");
            }
            else if (MessageBox.Show("Deseja listar arquivos?", "Arquivos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string? PastaSelecionada = dgvLeitor[dgvLeitor.Columns["FullName"].Index, e.RowIndex].Value.ToString();
                string filtro = "*.*";
                cboArquivos.DataSource = new List<string>() { PastaSelecionada };
                var arquivo = new Models.LayoutArquivo()
                {
                    File = new List<FileInfo>() { new FileInfo(PastaSelecionada) },
                    LimiteLinhas = chkLimite.Checked,
                    Linhas = NumValues.Value,
                    Enco = Encoding.UTF8,
                    Header = true,
                    Delimitador = cboDelimitador.SelectedItem.ToString()
                };
                dgvLeitor.DataSource = new Arquivos().ArquivosPasta(caminho: PastaSelecionada, filtro);
                lblQuantidade.Text = dgvLeitor.Rows.Count.ToString("N0");
            }
            else
            {
                MessageBox.Show("Nenhuma Ação Selecionada");
            }
        }

        private void chkDelimitar_CheckedChanged(object sender, EventArgs e)
        {
            cboDelimitador.Enabled = chkDelimitar.Checked;
        }
    }
}