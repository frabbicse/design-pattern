using BuilderDesignPattern;
using BuilderDesignPattern.RealTime;

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattenLearning.Patterns
{
    class BuilderDesignPatternHelper
    {
        public static void GetOutput()
        {
            Report report;
            ReportDirector reportDirector = new ReportDirector();

            PDFReport pdfReport = new PDFReport();
            report = reportDirector.MakeReport(pdfReport);
            report.DisplayReport();
            Console.WriteLine("-------------------");

            ExcelReport excelReport = new ExcelReport();
            report = reportDirector.MakeReport(excelReport);
            report.DisplayReport();

            Console.ReadKey();
        }

        public static void GetOutputRealtime()
        {
            Beverage beverage;
            BeverageDirector beverageDirector = new BeverageDirector();

            TeaBuilder tea = new TeaBuilder();
            beverage = beverageDirector.MakeBeverage(tea);
            Console.WriteLine(beverage.ShowBeverage());

            CoffeeBuilder coffee = new CoffeeBuilder();
            beverage = beverageDirector.MakeBeverage(coffee);
            Console.WriteLine(beverage.ShowBeverage());
            Console.ReadKey();
        }
    }
}
