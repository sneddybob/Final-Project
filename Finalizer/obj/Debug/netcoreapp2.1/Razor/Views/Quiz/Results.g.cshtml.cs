#pragma checksum "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e343d52a341815f7b75847ff8f88cc8e57eaeed4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quiz_Results), @"mvc.1.0.view", @"/Views/Quiz/Results.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Quiz/Results.cshtml", typeof(AspNetCore.Views_Quiz_Results))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e343d52a341815f7b75847ff8f88cc8e57eaeed4", @"/Views/Quiz/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"114feecbc7bb502572199314ad0d2e632a5e45ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Quiz_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Finalizer.Data.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml"
  
    ViewData["Title"] = "Results";

#line default
#line hidden
            BeginContext(74, 121, true);
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-12 col-sm-4\">\r\n            <img class=\"img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 195, "\"", 287, 1);
#line 8 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml"
WriteAttributeValue("", 201, Model.ProductImages.Any() ? Model.ProductImages.First().Url : "/images/noImage.png", 201, 86, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 288, "\"", 435, 1);
#line 8 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml"
WriteAttributeValue("", 294, Model.ProductImages.Any() && !string.IsNullOrEmpty(Model.ProductImages.First().AltText) ? Model.ProductImages.First().AltText : Model.Name, 294, 141, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(436, 190, true);
            WriteLiteral(" />\r\n        </div>\r\n        <div class=\"col-12 col-sm-8 p-2 border rounded bg-dark text-light\">\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    <h3>");
            EndContext();
            BeginContext(627, 10, false);
#line 14 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml"
                   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(637, 31, true);
            WriteLiteral("</h3>\r\n                    <h3>");
            EndContext();
            BeginContext(669, 8, false);
#line 15 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml"
                   Write(Model.ID);

#line default
#line hidden
            EndContext();
            BeginContext(677, 109, true);
            WriteLiteral("</h3>\r\n                </div>\r\n                <div class=\"col\">\r\n                    <h3 class=\"text-right\">");
            EndContext();
            BeginContext(787, 25, false);
#line 18 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml"
                                      Write(Model.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(812, 66, true);
            WriteLiteral("</h3>\r\n                </div>\r\n            </div>\r\n            <p>");
            EndContext();
            BeginContext(879, 17, false);
#line 21 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml"
          Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(896, 18, true);
            WriteLiteral("</p>\r\n            ");
            EndContext();
            BeginContext(914, 640, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5633a2bd59a4fa386158e115e4bfd43", async() => {
                BeginContext(934, 207, true);
                WriteLiteral("\r\n                <div class=\"form-row\">\r\n                    <div class=\"col\">\r\n                        <label for=\"color\">Color</label>\r\n                        <select name=\"color\" class=\"form-control\">\r\n");
                EndContext();
#line 27 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml"
                             foreach (var c in Model.ProductColors)
                            {

#line default
#line hidden
                BeginContext(1241, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(1273, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f41caf13d65435781b1a022340261c6", async() => {
                    BeginContext(1296, 7, false);
#line 29 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml"
                                                 Write(c.Color);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 29 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml"
                                   WriteLiteral(c.ID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1312, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 30 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml"
                            }

#line default
#line hidden
                BeginContext(1345, 202, true);
                WriteLiteral("                        </select>\r\n                    </div>\r\n\r\n                </div>\r\n                <input class=\"btn btn-light btn-lg active m-4\" type=\"submit\" value=\"Add To Cart\" />\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1554, 67, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div>\r\n        <h3>Reviews</h3>\r\n");
            EndContext();
#line 41 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml"
         foreach (var review in Model.Reviews)
        {

#line default
#line hidden
            BeginContext(1680, 70, true);
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-4\"><h1>");
            EndContext();
            BeginContext(1751, 13, false);
#line 44 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml"
                                  Write(review.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(1764, 60, true);
            WriteLiteral("</h1></div>\r\n                <div class=\"col-8\"><blockquote>");
            EndContext();
            BeginContext(1825, 11, false);
#line 45 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml"
                                          Write(review.Text);

#line default
#line hidden
            EndContext();
            BeginContext(1836, 6, true);
            WriteLiteral("<cite>");
            EndContext();
            BeginContext(1843, 13, false);
#line 45 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml"
                                                            Write(review.UserID);

#line default
#line hidden
            EndContext();
            BeginContext(1856, 48, true);
            WriteLiteral("</cite></blockquote></div>\r\n            </div>\r\n");
            EndContext();
#line 47 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml"
        }

#line default
#line hidden
            BeginContext(1915, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Finalizer.Data.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
