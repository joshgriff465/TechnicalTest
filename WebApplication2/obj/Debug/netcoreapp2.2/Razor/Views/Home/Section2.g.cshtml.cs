#pragma checksum "C:\Users\JGriffit\source\repos\WebApplication2\WebApplication2\Views\Home\Section2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a147e4dad5359f7c08ecc3c29d47cb1098d124f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Section2), @"mvc.1.0.view", @"/Views/Home/Section2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Section2.cshtml", typeof(AspNetCore.Views_Home_Section2))]
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
#line 1 "C:\Users\JGriffit\source\repos\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#line 2 "C:\Users\JGriffit\source\repos\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a147e4dad5359f7c08ecc3c29d47cb1098d124f9", @"/Views/Home/Section2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Section2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\JGriffit\source\repos\WebApplication2\WebApplication2\Views\Home\Section2.cshtml"
  
    ViewData["Title"] = "Section2";

#line default
#line hidden
            BeginContext(44, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(48, 6608, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a147e4dad5359f7c08ecc3c29d47cb1098d124f93407", async() => {
                BeginContext(54, 965, true);
                WriteLiteral(@"
        <div class=""bgImage2"" style=""width: 100%;"">

            <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"" data-interval=""false"">
                <ol class=""carousel-indicators"">
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
                </ol>
                <div class=""carousel-inner"">
                    <div class=""carousel-item active"">
                        <div class=""row"" style=""width: 80%; margin-left: 10%"">
                            <div class=""col-md-3 box "">
                                <div class=""inner-box"">
                                    <h1 class=""panel2-heading"">Heading 2</h1>
                                    <ul class=""box-text"">
");
                EndContext();
#line 20 "C:\Users\JGriffit\source\repos\WebApplication2\WebApplication2\Views\Home\Section2.cshtml"
                                         foreach (var part in ViewBag.Bullet)
                                        {

#line default
#line hidden
                BeginContext(1141, 48, true);
                WriteLiteral("                                            <li>");
                EndContext();
                BeginContext(1190, 4, false);
#line 22 "C:\Users\JGriffit\source\repos\WebApplication2\WebApplication2\Views\Home\Section2.cshtml"
                                           Write(part);

#line default
#line hidden
                EndContext();
                BeginContext(1194, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 23 "C:\Users\JGriffit\source\repos\WebApplication2\WebApplication2\Views\Home\Section2.cshtml"
                                        }

#line default
#line hidden
                BeginContext(1244, 367, true);
                WriteLiteral(@"                                    </ul>
                                </div>
                            </div>
                            <div class=""col-md-3 box"">
                                <div class=""inner-box"">
                                    <h1 class=""panel2-heading"">Heading 2</h1>
                                    <p class=""box-text"">");
                EndContext();
                BeginContext(1612, 15, false);
#line 30 "C:\Users\JGriffit\source\repos\WebApplication2\WebApplication2\Views\Home\Section2.cshtml"
                                                   Write(ViewBag.File[1]);

#line default
#line hidden
                EndContext();
                BeginContext(1627, 333, true);
                WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""col-md-3 box"">
                                <div class=""inner-box"">
                                    <h1 class=""panel2-heading"">Heading 2</h1>
                                    <ul class=""box-text"">
");
                EndContext();
#line 37 "C:\Users\JGriffit\source\repos\WebApplication2\WebApplication2\Views\Home\Section2.cshtml"
                                         foreach (var part in ViewBag.Bullet2)
                                        {

#line default
#line hidden
                BeginContext(2083, 48, true);
                WriteLiteral("                                            <li>");
                EndContext();
                BeginContext(2132, 4, false);
#line 39 "C:\Users\JGriffit\source\repos\WebApplication2\WebApplication2\Views\Home\Section2.cshtml"
                                           Write(part);

#line default
#line hidden
                EndContext();
                BeginContext(2136, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 40 "C:\Users\JGriffit\source\repos\WebApplication2\WebApplication2\Views\Home\Section2.cshtml"
                                        }

#line default
#line hidden
                BeginContext(2186, 560, true);
                WriteLiteral(@"                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""carousel-item"">
                        <div class=""row"" style=""width: 80%; margin-left: 10%"">
                            <div class=""col-md-3 box "">
                                <div class=""inner-box"">
                                    <h1 class=""panel2-heading"">Heading 3</h1>
                                    <ul class=""box-text"">
");
                EndContext();
#line 52 "C:\Users\JGriffit\source\repos\WebApplication2\WebApplication2\Views\Home\Section2.cshtml"
                                         foreach (var part in ViewBag.Bullet)
                                        {

#line default
#line hidden
                BeginContext(2868, 48, true);
                WriteLiteral("                                            <li>");
                EndContext();
                BeginContext(2917, 4, false);
#line 54 "C:\Users\JGriffit\source\repos\WebApplication2\WebApplication2\Views\Home\Section2.cshtml"
                                           Write(part);

#line default
#line hidden
                EndContext();
                BeginContext(2921, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 55 "C:\Users\JGriffit\source\repos\WebApplication2\WebApplication2\Views\Home\Section2.cshtml"
                                        }

#line default
#line hidden
                BeginContext(2971, 367, true);
                WriteLiteral(@"                                    </ul>
                                </div>
                            </div>
                            <div class=""col-md-3 box"">
                                <div class=""inner-box"">
                                    <h1 class=""panel2-heading"">Heading 3</h1>
                                    <p class=""box-text"">");
                EndContext();
                BeginContext(3339, 15, false);
#line 62 "C:\Users\JGriffit\source\repos\WebApplication2\WebApplication2\Views\Home\Section2.cshtml"
                                                   Write(ViewBag.File[1]);

#line default
#line hidden
                EndContext();
                BeginContext(3354, 333, true);
                WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""col-md-3 box"">
                                <div class=""inner-box"">
                                    <h1 class=""panel2-heading"">Heading 3</h1>
                                    <ul class=""box-text"">
");
                EndContext();
#line 69 "C:\Users\JGriffit\source\repos\WebApplication2\WebApplication2\Views\Home\Section2.cshtml"
                                         foreach (var part in ViewBag.Bullet2)
                                        {

#line default
#line hidden
                BeginContext(3810, 48, true);
                WriteLiteral("                                            <li>");
                EndContext();
                BeginContext(3859, 4, false);
#line 71 "C:\Users\JGriffit\source\repos\WebApplication2\WebApplication2\Views\Home\Section2.cshtml"
                                           Write(part);

#line default
#line hidden
                EndContext();
                BeginContext(3863, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 72 "C:\Users\JGriffit\source\repos\WebApplication2\WebApplication2\Views\Home\Section2.cshtml"
                                        }

#line default
#line hidden
                BeginContext(3913, 560, true);
                WriteLiteral(@"                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""carousel-item"">
                        <div class=""row"" style=""width: 80%; margin-left: 10%"">
                            <div class=""col-md-3 box "">
                                <div class=""inner-box"">
                                    <h1 class=""panel2-heading"">Heading 4</h1>
                                    <ul class=""box-text"">
");
                EndContext();
#line 84 "C:\Users\JGriffit\source\repos\WebApplication2\WebApplication2\Views\Home\Section2.cshtml"
                                         foreach (var part in ViewBag.Bullet)
                                        {

#line default
#line hidden
                BeginContext(4595, 48, true);
                WriteLiteral("                                            <li>");
                EndContext();
                BeginContext(4644, 4, false);
#line 86 "C:\Users\JGriffit\source\repos\WebApplication2\WebApplication2\Views\Home\Section2.cshtml"
                                           Write(part);

#line default
#line hidden
                EndContext();
                BeginContext(4648, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 87 "C:\Users\JGriffit\source\repos\WebApplication2\WebApplication2\Views\Home\Section2.cshtml"
                                        }

#line default
#line hidden
                BeginContext(4698, 367, true);
                WriteLiteral(@"                                    </ul>
                                </div>
                            </div>
                            <div class=""col-md-3 box"">
                                <div class=""inner-box"">
                                    <h1 class=""panel2-heading"">Heading 4</h1>
                                    <p class=""box-text"">");
                EndContext();
                BeginContext(5066, 15, false);
#line 94 "C:\Users\JGriffit\source\repos\WebApplication2\WebApplication2\Views\Home\Section2.cshtml"
                                                   Write(ViewBag.File[1]);

#line default
#line hidden
                EndContext();
                BeginContext(5081, 333, true);
                WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""col-md-3 box"">
                                <div class=""inner-box"">
                                    <h1 class=""panel2-heading"">Heading 4</h1>
                                    <ul class=""box-text"">
");
                EndContext();
#line 101 "C:\Users\JGriffit\source\repos\WebApplication2\WebApplication2\Views\Home\Section2.cshtml"
                                         foreach (var part in ViewBag.Bullet2)
                                        {

#line default
#line hidden
                BeginContext(5537, 48, true);
                WriteLiteral("                                            <li>");
                EndContext();
                BeginContext(5586, 4, false);
#line 103 "C:\Users\JGriffit\source\repos\WebApplication2\WebApplication2\Views\Home\Section2.cshtml"
                                           Write(part);

#line default
#line hidden
                EndContext();
                BeginContext(5590, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 104 "C:\Users\JGriffit\source\repos\WebApplication2\WebApplication2\Views\Home\Section2.cshtml"
                                        }

#line default
#line hidden
                BeginContext(5640, 1009, true);
                WriteLiteral(@"                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" id=""btnNext"" onclick=""NextClick();"" data-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Next</span>
                </a>
            </div>
            <br />
            <hr class=""White"" />
            <label id=""SlideNum"" value=""1/3"" class=""slide-label"" style=""float:right"">1/3</label>


        </div>


    ");
                EndContext();
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
            EndContext();
            BeginContext(6656, 538, true);
            WriteLiteral(@"
    <script type=""text/javascript"">
        function NextClick()
        {
            var currText = document.getElementById('SlideNum').textContent;

            if (currText == ""1/3"")
                document.getElementById('SlideNum').textContent = ""2/3"";

            else if (currText == ""2/3"")
                document.getElementById('SlideNum').textContent = ""3/3"";
            
            else 
                document.getElementById('SlideNum').textContent = ""1/3"";
            
        }
     
    </script>");
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
