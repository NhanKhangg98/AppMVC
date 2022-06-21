#pragma checksum "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\ViewPost\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1935d0cfa8369ff7a7ffaae85114996ea61961a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Blog_Views_ViewPost_Details), @"mvc.1.0.view", @"/Areas/Blog/Views/ViewPost/Details.cshtml")]
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
#nullable restore
#line 2 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\ViewPost\Details.cshtml"
using AppMVC.Net.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1935d0cfa8369ff7a7ffaae85114996ea61961a7", @"/Areas/Blog/Views/ViewPost/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932b394b28e096cdacdc534a930bd10118231bc8", @"/Areas/Blog/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Blog_Views_ViewPost_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ViewPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\ViewPost\Details.cshtml"
  
    List<Category> categories = ViewBag.categories as List<Category>;
    Category category = ViewBag.category as Category;

    IQueryable<Post> otherPosts = ViewBag.otherPosts as IQueryable<Post>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<nav aria-label=\"breadcrumb\">\r\n  <ol class=\"breadcrumb\">\r\n    <li class=\"breadcrumb-item\"><a href=\"#\">Home</a></li>\r\n    \r\n");
#nullable restore
#line 15 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\ViewPost\Details.cshtml"
         if(category != null)
        {
            var li = category.ListParents();
            foreach (var l in li)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"breadcrumb-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1935d0cfa8369ff7a7ffaae85114996ea61961a75341", async() => {
#nullable restore
#line 21 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\ViewPost\Details.cshtml"
                                                                      Write(l.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoryslug", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\ViewPost\Details.cshtml"
                                                      WriteLiteral(l.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryslug"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryslug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryslug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 23 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\ViewPost\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"breadcrumb-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1935d0cfa8369ff7a7ffaae85114996ea61961a78022", async() => {
#nullable restore
#line 25 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\ViewPost\Details.cshtml"
                                                                             Write(category.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoryslug", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\ViewPost\Details.cshtml"
                                                      WriteLiteral(category.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryslug"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryslug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryslug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 27 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\ViewPost\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </ol>\r\n</nav>\r\n\r\n\r\n<div class=\"detailpost\">\r\n    <h1>");
#nullable restore
#line 34 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\ViewPost\Details.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"sapo\">\r\n        ");
#nullable restore
#line 36 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\ViewPost\Details.cshtml"
   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <i>Cập nhật: ");
#nullable restore
#line 39 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\ViewPost\Details.cshtml"
                Write(Model.DateUpdated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i> /\r\n        Tác giả: <strong>");
#nullable restore
#line 40 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\ViewPost\Details.cshtml"
                    Write(Model.Author.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n    </div>\r\n    <hr />\r\n\r\n    ");
#nullable restore
#line 44 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\ViewPost\Details.cshtml"
Write(Html.Raw(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Sidebar", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 53 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\ViewPost\Details.cshtml"
Write(await Component.InvokeAsync("AppMVC.Net.Components.CategorySidebar", 
        new CategorySidebar.CategorySidebarData(){
            Categories = categories,
            level = 0,
            categoryslug = category.Slug
        }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <ul class=\"list-group\">\r\n");
#nullable restore
#line 61 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\ViewPost\Details.cshtml"
     foreach (var post in otherPosts)
   {

#line default
#line hidden
#nullable disable
                WriteLiteral("       <li class=\"list-group-item\">\r\n           ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1935d0cfa8369ff7a7ffaae85114996ea61961a712897", async() => {
                    WriteLiteral("\r\n               ");
#nullable restore
#line 65 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\ViewPost\Details.cshtml"
          Write(post.Title);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n           ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postslug", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\ViewPost\Details.cshtml"
                                                                     WriteLiteral(post.Slug);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postslug"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postslug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postslug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n       </li>\r\n");
#nullable restore
#line 68 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Blog\Views\ViewPost\Details.cshtml"
   }

#line default
#line hidden
#nullable disable
                WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
