#pragma checksum "C:\Users\ASUS\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36c40759cef30ed6b2fb6b1205de9d1e7ca878ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\_ViewImports.cshtml"
using Happy_Meat_Farm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\_ViewImports.cshtml"
using Happy_Meat_Farm.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36c40759cef30ed6b2fb6b1205de9d1e7ca878ee", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5349e7b0c7e850d7f5633e218477b16220312ca4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ASUS\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Tổng quan";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1>");
#nullable restore
#line 6 "C:\Users\ASUS\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\Home\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
</div>
<div class=""index-container"">
    <div class=""temperature box"">
        <h2>Nhiệt độ môi trường</h2>
        <p class=""value"">25 độ C</p>
    </div>
    <div class=""revenue box"">
        <h2>Thống kê doanh thu</h2>
        <p class=""value"">$50,000</p>
    </div>
    <div class=""sochuong box"">
        <h2>Số lượng chuồng nuôi</h2>
        <p class=""value"">4 chuồng</p>
    </div>
    <div class=""vatnuoi box"">
        <h2>Số lượng vật nuôi</h2>
        <p class=""value"">20 con</p>
    </div>
    <div class=""daily-report"">
        <h2>Thông tin trang trại</h2>
        <ul>
            <li>Số nhân viên: [Số lượng nhân viên]</li>
            <li>Số lượng heo giống: [Số lượng heo giống]</li>
            <li>Số lượng heo con: [Số lượng heo con]</li>
            <li>Số lượng heo thịt: [Số lượng heo thịt]</li>
        </ul>
    </div>
    <div class=""daily-report"">
        <h2>Lịch tiêm chủng</h2>
        <ul>
            <li>Ngày [XX/XX/XXXX] [mã chuồng] [loại thuốc]</li>
  ");
            WriteLiteral("          <li>Ngày [XX/XX/XXXX] [mã chuồng] [loại thuốc]</li>\r\n            <li>Ngày [XX/XX/XXXX] [mã chuồng] [loại thuốc]</li>\r\n            <li>Ngày [XX/XX/XXXX] [mã chuồng] [loại thuốc]</li>\r\n        </ul>\r\n    </div>\r\n</div>\r\n\r\n");
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
