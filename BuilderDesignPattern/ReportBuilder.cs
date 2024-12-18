﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
   public abstract class ReportBuilder
    {
        protected Report objReport;

        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();

        public void CreateNewReport()
        {
            objReport = new Report();
        }

        public Report GetReport()
        {
            return objReport;
        }
    }
}
