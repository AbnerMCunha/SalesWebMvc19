#pragma checksum "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f94d16d95a13df973ca881ee7889d330b2d84d66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f94d16d95a13df973ca881ee7889d330b2d84d66", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24fef127b0253aff74c3ecc41b2ded86e8a142c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
            BeginContext(64, 70, true);
            WriteLiteral("\r\n<h1 class=\"text text-bg-light\">Error.</h1>\r\n<h2 class=\"text-danger\">");
            EndContext();
            BeginContext(135, 8, false);
#line 7 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\Shared\Error.cshtml"
                   Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(143, 3, true);
            WriteLiteral(",  ");
            EndContext();
            BeginContext(147, 13, false);
#line 7 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\Shared\Error.cshtml"
                               Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(160, 5, true);
            WriteLiteral("</h2>");
            EndContext();
            BeginContext(191, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 9 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\Shared\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
            BeginContext(225, 52, true);
            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong> <code>");
            EndContext();
            BeginContext(278, 15, false);
#line 12 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\Shared\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
            EndContext();
            BeginContext(293, 19, true);
            WriteLiteral("</code>\r\n    </p>\r\n");
            EndContext();
#line 14 "C:\Abner\UDEMY\Secao18-SalesWebMvc-EntityFramework\SWM19\SalesWebMvc19\SalesWebMvc19\Views\Shared\Error.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
