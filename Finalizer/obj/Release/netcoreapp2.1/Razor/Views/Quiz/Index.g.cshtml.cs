#pragma checksum "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55b341522e9fe5475e9a85ac054c7d098c350f75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quiz_Index), @"mvc.1.0.view", @"/Views/Quiz/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Quiz/Index.cshtml", typeof(AspNetCore.Views_Quiz_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55b341522e9fe5475e9a85ac054c7d098c350f75", @"/Views/Quiz/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"114feecbc7bb502572199314ad0d2e632a5e45ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Quiz_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Quiz\Index.cshtml"
  
    ViewData["Title"] = "Quiz";

#line default
#line hidden
            BeginContext(42, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(46, 7199, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f26c1562de5c4ca7bcc53d0c07a4c47f", async() => {
                BeginContext(66, 7172, true);
                WriteLiteral(@"
    <div class=""container"">
        <h2>Answer the questions below and we will help choose a guitar for you!</h2>

        <div id=""accordion"">
            <div class=""card"">
                <div class=""card-header"" id=""headingOne"">
                    <h5 class=""mb-0"">
                        <button class=""btn btn-link"" onclick=""return false;"" data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">
                            Question #1
                        </button>
                    </h5>
                </div>

                <div id=""collapseOne"" class=""collapse show"" aria-labelledby=""headingOne"" data-parent=""#accordion"">
                    <div class=""card-body"">
                        How do you like to feel?
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""radio"" name=""Radios1"" id=""q11"" value=""1"">
                        <label class=""form-chec");
                WriteLiteral(@"k-label"" for=""answer1"">
                            Like I'm invincible!
                        </label>
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""radio"" name=""Radios1"" id=""q12"" value=""2"">
                        <label class=""form-check-label"" for=""answer2"">
                            Just, you know, mellow man.
                        </label>
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""radio"" name=""Radios1"" id=""q13"" value=""3"">
                        <label class=""form-check-label"" for=""answer3"">
                            Like I'm on cosmic voyage through space and time!
                        </label>
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""radio"" name=""Radios1"" id=""q14"" value=""4"">
                        <label");
                WriteLiteral(@" class=""form-check-label"" for=""answer4"">
                            Ready to dance!
                        </label>
                    </div>
                </div>
            </div>
            <div class=""card"">
                <div class=""card-header"" id=""headingTwo"">
                    <h5 class=""mb-0"">
                        <button class=""btn btn-link"" onclick=""return false;"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""true"" aria-controls=""collapseTwo"">
                            Question #2
                        </button>
                    </h5>
                </div>

                <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordion"">
                    <div class=""card-body"">
                        Do you own any leather?
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""radio"" name=""Radios2"" id=""q21"" value=""5"" >
         ");
                WriteLiteral(@"               <label class=""form-check-label"" for=""answer5"">
                            Yes
                        </label>
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""radio"" name=""Radios2"" id=""q22"" value=""6"">
                        <label class=""form-check-label"" for=""answer6"">
                            No
                        </label>
                    </div>
                </div>
            </div>
            <div class=""card"">
                <div class=""card-header"" id=""headingThree"">
                    <h5 class=""mb-0"">
                        <button class=""btn btn-link collapsed"" onclick=""return false;"" data-toggle=""collapse"" data-target=""#collapseThree"" aria-expanded=""false"" aria-controls=""collapseThree"">
                            Question #3
                        </button>
                    </h5>
                </div>
                <div id=""collapseThree"" class=""collap");
                WriteLiteral(@"se"" aria-labelledby=""headingThree"" data-parent=""#accordion"">
                    <div class=""card-body"">
                        What do you like to do when it rains?
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""radio"" name=""Radios3"" id=""q31"" value=""7"">
                        <label class=""form-check-label"" for=""answer7"">
                            Splash around!
                        </label>
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""radio"" name=""Radios3"" id=""q32"" value=""8"">
                        <label class=""form-check-label"" for=""answer8"">
                            Stay indoors and comtemplate my self-worth.
                        </label>
                    </div>
                </div>
            </div>
            <div class=""card"">
                <div class=""card-header"" id=""headingFour"">
   ");
                WriteLiteral(@"                 <h5 class=""mb-0"">
                        <button class=""btn btn-link collapsed"" onclick=""return false;"" data-toggle=""collapse"" data-target=""#collapseFour"" aria-expanded=""false"" aria-controls=""collapseFour"">
                            Question #4
                        </button>
                    </h5>
                </div>
                <div id=""collapseFour"" class=""collapse"" aria-labelledby=""headingFour"" data-parent=""#accordion"">
                    <div class=""card-body"">
                        When kind of music do you listen to?
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""radio"" name=""Radios4"" id=""q41"" value=""9"">
                        <label class=""form-check-label"" for=""answer9"">
                            Rock 'n Roll
                        </label>
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-");
                WriteLiteral(@"input"" type=""radio"" name=""Radios4"" id=""q42"" value=""10"">
                        <label class=""form-check-label"" for=""answer10"">
                            Folk
                        </label>
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""radio"" name=""Radios4"" id=""q43"" value=""11"">
                        <label class=""form-check-label"" for=""answer11"">
                            Pop
                        </label>
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""radio"" name=""Radios4"" id=""q44"" value=""12"">
                        <label class=""form-check-label"" for=""answer12"">
                            Funk
                        </label>
                    </div>
                </div>
            </div>
        </div>
        <input class=""btn btn-block btn-dark"" type=""submit"" value=""View Results"">



    </di");
                WriteLiteral("v>\r\n");
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
