#pragma checksum "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16189866505e73970339f633ee2f3d081d6d7159"
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
#line 1 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\_ViewImports.cshtml"
using Boekingssysteem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\_ViewImports.cshtml"
using Boekingssysteem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16189866505e73970339f633ee2f3d081d6d7159", @"/Views/TV/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03441aade3e891588a1e619eb5be676db935baef", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_TV_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Boekingssysteem.ViewModels.PersoonListViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
  
    ViewData["Title"] = "Screen";
    int teller = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta http-equiv=\"refresh\" content=\"10\">\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16189866505e73970339f633ee2f3d081d6d71594536", async() => {
                WriteLiteral("Terug");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<hr />\r\n<div class=\"MainWindowTV\">\r\n");
#nullable restore
#line 11 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
     foreach (var item in Model.Richtingen)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>");
#nullable restore
#line 13 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
       Write(item.Naam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <div class=\"divider\"></div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 16 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
             foreach (var p in Model.Personen)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                 if (p.PersoonRichtingen != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                     foreach (var item2 in p.PersoonRichtingen)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                         if (p.PersoonFuncties != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                             if (item2.RichtingID == teller)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                         if (p.Aanwezig == true)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"card text-white bg-success m-3\" style=\"max-width: 18rem;\">\r\n                                                <div class=\"card-header\"><h4>");
#nullable restore
#line 33 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                        Write(Html.DisplayFor(modelItem => p.Voornaam));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                                                                  Write(Html.DisplayFor(modelItem => p.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (Aanwezig)</h4></div>\r\n                                               \r\n                                            </div>\r\n");
#nullable restore
#line 36 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
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
            WriteLiteral("                                                        <div class=\"card text-white bg-danger m-3\" style=\"max-width: 18rem;\">\r\n                                                            <div class=\"card-header\"><h4>");
#nullable restore
#line 46 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                                    Write(Html.DisplayFor(modelItem => p.Voornaam));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 46 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                                                                              Write(Html.DisplayFor(modelItem => p.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (Afwezig)</h4></div>\r\n                                                            \r\n                                                        </div>\r\n");
#nullable restore
#line 49 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                    }
                                                }
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"card text-white bg-danger m-3\" style=\"max-width: 18rem;\">\r\n                                                    <div class=\"card-header\"><h4>");
#nullable restore
#line 55 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                            Write(Html.DisplayFor(modelItem => p.Voornaam));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 55 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                                                                      Write(Html.DisplayFor(modelItem => p.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (Afwezig)</h4></div>\r\n                                                 \r\n                                                </div>\r\n");
#nullable restore
#line 58 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                            }
                                        }
                                        else if (p.Aanwezig == null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"card text-white bg-warning m-3\" style=\"max-width: 18rem;\">\r\n                                                <div class=\"card-header\"><h4>");
#nullable restore
#line 63 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                        Write(Html.DisplayFor(modelItem => p.Voornaam));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 63 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                                                                                                  Write(Html.DisplayFor(modelItem => p.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (Ongekend)</h4></div>\r\n                                               \r\n                                            </div>\r\n");
#nullable restore
#line 66 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                        }
                                  

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                                   
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 106 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\TV\Index.cshtml"
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
