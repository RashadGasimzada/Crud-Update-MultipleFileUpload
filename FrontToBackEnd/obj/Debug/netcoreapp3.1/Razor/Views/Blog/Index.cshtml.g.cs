#pragma checksum "C:\Users\hp\Desktop\slider-crud\FrontToBackEnd\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d89b403f35fd4d9a2505b2822bd07a5d94fb2c7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\slider-crud\FrontToBackEnd\Views\_ViewImports.cshtml"
using FrontToBackEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\slider-crud\FrontToBackEnd\Views\_ViewImports.cshtml"
using FrontToBackEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Desktop\slider-crud\FrontToBackEnd\Views\_ViewImports.cshtml"
using FrontToBackEnd.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\Desktop\slider-crud\FrontToBackEnd\Views\_ViewImports.cshtml"
using FrontToBackEnd.ViewModels.Admin.SliderViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d89b403f35fd4d9a2505b2822bd07a5d94fb2c7b", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"536e8a9ef0f086b2faacecf94783024d1815246b", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/blog.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\hp\Desktop\slider-crud\FrontToBackEnd\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Blog";

#line default
#line hidden
#nullable disable
            DefineSection("style", async() => {
                WriteLiteral("\r\n    \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d89b403f35fd4d9a2505b2822bd07a5d94fb2c7b4436", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<main>\r\n    <section id=\"blog-first\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-9\">\r\n                    <img class=\"imag1\" src=\"https://klbtheme.com/bacola/wp-content/uploads/2021/05/blog-3.jpg\"");
            BeginWriteAttribute("alt", "\r\n                         alt=\"", 376, "\"", 408, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <h1>But I must explain to you how all this mistaken idea</h1>
                    <p>
                        Pellentesque feugiat, sem id interdum molestie, libero nibh imperdiet velit, sodales
                        elementum enim sem sed lectus. Vivamus viverra diam congue tristique pellentesque. Proin
                        efficitur est vel lectus ultrices rhoncus eu ut lacus. In gravida leo at justo lobortis,
                        vitae aliquet justo vehicula. Maecenas at facilisis ex. Curabitur cursus, ex id
                        efficitur ultrices, sapien mauris sodales
                    </p>
                    <button class=""btn btn-primary"">Read More</button>
                </div>
                <div class=""col-3"">

                    <input type=""search"" id=""form1"" placeholder=""search"" class=""form-control"" />
                    <h5 class=""popular"">POPULAR POSTS</h5>
                    <div class=""forms"">

                        <div class=""form1");
            WriteLiteral("\">\r\n                            <img class=\"daily1\"\r\n                                 src=\"https://klbtheme.com/bacola/multivendor/wp-content/uploads/sites/2/2021/05/blog-3-100x100.jpg\"");
            BeginWriteAttribute("alt", "\r\n                                 alt=\"", 1618, "\"", 1658, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <p>But I must explain to you how all this mistaken idea</p>
                        </div>
                        <div class=""form2"">
                            <img class=""daily2""
                                 src=""https://klbtheme.com/bacola/multivendor/wp-content/uploads/sites/2/2021/05/blog-5-100x100.jpg""");
            BeginWriteAttribute("alt", "\r\n                                 alt=\"", 2009, "\"", 2049, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <p>The Problem With Typefaces on the Web</p>
                        </div>
                        <div class=""form3"">
                            <img class=""daily3""
                                 src=""https://klbtheme.com/bacola/multivendor/wp-content/uploads/sites/2/2021/05/blog-1-100x100.jpg""");
            BeginWriteAttribute("alt", "\r\n                                 alt=\"", 2385, "\"", 2425, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <p>English Breakfast Tea With Tasty Donut Desserts</p>
                        </div>

                    </div>
                    <div class=""social-media"">
                        <h5 class=""social"">Social Media</h5>
                        <div class=""face"">
                            <i class=""fab fa-facebook-square""></i> <span>Facebook</span>
                        </div>
                        <div class=""twitter"">
                            <i class=""fab fa-twitter""></i> <span>Twitter</span>
                        </div>
                        <div class=""pinterest"">
                            <i class=""fab fa-pinterest""></i> <span>Pinterest</span>
                        </div>
                        <div class=""linkedin"">
                            <i class=""fab fa-linkedin""></i><span>Linkedin</span>
                        </div>
                        <div class=""insta"">
                            <i class=""fab fa-instagram""></i> <span");
            WriteLiteral(@">Instagram</span>
                        </div>
                    </div>


                </div>
            </div>
        </div>
    </section>
    <section id=""blog-second"">
        <div class=""container mt-5"">
            <div class=""row mt-5"">
                <div class=""col-9 mt-4"">
                    <img class=""img-5"" src=""https://klbtheme.com/bacola/wp-content/uploads/2021/05/blog-5.jpg""");
            BeginWriteAttribute("alt", "\r\n                         alt=\"", 3867, "\"", 3899, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <h1 class=""the"">The Problem With Typefaces on the Web</h1>
                    <p class=""feugiat"">
                        Pellentesque feugiat, sem id interdum molestie, libero nibh imperdiet
                        velit, sodales
                        elementum enim sem sed lectus. Vivamus viverra diam congue tristique pellentesque. Proin
                        efficitur est vel lectus ultrices rhoncus eu ut lacus. In gravida leo at justo lobortis,
                        vitae aliquet justo vehicula. Maecenas at facilisis ex. Curabitur cursus, ex id
                        efficitur ultrices, sapien mauris sodales
                    </p>
                    <button class=""btn btn-primary"">Read More</button>
                </div>
                <div class=""col-3"">
                    <div class=""banner"">
                        <h5 class=""widget"">Widget Banner</h5>
                        <img class=""img-ban""
                             src=""https://klbtheme.com/");
            WriteLiteral("bacola/multivendor/wp-content/uploads/sites/2/2021/05/sidebar-banner.gif\"");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 4997, "\"", 5033, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section id=""blog-third"">
        <div class=""container"">
            <div class=""row mt-5"">
                <div class=""col-9 mt-5"">
                    <img class=""blog-end"" src=""https://klbtheme.com/bacola/wp-content/uploads/2021/05/blog-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5396, "\"", 5402, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <h1 class=""english"">English Breakfast Tea With Tasty Donut Desserts</h1>
                    <p class=""sem"">
                        Pellentesque feugiat, sem id interdum molestie, libero nibh imperdiet velit, sodales
                        elementum enim sem sed lectus. Vivamus viverra diam congue tristique pellentesque. Proin
                        efficitur est vel lectus ultrices rhoncus eu ut lacus. In gravida leo at justo lobortis,
                        vitae aliquet justo vehicula. Maecenas at facilisis ex. Curabitur cursus, ex id
                        efficitur ultrices, sapien mauris sodales
                    </p>
                    <button class=""btn btn-primary"">Read More</button>
                </div>
            </div>
        </div>
    </section>
</main>
");
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