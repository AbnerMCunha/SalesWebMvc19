#pragma checksum "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\SalesRecords\SimpleSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ff16d8ced26aa5f952f7a2e5e8317ab1bcec5a0"
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
#line 1 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\_ViewImports.cshtml"
using SalesWebMvc19;

#line default
#line hidden
#line 2 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\_ViewImports.cshtml"
using SalesWebMvc19.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ff16d8ced26aa5f952f7a2e5e8317ab1bcec5a0", @"/Views/SalesRecords/SimpleSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24fef127b0253aff74c3ecc41b2ded86e8a142c6", @"/Views/_ViewImports.cshtml")]
    public class Views_SalesRecords_SimpleSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SalesWebMvc19.Models.SalesRecord>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\SalesRecords\SimpleSearch.cshtml"
  
    ViewData["Title"] = "Simple Search";

#line default
#line hidden
            BeginContext(105, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(110, 17, false);
#line 6 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\SalesRecords\SimpleSearch.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(127, 89, true);
            WriteLiteral("</h2>\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(216, 673, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ff16d8ced26aa5f952f7a2e5e8317ab1bcec5a05123", async() => {
                BeginContext(268, 217, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\" />Min Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 485, "\"", 513, 1);
#line 14 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\SalesRecords\SimpleSearch.cshtml"
WriteAttributeValue("", 493, ViewData["minDate"], 493, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(514, 205, true);
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Max Date </label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 719, "", 746, 1);
#line 18 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\SalesRecords\SimpleSearch.cshtml"
WriteAttributeValue("", 726, ViewData["maxDate"], 726, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(746, 136, true);
                WriteLiteral(" />\r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-primary\">Filter</button>\r\n            </div>\r\n        ");
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
            BeginContext(889, 144, true);
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n\r\n<div class=\"panel panel-primary\">\r\n    <div class=\"panel panel-heading\">\r\n        <h3 class=\"panel-title\">Total Sales = ");
            EndContext();
            BeginContext(1034, 43, false);
#line 28 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\SalesRecords\SimpleSearch.cshtml"
                                         Write(Model.Sum(obj => obj.Amount).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1077, 218, true);
            WriteLiteral(" </h3>\r\n    </div>\r\n\r\n    <div class=\"panel-body\">\r\n        <table class=\"table table-striped table-hover\">\r\n            <thead>\r\n                <th class=\"success\">\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1296, 30, false);
#line 36 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(x => x.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1326, 81, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1408, 32, false);
#line 40 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(x => x.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1440, 81, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1522, 39, false);
#line 44 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(x => x.Seller.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1561, 81, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1643, 45, false);
#line 48 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(x => x.Seller.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1688, 81, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1770, 39, false);
#line 52 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(x => x.SalesStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1809, 81, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1891, 34, false);
#line 56 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(x => x.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1925, 97, true);
            WriteLiteral("\r\n                    </td>\r\n                </th>\r\n            </thead>\r\n            <tbody>\r\n\r\n");
            EndContext();
#line 62 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\SalesRecords\SimpleSearch.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(2087, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2172, 29, false);
#line 66 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(x => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2201, 93, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2295, 31, false);
#line 70 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(x => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2326, 93, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2420, 38, false);
#line 74 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(x => item.Seller.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2458, 93, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2552, 49, false);
#line 78 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(x => item.Seller.Department.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2601, 93, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2695, 38, false);
#line 82 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(x => item.SalesStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2733, 93, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2827, 33, false);
#line 86 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(x => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2860, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 89 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\SalesRecords\SimpleSearch.cshtml"
                }

#line default
#line hidden
            BeginContext(2939, 62, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SalesWebMvc19.Models.SalesRecord>> Html { get; private set; }
    }
}
#pragma warning restore 1591
