#pragma checksum "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\Post\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "190cf2d915f2bfd06985911f01f0d934fdc5b2d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Search), @"mvc.1.0.view", @"/Views/Post/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"190cf2d915f2bfd06985911f01f0d934fdc5b2d4", @"/Views/Post/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16fd243ca58f6648d004cc96c1b4d4c8adc7bf97", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<PostModel>, PostSearch>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/table.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/post/search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/postsearch.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\Post\Search.cshtml"
  
    //ViewData["Title"] = "Home Page";
    ViewData["Title"] = "Login";
    Layout = "_CVHomeLayout";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "190cf2d915f2bfd06985911f01f0d934fdc5b2d46797", async() => {
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
            WriteLiteral("\r\n\r\n<div class=\"container pt-5\">\r\n    <div class=\"form-search d-flex p-4\" style=\"height:100px; background-color: rgba(83, 87, 90, 0.8);\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "190cf2d915f2bfd06985911f01f0d934fdc5b2d48068", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-md-7"">
                    <input type=""text"" class=""name"" name=""title"" style=""height:45px; width: 100%; border-radius:3px; border: unset; text-indent: 1rem;"" placeholder=""Tên công việc, vị trí bạn muốn ứng tuyển""");
                BeginWriteAttribute("value", " value=\"", 676, "\"", 702, 1);
#nullable restore
#line 14 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\Post\Search.cshtml"
WriteAttributeValue("", 684, Model.Item2.Title, 684, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-md-3\">\r\n                    <select name=\"area\" class=\"area\" style=\"height:45px;width: 100%; border-radius:3px;\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "190cf2d915f2bfd06985911f01f0d934fdc5b2d49203", async() => {
                    WriteLiteral("Tất cả");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </select>\r\n                </div>\r\n                <div class=\"col-md-2 d-flex\">\r\n                    <button type=\"submit\" class=\"btn btn-success btn-search\">Tìm kiếm</button>\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 27 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\Post\Search.cshtml"
     if (Model.Item1.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1 class=\"text-center text-success mt-3\">Không có công việc phù hợp</h1>\r\n");
#nullable restore
#line 30 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\Post\Search.cshtml"
         if (Model.Item2.Page == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row mt-5"">
                <div class=""col-md-12 d-flex justify-content-center"">
                    <ul class=""pagination"">
                        <li class=""page-item""><button class=""page-link btn-prev"" disabled>Previous</button></li>
                        <li class=""page-item""><button class=""page-link btn-next"" disabled>Next</button></li>
                    </ul>
                </div>
            </div>
");
#nullable restore
#line 40 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\Post\Search.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row mt-5"">
                <div class=""col-md-12 d-flex justify-content-center"">
                    <ul class=""pagination"">
                        <li class=""page-item""><button class=""page-link btn-prev"">Previous</button></li>
                        <li class=""page-item""><button class=""page-link btn-next"" disabled>Next</button></li>
                    </ul>
                </div>
            </div>
");
#nullable restore
#line 51 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\Post\Search.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\Post\Search.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""list-job-wrapper  mt-5"">
            <table class=""table-fill"">
                <thead>
                    <tr>
                        <th class=""text-left"">Tên công ty</th>
                        <th class=""text-left"">Thông tin</th>
                        <th class=""text-left"">Khu vực</th>
                        <th class=""text-left"">Thao tác</th>
                    </tr>
                </thead>
                <tbody class=""table-hover"">
");
#nullable restore
#line 66 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\Post\Search.cshtml"
                     foreach (var p in Model.Item1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td class=\"text-left\">");
#nullable restore
#line 69 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\Post\Search.cshtml"
                                             Write(p.Company_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-left\">");
#nullable restore
#line 70 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\Post\Search.cshtml"
                                             Write(p.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-left\">");
#nullable restore
#line 71 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\Post\Search.cshtml"
                                             Write(p.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-center\"><a");
            BeginWriteAttribute("href", " href=\"", 3182, "\"", 3204, 2);
            WriteAttributeValue("", 3189, "/post/", 3189, 6, true);
#nullable restore
#line 72 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\Post\Search.cshtml"
WriteAttributeValue("", 3195, p.PostID, 3195, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Xem chi tiết</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 74 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\Post\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n");
#nullable restore
#line 79 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\Post\Search.cshtml"
         if (Model.Item2.Page == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row mt-5"">
                <div class=""col-md-12 d-flex justify-content-center"">
                    <ul class=""pagination"">
                        <li class=""page-item""><button class=""page-link btn-prev"" disabled>Previous</button></li>
                        <li class=""page-item""><button class=""page-link btn-next"">Next</button></li>
                    </ul>
                </div>
            </div>
");
#nullable restore
#line 89 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\Post\Search.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row mt-5"">
                <div class=""col-md-12 d-flex justify-content-center"">
                    <ul class=""pagination"">
                        <li class=""page-item""><button class=""page-link btn-prev"">Previous</button></li>
                        <li class=""page-item""><button class=""page-link btn-next"">Next</button></li>
                    </ul>
                </div>
            </div>
");
#nullable restore
#line 100 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\Post\Search.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\Post\Search.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "190cf2d915f2bfd06985911f01f0d934fdc5b2d418201", async() => {
                WriteLiteral("\r\n    <input class=\"title\" name=\"title\"");
                BeginWriteAttribute("value", " value=\"", 4459, "\"", 4485, 1);
#nullable restore
#line 106 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\Post\Search.cshtml"
WriteAttributeValue("", 4467, Model.Item2.Title, 4467, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    <input class=\"address\" name=\"address\"");
                BeginWriteAttribute("value", " value=\"", 4531, "\"", 4559, 1);
#nullable restore
#line 107 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\Post\Search.cshtml"
WriteAttributeValue("", 4539, Model.Item2.Address, 4539, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    <input class=\"page\" name=\"page\"");
                BeginWriteAttribute("value", " value=\"", 4599, "\"", 4624, 1);
#nullable restore
#line 108 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\Post\Search.cshtml"
WriteAttributeValue("", 4607, Model.Item2.Page, 4607, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "190cf2d915f2bfd06985911f01f0d934fdc5b2d421385", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<PostModel>, PostSearch>> Html { get; private set; }
    }
}
#pragma warning restore 1591
