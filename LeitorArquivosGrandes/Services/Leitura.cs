using LeitorArquivosGrandes.Interfaces;
using LeitorArquivosGrandes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeitorArquivosGrandes.Services
{
    public class Leitura : ILeitura
    {
        public DataTable LeituraArquivo(LayoutArquivo layout)
        {
            foreach (FileInfo item in layout.File)
            {
                DataTable dataTable = new DataTable(item.Name);
                using (StreamReader sr = new(item.FullName, layout.Enco))
                {
                    int i = 1;
                    string[]? aux = sr.ReadLine().Split(layout.Delimitador);

                    if (layout.Header)
                    {
                        foreach (string coluna in aux)
                        {
                            DataColumn dc = new DataColumn()
                            {
                                ColumnName = coluna,
                                DataType = coluna.GetType()
                            };
                            dataTable.Columns.Add(dc);
                        }

                    }
                    while (!sr.EndOfStream)
                    {
                        aux = sr.ReadLine().Split(layout.Delimitador);

                        DataRow row = dataTable.NewRow();
                        int tamanho = !layout.LimiteLinhas ? int.MaxValue : aux.Length;

                        for (int j = 0; j < tamanho; j++)
                        {
                            row[j] = aux[j];
                        }
                        dataTable.Rows.Add(row);
                        i++;
                        if (i == tamanho && sr.EndOfStream)
                        {
                            return dataTable;
                        }
                    }
                }
                return dataTable;
            }
            return null;
        }

        //public DataTable LeituraArquivo(FileInfo[] files, decimal linhas, Encoding enco, bool Header, string delimitador)
        //{
        //    DataTable dataTable = new DataTable();
        //    foreach (var item in files)
        //    {
        //        dataTable = new DataTable(item.Name);
        //    }
        //    if (dataTable.DataSet.Tables.Count > 0)
        //    {
        //        return dataTable;
        //    }
        //    return null;
        //}
    }
}
