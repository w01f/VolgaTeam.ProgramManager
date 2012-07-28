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

        public static bool Is2003
        {
            get
            {
                bool result = true;
                ExcelHelper helper = new ExcelHelper();
                if (helper.Connect())
                {
                    result = helper._excelObject.Version.Equals("11.0");
                    helper.Disconnect();
                }
                return result;
            }
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
                        workSheet.PageSetup.CenterHeader = string.Format("&\"{0}{2}\"&{1}", new string[] { ConfigurationClasses.SettingsManager.Instance.OutputSettings.HeaderFont.Name, ConfigurationClasses.SettingsManager.Instance.OutputSettings.HeaderFont.Size.ToString(), ConfigurationClasses.SettingsManager.Instance.OutputSettings.HeaderFont.Bold ? ",bold" : string.Empty }) + title + (char)13 + dateRange;

                        workSheet.PageSetup.CenterFooter = string.Format("&\"{0}{2}\"&{1}", new string[] { ConfigurationClasses.SettingsManager.Instance.OutputSettings.FooterFont.Name, ConfigurationClasses.SettingsManager.Instance.OutputSettings.FooterFont.Size.ToString(), ConfigurationClasses.SettingsManager.Instance.OutputSettings.FooterFont.Bold ? ",bold" : string.Empty }) + "Schedule Generated" + (char)13 + sheduleGenrated.ToString("MM/dd/yy h:mm tt");
                        workSheet.PageSetup.RightFooter = string.Format("&\"{0}{1}\"", new string[] { ConfigurationClasses.SettingsManager.Instance.OutputSettings.FooterFont.Name, ConfigurationClasses.SettingsManager.Instance.OutputSettings.FooterFont.Size.ToString() }) + workSheet.PageSetup.RightFooter;

                        Excel.Range range = workSheet.Range["Data"];
                        range.Font.Name = ConfigurationClasses.SettingsManager.Instance.OutputSettings.BodyFont.Name;
                        range.Font.Size = ConfigurationClasses.SettingsManager.Instance.OutputSettings.BodyFont.Size;
                        range.Font.Bold = ConfigurationClasses.SettingsManager.Instance.OutputSettings.BodyFont.Bold;
                        range.Font.Italic = ConfigurationClasses.SettingsManager.Instance.OutputSettings.BodyFont.Italic;

                        if (ConfigurationClasses.SettingsManager.Instance.OutputSettings.UsePrimeTimeSpecialFontSize)
                        {
                            {
                                int firstColumn = workSheet.Range["day1"].Column;
                                int lastColumn = workSheet.Range["day6"].Column;

                                int firstRow = workSheet.Range["day1"].Row + 1;
                                DateTime time = new DateTime(1, 1, 1, 5, 0, 0);
                                while (!(time.Hour == ConfigurationClasses.SettingsManager.Instance.OutputSettings.WeekPrimeTimeStart.Hour && time.Minute == ConfigurationClasses.SettingsManager.Instance.OutputSettings.WeekPrimeTimeStart.Minute))
                                {
                                    time = time.AddMinutes(30);
                                    firstRow++;
                                }

                                int lastRow = firstRow;
                                while (!(time.Hour == ConfigurationClasses.SettingsManager.Instance.OutputSettings.WeekPrimeTimeEnd.Hour && time.Minute == ConfigurationClasses.SettingsManager.Instance.OutputSettings.WeekPrimeTimeEnd.Minute))
                                {
                                    time = time.AddMinutes(30);
                                    lastRow++;
                                }

                                range = workSheet.Range[GetColumnLetterByIndex(firstColumn) + firstRow.ToString() + ":" + GetColumnLetterByIndex(lastColumn) + lastRow.ToString()];
                                range.Font.Name = ConfigurationClasses.SettingsManager.Instance.OutputSettings.BodyFont.Name;
                                range.Font.Size = ConfigurationClasses.SettingsManager.Instance.OutputSettings.PrimeTimeSpecialFontSize;
                                range.Font.Bold = ConfigurationClasses.SettingsManager.Instance.OutputSettings.BodyFont.Bold;
                                range.Font.Italic = ConfigurationClasses.SettingsManager.Instance.OutputSettings.BodyFont.Italic;
                            }

                            {
                                int firstColumn = workSheet.Range["day7"].Column;
                                int lastColumn = workSheet.Range["day7"].Column;

                                int firstRow = workSheet.Range["day7"].Row + 1;
                                DateTime time = new DateTime(1, 1, 1, 5, 0, 0);
                                while (!(time.Hour == ConfigurationClasses.SettingsManager.Instance.OutputSettings.SundayPrimeTimeStart.Hour && time.Minute == ConfigurationClasses.SettingsManager.Instance.OutputSettings.SundayPrimeTimeStart.Minute))
                                {
                                    time = time.AddMinutes(30);
                                    firstRow++;
                                }

                                int lastRow = firstRow;
                                while (!(time.Hour == ConfigurationClasses.SettingsManager.Instance.OutputSettings.SundayPrimeTimeEnd.Hour && time.Minute == ConfigurationClasses.SettingsManager.Instance.OutputSettings.SundayPrimeTimeEnd.Minute))
                                {
                                    time = time.AddMinutes(30);
                                    lastRow++;
                                }

                                range = workSheet.Range[GetColumnLetterByIndex(firstColumn) + firstRow.ToString() + ":" + GetColumnLetterByIndex(lastColumn) + lastRow.ToString()];
                                range.Font.Name = ConfigurationClasses.SettingsManager.Instance.OutputSettings.BodyFont.Name;
                                range.Font.Size = ConfigurationClasses.SettingsManager.Instance.OutputSettings.PrimeTimeSpecialFontSize;
                                range.Font.Bold = ConfigurationClasses.SettingsManager.Instance.OutputSettings.BodyFont.Bold;
                                range.Font.Italic = ConfigurationClasses.SettingsManager.Instance.OutputSettings.BodyFont.Italic;
                            }
                        }

                        object[,] values = new object[48, 7];
                        for (int j = 0; j < 48; j++)
                        {
                            List<object> cells = new List<object>();
                            for (int i = 0; i < 7; i++)
                                values[j, i] = weekDays[i].ProgramActivities[j].ProgramExtended + (ConfigurationClasses.SettingsManager.Instance.OutputSettings.ShowHouseNumber && !string.IsNullOrEmpty(weekDays[i].ProgramActivities[j].HouseNumber) ? (" (" + weekDays[i].ProgramActivities[j].HouseNumber + ")") : string.Empty);
                        }
                        workSheet.Range["Data"].Value2 = values;

                        for (int i = 0; i < 7; i++)
                        {
                            range = workSheet.Range["day" + (i + 1).ToString()];
                            range.Formula = weekDays[i].Date.ToString(landscape ? "dddd M/d" : "ddd M/d");
                            int columnIndex = range.Column;
                            int rowIndex = range.Row + 1;
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
                            range = workSheet.Range["day" + (i + 1).ToString()];
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
                                    for (int j = i; j < 7; j++)
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

                        Excel.Range dataRange = workSheet.Range["Data"];

                        dataRange.Rows.AutoFit();

                        //set correct page breaks
                        try
                        {
                            int fisrtColumnNumber = workSheet.Range["day1"].Column;
                            int lastColumnNumber = workSheet.Range["day7"].Column;
                            Excel.HPageBreaks pageBreaks = workSheet.HPageBreaks;
                            for (int i = 1; i <= pageBreaks.Count; i++)
                            {
                                int currentBreakRow = pageBreaks[i].Location.Row;
                                int newBreakRow = currentBreakRow;
                                Excel.Range beforeRange = pageBreaks[i].Location;
                                for (int j = fisrtColumnNumber; j <= lastColumnNumber; j++)
                                {
                                    Excel.Range cellRange = workSheet.Cells[currentBreakRow, j];
                                    if (cellRange.MergeCells)
                                    {
                                        if (beforeRange.Row > cellRange.MergeArea.Row)
                                        {
                                            beforeRange = cellRange.MergeArea;
                                            newBreakRow = beforeRange.Row;
                                        }
                                    }
                                }
                                if (newBreakRow != currentBreakRow)
                                    workSheet.HPageBreaks.Add(Before: beforeRange);
                            }
                        }
                        catch
                        { }

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
                    range = workSheet.Range["Type"];
                    int lastColumn = range.Column;

                    List<object[]> rows = new List<object[]>();
                    foreach (CoreObjects.ProgramActivity activity in activities)
                    {
                        List<object> cells = new List<object>();
                        cells.Add(activity.Date.ToString("MM/dd/yyyy"));
                        cells.Add(activity.Date.ToString("ddd"));
                        cells.Add(activity.Time.ToString("hh:mmtt"));
                        cells.Add(activity.ProgramExtended);
                        cells.Add(activity.HouseNumber);
                        cells.Add(activity.Episode);
                        cells.Add(activity.Type);
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
