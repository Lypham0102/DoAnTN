#pragma checksum "/Users/dev/Desktop/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/BayDan/BayDanShow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f80119767210d40b87d4ca474e79d16c102d10d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BayDan_BayDanShow), @"mvc.1.0.view", @"/Views/BayDan/BayDanShow.cshtml")]
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
#line 1 "/Users/dev/Desktop/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/_ViewImports.cshtml"
using Happy_Meat_Farm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/dev/Desktop/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/_ViewImports.cshtml"
using Happy_Meat_Farm.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f80119767210d40b87d4ca474e79d16c102d10d5", @"/Views/BayDan/BayDanShow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d09711060e35f0da6d1d9a1ccff3216366cccabb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_BayDan_BayDanShow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Happy_Meat_Farm.Models.CaThe>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/dev/Desktop/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/BayDan/BayDanShow.cshtml"
  
    ViewData["Title"] = "Bầy Đàn";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<table>\n    <tr>\n        <th>Mã Cá Thể</th>\n        <th>Tên Cá Thể</th>\n        <!-- ... -->\n    </tr>\n");
#nullable restore
#line 13 "/Users/dev/Desktop/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/BayDan/BayDanShow.cshtml"
     foreach (var caThe in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 16 "/Users/dev/Desktop/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/BayDan/BayDanShow.cshtml"
           Write(caThe.MaBayDan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 17 "/Users/dev/Desktop/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/BayDan/BayDanShow.cshtml"
           Write(caThe.NgayTuoi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <!-- ... -->\n        </tr>\n");
#nullable restore
#line 20 "/Users/dev/Desktop/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/BayDan/BayDanShow.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Happy_Meat_Farm.Models.CaThe>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591