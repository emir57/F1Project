#pragma checksum "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Shared\_Rightbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5991ad3396af9f2c90b540cb83506337f0223bf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Rightbar), @"mvc.1.0.view", @"/Views/Shared/_Rightbar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5991ad3396af9f2c90b540cb83506337f0223bf5", @"/Views/Shared/_Rightbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb88bbb3cf30f97532e923d17e2c9f35ae01e69c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Rightbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1 class=\"display-4\">Son Haberler</h1>\r\n<hr");
            BeginWriteAttribute("id", " id=\"", 44, "\"", 49, 0);
            EndWriteAttribute();
            WriteLiteral(@">
<ul class=""list-group"">
    <li class=""list-group-item d-flex justify-content-between align-items-center"">
        A list item
        <span class=""badge bg-primary text-white rounded-pill"">14</span>
    </li>
    <li class=""list-group-item d-flex justify-content-between align-items-center"">
        A second list item
        <span class=""badge bg-primary text-white rounded-pill"">2</span>
    </li>
    <li class=""list-group-item d-flex justify-content-between align-items-center"">
        A third list item
        <span class=""badge bg-primary text-white rounded-pill"">1</span>
    </li>
</ul>");
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
