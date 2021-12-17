using DesignPatterns.FactoryMethod.v2.Parser;
using DesignPatterns.TemplateMethod.ReportGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod
{
    public class TemplateMethodProgram
    {
        public static void Run()
        {
            File xml_file = new File();
            string email = "bryan.fernandez@assuresoftbolivia.com";
            ReportGenerator pdf_report = new PDFReportGenerator(new EmailService());
            ReportGenerator xlsx_report = new XLSXReportGenerator(new EmailService());
            pdf_report.generate(xml_file, email);
            xlsx_report.generate(xml_file, email);
        }
    }
}
