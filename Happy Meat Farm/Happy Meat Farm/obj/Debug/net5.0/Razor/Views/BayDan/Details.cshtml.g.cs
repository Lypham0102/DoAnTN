#pragma checksum "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/BayDan/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f37b30d721312e2c3b7a66652e6478f90cfd488"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BayDan_Details), @"mvc.1.0.view", @"/Views/BayDan/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f37b30d721312e2c3b7a66652e6478f90cfd488", @"/Views/BayDan/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d09711060e35f0da6d1d9a1ccff3216366cccabb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_BayDan_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Happy_Meat_Farm.Models.BayDan>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/BayDan/Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>BayDan</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 15 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/BayDan/Details.cshtml"
       Write(Html.DisplayNameFor(model => model._id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 18 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/BayDan/Details.cshtml"
       Write(Html.DisplayFor(model => model._id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 21 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/BayDan/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Chuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 24 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/BayDan/Details.cshtml"
       Write(Html.DisplayFor(model => model.Chuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n\n<div>\n    <button class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 656, "\"", 702, 3);
            WriteAttributeValue("", 666, "location.href=\'", 666, 15, true);
#nullable restore
#line 30 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/BayDan/Details.cshtml"
WriteAttributeValue("", 681, Url.Action("Index"), 681, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 701, "\'", 701, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Back to List</button>\n    \n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Happy_Meat_Farm.Models.BayDan> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
