using OfficeOpenXml;
using System.Data;
using System.IO;

namespace DemoMVC.Models.Process
{
    public class ExcelProcess
    {
        public DataTable ExcelToDataTable(string filePath)
        {
            DataTable dt = new DataTable();

            // ĐÃ SỬA: DÙNG License CHO EPPLUS 8+
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                bool hasHeader = true;

                foreach (var headerCell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
                {
                    dt.Columns.Add(hasHeader ? headerCell.Text : $"Col{headerCell.Start.Column}");
                }

                int startRow = hasHeader ? 2 : 1;
                for (int rowNum = startRow; rowNum <= worksheet.Dimension.End.Row; rowNum++)
                {
                    var wsRow = worksheet.Cells[rowNum, 1, rowNum, worksheet.Dimension.End.Column];
                    DataRow row = dt.NewRow();
                    foreach (var cell in wsRow)
                    {
                        row[cell.Start.Column - 1] = cell.Text;
                    }
                    dt.Rows.Add(row);
                }
            }

            return dt;
        }
    }
}