#pragma checksum "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e57c79a15aea32d694412d5caf3a95174972aea"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e57c79a15aea32d694412d5caf3a95174972aea", @"/Views/Quiz/Results.cshtml")]
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
            BeginContext(74, 203, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-6 col-sm-4\"><h4>Here are the results of your quiz!</h4></div>\r\n    \r\n    <div class=\"row\">\r\n        <div class=\"col-6 col-sm-4\">\r\n            <img class=\"img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 277, "\"", 369, 1);
#line 10 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml"
WriteAttributeValue("", 283, Model.ProductImages.Any() ? Model.ProductImages.First().Url : "/images/noImage.png", 283, 86, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 370, "\"", 517, 1);
#line 10 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml"
WriteAttributeValue("", 376, Model.ProductImages.Any() && !string.IsNullOrEmpty(Model.ProductImages.First().AltText) ? Model.ProductImages.First().AltText : Model.Name, 376, 141, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(518, 189, true);
            WriteLiteral(" />\r\n        </div>\r\n        <div class=\"col-6 col-sm-8 p-2 border rounded bg-dark text-light\">\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    <h2>");
            EndContext();
            BeginContext(708, 10, false);
#line 16 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml"
                   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(718, 109, true);
            WriteLiteral("</h2>\r\n                </div>\r\n                <div class=\"col\">\r\n                    <h3 class=\"text-right\">");
            EndContext();
            BeginContext(828, 25, false);
#line 19 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml"
                                      Write(Model.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(853, 66, true);
            WriteLiteral("</h3>\r\n                </div>\r\n            </div>\r\n            <p>");
            EndContext();
            BeginContext(920, 17, false);
#line 22 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml"
          Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(937, 18, true);
            WriteLiteral("</p>\r\n            ");
            EndContext();
            BeginContext(955, 655, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71543eb34a1a4031b1e783f00dc095bd", async() => {
                BeginContext(975, 207, true);
                WriteLiteral("\r\n                <div class=\"form-row\">\r\n                    <div class=\"col\">\r\n                        <label for=\"color\">Color</label>\r\n                        <select name=\"color\" class=\"form-control\">\r\n");
                EndContext();
#line 28 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml"
                             foreach (var c in Model.ProductColors)
                            {

#line default
#line hidden
                BeginContext(1282, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(1314, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c32e58d0d0f4bf9a14e214ebf5901a0", async() => {
                    BeginContext(1337, 7, false);
#line 30 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml"
                                                 Write(c.Color);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 30 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml"
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
                BeginContext(1353, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 31 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Results.cshtml"
                            }

#line default
#line hidden
                BeginContext(1386, 217, true);
                WriteLiteral("                        </select>\r\n                    </div>\r\n                  \r\n                </div>\r\n                <input class=\"btn btn-light btn-block my-2\" type=\"submit\" value=\"Add To Cart\" />\r\n            ");
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
            BeginContext(1610, 40, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>");
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
