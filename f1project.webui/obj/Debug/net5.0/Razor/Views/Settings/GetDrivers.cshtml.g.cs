#pragma checksum "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Settings\GetDrivers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "212f6eb5bebb62a28401c613fde03b3f0132e03c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Settings_GetDrivers), @"mvc.1.0.view", @"/Views/Settings/GetDrivers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"212f6eb5bebb62a28401c613fde03b3f0132e03c", @"/Views/Settings/GetDrivers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb88bbb3cf30f97532e923d17e2c9f35ae01e69c", @"/Views/_ViewImports.cshtml")]
    public class Views_Settings_GetDrivers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<F1Driver>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("class", " class=\"", 29, "\"", 78, 1);
#nullable restore
#line 3 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Settings\GetDrivers.cshtml"
WriteAttributeValue("", 37, ViewBag.message==null?"":ViewBag.alert, 37, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 3 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Settings\GetDrivers.cshtml"
                                                  Write(ViewBag.message);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<a class=""btn btn-primary"" href=""/pilotekle"">Pilot Ekle</a>

<table id=""driversTable"" class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Fotoğrafı</th>
            <th scope=""col"">Adı Ve Soyadı</th>
            <th scope=""col"">Numarası</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 17 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Settings\GetDrivers.cshtml"
         foreach (var p in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"cursor:pointer;\"");
            BeginWriteAttribute("title", " title=\"", 547, "\"", 609, 7);
            WriteAttributeValue("", 555, "Düzenlemek", 555, 10, true);
            WriteAttributeValue(" ", 565, "için", 566, 5, true);
            WriteAttributeValue(" ", 570, "tıkla", 571, 6, true);
            WriteAttributeValue(" ", 576, "{", 577, 2, true);
#nullable restore
#line 19 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Settings\GetDrivers.cshtml"
WriteAttributeValue("", 578, p.DriverName, 578, 13, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Settings\GetDrivers.cshtml"
WriteAttributeValue(" ", 591, p.DriverSurname, 592, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 608, "}", 608, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 610, "\"", 665, 3);
            WriteAttributeValue("", 620, "location.href=\'/pilotlarıdüzenle/", 620, 33, true);
#nullable restore
#line 19 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Settings\GetDrivers.cshtml"
WriteAttributeValue("", 653, p.DriverId, 653, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 664, "\'", 664, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>");
#nullable restore
#line 20 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Settings\GetDrivers.cshtml"
               Write(p.DriverId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><img");
            BeginWriteAttribute("src", " src=\"", 731, "\"", 762, 2);
            WriteAttributeValue("", 737, "/images/", 737, 8, true);
#nullable restore
#line 21 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Settings\GetDrivers.cshtml"
WriteAttributeValue("", 745, p.DriverImageUrl, 745, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\"></td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Settings\GetDrivers.cshtml"
               Write(p.DriverName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 22 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Settings\GetDrivers.cshtml"
                             Write(p.DriverSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><span class=\"badge bg-secondary\">");
#nullable restore
#line 23 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Settings\GetDrivers.cshtml"
                                                Write(p.DriverNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 26 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Settings\GetDrivers.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<link rel=""stylesheet"" href=""/modules/datatables.net-bs5/css/dataTables.bootstrap5.css"">
<script src=""/modules/jquery/dist/jquery.min.js""></script>
<script src=""/modules/datatables.net/js/jquery.dataTables.min.js""></script>
<script>
    $(document).ready(function () {
        $('#driversTable').DataTable();
    });
</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<F1Driver>> Html { get; private set; }
    }
}
#pragma warning restore 1591
