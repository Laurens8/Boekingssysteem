#pragma checksum "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27ff7434f7e013c6d0e7863a6ad3f2015abd06b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Status_StatusIndividueel), @"mvc.1.0.view", @"/Views/Status/StatusIndividueel.cshtml")]
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
#line 1 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\_ViewImports.cshtml"
using Boekingssysteem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\_ViewImports.cshtml"
using Boekingssysteem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27ff7434f7e013c6d0e7863a6ad3f2015abd06b4", @"/Views/Status/StatusIndividueel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03441aade3e891588a1e619eb5be676db935baef", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Status_StatusIndividueel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Boekingssysteem.ViewModels.PersoonCRUDViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Status", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
  
    ViewData["Title"] = "Aanwezigheid aanpassen";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row mb-5\">\r\n");
#nullable restore
#line 7 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
     if (Context.User.IsInRole("admin"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27ff7434f7e013c6d0e7863a6ad3f2015abd06b45788", async() => {
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
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27ff7434f7e013c6d0e7863a6ad3f2015abd06b47503", async() => {
                WriteLiteral("Terug");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
    }   

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr />\r\n");
#nullable restore
#line 16 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
     if (Context.User.IsInRole("admin"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#exampleModalLong\">\r\n            Personeel lijst\r\n        </button>\r\n");
#nullable restore
#line 21 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
    }   

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 24 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!-- Modal -->
    <div class=""modal fade"" id=""exampleModalLong"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLongTitle"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">Personeel lijst</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
");
#nullable restore
#line 37 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
                     if (Model.Personen != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
                         foreach (var item in Model.Personen)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <table>\r\n");
#nullable restore
#line 42 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
                                 using (Html.BeginForm("StatusData", "Status", new { @personeelnummer = $"{@item.Personeelnummer}" }, FormMethod.Post))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input type=\"submit\" class=\"btn btn-primary btn mb-2\"");
            BeginWriteAttribute("value", " value=\"", 1813, "\"", 1868, 3);
#nullable restore
#line 44 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
WriteAttributeValue("", 1821, item.Personeelnummer, 1821, 21, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
WriteAttributeValue(" ", 1842, item.Naam, 1843, 10, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
WriteAttributeValue(" ", 1853, item.Voornaam, 1854, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 45 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
                                }                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"divider mb-5 mt-5\"></div>\r\n                            </table>\r\n");
#nullable restore
#line 48 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"modal-footer\">\r\n                    <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 57 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"h-100 d-flex align-items-center justify-content-center\">\r\n    <div class=\"col\">\r\n");
#nullable restore
#line 61 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
         using (Html.BeginForm("StatusData", "Status", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27ff7434f7e013c6d0e7863a6ad3f2015abd06b414987", async() => {
                WriteLiteral("\r\n                <div class=\"col\">\r\n                    <div class=\"mb-5\">\r\n                        <div class=\"form-group\">\r\n                            <label class=\"mr-3\">Personeelsnummer: </label>\r\n                            ");
#nullable restore
#line 68 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
                       Write(Html.TextBoxFor(s => s.Personeelnummer, new {@class = "form-control mb-3", @placeholder = "R-nummer"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            <input type=""submit"" value=""Gebruiker zoeken"" class=""btn btn-primary mb-2"" />
                        </div>
                    </div>
                    <div class=""PersoneelInfo"">
                        <div class=""col"">
                            <div class=""row"">
                                <p>Naam: </p>
                                <p>");
#nullable restore
#line 76 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
                              Write(ViewBag.naam);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"row\">\r\n                                <p>Voornaam: </p>\r\n                                <p>");
#nullable restore
#line 80 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
                              Write(ViewBag.voornaam);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"row\">\r\n                                <p>Personeelnummer: </p>\r\n                                <p>");
#nullable restore
#line 84 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
                              Write(ViewBag.personeelnummer);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"row\">\r\n                                <p>Status: </p>\r\n");
#nullable restore
#line 88 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
                                 if (ViewBag.Aanwezig == null)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <p></p> \r\n");
#nullable restore
#line 91 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
                                }
                                else if (ViewBag.Aanwezig == true)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <p>Aanwezig</p>                                    \r\n");
#nullable restore
#line 95 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <p>Afwezig</p>\r\n");
#nullable restore
#line 99 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>                \r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 105 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
        }       

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div>\r\n");
#nullable restore
#line 108 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
                 using (Html.BeginForm("AanpassenViaId", "Status", new { @personeelnummer = $"{@ViewBag.personeelnummer}" }, FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"mt-5 mr-5\">\r\n                        <input type=\"submit\" class=\"btn btn-primary btn-lg mb-2\" value=\"Status aanpassen\">\r\n                    </div>\r\n");
#nullable restore
#line 113 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Nieuwe map\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Boekingssysteem.ViewModels.PersoonCRUDViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
