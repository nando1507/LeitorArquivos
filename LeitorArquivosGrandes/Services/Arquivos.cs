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

        public string SelecionaArquivo(string filtro)
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
                    return file.FileName;
                }
            }
            return "";
        }
        
        public bool ArquivoExiste(string Caminho)
        {
            return File.Exists(Caminho);
        }

        public string[] SelecionaArquivo(string filtro, bool MultiplosArquivos)
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Filter = filtro;
                file.InitialDirectory = Path.GetDirectoryName(path: Environment.GetFolderPath(folder: Environment.SpecialFolder.Desktop));
                file.Title = "Selecione arquivo desejado";
                file.FilterIndex = 2;
                file.RestoreDirectory = true;
                file.Multiselect = MultiplosArquivos;
                if (file.ShowDialog() == DialogResult.OK)
                {
                    return file.FileNames;
                }
            }
            return new string[] { };
        }


    }
}
