#pragma checksum "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Settings\GetPosts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81f0b3f95c96b7191b34c35c779c25f6ca098f97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Settings_GetPosts), @"mvc.1.0.view", @"/Views/Settings/GetPosts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81f0b3f95c96b7191b34c35c779c25f6ca098f97", @"/Views/Settings/GetPosts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb88bbb3cf30f97532e923d17e2c9f35ae01e69c", @"/Views/_ViewImports.cshtml")]
    public class Views_Settings_GetPosts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div");
            BeginWriteAttribute("class", " class=\"", 27, "\"", 76, 1);
#nullable restore
#line 4 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Settings\GetPosts.cshtml"
WriteAttributeValue("", 35, ViewBag.message==null?"":ViewBag.alert, 35, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 4 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Settings\GetPosts.cshtml"
                                                  Write(ViewBag.message);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<a class=""btn btn-primary"" href=""/postpaylaş"">Post Paylaş</a>

<table id=""postsTable"" class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Başlık</th>
            <th scope=""col"">Başlık Resmi</th>
            <th scope=""col"">Haber İçeriği</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 18 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Settings\GetPosts.cshtml"
         foreach (var p in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"cursor:pointer;\"");
            BeginWriteAttribute("title", " title=\"", 546, "\"", 586, 6);
            WriteAttributeValue("", 554, "Düzenlemek", 554, 10, true);
            WriteAttributeValue(" ", 564, "için", 565, 5, true);
            WriteAttributeValue(" ", 569, "tıkla", 570, 6, true);
            WriteAttributeValue(" ", 575, "{", 576, 2, true);
#nullable restore
#line 20 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Settings\GetPosts.cshtml"
WriteAttributeValue("", 577, p.Title, 577, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 585, "}", 585, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", "\r\n            onclick=\"", 587, "\"", 652, 3);
            WriteAttributeValue("", 610, "location.href=\'/postlarıdüzenle/", 610, 32, true);
#nullable restore
#line 21 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Settings\GetPosts.cshtml"
WriteAttributeValue("", 642, p.PostId, 642, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 651, "\'", 651, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>");
#nullable restore
#line 22 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Settings\GetPosts.cshtml"
               Write(p.PostId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Settings\GetPosts.cshtml"
               Write(p.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><img");
            BeginWriteAttribute("src", " src=\"", 751, "\"", 781, 2);
            WriteAttributeValue("", 757, "/images/", 757, 8, true);
#nullable restore
#line 24 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Settings\GetPosts.cshtml"
WriteAttributeValue("", 765, p.ImageTitleUrl, 765, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150\"></td>\r\n                <td>-</td>\r\n            </tr>\r\n");
#nullable restore
#line 27 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Settings\GetPosts.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<link rel=""stylesheet"" href=""/modules/datatables.net-bs5/css/dataTables.bootstrap5.css"">
<script src=""/modules/jquery/dist/jquery.min.js""></script>
<script src=""/modules/datatables.net/js/jquery.dataTables.min.js""></script>
<script>
    $(document).ready(function () {
        $('#postsTable').DataTable();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
