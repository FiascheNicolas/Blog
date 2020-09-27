#pragma checksum "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db80a178b86d00e92a87eae18ba733ef3e7c3319"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Post.cshtml", typeof(AspNetCore.Views_Home_Post))]
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
#line 2 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
#line 3 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\_ViewImports.cshtml"
using Blog.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db80a178b86d00e92a87eae18ba733ef3e7c3319", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9441f6bc3cc00f7951c7eb7911917222fac2c378", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml"
  
    ViewBag.Title = Model.Title;
    ViewBag.Description = Model.Description;
    ViewBag.Keywords = $"{Model.Tags?.Replace(","," ")} {Model.Category}";

#line default
#line hidden
            BeginContext(178, 5, true);
            WriteLiteral("\r\n<a>");
            EndContext();
            BeginContext(184, 8, false);
#line 9 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml"
Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(192, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 10 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml"
 if (!String.IsNullOrEmpty(Model.Image))
{
    var image_path = $"/image/{Model.Image}";

#line default
#line hidden
            BeginContext(290, 8, true);
            WriteLiteral("    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 298, "\"", 315, 1);
#line 13 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml"
WriteAttributeValue("", 304, image_path, 304, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(316, 17, true);
            WriteLiteral(" width=\"500\" />\r\n");
            EndContext();
#line 14 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml"
}

#line default
#line hidden
            BeginContext(336, 26, true);
            WriteLiteral("\r\n\r\n<div class=\"bodypost\">");
            EndContext();
            BeginContext(363, 20, false);
#line 17 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml"
                 Write(Html.Raw(Model.Body));

#line default
#line hidden
            EndContext();
            BeginContext(383, 13, true);
            WriteLiteral("</div>\r\n\r\n<a>");
            EndContext();
            BeginContext(397, 11, false);
#line 19 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml"
Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(408, 11, true);
            WriteLiteral("</a>\r\n\r\n<a>");
            EndContext();
            BeginContext(420, 13, false);
#line 21 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml"
Write(Model.Created);

#line default
#line hidden
            EndContext();
            BeginContext(433, 6, true);
            WriteLiteral("</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
