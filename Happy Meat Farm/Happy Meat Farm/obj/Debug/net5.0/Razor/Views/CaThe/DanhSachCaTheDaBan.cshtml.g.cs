#pragma checksum "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/CaThe/DanhSachCaTheDaBan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61fbbbae08573835605941dccdd9970011693ebf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CaThe_DanhSachCaTheDaBan), @"mvc.1.0.view", @"/Views/CaThe/DanhSachCaTheDaBan.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61fbbbae08573835605941dccdd9970011693ebf", @"/Views/CaThe/DanhSachCaTheDaBan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d09711060e35f0da6d1d9a1ccff3216366cccabb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CaThe_DanhSachCaTheDaBan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
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
        border: 1px solid #ccc;
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
        background-color: #e0e0e0;
    }

    .custom-button {
        backgro");
            WriteLiteral(@"und-color: #800000;
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

    h2 {
        color: #333;
        margin-bottom: 20px;
    }

    p {
        color: #666;
        margin-bottom: 10px;
    }

    h3 {
        margin-top: 20px;
    }

    h4 {
        margin-top: 10px;
    }

    .dotTiem {
        background-color: #f9f9f9;
        padding: 10px;
        margin-top: 10px;
    }
    .qr-");
            WriteLiteral(@"code-img.zoom {
        position: fixed;
        top: 50%;
        left: 50%;
        transform: translate(-50%, -50%);
        height: 100vh;
        width: 80vh;
        object-fit: contain;
        z-index: 9999;
    }

    .hidden {
        display: none;
    }

    .qr-code.zoom {
        width: 250px;
        height: 250px;
    }

    .qr-code-img {
        width: 100px;
        height: 100px;
        transition: all 0.2s ease-in-out;
    }
</style>

<h2 style=""text-align: center;"">Danh sách cá thể đã bán</h2>

");
#nullable restore
#line 136 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/CaThe/DanhSachCaTheDaBan.cshtml"
 if (Model.Count > 0)
{
    Dictionary<DateTime, List<CaThe>> groups = new Dictionary<DateTime, List<CaThe>>();

    foreach (var caThe in Model)
    {
        DateTime ngayBan = caThe.NgayBan.Date;

        if (!groups.ContainsKey(ngayBan))
        {
            groups[ngayBan] = new List<CaThe>();
        }

        groups[ngayBan].Add(caThe);
    }

    foreach (var group in groups.OrderByDescending(g => g.Key))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>Ngày bán: ");
#nullable restore
#line 154 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/CaThe/DanhSachCaTheDaBan.cshtml"
                 Write(group.Key.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n");
            WriteLiteral(@"        <table>
            <tr>
                <th style=""width: 250px; text-align: center;"">Mã QR</th>
                <th style=""width: 150px;"">Mã cá thể</th>
                <th style=""width: 300px;"">Đặc điểm</th>
                <th style=""width: 150px;"">Cân nặng</th>
                <th style=""width: 150px;"">Giá bán</th>
            </tr>
");
#nullable restore
#line 164 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/CaThe/DanhSachCaTheDaBan.cshtml"
             foreach (var caThe in group.Value)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td style=\"text-align: center; padding: 0;\">\n");
#nullable restore
#line 168 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/CaThe/DanhSachCaTheDaBan.cshtml"
                          
                            string data = caThe._id;
                            string detailUrl = Url.Action("Detail", "CaThe", new { id = caThe._id });
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"qr-code-button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3840, "\"", 3882, 4);
            WriteAttributeValue("", 3850, "toggleQrCode(this,", 3850, 18, true);
            WriteAttributeValue(" ", 3868, "\'", 3869, 2, true);
#nullable restore
#line 172 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/CaThe/DanhSachCaTheDaBan.cshtml"
WriteAttributeValue("", 3870, detailUrl, 3870, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3880, "\')", 3880, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\n                            Mã QR Code\n                        </button>\n                        <img class=\"qr-code-img hidden\"");
            BeginWriteAttribute("src", " src=\"", 4013, "\"", 4076, 1);
#nullable restore
#line 175 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/CaThe/DanhSachCaTheDaBan.cshtml"
WriteAttributeValue("", 4019, Url.Action("QrCodeImage", "BayDan", new { data = data }), 4019, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"120\" width=\"120\" />\n                    </td>\n                    <td>");
#nullable restore
#line 177 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/CaThe/DanhSachCaTheDaBan.cshtml"
                   Write(caThe.MaCT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 178 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/CaThe/DanhSachCaTheDaBan.cshtml"
                   Write(caThe.DacDiem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 179 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/CaThe/DanhSachCaTheDaBan.cshtml"
                   Write(caThe.CanNang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 180 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/CaThe/DanhSachCaTheDaBan.cshtml"
                   Write(caThe.GiaBan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 182 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/CaThe/DanhSachCaTheDaBan.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\n");
#nullable restore
#line 184 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/CaThe/DanhSachCaTheDaBan.cshtml"
    }
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Không có cá thể nào đã bán.</p>\n");
#nullable restore
#line 189 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/CaThe/DanhSachCaTheDaBan.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div style=\"height: 50px;\"></div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
