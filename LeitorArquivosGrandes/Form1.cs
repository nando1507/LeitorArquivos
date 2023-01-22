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

            if (arq.Count == 1)
            {
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

            if (arq.Count == 1)
            {
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

            if (arq.Count == 1)
            {
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
            dgvLeitor.DataSource = new Leitura().LeituraArquivo(new Models.LayoutArquivo()
            {
                File = arq,
                LimiteLinhas = chkLimite.Checked,
                Linhas = NumValues.Value,
                Enco = Encoding.UTF8,
                Header = true,
                Delimitador = cboDelimitador.SelectedItem.ToString()
            });
        }

        private void CarregaCombo(List<FileInfo> arq)
        {
            btnCarregar.Visible = true;
            cboArquivos.DataSource = arq;
        }
    }
}