#pragma checksum "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2297714fa4e269dec2ab75c241f9209954896152"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanVien_Index), @"mvc.1.0.view", @"/Views/NhanVien/Index.cshtml")]
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
#line 1 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\_ViewImports.cshtml"
using Happy_Meat_Farm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\_ViewImports.cshtml"
using Happy_Meat_Farm.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2297714fa4e269dec2ab75c241f9209954896152", @"/Views/NhanVien/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5349e7b0c7e850d7f5633e218477b16220312ca4", @"/Views/_ViewImports.cshtml")]
    public class Views_NhanVien_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Happy_Meat_Farm.Models.NhanVien>>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Danh sách nhân viên</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2297714fa4e269dec2ab75c241f92099548961523790", async() => {
                WriteLiteral("Thêm nhân viên");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\"\">\r\n    <thead>\r\n        <tr>\r\n            <th style=\"width:180px\"> Mã nhân viên </th>\r\n            <th style=\"width:250px\"> Tên nhân viên </th>\r\n");
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 24 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 30 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaNV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TenNV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\Index.cshtml"
           Write(Html.ActionLink("Chỉnh sửa", "Edit", new { Name = item.TenNV }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 46 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\Index.cshtml"
           Write(Html.ActionLink("Chi tiết", "Details", new { Name = item.TenNV }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 47 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\Index.cshtml"
           Write(Html.ActionLink("Xóa", "Delete", new { Name = item.TenNV }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 50 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Happy_Meat_Farm.Models.NhanVien>> Html { get; private set; }
    }
}
#pragma warning restore 1591
