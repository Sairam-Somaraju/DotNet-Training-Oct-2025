using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _20_11_25
{
    internal class SRP
    {
         public class InvoiceGenerator
        {
            public void GenerateInvoice()
            {
                WriteLine("Invoice Generated");
            }
        }
         public class InvoiceRepository
        {
            public void SaveToDatabase()
            {
                WriteLine("Saved in Database ");
            }
        }
          public class EmailService
        {
            public void SendEmail()
            {
                WriteLine("Invoice Email sent ");
            }
        }
        public static void Main(string[] args)
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            invoiceGenerator.GenerateInvoice();

            InvoiceRepository invoiceRepository = new InvoiceRepository();
            invoiceRepository.SaveToDatabase();

            EmailService emailService = new EmailService();
            emailService.SendEmail();
        }
            
    }
}
