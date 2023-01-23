using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeitorArquivosGrandes.Interfaces
{
    public interface IArquivos
    {
        List<FileInfo> SelecionaArquivo(string filtro, bool MultiplosArquivos);
        bool ArquivoExiste(string Caminho);
        List<FileInfo> ArquivosPasta(string caminho, string filtro);



    }
}
