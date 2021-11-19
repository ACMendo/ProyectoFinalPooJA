using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;
using NPOI.HSSF.UserModel;
using System.IO;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using ProyectoFinalPooJA.Datos.Entities;

namespace ProyectoFinalPooJA
{
    public class Reports
    {
        public void GenerateExcelEntregas(List<Entrega> datos, string NombreArchivo)
        {
            var workbook = new XSSFWorkbook();
            var sheet = workbook.CreateSheet("NameOfYourSheet");
            var fontHeader = workbook.CreateFont();
            fontHeader.Boldweight = (short)FontBoldWeight.Bold;
            //var columns = dt.GetType().GetProperties();
            List<string> camps = new List<string> { "Destino", "Fecha Salida", "Fecha Regreso", "Descripción", "Peso", "Empleado", "Cliente", "Prioridad" };
            var header = sheet.CreateRow(0);
            for (int i = 0; i < camps.Count; i++)
            {
                var Destino = header.CreateCell(0);
                Destino.SetCellValue(camps[i]);
                Destino.CellStyle = workbook.CreateCellStyle();
                Destino.CellStyle.SetFont(fontHeader);
            }
            int rowIndex = 1;
            foreach (var item in datos)
            {
                var detailsRow = sheet.CreateRow(rowIndex);
                detailsRow.CreateCell(0).SetCellValue(item.Destino);
                detailsRow.CreateCell(0).SetCellValue(item.Fecha_Salida);
                detailsRow.CreateCell(0).SetCellValue(item.Fecha_Regreso);
                detailsRow.CreateCell(0).SetCellValue(item.Descripcion);
                detailsRow.CreateCell(0).SetCellValue(item.Peso.ToString());
                detailsRow.CreateCell(0).SetCellValue(item.Empleado.Nombre);
                detailsRow.CreateCell(0).SetCellValue(item.Cliente.Nombre);
                detailsRow.CreateCell(0).SetCellValue(item.Prioridad.Nombre);
            }
            string FilePath = NombreArchivo;
            using (var fileData = new FileStream(FilePath, FileMode.Create))
            {
                workbook.Write(fileData);
            }
        }

        public void GenerateExcelFileGeneric(DataTable dt)
        {
            var workbook = new XSSFWorkbook();
            var sheet = workbook.CreateSheet("NameOfYourSheet");
            var headerRow = sheet.CreateRow(0);

            for (int i = 0; i < dt.Columns.Count - 1; i++)
            {
                var cell = headerRow.CreateCell(i);
                cell.SetCellValue(dt.Columns[i].ColumnName);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var rowIndex = i + 1;
                var row = sheet.CreateRow(rowIndex);
                for (int j = 0; j < dt.Columns.Count - 1; j++)
                {
                    var cell = row.CreateCell(j);
                    //var o = items[i];
                    cell.SetCellValue(dt.Rows[i][j].ToString());
                }
            }
            string FilePath = "D:\\hola.xlsx";
            using (var fileData = new FileStream(FilePath, FileMode.Create))
            {
                workbook.Write(fileData);
            }
        }

    }
}
