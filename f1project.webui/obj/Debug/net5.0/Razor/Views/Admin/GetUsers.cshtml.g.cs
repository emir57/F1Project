#pragma checksum "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Admin\GetUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a942eb3d501901b27479e1d46aed9c03e0f89973"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GetUsers), @"mvc.1.0.view", @"/Views/Admin/GetUsers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a942eb3d501901b27479e1d46aed9c03e0f89973", @"/Views/Admin/GetUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb88bbb3cf30f97532e923d17e2c9f35ae01e69c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GetUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("class", " class=\"", 25, "\"", 74, 1);
#nullable restore
#line 3 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Admin\GetUsers.cshtml"
WriteAttributeValue("", 33, ViewBag.message==null?"":ViewBag.alert, 33, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <p>");
#nullable restore
#line 4 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Admin\GetUsers.cshtml"
  Write(ViewBag.message);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
</div>

<a class=""btn btn-primary"" href=""/roller"">Roller</a>
<div class=""my-2"">Epostas?? Onaylanmayanlar <div style=""display:inline-block;width: 20px; height:20px;border-radius:50%;""
        class=""bg-warning""></div>
</div>
<table id=""usersTable"" class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Ad??</th>
            <th scope=""col"">Soyad??</th>
            <th scope=""col"">K.Ad??</th>
            <th scope=""col"">E-posta</th>
            <th scope=""col"">A????klama</th>

        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 24 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Admin\GetUsers.cshtml"
         foreach (var t in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("class", " class=\"", 759, "\"", 808, 1);
#nullable restore
#line 26 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Admin\GetUsers.cshtml"
WriteAttributeValue("", 767, t.EmailConfirmed==true?"":"bg-warning", 767, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor:pointer;\"");
            BeginWriteAttribute("title", "\r\n            title=\"", 833, "\"", 889, 6);
            WriteAttributeValue("", 854, "D??zenlemek", 854, 10, true);
            WriteAttributeValue(" ", 864, "i??in", 865, 5, true);
            WriteAttributeValue(" ", 869, "t??kla", 870, 6, true);
            WriteAttributeValue(" ", 875, "{", 876, 2, true);
#nullable restore
#line 27 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Admin\GetUsers.cshtml"
WriteAttributeValue("", 877, t.UserName, 877, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 888, "}", 888, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 890, "\"", 943, 3);
            WriteAttributeValue("", 900, "location.href=\'/kullan??c??lar??d??zenle/", 900, 37, true);
#nullable restore
#line 27 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Admin\GetUsers.cshtml"
WriteAttributeValue("", 937, t.Id, 937, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 942, "\'", 942, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>");
#nullable restore
#line 28 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Admin\GetUsers.cshtml"
               Write(t.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Admin\GetUsers.cshtml"
               Write(t.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Admin\GetUsers.cshtml"
               Write(t.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Admin\GetUsers.cshtml"
               Write(t.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Admin\GetUsers.cshtml"
               Write(t.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Admin\GetUsers.cshtml"
               Write(t.ProfileDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 36 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Admin\GetUsers.cshtml"

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
        $('#usersTable').DataTable();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
