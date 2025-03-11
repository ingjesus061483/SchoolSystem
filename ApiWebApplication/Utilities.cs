using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using SelectPdf;

namespace ApiWebApplication
{
    public abstract  class Utilities
    {
        public static string app = ConfigurationManager.AppSettings["NombreAplicacion"];
        public static string conectionstring = ConfigurationManager.ConnectionStrings["SchoolSystem"].ConnectionString;
        public static HtmlToPdf GetHtmlToPdf(PdfPageSize pageSize, PdfPageOrientation pdfOrientation,
                                 int webPageWidth)
        {
            HtmlToPdf htmlToPdf = new HtmlToPdf();
            htmlToPdf.Options.PdfPageSize = pageSize;
            htmlToPdf.Options.PdfPageOrientation = pdfOrientation;
            htmlToPdf.Options.WebPageWidth = webPageWidth;
            return htmlToPdf;
        }
        public static byte[] ConvertPdfToByte(string html, HtmlToPdf htmlToPdf)
        {
            PdfDocument pdfDocument = htmlToPdf.ConvertHtmlString(html);
            byte[] bytes = pdfDocument.Save();
            pdfDocument.Close();
            return bytes;
        }
        public static string GetErrors(System.Web.Http.ModelBinding.ModelStateDictionary modelstate)
        {
            string msg = "";
            foreach (var item in modelstate.Values)
            {
                foreach (var err in item.Errors)
                {
                    msg += err.ErrorMessage + Environment.NewLine;
                }
            }
            return msg;
        }
    }
}