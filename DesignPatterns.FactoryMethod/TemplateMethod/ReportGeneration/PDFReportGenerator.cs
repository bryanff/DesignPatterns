using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod.ReportGeneration
{
    public class PDFReportGenerator : ReportGenerator
    {
        public PDFReportGenerator(EmailService emailService)
            : base(emailService) { }
        protected override File generateFile(DataAnalized data)
        {
            Console.WriteLine("Generating A PDF Report file...");
            return new File();
        }
        protected override DataAnalized analizeData(string path)
        {
            Console.WriteLine("Analizind Data from : " + path);
            return new DataAnalized();
        }
    }
}
