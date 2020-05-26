using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using Microsoft.VisualBasic.FileIO;


namespace CityGym
{
    public class Helper
    {
        public static DataTable DataTableFromTextFile(string location, char delimiter )
            {
               
                DataTable result;
                List<string[]> data = new List<string[]>();
                var parser = new Microsoft.VisualBasic.FileIO.TextFieldParser(location);
                parser.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited;
                parser.SetDelimiters(new string[] { "," });

                while (!parser.EndOfData)
                {
                    string[] row = parser.ReadFields();
                    data.Add(row);
                }
                
                result = FormDataTable(data, delimiter);

                return result;
            }

            private static DataTable FormDataTable(List<string[]>  LineArray, char delimiter)
            {
                DataTable dt = new DataTable();

                AddColumnToTable(LineArray, delimiter, ref dt);

                AddRowToTable(LineArray, delimiter, ref dt);

                return dt;
            }

            private static void AddRowToTable(List<string[]> valueCollection, char delimiter, ref DataTable dt)
            {

            
                foreach (var item in valueCollection)
                {
                    DataRow dr = dt.NewRow();
                    for (int j = 0; j < item.Length; j++)
                    {
                        dr[j] = item[j];
                    }
                    dt.Rows.Add(dr);
                }
            }

            private static void AddColumnToTable(List<string[]> columnCollection, char delimiter, ref DataTable dt)
            {
                string[] columns = columnCollection[0];
                foreach (string columnName in columns)
                {
                    DataColumn dc = new DataColumn(columnName, typeof(string));
                    dt.Columns.Add(dc);
                }
            }

        }
    }

