#pragma checksum "C:\Users\DELL\Desktop\FirstCoreApp\FirstCoreApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8325477b66817f8a67c29b229179e9a6058c2719"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\DELL\Desktop\FirstCoreApp\FirstCoreApp\Views\_ViewImports.cshtml"
using FirstCoreApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Desktop\FirstCoreApp\FirstCoreApp\Views\_ViewImports.cshtml"
using FirstCoreApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8325477b66817f8a67c29b229179e9a6058c2719", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1b89d64417aa850124b73c17b1ea05d2fa5fc0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Categories>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<section id=\"featured-services\" class=\"featured-services\">\n    <div class=\"container\" data-aos=\"fade-up\">\n        <div class=\"row\">\n");
#nullable restore
#line 6 "C:\Users\DELL\Desktop\FirstCoreApp\FirstCoreApp\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-6 col-lg-3 d-flex align-items-stretch mb-5 mb-lg-0\">\n             \n                <a");
            BeginWriteAttribute("href", " href=\"", 345, "\"", 371, 2);
            WriteAttributeValue("", 352, "/Home/News/", 352, 11, true);
#nullable restore
#line 11 "C:\Users\DELL\Desktop\FirstCoreApp\FirstCoreApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 363, item.Id, 363, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <div class=\"icon-box w-100\" data-aos=\"fade-up\" data-aos-delay=\"100\">\n\n                        <div class=\"icon\"><i class=\"fas fa-heartbeat\"></i></div>\n\n                        <h4 class=\"title\"><a");
            BeginWriteAttribute("href", " href=\"", 590, "\"", 616, 2);
            WriteAttributeValue("", 597, "/Home/News/", 597, 11, true);
#nullable restore
#line 16 "C:\Users\DELL\Desktop\FirstCoreApp\FirstCoreApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 608, item.Id, 608, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "C:\Users\DELL\Desktop\FirstCoreApp\FirstCoreApp\Views\Home\Index.cshtml"
                                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\n                        <p class=\"description\">");
#nullable restore
#line 17 "C:\Users\DELL\Desktop\FirstCoreApp\FirstCoreApp\Views\Home\Index.cshtml"
                                          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n\n\n                    </div>\n                </a>\n                  \n            </div>\n");
#nullable restore
#line 25 "C:\Users\DELL\Desktop\FirstCoreApp\FirstCoreApp\Views\Home\Index.cshtml"
         
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        \n        </div>\n        \n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Categories>> Html { get; private set; }
    }
}
#pragma warning restore 1591
