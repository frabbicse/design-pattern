using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
  public class ExcelReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            objReport.ReportContent = "Excel Content Section";

        }

        public override void SetReportFooter()
        {
            objReport.ReportFooter = "Excel Footer";
        }

        public override void SetReportHeader()
        {
            objReport.ReportHeader = "Excel Header";
        }

        public override void SetReportType()
        {
            objReport.ReportType = "Excel";
        }
    }
}
