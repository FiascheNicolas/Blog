#pragma checksum "C:\Users\Nicolas\source\repos\Blog\Blog\Views\User\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5db7fa574e6a17170a35b22d2bf4d642d5c11198"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Users), @"mvc.1.0.view", @"/Views/User/Users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Users.cshtml", typeof(AspNetCore.Views_User_Users))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5db7fa574e6a17170a35b22d2bf4d642d5c11198", @"/Views/User/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f6dacf880d8b1262d2ea06921b70e4a8bd9f2a3", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\User\Users.cshtml"
 foreach (var i in Model) {

#line default
#line hidden
            BeginContext(61, 7, true);
            WriteLiteral("    <a>");
            EndContext();
            BeginContext(69, 10, false);
#line 4 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\User\Users.cshtml"
  Write(i.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(79, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 5 "C:\Users\Nicolas\source\repos\Blog\Blog\Views\User\Users.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591