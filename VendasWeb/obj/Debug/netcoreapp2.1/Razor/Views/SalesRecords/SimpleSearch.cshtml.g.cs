#pragma checksum "C:\Users\Windows 10\OneDrive\Documentos\Cursos e concursos\Cursos profissionalizantes\C#\Cap18\VendasWeb\VendasWeb\Views\SalesRecords\SimpleSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5eff959b96a3f7781e09a8547029da19cc3d9944"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesRecords_SimpleSearch), @"mvc.1.0.view", @"/Views/SalesRecords/SimpleSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SalesRecords/SimpleSearch.cshtml", typeof(AspNetCore.Views_SalesRecords_SimpleSearch))]
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
#line 1 "C:\Users\Windows 10\OneDrive\Documentos\Cursos e concursos\Cursos profissionalizantes\C#\Cap18\VendasWeb\VendasWeb\Views\_ViewImports.cshtml"
using VendasWeb;

#line default
#line hidden
#line 2 "C:\Users\Windows 10\OneDrive\Documentos\Cursos e concursos\Cursos profissionalizantes\C#\Cap18\VendasWeb\VendasWeb\Views\_ViewImports.cshtml"
using VendasWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eff959b96a3f7781e09a8547029da19cc3d9944", @"/Views/SalesRecords/SimpleSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a55d37012a149cb68ce4f7377906d2ec790911c", @"/Views/_ViewImports.cshtml")]
    public class Views_SalesRecords_SimpleSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VendasWeb.Models.SalesRecord>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(76, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\Windows 10\OneDrive\Documentos\Cursos e concursos\Cursos profissionalizantes\C#\Cap18\VendasWeb\VendasWeb\Views\SalesRecords\SimpleSearch.cshtml"
  
    ViewData["Title"] = "Simple Search";

#line default
#line hidden
            BeginContext(129, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(136, 17, false);
#line 8 "C:\Users\Windows 10\OneDrive\Documentos\Cursos e concursos\Cursos profissionalizantes\C#\Cap18\VendasWeb\VendasWeb\Views\SalesRecords\SimpleSearch.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(153, 46, true);
            WriteLiteral("</h2>\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n");
            EndContext();
            BeginContext(342, 43, true);
            WriteLiteral("    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(385, 664, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f4f00fc9cfc4a80853ad2ec1db0b9ce", async() => {
                BeginContext(437, 215, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\">Min Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 652, "", 679, 1);
#line 18 "C:\Users\Windows 10\OneDrive\Documentos\Cursos e concursos\Cursos profissionalizantes\C#\Cap18\VendasWeb\VendasWeb\Views\SalesRecords\SimpleSearch.cshtml"
WriteAttributeValue("", 659, ViewData["minDate"], 659, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(679, 204, true);
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Max Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 883, "", 910, 1);
#line 22 "C:\Users\Windows 10\OneDrive\Documentos\Cursos e concursos\Cursos profissionalizantes\C#\Cap18\VendasWeb\VendasWeb\Views\SalesRecords\SimpleSearch.cshtml"
WriteAttributeValue("", 890, ViewData["maxDate"], 890, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(910, 132, true);
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Filter</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1049, 61, true);
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n\r\n\r\n<div class=\"panel panel-primary\">\r\n");
            EndContext();
            BeginContext(1150, 79, true);
            WriteLiteral("    <div class=\"panel-heading\">\r\n        <h3 class=\"panel-title\">Total sales = ");
            EndContext();
            BeginContext(1230, 43, false);
#line 34 "C:\Users\Windows 10\OneDrive\Documentos\Cursos e concursos\Cursos profissionalizantes\C#\Cap18\VendasWeb\VendasWeb\Views\SalesRecords\SimpleSearch.cshtml"
                                         Write(Model.Sum(obj => obj.Amount).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1273, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
            BeginContext(1365, 208, true);
            WriteLiteral("    </div>\r\n    <div class=\"panel-body\">\r\n        <table class=\"table table-striped table-hover\">\r\n            <thead>\r\n                <tr class=\"success\">\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1574, 38, false);
#line 42 "C:\Users\Windows 10\OneDrive\Documentos\Cursos e concursos\Cursos profissionalizantes\C#\Cap18\VendasWeb\VendasWeb\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1612, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1692, 40, false);
#line 45 "C:\Users\Windows 10\OneDrive\Documentos\Cursos e concursos\Cursos profissionalizantes\C#\Cap18\VendasWeb\VendasWeb\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1732, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1812, 42, false);
#line 48 "C:\Users\Windows 10\OneDrive\Documentos\Cursos e concursos\Cursos profissionalizantes\C#\Cap18\VendasWeb\VendasWeb\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Seller));

#line default
#line hidden
            EndContext();
            BeginContext(1854, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1934, 53, false);
#line 51 "C:\Users\Windows 10\OneDrive\Documentos\Cursos e concursos\Cursos profissionalizantes\C#\Cap18\VendasWeb\VendasWeb\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Seller.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1987, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2067, 42, false);
#line 54 "C:\Users\Windows 10\OneDrive\Documentos\Cursos e concursos\Cursos profissionalizantes\C#\Cap18\VendasWeb\VendasWeb\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2109, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2189, 42, false);
#line 57 "C:\Users\Windows 10\OneDrive\Documentos\Cursos e concursos\Cursos profissionalizantes\C#\Cap18\VendasWeb\VendasWeb\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2231, 95, true);
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 62 "C:\Users\Windows 10\OneDrive\Documentos\Cursos e concursos\Cursos profissionalizantes\C#\Cap18\VendasWeb\VendasWeb\Views\SalesRecords\SimpleSearch.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(2391, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2476, 37, false);
#line 66 "C:\Users\Windows 10\OneDrive\Documentos\Cursos e concursos\Cursos profissionalizantes\C#\Cap18\VendasWeb\VendasWeb\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2513, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2605, 39, false);
#line 69 "C:\Users\Windows 10\OneDrive\Documentos\Cursos e concursos\Cursos profissionalizantes\C#\Cap18\VendasWeb\VendasWeb\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2644, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2736, 46, false);
#line 72 "C:\Users\Windows 10\OneDrive\Documentos\Cursos e concursos\Cursos profissionalizantes\C#\Cap18\VendasWeb\VendasWeb\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Seller.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2782, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2874, 57, false);
#line 75 "C:\Users\Windows 10\OneDrive\Documentos\Cursos e concursos\Cursos profissionalizantes\C#\Cap18\VendasWeb\VendasWeb\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Seller.Department.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2931, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3023, 41, false);
#line 78 "C:\Users\Windows 10\OneDrive\Documentos\Cursos e concursos\Cursos profissionalizantes\C#\Cap18\VendasWeb\VendasWeb\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(3064, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3156, 41, false);
#line 81 "C:\Users\Windows 10\OneDrive\Documentos\Cursos e concursos\Cursos profissionalizantes\C#\Cap18\VendasWeb\VendasWeb\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3197, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 84 "C:\Users\Windows 10\OneDrive\Documentos\Cursos e concursos\Cursos profissionalizantes\C#\Cap18\VendasWeb\VendasWeb\Views\SalesRecords\SimpleSearch.cshtml"
                }

#line default
#line hidden
            BeginContext(3276, 62, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VendasWeb.Models.SalesRecord>> Html { get; private set; }
    }
}
#pragma warning restore 1591
