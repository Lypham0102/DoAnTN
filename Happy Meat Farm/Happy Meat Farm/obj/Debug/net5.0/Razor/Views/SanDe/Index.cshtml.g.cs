#pragma checksum "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/SanDe/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47b84a47e218fcb71d0890cf5c1e7b3911cf5c59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanDe_Index), @"mvc.1.0.view", @"/Views/SanDe/Index.cshtml")]
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
#line 1 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/_ViewImports.cshtml"
using Happy_Meat_Farm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/_ViewImports.cshtml"
using Happy_Meat_Farm.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b84a47e218fcb71d0890cf5c1e7b3911cf5c59", @"/Views/SanDe/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d09711060e35f0da6d1d9a1ccff3216366cccabb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SanDe_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Happy_Meat_Farm.Models.SanDe>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #800000; color: white; border: 1px solid #800000; box-shadow: 0 2px 4px rgba(0, 0, 0, 0.4);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/SanDe/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 style=""text-align: center; color: gray;"">Danh sách bầy đàn</h1>
<style>
    body {
        background-image: none;
        background-color: #f5f5f5;
        font-family: Arial, sans-serif;
    }

    h1 {
        text-align: center;
        margin-top: 20px;
        color: #333;
    }

    table {
        width: 100%;
        border-collapse: collapse;
        margin-top: 10px;
        background-color: #fff;
        box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
        /*        border: 1px solid #ccc;*/
        border-radius: 10px; /* Thêm border-radius để bo góc bảng */
        transition: box-shadow 0.3s ease;
    }

        table:hover {
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2); /* Hiệu ứng đổ bóng khi di chuột vào */
        }

    th {
        background-color: #f8f8f8;
        color: #333;
        font-weight: bold;
        padding: 10px;
        text-align: left;
    }

    td {
        padding: 10px;
    }

    tr:nth-child(even) {
        background-color: #f2f2f2;
    }

    tr:hover");
            WriteLiteral(@" {
        background-color: #e0e0e0;
    }

    .custom-button {
        background-color: #800000;
        color: white;
        text-decoration: none;
        border: none;
        border-radius: 5px;
        padding: 8px 16px;
        margin-right: 10px;
    }

    .confirm-msg {
        color: red;
    }

    .highlight {
        border: none;
        background-color: #FAF0E6;
        color: black;
        padding: 2px 4px;
        border-radius: 20px;
        box-shadow: 0px 1px 2px rgba(0, 0, 0, 0.4);
    }

    .highlight-phoi {
        background-color: #FFE4B5;
    }

    .btn-custom {
        background-color: #FF9999;
        border: 1px solid #ccc;
        /* Viền màu xám */
        box-shadow: 2px 2px 4px rgba(0, 0, 0, 0.3);
        /* Bóng */
    }
</style>
<p>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47b84a47e218fcb71d0890cf5c1e7b3911cf5c596392", async() => {
                WriteLiteral("Thêm chuồng nuôi");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n\n            <th style=\"width:180px\"> Mã sàn </th>\n            <th style=\"width:280px\"> Số sàn  </th>\n            <th style=\"width:280px\"> Tuỳ chọn  </th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 105 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/SanDe/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n\n                <td>\n                    ");
#nullable restore
#line 110 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/SanDe/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.MaSanDe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 113 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/SanDe/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SoSanDe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n\n                    <button class=\"highlight\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2728, "\"", 2798, 3);
            WriteAttributeValue("", 2738, "location.href=\'", 2738, 15, true);
#nullable restore
#line 117 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/SanDe/Index.cshtml"
WriteAttributeValue("", 2753, Url.Action("Edit", new { Name = item._id }), 2753, 44, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2797, "\'", 2797, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Sửa</button>\n\n                    <button class=\"highlight\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2859, "\"", 2932, 3);
            WriteAttributeValue("", 2869, "location.href=\'", 2869, 15, true);
#nullable restore
#line 119 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/SanDe/Index.cshtml"
WriteAttributeValue("", 2884, Url.Action("Details", new { Name = item._id }), 2884, 47, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2931, "\'", 2931, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Chi tiết bầy</button>\n\n                    <button class=\"highlight\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3002, "\"", 3092, 3);
            WriteAttributeValue("", 3012, "location.href=\'", 3012, 15, true);
#nullable restore
#line 121 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/SanDe/Index.cshtml"
WriteAttributeValue("", 3027, Url.Action("CacCaThe", new { Name = "Sàn đẻ " + item.SoSanDe }), 3027, 64, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3091, "\'", 3091, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Các cá thể</button>\n\n                </td>\n            </tr>\n");
#nullable restore
#line 125 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/SanDe/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n<div style=\"height: 50px;\"></div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Happy_Meat_Farm.Models.SanDe>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591