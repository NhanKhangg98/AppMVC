#pragma checksum "D:\TestCode\AppMVC\AppMVC.Net\Views\First\ViewProduct3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed5634576fe75b0fe051ed9764eece3509dfff8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_First_ViewProduct3), @"mvc.1.0.view", @"/Views/First/ViewProduct3.cshtml")]
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
#line 1 "D:\TestCode\AppMVC\AppMVC.Net\Views\_ViewImports.cshtml"
using AppMVC.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TestCode\AppMVC\AppMVC.Net\Views\_ViewImports.cshtml"
using AppMVC.Net.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed5634576fe75b0fe051ed9764eece3509dfff8e", @"/Views/First/ViewProduct3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b83f9ea051eab0be684412b936d0a2dce6b8b1e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_First_ViewProduct3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\TestCode\AppMVC\AppMVC.Net\Views\First\ViewProduct3.cshtml"
  
    var productt = ViewBag.product as ProductModel;

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 5 "D:\TestCode\AppMVC\AppMVC.Net\Views\First\ViewProduct3.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<div class=\"card bg-warning text-white\">\r\n    <h1 class=\"card-header\">Hello Mother Fucker!!! ");
#nullable restore
#line 8 "D:\TestCode\AppMVC\AppMVC.Net\Views\First\ViewProduct3.cshtml"
                                              Write(productt.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"card-body\">\r\n        <p class=\"card-text\">\r\n        Giá: ");
#nullable restore
#line 11 "D:\TestCode\AppMVC\AppMVC.Net\Views\First\ViewProduct3.cshtml"
        Write(productt.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    </div>\r\n</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591