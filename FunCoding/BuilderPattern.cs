using System;
using System.Collections.Generic;
using System.Text;

namespace FunCoding
{
    class BuilederPattern
    {
        public class Report
        {
            public string ReportType;
            public string Header;
            public string Footer;
            public string Content;
        }
       public abstract class ReportBuilder
        {
            public Report report;
            public void CreateReport()
            {
                report = new Report();
            }
            public abstract void SetReportType();
            public abstract void SetHeader();
            public abstract void SetFooter();
            public abstract void SetContent();
            public Report DispatchReport()
            {
                return report;
            }
        }

        public class PDFReport : ReportBuilder
        {
            public override void SetContent()
            {
                report.Content = "PDF Content";
            }

            public override void SetFooter()
            {
                report.Footer = "PDF Footer";
            }

            public override void SetHeader()
            {
                report.Header = "PDF Header";
            }

            public override void SetReportType()
            {
                report.Content = "PDF";
            }
        }

        public class ExcelReport : ReportBuilder
        {
            public override void SetContent()
            {
                report.Content = "Excel Content";
            }

            public override void SetFooter()
            {
                report.Footer = "Excel Footer";
            }

            public override void SetHeader()
            {
                report.Header = "Excel Header";
            }

            public override void SetReportType()
            {
                report.Content = "Excel";
            }
        }

        public class ReoprtDirector
        { 
            public Report GenerateReport(ReportBuilder builder)
            {
                builder.CreateReport();
                builder.SetHeader();
                builder.SetFooter();
                builder.SetContent();
                return builder.DispatchReport();
            }
           
        }
    }
}
