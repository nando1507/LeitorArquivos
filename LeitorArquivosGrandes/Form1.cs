using LeitorArquivosGrandes.Services;
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

        private void cSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filtro = "Csv files (*.csv)|*.CSV|All files (*.*)|*.*";
            string? aux = new Arquivos().Arquivo(filtro);
        }

        private void tXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filtro = "Txt files (*.Txt)|*.Txt|All files (*.*)|*.*";
            string? aux = new Arquivos().Arquivo(filtro);
        }

        private void aRQUIVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filtro = "All files (*.*)|*.*";
            string? aux = new Arquivos().Arquivo(filtro);
        }

        private void pastasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filtro = "Txt files (*.Txt)|*.Txt|All files (*.*)|*.*";
            string? aux = new Arquivos().Arquivo(filtro);
        }
    }
}