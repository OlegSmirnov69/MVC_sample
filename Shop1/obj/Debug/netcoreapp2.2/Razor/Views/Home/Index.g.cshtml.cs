#pragma checksum "D:\DEV\sharp\mvc_sample\Shop1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "778cf0ec29bb63341435403f38acb52aa652f1b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"778cf0ec29bb63341435403f38acb52aa652f1b5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06fe0a13178c9aa84f5e6378dd9c3c48115bf05c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 37, true);
            WriteLiteral("\r\n    <div class=\"row mt-5 mb-2\">\r\n\r\n");
            EndContext();
#line 5 "D:\DEV\sharp\mvc_sample\Shop1\Views\Home\Index.cshtml"
          
        foreach (Item item in Model.topItems)
        {
            

#line default
#line hidden
            BeginContext(142, 30, false);
#line 8 "D:\DEV\sharp\mvc_sample\Shop1\Views\Home\Index.cshtml"
       Write(Html.Partial("AllItems", item));

#line default
#line hidden
            EndContext();
#line 8 "D:\DEV\sharp\mvc_sample\Shop1\Views\Home\Index.cshtml"
                                           

        }
        

#line default
#line hidden
            BeginContext(198, 12, true);
            WriteLiteral("\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
