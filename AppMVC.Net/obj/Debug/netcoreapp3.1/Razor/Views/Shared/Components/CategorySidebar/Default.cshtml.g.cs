#pragma checksum "D:\TestCode\AppMVC\AppMVC.Net\Views\Shared\Components\CategorySidebar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29a77586b5ea5df876e4ae5726a852aa96e13b10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategorySidebar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategorySidebar/Default.cshtml")]
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
#nullable restore
#line 1 "D:\TestCode\AppMVC\AppMVC.Net\Views\Shared\Components\CategorySidebar\Default.cshtml"
using AppMVC.Net.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29a77586b5ea5df876e4ae5726a852aa96e13b10", @"/Views/Shared/Components/CategorySidebar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b83f9ea051eab0be684412b936d0a2dce6b8b1e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CategorySidebar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppMVC.Net.Components.CategorySidebar.CategorySidebarData>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ViewPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-categoryslug", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "D:\TestCode\AppMVC\AppMVC.Net\Views\Shared\Components\CategorySidebar\Default.cshtml"
  
    int level = Model.level;

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n\r\n</style>\r\n");
#nullable restore
#line 9 "D:\TestCode\AppMVC\AppMVC.Net\Views\Shared\Components\CategorySidebar\Default.cshtml"
 if(Model.Categories.Count >0){
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\TestCode\AppMVC\AppMVC.Net\Views\Shared\Components\CategorySidebar\Default.cshtml"
     if(level == 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\TestCode\AppMVC\AppMVC.Net\Views\Shared\Components\CategorySidebar\Default.cshtml"
   Write(Html.Raw("<div class=\"categorysidebar\">"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\TestCode\AppMVC\AppMVC.Net\Views\Shared\Components\CategorySidebar\Default.cshtml"
                                                    ;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29a77586b5ea5df876e4ae5726a852aa96e13b105481", async() => {
                WriteLiteral("\r\n                Tất cả chuyên mục\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoryslug", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryslug"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </h3>\r\n");
#nullable restore
#line 18 "D:\TestCode\AppMVC\AppMVC.Net\Views\Shared\Components\CategorySidebar\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n");
#nullable restore
#line 20 "D:\TestCode\AppMVC\AppMVC.Net\Views\Shared\Components\CategorySidebar\Default.cshtml"
         foreach (var category in Model.Categories)
        {
            var cssActive = (category.Slug == Model.categoryslug) ? "active" : null;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\n               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29a77586b5ea5df876e4ae5726a852aa96e13b108030", async() => {
                WriteLiteral("\r\n                   ");
#nullable restore
#line 25 "D:\TestCode\AppMVC\AppMVC.Net\Views\Shared\Components\CategorySidebar\Default.cshtml"
              Write(category.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n               ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 24 "D:\TestCode\AppMVC\AppMVC.Net\Views\Shared\Components\CategorySidebar\Default.cshtml"
AddHtmlAttributeValue("", 647, cssActive, 647, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoryslug", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "D:\TestCode\AppMVC\AppMVC.Net\Views\Shared\Components\CategorySidebar\Default.cshtml"
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
            WriteLiteral("\r\n");
#nullable restore
#line 27 "D:\TestCode\AppMVC\AppMVC.Net\Views\Shared\Components\CategorySidebar\Default.cshtml"
                 if(category.CategoryChildren?.Count > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\TestCode\AppMVC\AppMVC.Net\Views\Shared\Components\CategorySidebar\Default.cshtml"
               Write(await Component.InvokeAsync("AppMVC.Net.Components.CategorySidebar", 
                    new CategorySidebar.CategorySidebarData(){
                        Categories = category.CategoryChildren.ToList(),
                        level = level + 1,
                        categoryslug = ViewBag.categoryslug
                    }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\TestCode\AppMVC\AppMVC.Net\Views\Shared\Components\CategorySidebar\Default.cshtml"
                      
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </li>\n");
#nullable restore
#line 37 "D:\TestCode\AppMVC\AppMVC.Net\Views\Shared\Components\CategorySidebar\Default.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 39 "D:\TestCode\AppMVC\AppMVC.Net\Views\Shared\Components\CategorySidebar\Default.cshtml"
     if(level == 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\TestCode\AppMVC\AppMVC.Net\Views\Shared\Components\CategorySidebar\Default.cshtml"
   Write(Html.Raw("<div/>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\TestCode\AppMVC\AppMVC.Net\Views\Shared\Components\CategorySidebar\Default.cshtml"
                           ;
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\TestCode\AppMVC\AppMVC.Net\Views\Shared\Components\CategorySidebar\Default.cshtml"
     
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppMVC.Net.Components.CategorySidebar.CategorySidebarData> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
