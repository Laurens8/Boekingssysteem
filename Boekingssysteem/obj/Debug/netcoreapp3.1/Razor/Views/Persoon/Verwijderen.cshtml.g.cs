#pragma checksum "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\Persoon\Verwijderen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06bff9981c4be9a32e9b6a6fe26a5061043611cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persoon_Verwijderen), @"mvc.1.0.view", @"/Views/Persoon/Verwijderen.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06bff9981c4be9a32e9b6a6fe26a5061043611cd", @"/Views/Persoon/Verwijderen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03441aade3e891588a1e619eb5be676db935baef", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Persoon_Verwijderen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Boekingssysteem.ViewModels.DeletePersoonViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\Persoon\Verwijderen.cshtml"
  
    ViewData["Title"] = "Verwijderen";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"alert alert-danger mb-5 visible\" role=\"alert\">\r\n    alert wordt getoont bij foutmelding. normaal niet zichtbaar.\r\n</div>\r\n\r\n<div class=\"h-100 d-flex align-items-center justify-content-center\">\r\n    <div class=\"col\">\r\n");
#nullable restore
#line 12 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\Persoon\Verwijderen.cshtml"
         using (Html.BeginForm("VerwijderenData", "Persoon", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col"">
                <div class=""mb-5"">
                    <div class=""form-group"">
                        <label class=""mr-3"">personeelsnummer:</label>
                        <input class=""mr-3"" type=""text"" name=""personeelnummer"" />
                        <input type=""submit"" value=""Gebruiker zoeken"" class=""btn btn-primary mb-2"" />
                    </div>
                </div>
                <div class=""PersoneelInfo"">
                    <div class=""col"">
                        <div class=""row"">
                            <p>Naam: </p>
                            <p>");
#nullable restore
#line 26 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\Persoon\Verwijderen.cshtml"
                          Write(ViewBag.naam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <p>Voornaam: </p>\r\n                            <p>");
#nullable restore
#line 30 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\Persoon\Verwijderen.cshtml"
                          Write(ViewBag.voornaam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <p>Personeelnummer: </p>\r\n                            <p>");
#nullable restore
#line 34 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\Persoon\Verwijderen.cshtml"
                          Write(ViewBag.personeelnummer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n");
#nullable restore
#line 40 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\Persoon\Verwijderen.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\Persoon\Verwijderen.cshtml"
         using (Html.BeginForm("Delete", "Persoon", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"mt-5\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06bff9981c4be9a32e9b6a6fe26a5061043611cd7477", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "06bff9981c4be9a32e9b6a6fe26a5061043611cd7755", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 45 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\Persoon\Verwijderen.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Personeelnummer);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <input type=\"submit\" value=\"Gebruiker verwijderen\" class=\"btn btn-primary btn-lg mb-2\" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 49 "C:\Users\laure\OneDrive\Desktop\Boekingssysteem\Boekingssysteem\Boekingssysteem\Views\Persoon\Verwijderen.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Boekingssysteem.ViewModels.DeletePersoonViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
