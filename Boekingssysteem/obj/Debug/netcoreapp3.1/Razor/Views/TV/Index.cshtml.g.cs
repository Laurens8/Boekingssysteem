#pragma checksum "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72ffddee31aecb23281eaee654e5d92d46eb40df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TV_Index), @"mvc.1.0.view", @"/Views/TV/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\_ViewImports.cshtml"
using Boekingssysteem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\_ViewImports.cshtml"
using Boekingssysteem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72ffddee31aecb23281eaee654e5d92d46eb40df", @"/Views/TV/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03441aade3e891588a1e619eb5be676db935baef", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_TV_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Boekingssysteem.ViewModels.PersoonListViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
  
    ViewData["Title"] = "Screen";
    int teller = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"MainWindow\">\r\n");
#nullable restore
#line 8 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
     foreach (var item in Model.Richtingen)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>");
#nullable restore
#line 10 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
       Write(item.Naam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <div class=\"divider\"></div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 13 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
             foreach (var p in Model.Personen)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                 if (p.PersoonRichtingen != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                     foreach (var item2 in p.PersoonRichtingen)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                         if (p.PersoonFuncties != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                             if (item2.RichtingID == teller)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                 foreach (var functie in p.PersoonFuncties)
                                {                                   
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                     if (functie.FunctieID == 3)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                         if (p.Aanwezig == true)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""card text-white bg-success m-3 w-100"" style=""max-width: 18rem;"">
                                                <div class=""card-header""><h4>Aanwezig</h4></div>
                                                <div class=""card-body"">
                                                    <h5 class=""card-title"">");
#nullable restore
#line 32 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => p.Voornaam));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 32 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                                                                Write(Html.DisplayFor(modelItem => p.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                                    <p>");
#nullable restore
#line 33 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                  Write(Html.DisplayFor(modelItem => functie.Functie.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 36 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                        }
                                        else if (p.Aanwezig == false)
                                        {
                                            if (p.Afwezigheden != null)
                                            {
                                                foreach (var item3 in p.Afwezigheden)
                                                {
                                                    if (item3.Begindatum.Year <= DateTime.Now.Year && item3.Einddatum != null)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        <div class=""card text-white bg-danger m-3 w-100"" style=""max-width: 18rem;"">
                                                            <div class=""card-header""><h4>Afwezig</h4></div>
                                                            <div class=""card-body"">
                                                                <h5 class=""card-title"">");
#nullable restore
#line 48 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                                  Write(Html.DisplayFor(modelItem => p.Voornaam));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 48 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                                                                            Write(Html.DisplayFor(modelItem => p.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                                                <p>");
#nullable restore
#line 49 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                              Write(Html.DisplayFor(modelItem => functie.Functie.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                                <p>Afwezig van ");
#nullable restore
#line 50 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                          Write(Html.DisplayFor(modelItem => item3.Begindatum));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                                <p>tot en met ");
#nullable restore
#line 51 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                         Write(Html.DisplayFor(modelItem => item3.Einddatum));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                            </div>\r\n                                                        </div>\r\n");
#nullable restore
#line 54 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                    }
                                                }
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <div class=""card text-white bg-danger m-3 w-100"" style=""max-width: 18rem;"">
                                                    <div class=""card-header""><h4>Afwezig</h4></div>
                                                    <div class=""card-body"">
                                                        <h5 class=""card-title"">");
#nullable restore
#line 62 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                          Write(Html.DisplayFor(modelItem => p.Voornaam));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 62 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                                                                    Write(Html.DisplayFor(modelItem => p.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                                        <p>");
#nullable restore
#line 63 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                      Write(Html.DisplayFor(modelItem => functie.Functie.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                    </div>\r\n                                                </div>\r\n");
#nullable restore
#line 66 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                            }
                                        }
                                        else if (p.Aanwezig == null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""card text-white bg-warning m-3 w-100"" style=""max-width: 18rem;"">
                                                <div class=""card-header""><h4>Ongekend</h4></div>
                                                <div class=""card-body"">
                                                    <h5 class=""card-title"">");
#nullable restore
#line 73 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => p.Voornaam));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 73 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                                                                Write(Html.DisplayFor(modelItem => p.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                                    <p>");
#nullable restore
#line 74 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                  Write(Html.DisplayFor(modelItem => functie.Functie.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 77 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                        
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                 foreach (var functie in p.PersoonFuncties)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                     if (functie.FunctieID == 2)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                         if (p.Aanwezig == true)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""card text-white bg-success m-3 w-100"" style=""max-width: 18rem;"">
                                                <div class=""card-header""><h4>Aanwezig</h4></div>
                                                <div class=""card-body"">
                                                    <h5 class=""card-title"">");
#nullable restore
#line 89 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => p.Voornaam));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 89 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                                                                Write(Html.DisplayFor(modelItem => p.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                                    <p>");
#nullable restore
#line 90 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                  Write(Html.DisplayFor(modelItem => functie.Functie.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 93 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                        }
                                        else if(p.Afwezigheden != null)
                                        {
                                            foreach (var item3 in p.Afwezigheden)
                                            {                                               

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    <div class=""card text-white bg-danger m-3 w-100"" style=""max-width: 18rem;"">
                                                        <div class=""card-header""><h4>Afwezig</h4></div>
                                                        <div class=""card-body"">
                                                            <h5 class=""card-title"">");
#nullable restore
#line 101 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                              Write(Html.DisplayFor(modelItem => p.Voornaam));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 101 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                                                                        Write(Html.DisplayFor(modelItem => p.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                                            <p>");
#nullable restore
#line 102 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                          Write(Html.DisplayFor(modelItem => functie.Functie.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                            <p>Afwezig van ");
#nullable restore
#line 103 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item3.Begindatum));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                            <p>tot en met ");
#nullable restore
#line 104 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                     Write(Html.DisplayFor(modelItem => item3.Einddatum));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                        </div>
                                                    </div>                                                                                                                                                    
");
#nullable restore
#line 107 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                            }        
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""card text-white bg-danger m-3 w-100"" style=""max-width: 18rem;"">
                                                        <div class=""card-header""><h4>Afwezig</h4></div>
                                                        <div class=""card-body"">
                                                            <h5 class=""card-title"">");
#nullable restore
#line 114 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                              Write(Html.DisplayFor(modelItem => p.Voornaam));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 114 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                                                                        Write(Html.DisplayFor(modelItem => p.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                                            <p>");
#nullable restore
#line 115 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                          Write(Html.DisplayFor(modelItem => functie.Functie.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                        </div>\r\n                                            </div>\r\n");
#nullable restore
#line 118 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                     

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 128 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
        teller++;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Boekingssysteem.ViewModels.PersoonListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
