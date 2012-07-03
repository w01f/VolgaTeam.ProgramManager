using System;

namespace ProgramManager.CoreObjects
{
    public class Week
    {
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }

        public string Caption
        {
            get
            {
                return this.DateStart.ToString("MM/dd/yy") + " - " + this.DateEnd.ToString("MM/dd/yy");
            }
        }
    }
}
