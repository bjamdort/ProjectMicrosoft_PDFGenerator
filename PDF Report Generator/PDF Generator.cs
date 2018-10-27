using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF_Report_Generator
{
    class PDF_Generator
    {

        string generate = "";

        public PDF_Generator()
        {

        }

        public void Generate(List<Question> Data)
        {
            AddInfo(Data);
            
            var Renderer = new IronPdf.HtmlToPdf();
            var PDF = Renderer.RenderHtmlAsPdf(generate);
            PDF.SaveAs("PDF.pdf");
            Process.Start("PDF.pdf");
        }


        public void AddInfo(List<Question> Data)
        {

            foreach (Question q in Data) {

                generate += "<h1 style=\"font-family: Arial\">" + q.Description + "</h1><br>";
                    
                foreach(Answer a in q.Answer)
                {
                    if(a.Score != null)
                    {
                        generate += "<p style=\"font-family: Arial\"><b>Score:</b> " + a.Score + "<br><br>";
                    }

                    generate += "<b>Antwoord:</b><br>" + a.Explanation + "</p><br>";
                }
            }
        }
    }
}
