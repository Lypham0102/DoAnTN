<<<<<<< HEAD
#pragma checksum "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\Home\QuanLyNhanSu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22d67b14036f67730d30778e44058572fd5f9fb4"
=======
#pragma checksum "C:\Users\ASUS\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\Home\QuanLyNhanSu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc78ccc3c0ed08120d09d8521d7dfbeec325fb02"
>>>>>>> 4039dcd212299718b4102fcdb0ede2801875e001
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_QuanLyNhanSu), @"mvc.1.0.view", @"/Views/Home/QuanLyNhanSu.cshtml")]
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
<<<<<<< HEAD
#line 1 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\Home\QuanLyNhanSu.cshtml"
using PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\Home\QuanLyNhanSu.cshtml"
=======
#line 2 "C:\Users\ASUS\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\_ViewImports.cshtml"
>>>>>>> 4039dcd212299718b4102fcdb0ede2801875e001
using Happy_Meat_Farm.Models;

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
#nullable restore
#line 3 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\Home\QuanLyNhanSu.cshtml"
using Happy_Meat_Farm.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\Home\QuanLyNhanSu.cshtml"
using MongoDB.Bson;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22d67b14036f67730d30778e44058572fd5f9fb4", @"/Views/Home/QuanLyNhanSu.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc78ccc3c0ed08120d09d8521d7dfbeec325fb02", @"/Views/Home/QuanLyNhanSu.cshtml")]
>>>>>>> 4039dcd212299718b4102fcdb0ede2801875e001
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5349e7b0c7e850d7f5633e218477b16220312ca4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_QuanLyNhanSu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Happy_Meat_Farm.Models.NhanVien>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
<<<<<<< HEAD
#line 6 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\Home\QuanLyNhanSu.cshtml"
=======
#line 2 "C:\Users\ASUS\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\Home\QuanLyNhanSu.cshtml"
>>>>>>> 4039dcd212299718b4102fcdb0ede2801875e001
  
    ViewData["Title"] = "QuanLyNhanSu";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Danh sách nhân viên</h2>\r\n\r\n<p>\r\n    ");
#nullable restore
<<<<<<< HEAD
#line 14 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\Home\QuanLyNhanSu.cshtml"
Write(Html.ActionLink("Thêm Mới", ""));
=======
#line 10 "C:\Users\ASUS\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\Home\QuanLyNhanSu.cshtml"
Write(Html.ActionLink("Thêm Mới", "Themdienthoaimoi"));
>>>>>>> 4039dcd212299718b4102fcdb0ede2801875e001

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</p>
<table class=""table"" border=""1"">

    <tr>
        <th style=""width:100px""> Mã nhân viên </th>
        <th style=""width:200px""> Tên nhân viên </th>
        <th style=""width:120px""> CCCD </th>
        <th style=""width:120px""> SDT</th>
        <th style=""width:150px""> Địa chỉ </th>
    </tr>
    
<<<<<<< HEAD
    
=======


>>>>>>> 4039dcd212299718b4102fcdb0ede2801875e001
</table>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Happy_Meat_Farm.Models.NhanVien> Html { get; private set; }
    }
}
#pragma warning restore 1591
