#pragma checksum "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Home\Genre.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "884346df0a09ab62d04cc4e92cdc78b10848ec56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Genre), @"mvc.1.0.view", @"/Views/Home/Genre.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Genre.cshtml", typeof(AspNetCore.Views_Home_Genre))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"884346df0a09ab62d04cc4e92cdc78b10848ec56", @"/Views/Home/Genre.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"114feecbc7bb502572199314ad0d2e632a5e45ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Genre : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GenreViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Home\Genre.cshtml"
  
    ViewData["Title"] = "Genre";

#line default
#line hidden
            BeginContext(64, 56, true);
            WriteLiteral("\r\n<h2>The latest genres people are talking about:</h2>\r\n");
            EndContext();
#line 7 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Home\Genre.cshtml"
 foreach ( var story in Model.response)
{

#line default
#line hidden
            BeginContext(164, 8, true);
            WriteLiteral("    <h5>");
            EndContext();
            BeginContext(173, 5, false);
#line 9 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Home\Genre.cshtml"
   Write(story);

#line default
#line hidden
            EndContext();
            BeginContext(178, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 10 "C:\Users\Bob\Desktop\Finalizer\Finalizer\Views\Home\Genre.cshtml"
}

#line default
#line hidden
            BeginContext(188, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GenreViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
