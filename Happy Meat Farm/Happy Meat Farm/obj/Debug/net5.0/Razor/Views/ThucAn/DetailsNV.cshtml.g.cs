#pragma checksum "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/ThucAn/DetailsNV.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2d6917bb0fdb5d784e55f6d9811e64f630d2135"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ThucAn_DetailsNV), @"mvc.1.0.view", @"/Views/ThucAn/DetailsNV.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2d6917bb0fdb5d784e55f6d9811e64f630d2135", @"/Views/ThucAn/DetailsNV.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d09711060e35f0da6d1d9a1ccff3216366cccabb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ThucAn_DetailsNV : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Happy_Meat_Farm.Models.ThucAn>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/ThucAn/DetailsNV.cshtml"
  
    ViewData["Title"] = "Chi tiết";
    Layout = "~/Views/Shared/_LayoutNV.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    body {
        background-image: none;
        background-size: cover;
        background-position: center;
    }
</style>
<div class=""container"">
    <h1 class=""text-center mt-5 mb-4"">Chi tiết thức ăn</h1>
    <div class=""row"">
        <div class=""col-md-8 offset-md-2"">
            <div class=""card shadow"">
                <div class=""card-body"">
                    <h4 class=""card-title"">Thông tin thức ăn</h4>
                    <hr />
                    <dl class=""row"">
                        <dt class=""col-sm-3"">
                            ID:
                        </dt>
                        <dd class=""col-sm-9"">
                            ");
#nullable restore
#line 27 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/ThucAn/DetailsNV.cshtml"
                       Write(Html.DisplayFor(model => model._id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-3\">\n                            Tên thức ăn:\n                        </dt>\n                        <dd class=\"col-sm-9\">\n                            ");
#nullable restore
#line 33 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/ThucAn/DetailsNV.cshtml"
                       Write(Html.DisplayFor(model => model.TenHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-3\">\n                            Mã loại:\n                        </dt>\n                        <dd class=\"col-sm-9\">\n                            ");
#nullable restore
#line 39 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/ThucAn/DetailsNV.cshtml"
                       Write(Html.DisplayFor(model => model.MaLoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-3\">\n                            Khối lượng:\n                        </dt>\n                        <dd class=\"col-sm-9\">\n                            ");
#nullable restore
#line 45 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/ThucAn/DetailsNV.cshtml"
                       Write(Html.DisplayFor(model => model.KhoiLuongTinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-3\">\n                            Đối tượng:\n                        </dt>\n                        <dd class=\"col-sm-9\">\n                            ");
#nullable restore
#line 51 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/ThucAn/DetailsNV.cshtml"
                       Write(Html.DisplayFor(model => model.DoiTuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-3\">\n                            Đơn giá:\n                        </dt>\n                        <dd class=\"col-sm-9\">\n                            ");
#nullable restore
#line 57 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/ThucAn/DetailsNV.cshtml"
                       Write(Html.DisplayFor(model => model.DonGia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-3\">\n                            Hạn dùng:\n                        </dt>\n                        <dd class=\"col-sm-9\">\n                            ");
#nullable restore
#line 63 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/ThucAn/DetailsNV.cshtml"
                       Write(Html.DisplayFor(model => model.HanDung));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-3\">\n                            Số lượng:\n                        </dt>\n                        <dd class=\"col-sm-9\">\n                            ");
#nullable restore
#line 69 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/ThucAn/DetailsNV.cshtml"
                       Write(Html.DisplayFor(model => model.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-3\">\n                            Ngày tuổi:\n                        </dt>\n                        <dd class=\"col-sm-9\">\n                            ");
#nullable restore
#line 75 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/ThucAn/DetailsNV.cshtml"
                       Write(Html.DisplayFor(model => model.NgayTuoi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </dd>\n\n                    </dl>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n<div style=\"height: 50px;\"></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Happy_Meat_Farm.Models.ThucAn> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591