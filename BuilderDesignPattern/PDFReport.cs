using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public class PDFReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            objReport.ReportContent = "PDF Content Section";
        }

        public override void SetReportFooter()
        {
            objReport.ReportFooter = "PDF Footer";
        }

        public override void SetReportHeader()
        {
            objReport.ReportHeader = "PDF Header";
        }

        public override void SetReportType()
        {
            objReport.ReportType = "PDF";
        }
    }
}
