using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeitorArquivosGrandes.Models
{
    public class LayoutArquivo
    {
        public List<FileInfo>? File { get; set; }
        public bool LimiteLinhas { get; set; }
        public decimal Linhas { get; set; }
        public Encoding? Enco { get; set; }
        public bool Header { get; set; }
        public string? Delimitador { get; set; }
    }
}
