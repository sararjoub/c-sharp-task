using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class SchoolReport
    {
        public string ReportTitle { get; set; }

        public SchoolReport(string reportTitle)
        {
            ReportTitle = reportTitle;
        }

        public void DisplayReportTitle()
        {
            Console.WriteLine($"School Report:");
            Console.WriteLine($"Report Title: {ReportTitle}");
            Console.WriteLine();
        }
    }
}

