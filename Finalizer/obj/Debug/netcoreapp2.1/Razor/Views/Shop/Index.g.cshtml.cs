#pragma checksum "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "121c0a69f3b606968f7773841b0ddef05f6c3d2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/Index.cshtml", typeof(AspNetCore.Views_Shop_Index))]
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
#line 1 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\_ViewImports.cshtml"
using Finalizer;

#line default
#line hidden
#line 2 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\_ViewImports.cshtml"
using Finalizer.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"121c0a69f3b606968f7773841b0ddef05f6c3d2d", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"114feecbc7bb502572199314ad0d2e632a5e45ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Finalizer.Data.Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Index.cshtml"
  
    ViewData["Title"] = "Shop";

#line default
#line hidden
            BeginContext(85, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Index.cshtml"
 foreach (var category in this.Model)
{

#line default
#line hidden
            BeginContext(129, 58, true);
            WriteLiteral("    <h2 class=\"p-2 m-2 border rounded bg-dark text-light\">");
            EndContext();
            BeginContext(188, 13, false);
#line 8 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Index.cshtml"
                                                     Write(category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(201, 30, true);
            WriteLiteral("</h2>\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 10 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Index.cshtml"
         foreach (var product in category.Products.Take(3))
        {

#line default
#line hidden
            BeginContext(303, 86, true);
            WriteLiteral("            <div class=\"col-12 col-sm-4 mx-2\">\r\n                <img class=\"img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 389, "\"", 485, 1);
#line 13 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Index.cshtml"
WriteAttributeValue("", 395, product.ProductImages.Any() ? product.ProductImages.First().Url : "/images/noImage.png", 395, 90, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 486, "\"", 641, 1);
#line 13 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Index.cshtml"
WriteAttributeValue("", 492, product.ProductImages.Any() && !string.IsNullOrEmpty(product.ProductImages.First().AltText) ? product.ProductImages.First().AltText : product.Name, 492, 149, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(642, 21, true);
            WriteLiteral(" />\r\n                ");
            EndContext();
            BeginContext(663, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03b080e17c544aa1acdd2c370a9c4094", async() => {
                BeginContext(770, 5, true);
                WriteLiteral("View ");
                EndContext();
                BeginContext(776, 12, false);
#line 14 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Index.cshtml"
                                                                                                                           Write(product.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 14 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Index.cshtml"
                                                                                                  WriteLiteral(product.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(792, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 16 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(825, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 18 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Finalizer.Data.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
