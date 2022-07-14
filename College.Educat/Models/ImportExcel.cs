using Excel;
using System.IO;

namespace College.Educat.Models
{
    public class ImportExcel
    {
        public string FilePath { private get; set; }

        /// <summary>
        /// Read an Excel File version below 2007
        /// </summary>
        /// <returns>Datatable</returns>
        public System.Data.DataTable GetData03()
        {
            FileStream stream = File.Open(FilePath, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
            excelReader.IsFirstRowAsColumnNames = true;
            System.Data.DataSet result = excelReader.AsDataSet();
            return result.Tables[0];
        }
        /// <summary>
        /// Read an Excel File version 2007 and above
        /// </summary>
        /// <returns>Datatable</returns>
        public System.Data.DataTable GetData07()
        {
            FileStream stream = File.Open(FilePath, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            excelReader.IsFirstRowAsColumnNames = true;
            System.Data.DataSet result = excelReader.AsDataSet();
            return result.Tables[0];
        }

    }


    public class ImportError
    {
        public string Id { get; set; }
        public string Error { get; set; }
    }
}