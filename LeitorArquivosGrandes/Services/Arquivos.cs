using LeitorArquivosGrandes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeitorArquivosGrandes.Services
{
    public class Arquivos : IArquivos
    {
        public Arquivos()
        {

        }

        public FileInfo SelecionaArquivo(string filtro)
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Filter = filtro;
                file.InitialDirectory = Path.GetDirectoryName(path: Environment.GetFolderPath(folder: Environment.SpecialFolder.Desktop));
                file.Title = "Selecione arquivo desejado";
                file.FilterIndex = 2;
                file.RestoreDirectory = true;
                if (file.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fileInfo = new FileInfo(file.FileName);
                    return fileInfo;
                }
            }
            return null;
        }

        public bool ArquivoExiste(string Caminho)
        {
            return File.Exists(Caminho);
        }

        public List<FileInfo> SelecionaArquivo(string filtro, bool MultiplosArquivos)
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Filter = filtro;
                file.InitialDirectory = Path.GetDirectoryName(path: Environment.GetFolderPath(folder: Environment.SpecialFolder.Desktop));
                file.Title = "Selecione arquivo desejado";
                file.FilterIndex = 1;
                file.RestoreDirectory = true;
                file.Multiselect = MultiplosArquivos;
                if (file.ShowDialog() == DialogResult.OK)
                {
                    List<FileInfo> fileInfo = new List<FileInfo>();
                    foreach (var item in file.FileNames)
                    {
                        fileInfo.Add(new FileInfo(item));
                    }
                    return fileInfo;
                }
            }
            return null;
        }
    }
}
