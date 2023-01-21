using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeitorArquivosGrandes.Interfaces
{
    public interface IPastas
    {
        DirectoryInfo[] ListaPastas(string caminho);

        string SelecionaPasta();
        
    }
}
