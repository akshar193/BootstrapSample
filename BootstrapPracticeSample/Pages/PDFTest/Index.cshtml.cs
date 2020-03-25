using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SelectPdf;

namespace BootstrapPracticeSample.Pages.PDFTest
{
    public class IndexModel : PageModel
    {
        private IWebHostEnvironment _env;
        public IndexModel(IWebHostEnvironment env)
        {
            _env = env;
        }
        public void OnGet()
        {
            // the initial file
            var webRoot = _env.WebRootPath;
            var file = System.IO.Path.Combine(webRoot, "files/w-9.pdf");

            // load the pdf form manager    
            PdfFormManager form = new PdfFormManager();
            form.Load(file);

            PdfFormFieldTextBox name =
               form.Fields["f1_1"] as PdfFormFieldTextBox;
            name.Text = "AKshar AKshar AKshar AKshar ";

            PdfFormFieldTextBox businessName =
                form.Fields["f1_2"] as PdfFormFieldTextBox;
            businessName.Text = "This is my business name";

            PdfFormFieldCheckBox clasifIndividual =
                form.Fields["c1_1"] as PdfFormFieldCheckBox;
            clasifIndividual.Checked = true;

            PdfFormFieldTextBox address =
                form.Fields["f1_7"] as PdfFormFieldTextBox;
            address.Text = "This is my address";

            PdfFormFieldTextBox city =
                form.Fields["f1_8"] as PdfFormFieldTextBox;
            city.Text = "This is my city";

            PdfFormFieldTextBox employer1 =
                form.Fields["f1_14"] as PdfFormFieldTextBox;
            employer1.Text = "XX";

            PdfFormFieldTextBox employer2 =
                form.Fields["f1_15"] as PdfFormFieldTextBox;
            employer2.Text = "1234567";

            PdfFormFieldTextBox ssn1 =
                form.Fields["f1_11"] as PdfFormFieldTextBox;
            ssn1.Text = "123";

            PdfFormFieldTextBox ssn2 =
                form.Fields["f1_12"] as PdfFormFieldTextBox;
            ssn2.Text = "45";

            PdfFormFieldTextBox ssn3 =
                form.Fields["f1_13"] as PdfFormFieldTextBox;
            ssn3.Text = "6789";

            // save pdf document
            form.Save(@"C:\Users\aksha\OneDrive\Desktop\Sample.pdf");

            // close pdf document
            form.Close();

        }
    }
}
