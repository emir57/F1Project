#pragma checksum "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Home\Team.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff93be18dfb1ea03de437aa565d0116c4e21c837"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Team), @"mvc.1.0.view", @"/Views/Home/Team.cshtml")]
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
#line 1 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\_ViewImports.cshtml"
using f1project.webui;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\_ViewImports.cshtml"
using f1project.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\_ViewImports.cshtml"
using f1project.entity.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\_ViewImports.cshtml"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\_ViewImports.cshtml"
using f1project.webui.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff93be18dfb1ea03de437aa565d0116c4e21c837", @"/Views/Home/Team.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb88bbb3cf30f97532e923d17e2c9f35ae01e69c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Team : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GetTeamViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<h1 class=\"display-3\">");
#nullable restore
#line 17 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Home\Team.cshtml"
                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<hr>\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 21 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Home\Team.cshtml"
     foreach (var p in Model.Drivers)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col\">\r\n            <div class=\"card\" style=\"width: 18rem;\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 851, "\"", 882, 2);
            WriteAttributeValue("", 857, "/images/", 857, 8, true);
#nullable restore
#line 25 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Home\Team.cshtml"
WriteAttributeValue("", 865, p.DriverImageUrl, 865, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("width", " width=\"", 883, "\"", 891, 0);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 892, "\"", 911, 1);
#nullable restore
#line 25 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Home\Team.cshtml"
WriteAttributeValue("", 898, p.DriverName, 898, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 27 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Home\Team.cshtml"
                                      Write(p.DriverName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 27 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Home\Team.cshtml"
                                                    Write(p.DriverSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span\r\n                        class=\"badge bg-secondary\">");
#nullable restore
#line 28 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Home\Team.cshtml"
                                              Write(p.DriverNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n\r\n                </div>\r\n                <ul class=\"list-group list-group-flush\">\r\n                    <li class=\"list-group-item\"><img width=\"50\"");
            BeginWriteAttribute("src", " src=\"", 1264, "\"", 1304, 2);
            WriteAttributeValue("", 1270, "/images/", 1270, 8, true);
#nullable restore
#line 32 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Home\Team.cshtml"
WriteAttributeValue("", 1278, p.Country.CountryImageUrl, 1278, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1305, "\"", 1311, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <b>");
#nullable restore
#line 33 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Home\Team.cshtml"
                      Write(p.Country.CountryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                    </li>\r\n                    <li class=\"list-group-item\">Doğum Tarihi <b>");
#nullable restore
#line 35 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Home\Team.cshtml"
                                                           Write(p.DateOfBirth.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            (");
#nullable restore
#line 36 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Home\Team.cshtml"
                         Write(DateTime.Now.Year-p.DateOfBirth.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" yaşında)</b></li>\r\n\r\n                </ul>\r\n                <div class=\"card-body\">\r\n");
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 44 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Home\Team.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GetTeamViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
