using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod.ReportGeneration
{
    public abstract class ReportGenerator
    {
        private readonly EmailService emailService;
        protected ReportGenerator(EmailService emailService)
        {
            this.emailService = emailService;
        }
        public bool generate(File file, string email)
        {
            string path = uploadFile(file);
            if (path != null)
            {
                DataAnalized data = analizeData(path);
                File report_file = generateFile(data);
                return sendFile(report_file, email) ? true : false;
            }
            return false;
        }
        protected string uploadFile(File file)
        {
            Console.WriteLine("Loading File...");
            return @"/path/to/file";
        }
        protected bool sendFile(File file, string email)
        {
            Console.WriteLine("File attached to email");
            return emailService.send(email);
        }
        protected abstract DataAnalized analizeData(string path);
        protected abstract File generateFile(DataAnalized data);

    }
}
