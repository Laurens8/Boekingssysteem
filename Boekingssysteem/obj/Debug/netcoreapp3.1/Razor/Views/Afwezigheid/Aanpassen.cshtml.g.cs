#pragma checksum "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "678233e3e2b9de5d6770b1154ee5620eb605455b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Afwezigheid_Aanpassen), @"mvc.1.0.view", @"/Views/Afwezigheid/Aanpassen.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"678233e3e2b9de5d6770b1154ee5620eb605455b", @"/Views/Afwezigheid/Aanpassen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03441aade3e891588a1e619eb5be676db935baef", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Afwezigheid_Aanpassen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Boekingssysteem.ViewModels.AfwezigheidCRUDViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Afwezigheid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AanpassenDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Verwijderen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
  
    ViewData["Title"] = "Afwezigheid aanpassen";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row mb-5\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "678233e3e2b9de5d6770b1154ee5620eb605455b5561", async() => {
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
            WriteLiteral("\r\n    <hr />\r\n    <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#exampleModalLong\">\r\n        Personeel lijst\r\n    </button>\r\n</div>\r\n\r\n");
#nullable restore
#line 15 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
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
#line 28 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
                     if (Model.Personen != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
                         foreach (var item in Model.Personen)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <table>\r\n");
#nullable restore
#line 33 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
                                 using (Html.BeginForm("Aanpassen", "Afwezigheid", new { @personeelnummer = $"{@item.Personeelnummer}" }, FormMethod.Post))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input type=\"submit\" class=\"btn btn-primary btn mb-2\"");
            BeginWriteAttribute("value", " value=\"", 1567, "\"", 1622, 3);
#nullable restore
#line 35 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
WriteAttributeValue("", 1575, item.Personeelnummer, 1575, 21, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
WriteAttributeValue(" ", 1596, item.Naam, 1597, 10, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
WriteAttributeValue(" ", 1607, item.Voornaam, 1608, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 36 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"divider mb-5 mt-5\"></div>\r\n                            </table>\r\n");
#nullable restore
#line 39 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"modal-footer\">\r\n                    <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 48 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"h-100 d-flex align-items-center justify-content-center\">\r\n    <div BtnCrud>\r\n        <div class=\"col-sm-12\">\r\n            <div class=\"mb-5\">\r\n");
#nullable restore
#line 54 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
                 using (Html.BeginForm())
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
               Write(Html.TextBoxFor(s => s.Personeelnummer));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input class=\"btn btn-primary mb-2\" type=\"submit\" value=\"Zoek adhv personeelsnummer\" />\r\n");
#nullable restore
#line 58 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 2512, "\"", 2554, 2);
#nullable restore
#line 60 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
WriteAttributeValue("", 2520, ViewBag.Class, 2520, 14, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
WriteAttributeValue(" ", 2534, ViewBag.Visibility, 2535, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n                ");
#nullable restore
#line 61 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
           Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>

            <table class=""table table-bordered table-striped"">
                <tr>
                    <th>Begindatum</th>
                    <th>Einddatum</th>
                    <th></th>
                    <th></th>
                </tr>
");
#nullable restore
#line 71 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
                 foreach (var afwezig in ViewBag.Afwezigheden)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 74 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
                       Write(String.Format("{0:dd/MM/yyyy}",@afwezig.Begindatum));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 76 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
                             if (@afwezig.Einddatum != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
                           Write(String.Format("{0:dd/MM/yyyy}",@afwezig.Einddatum));

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
                                                                                   
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "678233e3e2b9de5d6770b1154ee5620eb605455b15780", async() => {
                WriteLiteral("Aanpassen");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
                                                                             WriteLiteral(afwezig.AfwezigheidID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "678233e3e2b9de5d6770b1154ee5620eb605455b18139", async() => {
                WriteLiteral("Verwijderen");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
                                                                         WriteLiteral(afwezig.AfwezigheidID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 84 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 92 "C:\Thomas More 2de jaar\Projecten van het werkveld\Boekingssysteem\Boekingssysteem\Views\Afwezigheid\Aanpassen.cshtml"
      
        await Html.RenderPartialAsync("_ValidationScriptsPartial");
    

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Boekingssysteem.ViewModels.AfwezigheidCRUDViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
