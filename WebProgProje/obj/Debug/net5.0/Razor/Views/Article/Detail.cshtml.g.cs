#pragma checksum "C:\Users\Yusuf\source\repos\WebProgProje\WebProgProje\Views\Article\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02150733c786104a624b29a63f401281cef02060"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Article_Detail), @"mvc.1.0.view", @"/Views/Article/Detail.cshtml")]
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
#line 1 "C:\Users\Yusuf\source\repos\WebProgProje\WebProgProje\Views\_ViewImports.cshtml"
using WebProgProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yusuf\source\repos\WebProgProje\WebProgProje\Views\_ViewImports.cshtml"
using WebProgProje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02150733c786104a624b29a63f401281cef02060", @"/Views/Article/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e58e707594c9b0670c10115df9bdc79e0632ea4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Article_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Article>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Article", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    .center {
        margin: auto;
        width: 60%;
        border-radius: 15px;
        padding: 10px;
    }
</style>
<style>
    .radius {
        margin: auto;
        border: 2px solid #E5963C;
        border-radius: 15px;
        padding: 5px;
        background-color: #E9B757;
    }
</style>

<div class=""center"">
    <header>
        <h3>");
#nullable restore
#line 23 "C:\Users\Yusuf\source\repos\WebProgProje\WebProgProje\Views\Article\Detail.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </header>\r\n    <hr />\r\n    <div class=\"fa-image\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 482, "\"", 508, 2);
            WriteAttributeValue("", 488, "/images/", 488, 8, true);
#nullable restore
#line 27 "C:\Users\Yusuf\source\repos\WebProgProje\WebProgProje\Views\Article\Detail.cshtml"
WriteAttributeValue("", 496, Model.Image, 496, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" width=\"%60\" height=\"%45\" />\r\n    </div>\r\n    <div class=\"Date\" style=\"margin-top: 25px;\">\r\n        <i class=\"fa fa-clock-o\"></i>\r\n        ");
#nullable restore
#line 31 "C:\Users\Yusuf\source\repos\WebProgProje\WebProgProje\Views\Article\Detail.cshtml"
   Write(Model.DateOfAdding);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"Description\" style=\"margin-top: 25px;\">\r\n        <i>");
#nullable restore
#line 34 "C:\Users\Yusuf\source\repos\WebProgProje\WebProgProje\Views\Article\Detail.cshtml"
      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n    </div>\r\n\r\n    <div class=\"Content\" style=\"margin-top: 50px;\">\r\n        ");
#nullable restore
#line 38 "C:\Users\Yusuf\source\repos\WebProgProje\WebProgProje\Views\Article\Detail.cshtml"
   Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n<div class=\"center\">\r\n");
#nullable restore
#line 44 "C:\Users\Yusuf\source\repos\WebProgProje\WebProgProje\Views\Article\Detail.cshtml"
         foreach (var comment in ViewData["comments"] as IList<Comment>)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"show-comments\">\r\n                <div class=\"User-info\" style=\"margin-top:30px;\">\r\n                    <i>Düzenleyen Kişi: ");
#nullable restore
#line 48 "C:\Users\Yusuf\source\repos\WebProgProje\WebProgProje\Views\Article\Detail.cshtml"
                                   Write(comment.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                    <br />\r\n                    <i>Düzenlendiği Tarih: ");
#nullable restore
#line 50 "C:\Users\Yusuf\source\repos\WebProgProje\WebProgProje\Views\Article\Detail.cshtml"
                                      Write(comment.DateOfCommenting);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                </div>\r\n                <div class=\"radius\" style=\"margin-top:10px;\">\r\n                    <p style=\"padding:5px;\">\r\n                        ");
#nullable restore
#line 54 "C:\Users\Yusuf\source\repos\WebProgProje\WebProgProje\Views\Article\Detail.cshtml"
                   Write(comment.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 58 "C:\Users\Yusuf\source\repos\WebProgProje\WebProgProje\Views\Article\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n<div class=\"center comment\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02150733c786104a624b29a63f401281cef020608152", async() => {
                WriteLiteral("\r\n        <div>\r\n            <label for=\"Comment\" name=\"Comment\"></label>\r\n            <br />\r\n            <textarea for=\"Comment\" name=\"Comment\" class=\"form-control\" rows=\"4\" cols=\"100\"></textarea>\r\n            <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1902, "\"", 1926, 1);
#nullable restore
#line 70 "C:\Users\Yusuf\source\repos\WebProgProje\WebProgProje\Views\Article\Detail.cshtml"
WriteAttributeValue("", 1910, Model.ArticleId, 1910, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n        <div>\r\n            <br />\r\n            <button class=\"btn btn-primary\" type=\"submit\">Yorum Yap</button>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Article> Html { get; private set; }
    }
}
#pragma warning restore 1591