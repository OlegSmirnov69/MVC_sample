#pragma checksum "D:\DEV\sharp\mvc_sample\Shop1\Views\Item\ShowList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b899e70c6965e2775f7377eeb292a3a796e3817"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_ShowList), @"mvc.1.0.view", @"/Views/Item/ShowList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Item/ShowList.cshtml", typeof(AspNetCore.Views_Item_ShowList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b899e70c6965e2775f7377eeb292a3a796e3817", @"/Views/Item/ShowList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4499727f7c30007b37a0e29336e6d603fbacc75", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_ShowList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 47, true);
            WriteLiteral("<h3 class=\"display-2 bg-light mt-5 rounded-lg\">");
            EndContext();
            BeginContext(48, 21, false);
#line 1 "D:\DEV\sharp\mvc_sample\Shop1\Views\Item\ShowList.cshtml"
                                          Write(Model.currentCategory);

#line default
#line hidden
            EndContext();
            BeginContext(69, 133, true);
            WriteLiteral("</h3>\r\n<div class=\"album py-5 bg-light rounded-lg mb-5\">\r\n    <div class=\"container\" >\r\n\r\n        <div class=\"row\">\r\n            \r\n\r\n");
            EndContext();
#line 8 "D:\DEV\sharp\mvc_sample\Shop1\Views\Item\ShowList.cshtml"
                  
                    foreach (Item item in Model.allItems)
                    {
                        

#line default
#line hidden
            BeginContext(329, 30, false);
#line 11 "D:\DEV\sharp\mvc_sample\Shop1\Views\Item\ShowList.cshtml"
                   Write(Html.Partial("AllItems", item));

#line default
#line hidden
            EndContext();
#line 11 "D:\DEV\sharp\mvc_sample\Shop1\Views\Item\ShowList.cshtml"
                                                       

                    }
                

#line default
#line hidden
            BeginContext(405, 60, true);
            WriteLiteral("\r\n            </div>\r\n            </div>\r\n        </div>\r\n\r\n");
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
