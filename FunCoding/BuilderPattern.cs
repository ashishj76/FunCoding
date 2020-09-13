namespace FunCoding
{
    //Builder falls under the type of creational pattern category.Builder pattern helps us to separate 
    //the construction of a complex object from its representation so that the same construction process 
    //can create different representations.Builder pattern is useful when the construction of the object 
    //is very complex. The main objective is to separate the construction of objects and their representations.
    //If we are able to separate the construction and representation, we can then get many representations from 
    //the same construction. 
    //• Builder: – Builder is responsible for defining the construction process for individual parts.Builder has 
    //those individual processes to initialize and configure the product.
    //• Director: – Director takes those individual processes from the builder and defines the sequence to build the product.
    //• Product: – Product is the final object which is produced from the builder and director coordination.

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
