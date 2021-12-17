using DesignPatterns.ChainOfResponsability.SanitizationHandler;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsability
{
    public class ChainOfResponsabilityProgram
    {
        public static void Run()
        {
            Dictionary<string, string> data = new() 
            {
                { "email", "bryan.fernandez@assuresoftbolivia.com" },
                { "digits", "4445"},
                { "date", "201-01-01" }
            };
            Request request = new Request(data);
            ISanitizationHandler emailHandler = new EmailSanitizationHandler();
            ISanitizationHandler numberHandler = new DigitsSanitizationHandler();
            ISanitizationHandler dateHandler = new DateSanitizationHandler();
            emailHandler.setNext(numberHandler).setNext(dateHandler);
            Request requestSanitized = emailHandler.sanitize(request);
            Console.WriteLine(
                "Request sanitized: "+
                "\n email : " + requestSanitized.body["email"] +
                "\n digits : " + requestSanitized.body["digits"] +
                "\n date : " + requestSanitized.body["date"]
            );
        }
    }
  
  
   

    

   

    

}
