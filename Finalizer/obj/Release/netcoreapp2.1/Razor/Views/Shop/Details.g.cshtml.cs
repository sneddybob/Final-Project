#pragma checksum "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb4767cba90ff15d4613a72c8939e8e68ab61bf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Details), @"mvc.1.0.view", @"/Views/Shop/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/Details.cshtml", typeof(AspNetCore.Views_Shop_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb4767cba90ff15d4613a72c8939e8e68ab61bf9", @"/Views/Shop/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"114feecbc7bb502572199314ad0d2e632a5e45ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Finalizer.Data.Product>
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
#line 2 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(74, 98, true);
            WriteLiteral("<div class=\"row m-0 p-0\">\r\n    <div class=\"col-lg-4 col-sm-4 p-0\">\r\n        <img class=\"img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 172, "\"", 264, 1);
#line 7 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Details.cshtml"
WriteAttributeValue("", 178, Model.ProductImages.Any() ? Model.ProductImages.First().Url : "/images/noImage.png", 178, 86, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 265, "\"", 412, 1);
#line 7 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Details.cshtml"
WriteAttributeValue("", 271, Model.ProductImages.Any() && !string.IsNullOrEmpty(Model.ProductImages.First().AltText) ? Model.ProductImages.First().AltText : Model.Name, 271, 141, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(413, 165, true);
            WriteLiteral(" />\r\n    </div>\r\n    <div class=\"col-lg-8 col-sm-8 p-0 bg-dark text-light\">\r\n\r\n        <div class=\"row m-2\">\r\n            <div class=\"col m-2\">\r\n                <h2>");
            EndContext();
            BeginContext(579, 10, false);
#line 13 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Details.cshtml"
               Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(589, 102, true);
            WriteLiteral("</h2>\r\n             </div>\r\n            <div class=\"col m-2\">\r\n                <h3 class=\"text-right\">");
            EndContext();
            BeginContext(692, 25, false);
#line 16 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Details.cshtml"
                                  Write(Model.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(717, 66, true);
            WriteLiteral("</h3>\r\n            </div>\r\n        </div>\r\n        <p class=\"m-4\">");
            EndContext();
            BeginContext(784, 17, false);
#line 19 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Details.cshtml"
                  Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(801, 14, true);
            WriteLiteral("</p>\r\n        ");
            EndContext();
            BeginContext(815, 604, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79968f58afd54eb1859385c8e9f567fe", async() => {
                BeginContext(835, 195, true);
                WriteLiteral("\r\n            <div class=\"form-row m-4\">\r\n                <div class=\"col\">\r\n                    <label for=\"color\">Color</label>\r\n                    <select name=\"color\" class=\"form-control\">\r\n");
                EndContext();
#line 25 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Details.cshtml"
                         foreach (var c in Model.ProductColors)
                        {

#line default
#line hidden
                BeginContext(1122, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1150, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7272bb4997545cf94e283a8a1e0fe16", async() => {
                    BeginContext(1173, 7, false);
#line 27 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Details.cshtml"
                                             Write(c.Color);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 27 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Details.cshtml"
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
                BeginContext(1189, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 28 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Details.cshtml"
                        }

#line default
#line hidden
                BeginContext(1218, 194, true);
                WriteLiteral("                    </select>\r\n                </div>\r\n            \r\n            </div>\r\n            <input class=\"btn btn-light btn-lg active m-4\" type=\"submit\" value=\"Add To Cart\" />\r\n        ");
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
            BeginContext(1419, 63, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"m-4\">\r\n    <h3>Reviews</h3>\r\n");
            EndContext();
#line 39 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Details.cshtml"
     foreach (var review in Model.Reviews)
    {

#line default
#line hidden
            BeginContext(1533, 66, true);
            WriteLiteral("        <div class=\"row m-2\">\r\n            <div class=\"col-4\"><h1>");
            EndContext();
            BeginContext(1600, 13, false);
#line 42 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Details.cshtml"
                              Write(review.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(1613, 56, true);
            WriteLiteral("</h1></div>\r\n            <div class=\"col-8\"><blockquote>");
            EndContext();
            BeginContext(1670, 11, false);
#line 43 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Details.cshtml"
                                      Write(review.Text);

#line default
#line hidden
            EndContext();
            BeginContext(1681, 6, true);
            WriteLiteral("<cite>");
            EndContext();
            BeginContext(1688, 13, false);
#line 43 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Details.cshtml"
                                                        Write(review.UserID);

#line default
#line hidden
            EndContext();
            BeginContext(1701, 44, true);
            WriteLiteral("</cite></blockquote></div>\r\n        </div>\r\n");
            EndContext();
#line 45 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Shop\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(1752, 6, true);
            WriteLiteral("</div>");
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
