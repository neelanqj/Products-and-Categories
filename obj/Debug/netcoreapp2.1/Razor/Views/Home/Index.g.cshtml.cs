#pragma checksum "C:\Storage\C\Products-and-Categories\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cb4fff706ce874e2f9681a727e355ea44e4cbfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Storage\C\Products-and-Categories\Views\_ViewImports.cshtml"
using Products_and_Categories;

#line default
#line hidden
#line 2 "C:\Storage\C\Products-and-Categories\Views\_ViewImports.cshtml"
using Products_and_Categories.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cb4fff706ce874e2f9681a727e355ea44e4cbfd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bd6de6e6a9ac2d243eee5113369f84e5ce262d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Storage\C\Products-and-Categories\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 74, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12 text-center\">\r\n        <h1>");
            EndContext();
            BeginContext(120, 19, false);
#line 7 "C:\Storage\C\Products-and-Categories\Views\Home\Index.cshtml"
       Write(Model.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(139, 115, true);
            WriteLiteral("</h1>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <h2>Categories</h2>\r\n        \r\n");
            EndContext();
#line 15 "C:\Storage\C\Products-and-Categories\Views\Home\Index.cshtml"
         foreach(ProductCategory prod in @Model.Category.ProductCategory){
            

#line default
#line hidden
            BeginContext(343, 17, false);
#line 16 "C:\Storage\C\Products-and-Categories\Views\Home\Index.cshtml"
       Write(prod.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(362, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(376, 7, true);
            WriteLiteral("<br/>\r\n");
            EndContext();
#line 18 "C:\Storage\C\Products-and-Categories\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(394, 48, true);
            WriteLiteral("    </div>\r\n    <div class=\"col-md-6\">\r\n        ");
            EndContext();
            BeginContext(442, 505, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c81313beb0484a22909d52c606669717", async() => {
                BeginContext(473, 52, true);
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"CategoryId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 525, "\"", 559, 1);
#line 22 "C:\Storage\C\Products-and-Categories\Views\Home\Index.cshtml"
WriteAttributeValue("", 533, Model.Category.CategoryId, 533, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(560, 76, true);
                WriteLiteral(" />\r\n            Add Product:<br/>\r\n            <select name=\"ProductId\" >\r\n");
                EndContext();
#line 25 "C:\Storage\C\Products-and-Categories\Views\Home\Index.cshtml"
                 foreach(Product prod in @Model.Products){

#line default
#line hidden
                BeginContext(696, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(718, 15, true);
                WriteLiteral("<option value=\"");
                EndContext();
                BeginContext(734, 14, false);
#line 26 "C:\Storage\C\Products-and-Categories\Views\Home\Index.cshtml"
                                Write(prod.ProductId);

#line default
#line hidden
                EndContext();
                BeginContext(748, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(772, 4, true);
                WriteLiteral("\">\r\n");
                EndContext();
                BeginContext(797, 9, false);
#line 28 "C:\Storage\C\Products-and-Categories\Views\Home\Index.cshtml"
               Write(prod.Name);

#line default
#line hidden
                EndContext();
                BeginContext(808, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(830, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 30 "C:\Storage\C\Products-and-Categories\Views\Home\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(860, 80, true);
                WriteLiteral("            </select>\r\n            <input type=\"submit\" value=\"Add\" />\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(947, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
