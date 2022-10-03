#pragma checksum "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d14d83c53b2696fe6daec48143513373030d006c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Product_Views_ViewProduct_Details), @"mvc.1.0.view", @"/Areas/Product/Views/ViewProduct/Details.cshtml")]
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
#line 1 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\_ViewImports.cshtml"
using AppMVC.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\_ViewImports.cshtml"
using AppMVC.Net.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\_ViewImports.cshtml"
using AppMVC.Net.Models.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
using AppMVC.Net.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d14d83c53b2696fe6daec48143513373030d006c", @"/Areas/Product/Views/ViewProduct/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4bbab2eb5edb191cc87d0d7d770df28580966f4", @"/Areas/Product/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Product_Views_ViewProduct_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ViewProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
  
    List<CategoryProduct> categories = ViewBag.categories as List<CategoryProduct>;
    CategoryProduct category = ViewBag.category as CategoryProduct;

    IQueryable<ProductModel> otherProducts = ViewBag.otherProducts as IQueryable<ProductModel>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<nav aria-label=\"breadcrumb\">\r\n  <ol class=\"breadcrumb\">\r\n    <li class=\"breadcrumb-item\"><a href=\"#\">Home</a></li>\r\n    \r\n");
#nullable restore
#line 15 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
         if(category != null)
        {
            var li = category.ListParents();
            foreach (var l in li)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"breadcrumb-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d14d83c53b2696fe6daec48143513373030d006c6123", async() => {
#nullable restore
#line 21 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
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
#line 21 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
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
#line 23 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"breadcrumb-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d14d83c53b2696fe6daec48143513373030d006c8822", async() => {
#nullable restore
#line 25 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
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
#line 25 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
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
#line 27 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </ol>\r\n</nav>\r\n\r\n\r\n<div class=\"detailpost\">\r\n    <h1>");
#nullable restore
#line 34 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"sapo\">\r\n        ");
#nullable restore
#line 36 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div>\r\n        <p>\r\n            Giá: <strong>");
#nullable restore
#line 41 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
                    Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d14d83c53b2696fe6daec48143513373030d006c12350", async() => {
                WriteLiteral("Đặt hàng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
                                               WriteLiteral(Model.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n\r\n    <div>\r\n        <i>Cập nhật: ");
#nullable restore
#line 47 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
                Write(Model.DateUpdated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i> /\r\n        Tác giả: <strong>");
#nullable restore
#line 48 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
                    Write(Model.Author.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n    </div>\r\n\r\n\r\n");
#nullable restore
#line 52 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
     if (Model.Photos.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"d-flex flex-wrap\">\r\n");
#nullable restore
#line 55 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
             foreach (var photo in Model.Photos)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <img class=\"w-50\"");
            BeginWriteAttribute("src", " src=\"", 1587, "\"", 1627, 2);
            WriteAttributeValue("", 1593, "/contents/Products/", 1593, 19, true);
#nullable restore
#line 57 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
WriteAttributeValue("", 1612, photo.FileName, 1612, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n");
#nullable restore
#line 58 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 60 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <hr />\r\n\r\n    ");
#nullable restore
#line 65 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
Write(Html.Raw(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Sidebar", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 74 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
Write(await Component.InvokeAsync("AppMVC.Net.Components.CategoryProductSidebar", 
        new CategoryProductSidebar.CategorySidebarData(){
            Categories = categories,
            level = 0,
            categoryslug = category.Slug
        }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <ul class=\"list-group\">\r\n");
#nullable restore
#line 82 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
     foreach (var product in otherProducts)
   {

#line default
#line hidden
#nullable disable
                WriteLiteral("       <li class=\"list-group-item\">\r\n           ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d14d83c53b2696fe6daec48143513373030d006c17836", async() => {
                    WriteLiteral("\r\n               ");
#nullable restore
#line 86 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
          Write(product.Title);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n           ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productslug", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
                                                                           WriteLiteral(product.Slug);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productslug"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productslug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productslug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n       </li>\r\n");
#nullable restore
#line 89 "D:\TestCode\AppMVC\AppMVC.Net\Areas\Product\Views\ViewProduct\Details.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591