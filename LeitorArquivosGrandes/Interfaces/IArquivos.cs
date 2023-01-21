using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeitorArquivosGrandes.Interfaces
{
    public interface IArquivos
    {
        string SelecionaArquivo(string filtro);

        string[] SelecionaArquivo(string filtro, bool MultiplosArquivos);

        bool ArquivoExiste(string Caminho);
    }
}
