#pragma checksum "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42a7172763fd2cf8a06fd3cb779326cf4c843d66"
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
#line 1 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\_ViewImports.cshtml"
using AspNetCoreTodo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\_ViewImports.cshtml"
using AspNetCoreTodo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42a7172763fd2cf8a06fd3cb779326cf4c843d66", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63823eaa5b73e495aebe7447edc96790f50c299d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page-Movie Ticketing Web App-ComIT";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"row mt-4\">\r\n        <div class=\"col-sm-12\">\r\n\r\n            <div id=\"slides\" class=\"carousel slide\" data-ride=\"carousel\">\r\n                <ul class=\"carousel-indicators bg-dark fixed-bottom\">\r\n");
#nullable restore
#line 13 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                     for (var i = 0; i < Model.Count; i = i + 4)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("class", " class=\"", 449, "\"", 478, 1);
#nullable restore
#line 15 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 457, i == 0?"active":"", 457, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-target=\"#slides\" data-slide-to=\"");
#nullable restore
#line 15 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                                                                                           Write(i/4);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></li>\r\n");
#nullable restore
#line 16 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n\r\n\r\n                <div class=\"carousel-inner\">\r\n\r\n");
#nullable restore
#line 22 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                     for (var i = 0; i < Model.Count; i = i + 4)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 747, "\"", 790, 2);
            WriteAttributeValue("", 755, "carousel-item", 755, 13, true);
#nullable restore
#line 24 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 768, i == 0?"active":"", 769, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"row\">\r\n                                <div class=\"col-3\">\r\n                                    <div class=\"card ceffect\">\r\n                                        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 1023, "\"", 1045, 1);
#nullable restore
#line 28 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 1029, Model[i].imgUrl, 1029, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1046, "\"", 1067, 1);
#nullable restore
#line 28 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 1052, Model[i].Title, 1052, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <div class=\"card-body\">\r\n                                            <div class=\"card-title ctitle\">");
#nullable restore
#line 30 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                                                                      Write(Model[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                            <p class=\"card-text\">");
#nullable restore
#line 31 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                                                            Write(Model[i].PlotDsc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 1368, "\"", 1403, 2);
            WriteAttributeValue("", 1375, "/Movies/Details/", 1375, 16, true);
#nullable restore
#line 32 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 1391, Model[i].Id, 1391, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"">book now</a>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-3"">
                                    <div class=""card ceffect"">
                                        <img class=""card-img-top""");
            BeginWriteAttribute("src", " src=\"", 1757, "\"", 1781, 1);
#nullable restore
#line 38 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 1763, Model[i+1].imgUrl, 1763, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1782, "\"", 1805, 1);
#nullable restore
#line 38 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 1788, Model[i+1].Title, 1788, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <div class=\"card-body\">\r\n                                            <div class=\"card-title ctitle\">");
#nullable restore
#line 40 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                                                                      Write(Model[i + 1].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                            <p class=\"card-text\">");
#nullable restore
#line 41 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                                                            Write(Model[i + 1].PlotDsc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2114, "\"", 2151, 2);
            WriteAttributeValue("", 2121, "/Movies/Details/", 2121, 16, true);
#nullable restore
#line 42 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 2137, Model[i+1].Id, 2137, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"">book now</a>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-3"">
                                    <div class=""card ceffect"">
                                        <img class=""card-img-top""");
            BeginWriteAttribute("src", " src=\"", 2505, "\"", 2529, 1);
#nullable restore
#line 48 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 2511, Model[i+2].imgUrl, 2511, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2530, "\"", 2553, 1);
#nullable restore
#line 48 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 2536, Model[i+2].Title, 2536, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <div class=\"card-body\">\r\n                                            <div class=\"card-title ctitle\">");
#nullable restore
#line 50 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                                                                      Write(Model[i + 2].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                            <p class=\"card-text\">");
#nullable restore
#line 51 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                                                            Write(Model[i + 2].PlotDsc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2862, "\"", 2899, 2);
            WriteAttributeValue("", 2869, "/Movies/Details/", 2869, 16, true);
#nullable restore
#line 52 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 2885, Model[i+2].Id, 2885, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"">book now</a>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-3"">
                                    <div class=""card ceffect"">
                                        <img class=""card-img-top""");
            BeginWriteAttribute("src", " src=\"", 3253, "\"", 3277, 1);
#nullable restore
#line 58 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 3259, Model[i+3].imgUrl, 3259, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3278, "\"", 3301, 1);
#nullable restore
#line 58 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 3284, Model[i+3].Title, 3284, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <div class=\"card-body\">\r\n                                            <div class=\"card-title ctitle\">");
#nullable restore
#line 60 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                                                                      Write(Model[i + 3].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                            <p class=\"card-text\">");
#nullable restore
#line 61 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                                                            Write(Model[i + 3].PlotDsc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3610, "\"", 3647, 2);
            WriteAttributeValue("", 3617, "/Movies/Details/", 3617, 16, true);
#nullable restore
#line 62 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
WriteAttributeValue("", 3633, Model[i+3].Id, 3633, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">book now</a>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 68 "C:\Users\tnapu\Desktop\CSharp\Movie Ticket-Web Application\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
