#pragma checksum "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\Shared\_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1490fa9a66c20813684420c99d7f0acfd089a255"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Header), @"mvc.1.0.view", @"/Views/Shared/_Header.cshtml")]
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
#line 1 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\_ViewImports.cshtml"
using CVManager.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\_ViewImports.cshtml"
using CVManager.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1490fa9a66c20813684420c99d7f0acfd089a255", @"/Views/Shared/_Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16fd243ca58f6648d004cc96c1b4d4c8adc7bf97", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<nav class=""navbar navbar-expand-sm bg-dark navbar-dark"">
    <!-- Brand/logo -->
    <a class=""navbar-brand"" href=""/"">CVBuilder</a>

    <!-- Links -->
    <ul class=""navbar-nav"">
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/post"">Việc làm</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/CVBuilder"">Tạo CV mới</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/cvmanager"">Quản lý CV</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/company"">Công ty</a>
        </li>
");
#nullable restore
#line 21 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\Shared\_Header.cshtml"
          
            var token = HttpContextAccessor.HttpContext.Request.Cookies["jwt"];
            if (token != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <li class=""nav-item dropdown text-center"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" id=""work"" data-toggle=""dropdown"">
                        Quản lý việc làm
                    </a>
                    <div class=""dropdown-menu"">
                        <a class=""dropdown-item"" href=""/contact/apply"">Đã ứng tuyển</a>
                        <a class=""dropdown-item"" href=""/contact/invited"">Lời mời</a>
                    </div>
                </li>
                <li class=""nav-item dropdown text-center"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbardrop"" data-toggle=""dropdown"">
                        Acount
                    </a>
                    <div class=""dropdown-menu"">
                        <a class=""dropdown-item"" href=""/profile"">Edit profile</a>
                        <button class=""dropdown-item logout-btn"">Logout</button>
                    </div>
                </li>
");
#nullable restore
#line 43 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\Shared\_Header.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"nav-item\">\r\n                    <a class=\"nav-link\" href=\"/user/login\">Login</a>\r\n                </li>\r\n");
#nullable restore
#line 49 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\Shared\_Header.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</nav>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
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
