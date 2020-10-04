#pragma checksum "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1165736bb6b5b9cfdde04561e208b0ef80f119aa"
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
using Blog.Models.Comments;

#line default
#line hidden
#line 4 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\_ViewImports.cshtml"
using Blog.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1165736bb6b5b9cfdde04561e208b0ef80f119aa", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f6dacf880d8b1262d2ea06921b70e4a8bd9f2a3", @"/Views/_ViewImports.cshtml")]
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
    ViewBag.Keywords = $"{Model.Tags?.Replace(",", " ")} {Model.Category}";
    var base_path = Context.Request.PathBase;

#line default
#line hidden
            BeginContext(226, 55, true);
            WriteLiteral("\r\n<div class=\"postContainer\">\r\n    <div class=\"post\">\r\n");
            EndContext();
#line 12 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml"
         if (!String.IsNullOrEmpty(Model.Image))
        {
            var image_path = $"{base_path}/image/{Model.Image}";

#line default
#line hidden
            BeginContext(408, 55, true);
            WriteLiteral("            <div class=\"postRow\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 463, "\"", 480, 1);
#line 16 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml"
WriteAttributeValue("", 469, image_path, 469, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(481, 37, true);
            WriteLiteral(" width=\"500\" />\r\n            </div>\r\n");
            EndContext();
#line 18 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml"
        }

#line default
#line hidden
            BeginContext(529, 43, true);
            WriteLiteral("        <div class=\"postRow\">\r\n            ");
            EndContext();
            BeginContext(573, 14, false);
#line 20 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml"
       Write(Model.Category);

#line default
#line hidden
            EndContext();
            BeginContext(587, 48, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"bodypost\">");
            EndContext();
            BeginContext(636, 20, false);
#line 22 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml"
                         Write(Html.Raw(Model.Body));

#line default
#line hidden
            EndContext();
            BeginContext(656, 51, true);
            WriteLiteral("</div>\r\n        <div class=\"postRow\">\r\n            ");
            EndContext();
            BeginContext(708, 11, false);
#line 24 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml"
       Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(719, 61, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"postRow\">\r\n            ");
            EndContext();
            BeginContext(781, 13, false);
#line 27 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml"
       Write(Model.Created);

#line default
#line hidden
            EndContext();
            BeginContext(794, 49, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"postRow\">\r\n");
            EndContext();
#line 30 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml"
              
                await Html.RenderPartialAsync("_MainComment", new CommentViewModel { PostId = Model.Id, MainCommentId = 0 });
            

#line default
#line hidden
            BeginContext(1001, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 33 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml"
             foreach (var c in Model.MainComments)
            {

#line default
#line hidden
            BeginContext(1068, 41, true);
            WriteLiteral("                <p>\r\n                    ");
            EndContext();
            BeginContext(1110, 9, false);
#line 36 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml"
               Write(c.Message);

#line default
#line hidden
            EndContext();
            BeginContext(1119, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1123, 9, false);
#line 36 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml"
                            Write(c.Created);

#line default
#line hidden
            EndContext();
            BeginContext(1132, 90, true);
            WriteLiteral("\r\n                </p>\r\n                <div>\r\n                    <h4>Sub Comments</h4>\r\n");
            EndContext();
#line 40 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml"
                      
                        await Html.RenderPartialAsync("_MainComment", new CommentViewModel { PostId = Model.Id, MainCommentId = c.Id });
                    

#line default
#line hidden
            BeginContext(1407, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 43 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml"
                     foreach (var sc in c.SubComments)
                    {

#line default
#line hidden
            BeginContext(1486, 57, true);
            WriteLiteral("                        <p>\r\n                            ");
            EndContext();
            BeginContext(1544, 10, false);
#line 46 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml"
                       Write(sc.Message);

#line default
#line hidden
            EndContext();
            BeginContext(1554, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1558, 10, false);
#line 46 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml"
                                     Write(sc.Created);

#line default
#line hidden
            EndContext();
            BeginContext(1568, 32, true);
            WriteLiteral("\r\n                        </p>\r\n");
            EndContext();
#line 48 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml"
                    }

#line default
#line hidden
            BeginContext(1623, 24, true);
            WriteLiteral("                </div>\r\n");
            EndContext();
#line 50 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\Home\Post.cshtml"
            }

#line default
#line hidden
            BeginContext(1662, 36, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
