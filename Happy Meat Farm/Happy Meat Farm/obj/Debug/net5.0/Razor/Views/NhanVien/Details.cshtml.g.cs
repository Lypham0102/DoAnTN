#pragma checksum "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/NhanVien/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b383217a2824cc08916215a9cfda4b4060d5249"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanVien_Details), @"mvc.1.0.view", @"/Views/NhanVien/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b383217a2824cc08916215a9cfda4b4060d5249", @"/Views/NhanVien/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d09711060e35f0da6d1d9a1ccff3216366cccabb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_NhanVien_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Happy_Meat_Farm.Models.NhanVien>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/NhanVien/Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Chi tiết</h1>\n\n<div>\n    <h4>Thông tin nhân viên</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ID:\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 18 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/NhanVien/Details.cshtml"
       Write(Html.DisplayFor(model => model._id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Mã nhân viên:\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 24 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/NhanVien/Details.cshtml"
       Write(Html.DisplayFor(model => model.MaNV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Tên nhân viên:\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 30 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/NhanVien/Details.cshtml"
       Write(Html.DisplayFor(model => model.TenNV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            CCCD:\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 36 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/NhanVien/Details.cshtml"
       Write(Html.DisplayFor(model => model.CCCD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            SĐT:\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 42 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/NhanVien/Details.cshtml"
       Write(Html.DisplayFor(model => model.SDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Địa chỉ:\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 48 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/NhanVien/Details.cshtml"
       Write(Html.DisplayFor(model => model.DiaChi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Chức vụ:\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 54 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/NhanVien/Details.cshtml"
       Write(Html.DisplayFor(model => model.ChucVu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Hệ số lương:\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 60 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/NhanVien/Details.cshtml"
       Write(Html.DisplayFor(model => model.HeSoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Ngân hàng:\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 66 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/NhanVien/Details.cshtml"
       Write(Html.DisplayFor(model => model.NganHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            STK:\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 72 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/NhanVien/Details.cshtml"
       Write(Html.DisplayFor(model => model.STK));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Tên tài khoản:\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 78 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/NhanVien/Details.cshtml"
       Write(Html.DisplayFor(model => model.TenTaiKhoan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Mật khẩu:\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 84 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/NhanVien/Details.cshtml"
       Write(Html.DisplayFor(model => model.Passwork));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Happy_Meat_Farm.Models.NhanVien> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
