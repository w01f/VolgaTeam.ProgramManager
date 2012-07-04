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

        public void ReportWeekSchedule(CoreObjects.Day[][] days, string destinationFilePath, bool convertToPDF, bool landscape)
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
                    DateTime sheduleGenrated = DateTime.Now;

                    foreach (CoreObjects.Day[] weekDays in days)
                    {
                        Excel.Workbook sourceWorkBook = _excelObject.Workbooks.Open(templatePath);
                        Excel.Worksheet workSheet = sourceWorkBook.Worksheets["Week"];

                        string title = string.Format("{0} - Weekly Program Schedule", weekDays.FirstOrDefault().Station.Name);
                        string dateRange = string.Format("Week of {0}", weekDays.FirstOrDefault().Date.ToString("MMMM d, yyyy"));
                        workSheet.PageSetup.CenterHeader = "&12&B" + title + (char)13 + dateRange;

                        workSheet.PageSetup.CenterFooter = "&11Schedule Generated" + (char)13 + sheduleGenrated.ToString("MM/dd/yy h:mm tt");

                        for (int i = 0; i < 7; i++)
                        {
                            Excel.Range range = workSheet.Range["day" + (i + 1).ToString()];
                            range.Formula = weekDays[i].Date.ToString(landscape ? "dddd M/d" : "ddd M/d");
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
                    if (convertToPDF)
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

        public void ReportActivityList(CoreObjects.ProgramActivity[] activities, string destinationFilePath, bool convertToPDF)
        {
            string templatePath = Controllers.OutputManager.Instance.ReporActivityListTemplatePath;
            if (File.Exists(templatePath) && Connect())
            {
                try
                {
                    Excel.Workbook sourceWorkBook = _excelObject.Workbooks.Open(templatePath);
                    Excel.Worksheet workSheet = sourceWorkBook.Worksheets["Program Activities"];

                    DateTime start = activities.FirstOrDefault().Time;
                    DateTime end = activities.LastOrDefault().Time;
                    string title = string.Format("Program Activity For {0}", activities.FirstOrDefault().Day.Station.Name);
                    string dateRange = string.Format("Between {0} and {1} from {2} to {3}", new string[] { start.ToString("MM/dd/yyyy"), end.ToString("MM/dd/yyyy"), start.ToString("hh:mmtt"), end.ToString("hh:mmtt") });
                    workSheet.PageSetup.CenterHeader = "&12&B" + title + (char)13 + dateRange;

                    DateTime sheduleGenrated = DateTime.Now;
                    workSheet.PageSetup.CenterFooter = "&11Generated" + (char)13 + sheduleGenrated.ToString("MM/dd/yy h:mm tt");

                    Excel.Range range = workSheet.Range["Date"];
                    int firstRow = range.Row + 1;
                    int lastRow = firstRow;
                    int firstColumn = range.Column;
                    range = workSheet.Range["Episode"];
                    int lastColumn = range.Column;

                    List<object[]> rows = new List<object[]>();
                    foreach (CoreObjects.ProgramActivity activity in activities)
                    {
                        List<object> cells = new List<object>();
                        cells.Add(activity.Date.ToString("MM/dd/yyyy"));
                        cells.Add(activity.Date.ToString("ddd"));
                        cells.Add(activity.Time.ToString("hh:mmtt"));
                        cells.Add(activity.Program);
                        cells.Add(activity.Type);
                        cells.Add(activity.Episode);
                        rows.Add(cells.ToArray());
                        lastRow++;
                    }
                    if (lastRow > firstRow)
                        lastRow--;

                    if (rows.Count > 0)
                    {
                        object[,] values = new object[rows.Count, rows[0].Length];
                        for (int i = 0; i < rows.Count; i++)
                            for (int j = 0; j < rows[0].Length; j++)
                                values[i, j] = rows[i][j];

                        range = workSheet.Range[GetColumnLetterByIndex(firstColumn) + firstRow.ToString() + ":" + GetColumnLetterByIndex(lastColumn) + lastRow.ToString()];
                        range.Value2 = values;
                        range.Rows.AutoFit();
                        range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                        range.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                        range.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                        range.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                        range.Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;
                        range.Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;

                        if (convertToPDF)
                            sourceWorkBook.ExportAsFixedFormat(Filename: destinationFilePath, Type: Excel.XlFixedFormatType.xlTypePDF);
                        else
                            sourceWorkBook.SaveAs(Filename: destinationFilePath, FileFormat: Excel.XlFileFormat.xlWorkbookNormal);
                    }

                    sourceWorkBook.Close();
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
