#pragma checksum "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/BayDan/Inf.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b1e7f614756f6430914a9c6632f5ed1f5d349d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BayDan_Inf), @"mvc.1.0.view", @"/Views/BayDan/Inf.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b1e7f614756f6430914a9c6632f5ed1f5d349d9", @"/Views/BayDan/Inf.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d09711060e35f0da6d1d9a1ccff3216366cccabb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_BayDan_Inf : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Happy_Meat_Farm.Models.CaThe>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/BayDan/Inf.cshtml"
  
    ViewData["Title"] = "Inf";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Danh sách cá thể </h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b1e7f614756f6430914a9c6632f5ed1f5d349d93773", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th style=""width:180px""> Mã Cá Thể  </th>
            <th style=""width:180px"">Đặc Điểm </th>
            <th style=""width:180px""> Ngày Tuổi  </th>
            
            <th style=""width:380px""> Tuỳ chọn  </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 25 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/BayDan/Inf.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 28 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/BayDan/Inf.cshtml"
           Write(Html.DisplayFor(modelItem => item._id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 31 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/BayDan/Inf.cshtml"
           Write(Html.DisplayFor(modelItem => item.DacDiem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 34 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/BayDan/Inf.cshtml"
           Write(Html.DisplayFor(modelItem => item.NgayTuoi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            \n");
            WriteLiteral("        <td>\n            <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1033, "\"", 1093, 1);
#nullable restore
#line 41 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/BayDan/Inf.cshtml"
WriteAttributeValue("", 1040, Url.Action("Edit", new { /* id=item.PrimaryKey */ }), 1040, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sửa</a>\n\n            <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1142, "\"", 1205, 1);
#nullable restore
#line 43 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/BayDan/Inf.cshtml"
WriteAttributeValue("", 1149, Url.Action("Details", new { /* id=item.PrimaryKey */ }), 1149, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Chi tiết</a>\n\n            <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1258, "\"", 1320, 1);
#nullable restore
#line 45 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/BayDan/Inf.cshtml"
WriteAttributeValue("", 1265, Url.Action("Delete", new { /* id=item.PrimaryKey */ }), 1265, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Xoá đối tượng này khỏi bầy đàn?\')\">Chết</a>\n        </td>\n        </tr>\n");
#nullable restore
#line 48 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/BayDan/Inf.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
