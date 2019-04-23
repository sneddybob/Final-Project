#pragma checksum "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Search\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61d2e03c133f15e07cb38e7ab9b83619fc9067b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Index), @"mvc.1.0.view", @"/Views/Search/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Search/Index.cshtml", typeof(AspNetCore.Views_Search_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61d2e03c133f15e07cb38e7ab9b83619fc9067b0", @"/Views/Search/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"114feecbc7bb502572199314ad0d2e632a5e45ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Finalizer.Data.Product>>
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
#line 2 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Search\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#line 5 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Search\Index.cshtml"
  
    if (Model != null)
    {

#line default
#line hidden
            BeginContext(120, 68, true);
            WriteLiteral("        <div>\r\n            <h3>Here are your results for searching \"");
            EndContext();
            BeginContext(189, 33, false);
#line 9 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Search\Index.cshtml"
                                                Write(ViewData["searchTerm"].ToString());

#line default
#line hidden
            EndContext();
            BeginContext(222, 197, true);
            WriteLiteral("\"</h3>\r\n        </div>\r\n        <div>\r\n            <h2 class=\"p-2  bg-dark text-light index-layout-style\"></h2>\r\n            <div class=\"row m-0\">\r\n                <div class=\"card-deck m-5 p-2\">\r\n");
            EndContext();
#line 15 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Search\Index.cshtml"
                     foreach (var product in this.Model)
                    {

#line default
#line hidden
            BeginContext(500, 116, true);
            WriteLiteral("                        <div class=\"card cardG mb-5\">\r\n                            <img class=\"card-img-top p-0 m-0\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 616, "\"", 712, 1);
#line 18 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Search\Index.cshtml"
WriteAttributeValue("", 622, product.ProductImages.Any() ? product.ProductImages.First().Url : "/images/noImage.png", 622, 90, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 713, "\"", 868, 1);
#line 18 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Search\Index.cshtml"
WriteAttributeValue("", 719, product.ProductImages.Any() && !string.IsNullOrEmpty(product.ProductImages.First().AltText) ? product.ProductImages.First().AltText : product.Name, 719, 149, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(869, 126, true);
            WriteLiteral(" />\r\n                            <div class=\"card-body p-0 m-0\">\r\n                                <h5 class=\"card-title ml-2\">");
            EndContext();
            BeginContext(996, 12, false);
#line 20 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Search\Index.cshtml"
                                                       Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1008, 70, true);
            WriteLiteral("</h5>\r\n                                <p class=\"card-text ml-2 mb-4\">");
            EndContext();
            BeginContext(1079, 19, false);
#line 21 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Search\Index.cshtml"
                                                          Write(product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1098, 38, true);
            WriteLiteral("</p>\r\n                                ");
            EndContext();
            BeginContext(1136, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b52da0c8549443faa5838342217f1c2b", async() => {
                BeginContext(1240, 5, true);
                WriteLiteral("View ");
                EndContext();
                BeginContext(1246, 12, false);
#line 22 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Search\Index.cshtml"
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
#line 22 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Search\Index.cshtml"
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
            BeginContext(1262, 136, true);
            WriteLiteral("\r\n                                <div class=\"card-footer mb-5\">\r\n                                    <small class=\"text-secondary m-0\">");
            EndContext();
            BeginContext(1399, 27, false);
#line 24 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Search\Index.cshtml"
                                                                 Write(product.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1426, 118, true);
            WriteLiteral("</small>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 28 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Search\Index.cshtml"

                    }

#line default
#line hidden
            BeginContext(1569, 60, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 33 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Search\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1653, 61, true);
            WriteLiteral("        <div> We Couldn\'t find any matching products.</div>\r\n");
            EndContext();
#line 37 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Search\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1724, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Finalizer.Data.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
