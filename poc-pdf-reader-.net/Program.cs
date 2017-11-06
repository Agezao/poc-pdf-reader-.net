using poc_pdf_reader_.net.Services;
using System;

namespace poc_pdf_reader_.net
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = @"C:\dev\tests\poc-pdf-reader-.net\file-test.PDF";

            PdfService pdfParser = new PdfService();
            var content = pdfParser.ExtractText(file);

            Console.WriteLine("Done");
        }
    }
}
