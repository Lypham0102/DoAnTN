#pragma checksum "/Users/dev/Library/Mobile Documents/com~apple~CloudDocs/Coding/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/TTB/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcf4956226668c26f88fe0bd121b414523b5cc3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TTB_Index), @"mvc.1.0.view", @"/Views/TTB/Index.cshtml")]
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
#line 1 "/Users/dev/Library/Mobile Documents/com~apple~CloudDocs/Coding/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/_ViewImports.cshtml"
using Happy_Meat_Farm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/dev/Library/Mobile Documents/com~apple~CloudDocs/Coding/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/_ViewImports.cshtml"
using Happy_Meat_Farm.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcf4956226668c26f88fe0bd121b414523b5cc3b", @"/Views/TTB/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d09711060e35f0da6d1d9a1ccff3216366cccabb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_TTB_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Happy_Meat_Farm.Models.TTBModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "/Users/dev/Library/Mobile Documents/com~apple~CloudDocs/Coding/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/TTB/Index.cshtml"
  
    ViewData["Title"] = "Trang thiết bị";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Danh Sách Trang Thiết Bị</h2>

<table class=""table"">
    <thead>
        <tr>
            <th style=""width:250px""> Tên </th>
            <th style=""width:250px""> Loại </th>
            <th style=""width:250px""> Kích thước </th>
            <th style=""width:250px""> Chất Liệu  </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "/Users/dev/Library/Mobile Documents/com~apple~CloudDocs/Coding/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/TTB/Index.cshtml"
         if (Model != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "/Users/dev/Library/Mobile Documents/com~apple~CloudDocs/Coding/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/TTB/Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        ");
#nullable restore
#line 26 "/Users/dev/Library/Mobile Documents/com~apple~CloudDocs/Coding/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/TTB/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TenTrangThietBi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 29 "/Users/dev/Library/Mobile Documents/com~apple~CloudDocs/Coding/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/TTB/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LoaiTrangThietBi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 32 "/Users/dev/Library/Mobile Documents/com~apple~CloudDocs/Coding/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/TTB/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.KichThuoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 35 "/Users/dev/Library/Mobile Documents/com~apple~CloudDocs/Coding/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/TTB/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ChatLieu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 38 "/Users/dev/Library/Mobile Documents/com~apple~CloudDocs/Coding/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/TTB/Index.cshtml"
                   Write(Html.ActionLink("Chỉnh sửa", "Edit", new { Name = item.TenTrangThietBi}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                        ");
#nullable restore
#line 39 "/Users/dev/Library/Mobile Documents/com~apple~CloudDocs/Coding/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/TTB/Index.cshtml"
                   Write(Html.ActionLink("Chi tiết", "Details", new { Name = item.TenTrangThietBi }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                        ");
#nullable restore
#line 40 "/Users/dev/Library/Mobile Documents/com~apple~CloudDocs/Coding/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/TTB/Index.cshtml"
                   Write(Html.ActionLink("Xóa", "Delete", new { Name = item.TenTrangThietBi }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                </tr>\n");
#nullable restore
#line 43 "/Users/dev/Library/Mobile Documents/com~apple~CloudDocs/Coding/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/TTB/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "/Users/dev/Library/Mobile Documents/com~apple~CloudDocs/Coding/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/TTB/Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n</table>\n<button class=\"btn btn-primary\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcf4956226668c26f88fe0bd121b414523b5cc3b8313", async() => {
                WriteLiteral("Thêm trang thiết bị ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</button>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Happy_Meat_Farm.Models.TTBModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
