using LeitorArquivosGrandes.Models;
using System.Data;

namespace LeitorArquivosGrandes.Interfaces
{
    public interface ILeitura
    {
        DataTable LeituraArquivo(LayoutArquivo layout);
        int LinhasArquivos(LayoutArquivo layout);
        
    }
}
