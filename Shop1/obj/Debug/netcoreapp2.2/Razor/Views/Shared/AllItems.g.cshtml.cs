#pragma checksum "D:\DEV\sharp\mvc_sample\Shop1\Views\Shared\AllItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b54b17d7030f4a93e73d124d2049939983cd4d3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AllItems), @"mvc.1.0.view", @"/Views/Shared/AllItems.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/AllItems.cshtml", typeof(AspNetCore.Views_Shared_AllItems))]
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
#line 1 "D:\DEV\sharp\mvc_sample\Shop1\Views\_ViewImports.cshtml"
using Shop1.ViewModels;

#line default
#line hidden
#line 2 "D:\DEV\sharp\mvc_sample\Shop1\Views\_ViewImports.cshtml"
using Shop1.Data.Models;

#line default
#line hidden
#line 3 "D:\DEV\sharp\mvc_sample\Shop1\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b54b17d7030f4a93e73d124d2049939983cd4d3d", @"/Views/Shared/AllItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06fe0a13178c9aa84f5e6378dd9c3c48115bf05c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AllItems : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Item>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 56, true);
            WriteLiteral("\r\n<div class=\"col-lg-4\">\r\n    <img class=\"img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 69, "\"", 85, 1);
#line 4 "D:\DEV\sharp\mvc_sample\Shop1\Views\Shared\AllItems.cshtml"
WriteAttributeValue("", 75, Model.img, 75, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 86, "\"", 103, 1);
#line 4 "D:\DEV\sharp\mvc_sample\Shop1\Views\Shared\AllItems.cshtml"
WriteAttributeValue("", 92, Model.name, 92, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(104, 19, true);
            WriteLiteral(" />\r\n    <h2>Name: ");
            EndContext();
            BeginContext(124, 10, false);
#line 5 "D:\DEV\sharp\mvc_sample\Shop1\Views\Shared\AllItems.cshtml"
         Write(Model.name);

#line default
#line hidden
            EndContext();
            BeginContext(134, 14, true);
            WriteLiteral("</h2>\r\n    <p>");
            EndContext();
            BeginContext(149, 15, false);
#line 6 "D:\DEV\sharp\mvc_sample\Shop1\Views\Shared\AllItems.cshtml"
  Write(Model.shortDesc);

#line default
#line hidden
            EndContext();
            BeginContext(164, 20, true);
            WriteLiteral("</p>\r\n    <p>Price: ");
            EndContext();
            BeginContext(185, 51, false);
#line 7 "D:\DEV\sharp\mvc_sample\Shop1\Views\Shared\AllItems.cshtml"
         Write(Model.price.ToString("C", new CultureInfo("en-GB")));

#line default
#line hidden
            EndContext();
            BeginContext(236, 72, true);
            WriteLiteral("</p>\r\n    <p><a class=\"btn btn-warning\" href=\"#\">Details</a></p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Item> Html { get; private set; }
    }
}
#pragma warning restore 1591
