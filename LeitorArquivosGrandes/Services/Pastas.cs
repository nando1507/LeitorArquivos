using LeitorArquivosGrandes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace LeitorArquivosGrandes.Services
{
    public class Pastas : IPastas
    {
        public Pastas()
        {

        }

        public DirectoryInfo[] ListaSubPastas(string caminho)
        {
            return new DirectoryInfo(caminho).GetDirectories();
        }

        public string SelecionaSubPasta()
        {
            using(FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Selecione pasta desejada";
                dialog.InitialDirectory = Path.GetDirectoryName(path: Environment.GetFolderPath(folder: Environment.SpecialFolder.Desktop));
                dialog.AutoUpgradeEnabled = true;
                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    return "";
                }
                else
                {
                    return dialog.SelectedPath;
                }
            }
        }


    }
}
