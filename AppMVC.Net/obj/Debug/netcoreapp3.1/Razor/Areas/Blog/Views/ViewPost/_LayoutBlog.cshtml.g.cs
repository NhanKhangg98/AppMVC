#pragma checksum "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\ViewPost\_LayoutBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "590011930e365d7e93f72152441862e5f28f265b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Blog_Views_ViewPost__LayoutBlog), @"mvc.1.0.view", @"/Areas/Blog/Views/ViewPost/_LayoutBlog.cshtml")]
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
#line 1 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\_ViewImports.cshtml"
using AppMVC.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\_ViewImports.cshtml"
using AppMVC.Net.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\_ViewImports.cshtml"
using AppMVC.Net.Models.Blog;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"590011930e365d7e93f72152441862e5f28f265b", @"/Areas/Blog/Views/ViewPost/_LayoutBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932b394b28e096cdacdc534a930bd10118231bc8", @"/Areas/Blog/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Blog_Views_ViewPost__LayoutBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\ViewPost\_LayoutBlog.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 \">\r\n        ");
#nullable restore
#line 7 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\ViewPost\_LayoutBlog.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        ");
#nullable restore
#line 10 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\ViewPost\_LayoutBlog.cshtml"
   Write(RenderSection("Sidebar", false));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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