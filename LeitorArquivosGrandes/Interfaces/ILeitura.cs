using LeitorArquivosGrandes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeitorArquivosGrandes.Interfaces
{
    public interface ILeitura
    {
        DataTable LeituraArquivo(LayoutArquivo layout);
        
    }
}
