#pragma checksum "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18d0d2f951c6cb7b2c67e22167260712325d8195"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18d0d2f951c6cb7b2c67e22167260712325d8195", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb88bbb3cf30f97532e923d17e2c9f35ae01e69c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"tr\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18d0d2f951c6cb7b2c67e22167260712325d81954607", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""keywords""
        content=""F1,F1 Türkiye,Scuderia Ferrari,Mercedes-AMG,Red Bull,Aston Martin,Alfa Romeo,AlphaTauri,Haas,McLaren,Williams Racing,Alpine,Racing Point,Daniel Ricciardo,Lando Norris,Sebastian Vettel,Nicholas Latifi,Kimi Raikkonen,Nikita Mazepin,Pierre Gasly,Sergio Perez,Fernando Alonso,Charles Leclerc,Lance Stroll,Yuki Tsunoda,Esteban Ocon,Max Verstappen,Lewis Hamilton,Mick Schumacher,Carlos Sainz Jr,George Russell,Valtteri Bottas,Antonio Giovinazzi"">
    <meta name=""description"" content=""F1 Haberleri F1 Yarışları F1 Pilotları F1 Takımları "">
    <meta name=""Author"" content=""Emir Gürbüz"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <title>");
#nullable restore
#line 11 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" - PolePosition</title>

    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet""
        integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.15.4/css/all.css""
        integrity=""sha384-DyZ88mC6Up2uqS4h/KRgHuoeGwBcD4Ng9SiP4dIRy0EXTlnuz47vAwmeGwVChigm"" crossorigin=""anonymous"">
");
                WriteLiteral("    ");
#nullable restore
#line 18 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Styles",false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/css/site.css\" />\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18d0d2f951c6cb7b2c67e22167260712325d81957398", async() => {
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 26 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("_Navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 27 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Alerts",required:false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 28 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Shared\_Layout.cshtml"
     if(IsSectionDefined("RightBar"))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"container\">\r\n            <main role=\"main\" class=\"pb-3\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-9\">\r\n                        ");
#nullable restore
#line 34 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Shared\_Layout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-3\">\r\n                        <div id=\"rightBar\">\r\n                            ");
#nullable restore
#line 38 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Shared\_Layout.cshtml"
                       Write(RenderSection("RightBar", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </main>\r\n        </div>\r\n");
#nullable restore
#line 44 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Shared\_Layout.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"container\">\r\n            <main role=\"main\" class=\"pb-3\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-12\">\r\n                        ");
#nullable restore
#line 51 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Shared\_Layout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </main>\r\n        </div>\r\n");
#nullable restore
#line 56 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Shared\_Layout.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 58 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("_Footer"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <script src=\"/modules/jquery/dist/jquery.min.js\"></script>\r\n    <script src=\"/modules/bootstrap/dist/js/bootstrap.bundle.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18d0d2f951c6cb7b2c67e22167260712325d819510752", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 61 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
#nullable restore
#line 62 "C:\Users\lolem\Desktop\F1Project\f1project.webui\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
