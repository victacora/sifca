using System;
using System.Data.OleDb;
using System.Collections;
using System.ComponentModel;
using System.Data;

using Spire.Xls;
using System.IO;
using System.Collections.Generic;

namespace SIFCA_BLL
{
    public class ExcelMarkDesigner
    {
        private string existFileName;
        private string pathFileTemplate;
        public Workbook currentWorkBook;
        private Dictionary<string,object> parameters=new Dictionary<string,object>();

        public ExcelMarkDesigner()
        {
            currentWorkBook = new Workbook();
            this.existFileName = string.Empty;
            this.pathFileTemplate = string.Empty;
        }

        public void ExportDataTableToExcel(DataTable t, string existFileName,string sheetName)
        {
            Workbook book = new Workbook();
            Worksheet sheet = book.CreateEmptySheet(sheetName);
            sheet.Activate();
            sheet.InsertDataTable(t, true, 1, 1);
            for (int i = 0; i < sheet.Columns.Length; i++)
            {
                sheet.Columns[i].Style.VerticalAlignment = VerticalAlignType.Center;
                sheet.Columns[i].Style.Font.FontName = "Arial";
                sheet.Columns[i].NumberFormat = "0";
                sheet.Columns[i].Style.Font.Size = 10;
                sheet.Columns[i].Style.HorizontalAlignment = HorizontalAlignType.Left;
            }
            sheet.AllocatedRange.AutoFitRows();
            sheet.AllocatedRange.AutoFitColumns();
            book.SaveToFile(existFileName, ExcelVersion.Version2010);
            Remove_WarningPage(existFileName);
            ExcelDocViewer(existFileName);
        }


        public ExcelMarkDesigner(string existFileName,string pathFileTemplate) 
        {
            currentWorkBook = new Workbook();
            if (pathFileTemplate != string.Empty)
            {
                this.pathFileTemplate = pathFileTemplate;
                currentWorkBook.LoadFromFile(@pathFileTemplate);
            }
            this.existFileName = existFileName;
        }

        public void AddParameters(string parameter, object value) 
        {
            if (!parameters.ContainsKey(parameter))
            {
                parameters.Add(parameter, value);
            }
        }

        public void ClearParameters()
        {
            foreach (KeyValuePair<string, object> parameter in parameters)
            {
                currentWorkBook.MarkerDesigner.RemoveParameter(parameter.Key);
            }
            parameters.Clear();
        }

        public string SaveFile()
        {
            currentWorkBook.MarkerDesigner.Apply();
            currentWorkBook.SaveToFile(existFileName, ExcelVersion.Version2010);
            return currentWorkBook.FileName;
        }

        public void CopySheetToSheet(string sheet,string newSheet)
        {
            currentWorkBook.Worksheets.Add(newSheet);
            currentWorkBook.Worksheets[newSheet].CopyFrom(currentWorkBook.Worksheets[sheet]);
        }

        public void RemoveSheet(string sheet)
        {
            currentWorkBook.Worksheets.Remove(sheet);
        }

        public void FindReplace(string sheetName,string findText,string replaceText)
        {
            Worksheet sheet = currentWorkBook.Worksheets[sheetName];
            CellRange[] ranges = sheet.FindAllString(findText, false, false);
            foreach (CellRange range in ranges)
            {
                range.Text = range.Text.Replace(findText,replaceText);
            }
        }

        public void ApplyParameters()
        {
            foreach (KeyValuePair<string, object> parameter in parameters)
            {
                currentWorkBook.MarkerDesigner.AddParameter(parameter.Key, parameter.Value);
            }
        }

        public void ModifiedSheetToCurrentWorkBook(DataTable dataTable, string tableName, string sheetName)
        {
            Worksheet sheet = currentWorkBook.Worksheets[sheetName];
            sheet.Activate();
            for (int i = 0; i < sheet.Columns.Length; i++)
            {
                sheet.Columns[i].Style.VerticalAlignment = VerticalAlignType.Center;
                sheet.Columns[i].Style.Font.FontName = "Arial";
                sheet.Columns[i].NumberFormat = "0";
                sheet.Columns[i].Style.Font.Size = 10;
                sheet.Columns[i].Style.HorizontalAlignment = HorizontalAlignType.Left;
            }
            currentWorkBook.MarkerDesigner.AddDataTable(tableName, dataTable);
            sheet.AllocatedRange.AutoFitRows();
            sheet.AllocatedRange.AutoFitColumns();
        }

        public void ExcelDocViewer(string fileName)
        {
            try
            {
                System.Diagnostics.Process.Start(fileName);
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }
        
        public void Remove_WarningPage(string fileName)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
                exApp.Visible = false;
                exApp.DisplayAlerts = false;
                Microsoft.Office.Interop.Excel.Workbook exWbk = exApp.Workbooks.Open(fileName);
                Microsoft.Office.Interop.Excel.Worksheet exWks = (Microsoft.Office.Interop.Excel.Worksheet)exWbk.Sheets["Evaluation Warning"];
                exWks.Delete();
                exWbk.Save();
                exWbk.Close();
                exApp.DisplayAlerts = true;
                exApp.Quit();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
    }
}
