#pragma checksum "D:\TestCode\AppMVC\AppMVC.Net\Views\Shared\_AlertMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4726cb1a3bfd150cc0efed834a29ca3326eafea7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AlertMessage), @"mvc.1.0.view", @"/Views/Shared/_AlertMessage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4726cb1a3bfd150cc0efed834a29ca3326eafea7", @"/Views/Shared/_AlertMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b83f9ea051eab0be684412b936d0a2dce6b8b1e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__AlertMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\TestCode\AppMVC\AppMVC.Net\Views\Shared\_AlertMessage.cshtml"
  
    var notify = TempData["Notify"] as string;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\TestCode\AppMVC\AppMVC.Net\Views\Shared\_AlertMessage.cshtml"
 if(!string.IsNullOrEmpty(notify)){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">\r\n        ");
#nullable restore
#line 8 "D:\TestCode\AppMVC\AppMVC.Net\Views\Shared\_AlertMessage.cshtml"
   Write(notify);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n    </div>\r\n");
#nullable restore
#line 13 "D:\TestCode\AppMVC\AppMVC.Net\Views\Shared\_AlertMessage.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
