#pragma checksum "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/VatNuoi/VatNuoi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b11e283d0f6fda48a7a807fbf351fda55dbcadf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VatNuoi_VatNuoi), @"mvc.1.0.view", @"/Views/VatNuoi/VatNuoi.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b11e283d0f6fda48a7a807fbf351fda55dbcadf1", @"/Views/VatNuoi/VatNuoi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d09711060e35f0da6d1d9a1ccff3216366cccabb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_VatNuoi_VatNuoi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Happy_Meat_Farm.Models.CaThe>>
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
            WriteLiteral("\n\n");
#nullable restore
#line 4 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/VatNuoi/VatNuoi.cshtml"
  
    ViewData["Title"] = "Vật Nuôi";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<p><h2 style=""margin-left: 320px"">Thông tin vật nuôi</h2></p>
<div style=""margin-left:280px; height: 200px; margin-top:5px"" class=""daily-report"">
    <ul>
        <li>Tổng cá thể: [92]</li>
        <li>Tổng số bầy: [4]</li>
        <li>Số lượng heo giống: [2]</li>
        <li>Số lượng heo con: [40]</li>
        <li>Số lượng heo thịt: [50]</li>
    </ul>
</div>
<div><h3>Danh sách cá thể</h3></div>
<p>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b11e283d0f6fda48a7a807fbf351fda55dbcadf14185", async() => {
                WriteLiteral("Thêm cá thể");
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
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 27 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/VatNuoi/VatNuoi.cshtml"
           Write(Html.DisplayNameFor(model => model._id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 30 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/VatNuoi/VatNuoi.cshtml"
           Write(Html.DisplayNameFor(model => model.DacDiem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 33 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/VatNuoi/VatNuoi.cshtml"
           Write(Html.DisplayNameFor(model => model.NgayTuoi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 36 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/VatNuoi/VatNuoi.cshtml"
           Write(Html.DisplayNameFor(model => model.Chuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 42 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/VatNuoi/VatNuoi.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 46 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/VatNuoi/VatNuoi.cshtml"
               Write(Html.DisplayFor(modelItem => item._id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 49 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/VatNuoi/VatNuoi.cshtml"
               Write(Html.DisplayFor(modelItem => item.DacDiem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 52 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/VatNuoi/VatNuoi.cshtml"
               Write(Html.DisplayFor(modelItem => item.NgayTuoi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 55 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/VatNuoi/VatNuoi.cshtml"
               Write(Html.DisplayFor(modelItem => item.Chuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 58 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/VatNuoi/VatNuoi.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new {  Name = item._id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                    ");
#nullable restore
#line 59 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/VatNuoi/VatNuoi.cshtml"
               Write(Html.ActionLink("Details", "Details", new {  Name = item._id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                    ");
#nullable restore
#line 60 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/VatNuoi/VatNuoi.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new {  Name = item._id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 63 "/Users/phamcongly/Documents/GitHub/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/VatNuoi/VatNuoi.cshtml"
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
