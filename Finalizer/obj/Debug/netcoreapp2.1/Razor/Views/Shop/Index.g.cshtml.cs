#pragma checksum "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8645f459cd09278973091b2668282096ac2ce62a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8645f459cd09278973091b2668282096ac2ce62a", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"114feecbc7bb502572199314ad0d2e632a5e45ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Finalizer.Data.Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(127, 70, true);
            WriteLiteral("<div>\r\n        <h2 class=\"p-3  bg-dark text-light index-layout-style\">");
            EndContext();
            BeginContext(198, 13, false);
#line 8 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Index.cshtml"
                                                          Write(category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(211, 124, true);
            WriteLiteral("</h2>\r\n        <div class=\"container\">\r\n            <div class=\"row m-0\">\r\n                <div class=\"card-deck m-0 p-0\">\r\n");
            EndContext();
#line 12 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Index.cshtml"
                     foreach (var product in category.Products.Take(3))
                    {


#line default
#line hidden
            BeginContext(433, 116, true);
            WriteLiteral("                        <div class=\"card cardG mb-5\">\r\n                            <img class=\"card-img-top p-0 m-0\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 549, "\"", 645, 1);
#line 16 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Index.cshtml"
WriteAttributeValue("", 555, product.ProductImages.Any() ? product.ProductImages.First().Url : "/images/noImage.png", 555, 90, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 646, "\"", 801, 1);
#line 16 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Index.cshtml"
WriteAttributeValue("", 652, product.ProductImages.Any() && !string.IsNullOrEmpty(product.ProductImages.First().AltText) ? product.ProductImages.First().AltText : product.Name, 652, 149, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(802, 125, true);
            WriteLiteral(" />\r\n                            <div class=\"card-body p-0 m-0\">\r\n                                <h5 class=\"card-title m-0\">");
            EndContext();
            BeginContext(928, 12, false);
#line 18 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Index.cshtml"
                                                      Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(940, 64, true);
            WriteLiteral("</h5>\r\n                                <p class=\"card-text m-0\">");
            EndContext();
            BeginContext(1005, 19, false);
#line 19 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Index.cshtml"
                                                    Write(product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1024, 38, true);
            WriteLiteral("</p>\r\n                                ");
            EndContext();
            BeginContext(1062, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1517153b64bd44d0bd120137dfa0818e", async() => {
                BeginContext(1166, 5, true);
                WriteLiteral("View ");
                EndContext();
                BeginContext(1172, 12, false);
#line 20 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Index.cshtml"
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
#line 20 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Index.cshtml"
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
            BeginContext(1188, 140, true);
            WriteLiteral("\r\n                                <div class=\"card-footer m-0 mb-5\">\r\n                                    <small class=\"text-secondary m-1\">");
            EndContext();
            BeginContext(1329, 27, false);
#line 22 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Index.cshtml"
                                                                 Write(product.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1356, 118, true);
            WriteLiteral("</small>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 26 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Index.cshtml"

                    }

#line default
#line hidden
            BeginContext(1499, 80, true);
            WriteLiteral("                </div>\r\n            </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 32 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1582, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Finalizer.Data.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
