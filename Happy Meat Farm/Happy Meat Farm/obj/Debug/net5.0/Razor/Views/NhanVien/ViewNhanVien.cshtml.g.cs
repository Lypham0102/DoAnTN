#pragma checksum "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\ViewNhanVien.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1c53f8296f085f5b478b3d40f543368b453e149"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanVien_ViewNhanVien), @"mvc.1.0.view", @"/Views/NhanVien/ViewNhanVien.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1c53f8296f085f5b478b3d40f543368b453e149", @"/Views/NhanVien/ViewNhanVien.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5349e7b0c7e850d7f5633e218477b16220312ca4", @"/Views/_ViewImports.cshtml")]
    public class Views_NhanVien_ViewNhanVien : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Happy_Meat_Farm.Models.NhanVien>>
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
#line 3 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\ViewNhanVien.cshtml"
  
    ViewData["Title"] = "ViewNhanVien";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ViewNhanVien</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1c53f8296f085f5b478b3d40f543368b453e1493832", async() => {
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\ViewNhanVien.cshtml"
           Write(Html.DisplayNameFor(model => model.MaNV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\ViewNhanVien.cshtml"
           Write(Html.DisplayNameFor(model => model.TenNV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\ViewNhanVien.cshtml"
           Write(Html.DisplayNameFor(model => model.CCCD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\ViewNhanVien.cshtml"
           Write(Html.DisplayNameFor(model => model.SDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\ViewNhanVien.cshtml"
           Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\ViewNhanVien.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\ViewNhanVien.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaNV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\ViewNhanVien.cshtml"
           Write(Html.DisplayFor(modelItem => item.TenNV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\ViewNhanVien.cshtml"
           Write(Html.DisplayFor(modelItem => item.CCCD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\ViewNhanVien.cshtml"
           Write(Html.DisplayFor(modelItem => item.SDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\ViewNhanVien.cshtml"
           Write(Html.DisplayFor(modelItem => item.DiaChi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\ViewNhanVien.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new {Name = item.TenNV }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 54 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\ViewNhanVien.cshtml"
           Write(Html.ActionLink("Details", "Details", new {Name = item.TenNV }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 55 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\ViewNhanVien.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new {Name = item.TenNV }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 58 "C:\Users\ADMIN\Desktop\DoAnTN\Happy Meat Farm\Happy Meat Farm\Views\NhanVien\ViewNhanVien.cshtml"
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
