#pragma checksum "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0029b5516fd9fd8be6cb93762f49c5d9092e70b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0029b5516fd9fd8be6cb93762f49c5d9092e70b3", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb88bbb3cf30f97532e923d17e2c9f35ae01e69c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div align=\"center\">\r\n    <img");
            BeginWriteAttribute("class", " class=\"", 45, "\"", 53, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"500\"");
            BeginWriteAttribute("src", " src=\"", 66, "\"", 100, 2);
            WriteAttributeValue("", 72, "/images/", 72, 8, true);
#nullable restore
#line 4 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Home\Post.cshtml"
WriteAttributeValue("", 80, Model.ImageTitleUrl, 80, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n    <br>\r\n    <h4 class=\"display-4\">");
#nullable restore
#line 6 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Home\Post.cshtml"
                     Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n</div>\r\n<hr>\r\n<div align=\"center\">\r\n    ");
#nullable restore
#line 10 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Home\Post.cshtml"
Write(Html.Raw(@Model.BodyText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
