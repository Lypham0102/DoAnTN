#pragma checksum "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/TTB/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89718d2959e4b711c57ee8eea051f2e805275299"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TTB_Index), @"mvc.1.0.view", @"/Views/TTB/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89718d2959e4b711c57ee8eea051f2e805275299", @"/Views/TTB/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d09711060e35f0da6d1d9a1ccff3216366cccabb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_TTB_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Happy_Meat_Farm.Models.TTBModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration: none; color: white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Export", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/TTB/Index.cshtml"
  
    ViewData["Title"] = "Trang thiết bị";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
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

    tr:hover {
        background-co");
            WriteLiteral(@"lor: #e0e0e0;
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
<h2 style=""text-align: center;"">Danh Sách Trang Thiết Bị</h2>
<button class=""custom-button"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89718d2959e4b711c57ee8eea051f2e8052752996368", async() => {
                WriteLiteral("Thêm thức ăn");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</button>
<div style=""height: 10px;""></div>
<table class=""table"">
    <thead>
        <tr>
            <th style=""width:180px""> Tên </th>
            <th style=""width:250px""> Loại </th>
            <th style=""width:250px""> Kích thước </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 105 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/TTB/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 109 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/TTB/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TenTrangThietBi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 112 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/TTB/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LoaiTrangThietBi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 115 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/TTB/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.KichThuoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    <button class=\"highlight\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2919, "\"", 2989, 3);
            WriteAttributeValue("", 2929, "location.href=\'", 2929, 15, true);
#nullable restore
#line 118 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/TTB/Index.cshtml"
WriteAttributeValue("", 2944, Url.Action("Edit", new { Name = item._id }), 2944, 44, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2988, "\'", 2988, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Chỉnh sửa</button>\n                    <button class=\"highlight\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3055, "\"", 3127, 3);
            WriteAttributeValue("", 3065, "location.href=\'", 3065, 15, true);
#nullable restore
#line 119 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/TTB/Index.cshtml"
WriteAttributeValue("", 3080, Url.Action("Details", new { Name = item._id}), 3080, 46, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3126, "\'", 3126, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Chi tiết</button>\n                    <button class=\"highlight\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3192, "\"", 3226, 3);
            WriteAttributeValue("", 3202, "showConfirm(\'", 3202, 13, true);
#nullable restore
#line 120 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/TTB/Index.cshtml"
WriteAttributeValue("", 3215, item._id, 3215, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3224, "\')", 3224, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Xóa</button>\n                </td>\n            </tr>\n            <script>\n                function showConfirm(name) {\n                    if (confirm(`Bạn muốn xóa trang thiết bị này không ${name} ?`)) {\n                        window.location.href = \"");
#nullable restore
#line 126 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/TTB/Index.cshtml"
                                           Write(Url.Action("Delete", new { Name = item._id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
                    } else {
                        let confirmMsg = document.getElementById(""confirm-msg"");
                        confirmMsg.innerHTML = `<span class=""confirm-msg"">Bạn đã hủy thao tác xóa thiết bị ${name}.</span>`;
                    }
                }
            </script>
");
            WriteLiteral("            <span id=\"confirm-msg\"></span>\n");
#nullable restore
#line 135 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/TTB/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n\n</table>\n<div style=\"text-align:right;\">\n    <div style=\"text-align:right;\">\n        <button class=\"custom-button\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89718d2959e4b711c57ee8eea051f2e80527529912336", async() => {
                WriteLiteral("Xuất Excel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </button>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Happy_Meat_Farm.Models.TTBModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
