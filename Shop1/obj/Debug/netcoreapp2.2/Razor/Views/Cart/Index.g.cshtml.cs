#pragma checksum "D:\DEV\sharp\mvc_sample\Shop1\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7418926705fe16516049d5f63e2e97caff19cb3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7418926705fe16516049d5f63e2e97caff19cb3a", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06fe0a13178c9aa84f5e6378dd9c3c48115bf05c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 31, true);
            WriteLiteral("\r\n    <div class=\"container\">\r\n");
            EndContext();
#line 4 "D:\DEV\sharp\mvc_sample\Shop1\Views\Cart\Index.cshtml"
         foreach (var el in Model.cart.cart_items_list)
        {

#line default
#line hidden
            BeginContext(121, 82, true);
            WriteLiteral("            <div class=\"alert alert-warning mt-3\">\r\n                <b>Item: </b> ");
            EndContext();
            BeginContext(204, 12, false);
#line 7 "D:\DEV\sharp\mvc_sample\Shop1\Views\Cart\Index.cshtml"
                         Write(el.item.name);

#line default
#line hidden
            EndContext();
            BeginContext(216, 38, true);
            WriteLiteral("<br />\r\n                <b>Price: </b>");
            EndContext();
            BeginContext(255, 27, false);
#line 8 "D:\DEV\sharp\mvc_sample\Shop1\Views\Cart\Index.cshtml"
                         Write(el.item.price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(282, 24, true);
            WriteLiteral("\r\n\r\n            </div>\r\n");
            EndContext();
#line 11 "D:\DEV\sharp\mvc_sample\Shop1\Views\Cart\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(317, 100, true);
            WriteLiteral("\r\n        <hr />\r\n        <div class=\"btn btn-danger\" asp-controller=\"Order\">Pay</div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
