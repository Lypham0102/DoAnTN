#pragma checksum "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/CaThe/QRCheck.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0708dc6b15dcc957371face6e8287b078dc9917a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CaThe_QRCheck), @"mvc.1.0.view", @"/Views/CaThe/QRCheck.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0708dc6b15dcc957371face6e8287b078dc9917a", @"/Views/CaThe/QRCheck.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d09711060e35f0da6d1d9a1ccff3216366cccabb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CaThe_QRCheck : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Happy_Meat_Farm.Models.CaThe>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/CaThe/QRCheck.cshtml"
  
    ViewData["Title"] = "Chi tiết";
    Layout = "~/Views/Shared/_LayoutBlank.cshtml";

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
    <h1 class=""text-center mt-5 mb-4"">Chi tiết cá thể</h1>
    <div class=""row"">
        <div class=""col-md-8 offset-md-2"">
            <div class=""card shadow"">
                <div class=""card-body"">
                    <h4 class=""card-title"">Thông tin cá thể</h4>
                    <hr />
                    <dl class=""row"">
                        <dt class=""col-sm-3"">
                            ID:
                        </dt>
                        <dd class=""col-sm-9"">
                            ");
#nullable restore
#line 27 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/CaThe/QRCheck.cshtml"
                       Write(Html.DisplayFor(model => model._id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-3\">\n                            Ngày nuôi:\n                        </dt>\n                        <dd class=\"col-sm-9\">\n                            ");
#nullable restore
#line 33 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/CaThe/QRCheck.cshtml"
                       Write(Html.DisplayFor(model => model.NgayNuoi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-3\">\n                            Cân nặng:\n                        </dt>\n                        <dd class=\"col-sm-9\">\n                            ");
#nullable restore
#line 39 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/CaThe/QRCheck.cshtml"
                       Write(Html.DisplayFor(model => model.CanNang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-3\">\n                            Đặc điểm:\n                        </dt>\n                        <dd class=\"col-sm-9\">\n                            ");
#nullable restore
#line 45 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/CaThe/QRCheck.cshtml"
                       Write(Html.DisplayFor(model => model.DacDiem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-3\">\n                            Ngày tuổi:\n                        </dt>\n                        <dd class=\"col-sm-9\">\n                            ");
#nullable restore
#line 51 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/CaThe/QRCheck.cshtml"
                       Write(Html.DisplayFor(model => model.NgayTuoi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-3\">\n                            Tình trạng sức khỏe:\n                        </dt>\n                        <dd class=\"col-sm-9\">\n                            ");
#nullable restore
#line 57 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/CaThe/QRCheck.cshtml"
                       Write(Html.DisplayFor(model => model.TinhTrangSucKhoe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-3\">\n                            Thức ăn:\n                        </dt>\n                        <dd class=\"col-sm-9\">\n                            ");
#nullable restore
#line 63 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/CaThe/QRCheck.cshtml"
                       Write(Html.DisplayFor(model => model.ThucAn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-3\">\n                            Ngày bán:\n                        </dt>\n                        <dd class=\"col-sm-9\">\n                            ");
#nullable restore
#line 69 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/CaThe/QRCheck.cshtml"
                       Write(Html.DisplayFor(model => model.NgayBan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-3\">\n                            Giá bán:\n                        </dt>\n                        <dd class=\"col-sm-9\">\n                            ");
#nullable restore
#line 75 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/CaThe/QRCheck.cshtml"
                       Write(Html.DisplayFor(model => model.GiaBan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </dd>\n                    </dl>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n<div style=\"height: 50px;\"></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Happy_Meat_Farm.Models.CaThe> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
