#pragma checksum "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/LichTiemChung/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d2c31fd0a31248949f28dad8586ab0501f62f45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LichTiemChung_Index), @"mvc.1.0.view", @"/Views/LichTiemChung/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d2c31fd0a31248949f28dad8586ab0501f62f45", @"/Views/LichTiemChung/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d09711060e35f0da6d1d9a1ccff3216366cccabb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LichTiemChung_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Happy_Meat_Farm.Models.LichTiemChung>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/LichTiemChung/Index.cshtml"
  
    ViewData["Title"] = "Lịch tiêm chủng ";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
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

    tr:hover {
        background-c");
            WriteLiteral(@"olor: #e0e0e0;
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
    .custom-button {
        background-color: #800000;
        color: white;
        text-decoration: none;
        border: none;
        border-radius: 5px;
        padding: 8px 16px;
        margin-right: 10px;
        box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
        transition: box-shadow 0.3s ease;
    }

        .custom-button:hover {
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);
        }
</style>
<h1>Danh sách các đợt tiêm chủng </");
            WriteLiteral("h1>\n<button class=\"custom-button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2234, "\"", 2288, 3);
            WriteAttributeValue("", 2244, "window.location.href=\'", 2244, 22, true);
#nullable restore
#line 97 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/LichTiemChung/Index.cshtml"
WriteAttributeValue("", 2266, Url.Action("Create"), 2266, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2287, "\'", 2287, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Thêm đợt tiêm chủng</button>
<table class=""table"">
    <thead>
        <tr>
            <th style=""width:250px""> Tên đợt tiêm  </th>
            <th style=""width:300px""> Ngày tuổi tiêm  </th>
            <th style=""width:300px""> Tùy chọn </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 107 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/LichTiemChung/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 111 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/LichTiemChung/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TenDotTiem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 114 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/LichTiemChung/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NgayTuoiTiem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n\n                <td>\n                    <button class=\"highlight\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2926, "\"", 2996, 3);
            WriteAttributeValue("", 2936, "location.href=\'", 2936, 15, true);
#nullable restore
#line 118 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/LichTiemChung/Index.cshtml"
WriteAttributeValue("", 2951, Url.Action("Edit", new { Name = item._id }), 2951, 44, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2995, "\'", 2995, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Chỉnh sửa</button>\n                    <button class=\"highlight\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3062, "\"", 3135, 3);
            WriteAttributeValue("", 3072, "location.href=\'", 3072, 15, true);
#nullable restore
#line 119 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/LichTiemChung/Index.cshtml"
WriteAttributeValue("", 3087, Url.Action("Details", new { Name = item._id }), 3087, 47, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3134, "\'", 3134, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Chi tiết</button>\n                    <button class=\"highlight\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3200, "\"", 3272, 3);
            WriteAttributeValue("", 3210, "location.href=\'", 3210, 15, true);
#nullable restore
#line 120 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/LichTiemChung/Index.cshtml"
WriteAttributeValue("", 3225, Url.Action("Delete", new { Name = item._id }), 3225, 46, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3271, "\'", 3271, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Xóa</button>\n                </td>\n            </tr>\n");
#nullable restore
#line 123 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/LichTiemChung/Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Happy_Meat_Farm.Models.LichTiemChung>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
