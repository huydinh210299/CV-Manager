#pragma checksum "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\CVBuilder\CVBuilder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cce7fdae3364c72907b59382c99e5ca166bf8ccb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CVBuilder_CVBuilder), @"mvc.1.0.view", @"/Views/CVBuilder/CVBuilder.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cce7fdae3364c72907b59382c99e5ca166bf8ccb", @"/Views/CVBuilder/CVBuilder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16fd243ca58f6648d004cc96c1b4d4c8adc7bf97", @"/Views/_ViewImports.cshtml")]
    public class Views_CVBuilder_CVBuilder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "20", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "40", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "60", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "80", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "100", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-save-cv"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\20201\projectIII\CVManager\CVManager.WebApp\Views\CVBuilder\CVBuilder.cshtml"
  
    //ViewData["Title"] = "Home Page";
    ViewData["Title"] = "CVBuilder";
    Layout = "_CVBuilderLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""cv-builder-wrapper"">
    <div class=""cv-builder-toolbar"">
        <div class=""toolbar-item"">
            <div class=""toolbar-title"">Thêm mục</div>
            <div class=""toolbar-icon icon-add""></div>
        </div>
        <div class=""toolbar-item save-cv"">
            <div class=""toolbar-title"">Lưu CV</div>
            <div class=""toolbar-icon icon-save""></div>
        </div>
        <div class=""toolbar-item cancel-cv-template"">
            <div class=""toolbar-title"">Bỏ mẫu CV</div>
            <div class=""toolbar-icon icon-cancel""></div>
        </div>
    </div>
    <div class=""cv-builder-container"">
        <div class=""cv-builder-layout"">
            <div id=""cv-tittle"">My CV</div>
            <div id=""gjs"" name=""gjs"">

            </div>
        </div>
        <div class=""cv-builder-suggestion"">
            <div class=""cv-builder-switch-menu"">
                <div class=""cv-builder-switch-menu-item active"" tab-name=""template"">
                    <div class=""switch-m");
            WriteLiteral(@"enu-title"">Mẫu CV</div>
                    <div class=""switch-menu-icon icon-template""></div>
                </div>
                <div class=""cv-builder-switch-menu-item"" tab-name=""suggest"">
                    <div class=""switch-menu-title"">Gợi ý</div>
                    <div class=""switch-menu-icon icon-suggest""></div>
                </div>
                <div class=""cv-builder-switch-menu-item"" tab-name=""style"">
                    <div class=""switch-menu-title"">Chỉnh sửa</div>
                    <div class=""switch-menu-icon icon-edit""></div>
                </div>
            </div>
            <div class=""cv-builder-suggestion-content"">
                <div class=""template-content"" id=""blocks""></div>
                <div class=""suggest-content"">
                    <div class=""suggestion-title-wrap"">
                        <div class=""suggestion-icon""></div>
                        <h4 class=""suggestion-title"">Hướng dẫn</h4>
                    </div>
                    <div ");
            WriteLiteral(@"class=""suggestion-body"" style=""padding : 10px 0"">
                        <h4>Lưu ý: Kéo mẫu CV cần dùng vào khung!</h4> <br />
                        1. Điền đầy đủ các thông tin hiển thị trong CV<br />
                        2. Bấm nút Lưu CV<br />
                        3. Xem & Tải CV về máy<br />
                        Một số lưu ý chung:<br />
                        &nbsp;•Sắp xếp thời gian theo thứ tự mới -> cũ.<br />
                        &nbsp;•Ưu tiên những gì quan trọng, có liên quan đến vị trí ứng tuyển lên đầu.<br />
                        &nbsp;•Ngày tháng nên dùng: 01/2016, 01-2016 hoặc Jan 2016
                    </div>
                    <div class=""suggestion-footer"">
                        Mọi chi tiết vui lòng liên hệ<br />
                        Email: dinhlun99hy@gmail.com
                    </div>
                </div>
                <div class=""style-content"">
                    <div class=""progress-style advance-style"">
                        <div cla");
            WriteLiteral("ss=\"advance-style-label\">Progress</div>\r\n                        <select name=\"progress-value\" class=\"progress-value\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cce7fdae3364c72907b59382c99e5ca166bf8ccb8871", async() => {
                WriteLiteral("1/5");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cce7fdae3364c72907b59382c99e5ca166bf8ccb10055", async() => {
                WriteLiteral("2/5");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cce7fdae3364c72907b59382c99e5ca166bf8ccb11240", async() => {
                WriteLiteral("3/5");
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
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cce7fdae3364c72907b59382c99e5ca166bf8ccb12425", async() => {
                WriteLiteral("4/5");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cce7fdae3364c72907b59382c99e5ca166bf8ccb13610", async() => {
                WriteLiteral("5/5");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </select>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- Button to Open the Modal -->
<button type=""button"" class=""btn btn-primary btn-open-modal-create"" data-toggle=""modal"" data-target=""#modal-save-cv"" hidden>
    Open modal
</button>

<!-- The Modal -->
<div class=""modal"" id=""modal-save-cv"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content "">

            <!-- Modal Header -->
            <div class=""modal-header"">
                <h4 class=""modal-title"">Lưu CV</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>

            <!-- Modal body -->
            <div class=""modal-body"">
                <input type=""text"" class=""cv-name"" placeholder=""Tên của CV"" style="" width: 100%; border-radius: 4px; border: 1px solid black;""/>
            </div>

            <!-- Modal footer -->
            <div c");
            WriteLiteral("lass=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-primary btn-save-cv\" data-dismiss=\"modal\">Lưu CV</button>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cce7fdae3364c72907b59382c99e5ca166bf8ccb16073", async() => {
                WriteLiteral(@"
    <input hidden class=""type"" name=""type"" />
    <input hidden class=""name"" name=""name"" />
    <input hidden class=""phone"" name=""phone"" />
    <input hidden class=""email"" name=""email"" />
    <input hidden class=""html"" name=""html"" />
    <input hidden class=""css"" name=""css"" />
    <input hidden class=""avata"" name=""avata"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
