#pragma checksum "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/Auth/UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "734065fbdb8b35482c92d79b3d8cd87dccc14bbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_UserProfile), @"mvc.1.0.view", @"/Views/Auth/UserProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"734065fbdb8b35482c92d79b3d8cd87dccc14bbb", @"/Views/Auth/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d09711060e35f0da6d1d9a1ccff3216366cccabb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Auth_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChuTrai>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>Thông tin người dùng</h2>\n\n<table>\n    <tr>\n        <th>Tên chủ trại:</th>\n        <td>");
#nullable restore
#line 8 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/Auth/UserProfile.cshtml"
       Write(Model.TenChuTrai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <th>Giới tính:</th>\n        <td>");
#nullable restore
#line 12 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/Auth/UserProfile.cshtml"
       Write(Model.GioiTinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <th>CCCD:</th>\n        <td>");
#nullable restore
#line 16 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/Auth/UserProfile.cshtml"
       Write(Model.CCCD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <th>Email:</th>\n        <td>");
#nullable restore
#line 20 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/Auth/UserProfile.cshtml"
       Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <th>Địa chỉ:</th>\n        <td>");
#nullable restore
#line 24 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/Auth/UserProfile.cshtml"
       Write(Model.DiaChi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <th>Số điện thoại:</th>\n        <td>");
#nullable restore
#line 28 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/Auth/UserProfile.cshtml"
       Write(Model.SDT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChuTrai> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
