#pragma checksum "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7a86cebb30a73838feba146313dfb8eb61f7a92"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7a86cebb30a73838feba146313dfb8eb61f7a92", @"/Views/Status/StatusIndividueel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03441aade3e891588a1e619eb5be676db935baef", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Status_StatusIndividueel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Boekingssysteem.ViewModels.PersoonCRUDViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Status", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
  
    ViewData["Title"] = "Aanwezigheid aanpassen";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7a86cebb30a73838feba146313dfb8eb61f7a924812", async() => {
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
            WriteLiteral("\r\n<hr />\r\n\r\n<div class=\"h-100 d-flex align-items-center justify-content-center\">\r\n    <div class=\"col\">\r\n");
#nullable restore
#line 11 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
         using (Html.BeginForm("StatusData", "Status", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7a86cebb30a73838feba146313dfb8eb61f7a926697", async() => {
                WriteLiteral("\r\n                <div class=\"col\">\r\n                    <div class=\"mb-5\">\r\n                        <div class=\"form-group\">\r\n                            <label class=\"mr-3\">Personeelsnummer: </label>\r\n                            ");
#nullable restore
#line 18 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
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
#line 26 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
                              Write(ViewBag.naam);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"row\">\r\n                                <p>Voornaam: </p>\r\n                                <p>");
#nullable restore
#line 30 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
                              Write(ViewBag.voornaam);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"row\">\r\n                                <p>Personeelnummer: </p>\r\n                                <p>");
#nullable restore
#line 34 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
                              Write(ViewBag.personeelnummer);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"row\">\r\n                                <p>Status: </p>\r\n");
#nullable restore
#line 38 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
                                 if (@ViewBag.Aanwezig == null)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <p></p> \r\n");
#nullable restore
#line 41 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
                                }
                                else if (@ViewBag.Aanwezig == true)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <p>Aanwezig</p>                                    \r\n");
#nullable restore
#line 45 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <p>Afwezig</p>\r\n");
#nullable restore
#line 49 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
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
#line 55 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
        }       

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div>\r\n");
#nullable restore
#line 58 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
                 using (Html.BeginForm("AanpassenViaId", "Status", new { @personeelnummer = $"{@ViewBag.personeelnummer}" }, FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"mt-5 mr-5\">\r\n                        <input type=\"submit\" class=\"btn btn-primary btn-lg mb-2\" value=\"Status aanpassen\">\r\n                    </div>\r\n");
#nullable restore
#line 63 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\Status\StatusIndividueel.cshtml"
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
