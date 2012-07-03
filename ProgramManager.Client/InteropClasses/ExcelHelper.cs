using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace ProgramManager.Client.InteropClasses
{
    public class ExcelHelper
    {
        private static object _locker = new object();
        private Excel.Application _excelObject;

        public ExcelHelper()
        {
        }

        public bool Connect()
        {
            bool result = false;
            try
            {
                _excelObject = new Excel.Application();
                _excelObject.Visible = false;
                _excelObject.DisplayAlerts = false;
                result = true;

            }
            catch
            {
                _excelObject = null;
            }
            return result;
        }

        public void Disconnect()
        {
            if (_excelObject != null)
            {
                foreach (Excel.Workbook workbook in _excelObject.Workbooks)
                    workbook.Close();
                uint processId = 0;
                WinAPIHelper.GetWindowThreadProcessId(new IntPtr(_excelObject.Hwnd), out processId);
                Process.GetProcessById((int)processId).Kill();
            }
            Controllers.AppManager.Instance.ReleaseComObject(_excelObject);
            GC.Collect();
        }

        public void ReportWeekSchedule(CoreObjects.Day[][] days, string destinationFilePath, bool converToPDF, bool landscape)
        {
            string templatePath = string.Format(Controllers.OutputManager.Instance.ReportWeekScheduleTemplatePath, landscape ? "Landscape" : "Portrait");
            if (File.Exists(templatePath) && Connect())
            {
                try
                {
                    Excel.Workbook destinationWorkBook = _excelObject.Workbooks.Add();

                    for (int i = 1; i < 3; i++)
                        try
                        {
                            destinationWorkBook.Worksheets[i].Delete();
                        }
                        catch
                        {
                            break;
                        }

                    int worksheetIndex = 1;
                    foreach (CoreObjects.Day[] weekDays in days)
                    {
                        Excel.Workbook sourceWorkBook = _excelObject.Workbooks.Open(templatePath);
                        Excel.Worksheet workSheet = sourceWorkBook.Worksheets["Week"];
                        workSheet.Range["Title"].Formula = string.Format("{0} - Weekly Program Schedule", weekDays.FirstOrDefault().Station.Name);
                        workSheet.Range["DateRange"].Formula = string.Format("Week of {0}", weekDays.FirstOrDefault().Date.ToString("MMMM d, yyyy"));
                        for (int i = 0; i < 7; i++)
                        {
                            Excel.Range range = workSheet.Range["day" + (i + 1).ToString()];
                            range.Formula = weekDays[i].Date.ToString("dddd M/d");
                            int columnIndex = range.Column;
                            int rowIndex = range.Row + 1;

                            int j = rowIndex;
                            foreach (CoreObjects.ProgramActivity programActivity in weekDays[i].ProgramActivities)
                            {
                                workSheet.Range[GetColumnLetterByIndex(columnIndex) + j.ToString()].Formula = programActivity.Program;
                                j++;
                            }

                            string programName = string.Empty;
                            int firstRow = 0;
                            for (int r = 0; r < 48; r++)
                            {
                                object value = workSheet.Range[GetColumnLetterByIndex(columnIndex) + (rowIndex + r).ToString()].Value;
                                string currentProgramName = value != null ? value.ToString() : string.Empty;
                                if (!currentProgramName.Equals(programName))
                                {
                                    if (!string.IsNullOrEmpty(programName))
                                        workSheet.Range[GetColumnLetterByIndex(columnIndex) + firstRow.ToString() + ":" + GetColumnLetterByIndex(columnIndex) + (rowIndex + r - 1).ToString()].Merge();
                                    firstRow = rowIndex + r;
                                    programName = currentProgramName;
                                }
                            }
                        }

                        for (int i = 0; i < 7; i++)
                        {
                            Excel.Range range = workSheet.Range["day" + (i + 1).ToString()];
                            int columnIndex = range.Column;
                            int r = 0;
                            object value = null;
                            do
                            {
                                value = null;
                                int rowIndex = 0;
                                Excel.Range rowRange = range.Offset[RowOffset: r];
                                try
                                {
                                    value = rowRange.Formula;
                                    rowIndex = rowRange.Row;
                                }
                                catch { }
                                if (value != null)
                                {
                                    string programName = string.Empty;
                                    int firstColumn = 0;
                                    for (int j = 0; j < 7; j++)
                                    {
                                        object nextValue = null;
                                        try
                                        {
                                            nextValue = rowRange.Offset[ColumnOffset: j].Value;
                                        }
                                        catch { }
                                        string currentProgramName = nextValue != null ? nextValue.ToString() : string.Empty;
                                        if (!currentProgramName.Equals(programName))
                                        {
                                            if (!string.IsNullOrEmpty(programName))
                                                workSheet.Range[GetColumnLetterByIndex(firstColumn) + rowIndex.ToString() + ":" + GetColumnLetterByIndex(columnIndex + j - 1) + rowIndex.ToString()].Merge();
                                            firstColumn = columnIndex + j;
                                            programName = currentProgramName;
                                        }
                                    }
                                }
                                r++;
                            }
                            while (value != null && r <= 48);
                        }

                        workSheet.Range["Data"].Rows.AutoFit();

                        workSheet.Copy(After: destinationWorkBook.Worksheets[worksheetIndex]);
                        worksheetIndex++;
                        workSheet = destinationWorkBook.Worksheets[worksheetIndex];
                        workSheet.Name = weekDays.FirstOrDefault().Date.ToString("MMddyy") + "-" + weekDays.LastOrDefault().Date.ToString("MMddyy");
                        sourceWorkBook.Close();
                    }

                    destinationWorkBook.Worksheets[1].Delete();
                    if (converToPDF)
                        destinationWorkBook.ExportAsFixedFormat(Filename: destinationFilePath, Type: Excel.XlFixedFormatType.xlTypePDF);
                    else
                        destinationWorkBook.SaveAs(Filename: destinationFilePath, FileFormat: Excel.XlFileFormat.xlWorkbookNormal);

                    destinationWorkBook.Close();
                }
                catch (Exception ex)
                {
                    Controllers.AppManager.Instance.Log.Records.Add(new CoreObjects.LogRecord(ex));
                    Controllers.AppManager.Instance.Log.Save();
                }
                Disconnect();
            }
        }

        public static string GetColumnLetterByIndex(int index)
        {
            switch (index)
            {
                case 1:
                    return "A";
                case 2:
                    return "B";
                case 3:
                    return "C";
                case 4:
                    return "D";
                case 5:
                    return "E";
                case 6:
                    return "F";
                case 7:
                    return "G";
                case 8:
                    return "H";
                case 9:
                    return "I";
                case 10:
                    return "J";
                case 11:
                    return "K";
                case 12:
                    return "L";
                default:
                    return string.Empty;
            }
        }
    }
}
