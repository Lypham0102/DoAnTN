#pragma checksum "/Users/dev/Library/Mobile Documents/com~apple~CloudDocs/Coding/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9653d57bcad8182079f56daaa41eefc39fec0ab"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9653d57bcad8182079f56daaa41eefc39fec0ab", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d09711060e35f0da6d1d9a1ccff3216366cccabb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/JavaScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/dev/Library/Mobile Documents/com~apple~CloudDocs/Coding/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Tổng quan trang trại";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""https://www.gstatic.com/firebasejs/8.2.9/firebase-app.js""></script>
<script src=""https://www.gstatic.com/firebasejs/8.2.9/firebase-database.js""></script>
<script src=""https://www.gstatic.com/firebasejs/8.6.7/firebase-analytics.js""></script>
<script src=""https://firebase.google.com/docs/web/learn-more#config-object""></script>
<script src=""https://firebase.google.com/docs/web/setup#available-libraries""></script>

<div>
    <h1>");
#nullable restore
#line 11 "/Users/dev/Library/Mobile Documents/com~apple~CloudDocs/Coding/DoAnTN/Happy Meat Farm/Happy Meat Farm/Views/Home/Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
</div>

<div class=""index-container"">
    <script src=""https://cdn.lordicon.com//libs/frhvbuzj/lord-icon-2.0.2.js""></script>

    <div class=""temperature box box1"">
        <h2>Nhiệt độ môi trường </h2>
        <a id=""temp""></a>
    </div>

    <div class=""revenue box box2"">
        <h2>Độ Ẩm </h2>
        <p id=""wet""></p>
    </div>
    <div class=""sochuong box box3"">
        <h2>Số lượng chuồng nuôi</h2>
        <p class=""value"">4 chuồng</p>
    </div>
    <div class=""vatnuoi box box4"">
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
            <li>Ngày [");
            WriteLiteral(@"XX/XX/XXXX] [mã chuồng] [loại thuốc]</li>
            <li>Ngày [XX/XX/XXXX] [mã chuồng] [loại thuốc]</li>
            <li>Ngày [XX/XX/XXXX] [mã chuồng] [loại thuốc]</li>
            <li>Ngày [XX/XX/XXXX] [mã chuồng] [loại thuốc]</li>
        </ul>
    </div>
</div>
<!--https://firebase.google.com/docs/web/setup#available-libraries -->
<script src=""https://www.gstatic.com/firebasejs/8.6.7/firebase-analytics.js""></script>
<script src=""https://www.gstatic.com/firebasejs/8.6.7/firebase-app.js""></script>
<script src=""https://www.gstatic.com/firebasejs/8.6.7/firebase-database.js""></script>

<script src=""https://firebase.google.com/docs/web/learn-more#config-object""></script>
<script src=""https://www.gstatic.com/firebasejs/8.6.7/firebase-app.js""></script>
<script src=""https://www.gstatic.com/firebasejs/8.6.7/firebase-database.js""></script>

<!-- TODO: Add SDKs for Firebase products that you want to use>
<script src=""https://firebase.google.com/docs/web/setup#available-libraries""></script>
=======
<!--https://firebas");
            WriteLiteral(@"e.google.com/docs/web/learn-more#config-object-->
<script src=""https://www.gstatic.com/firebasejs/8.6.7/firebase-app.js""></script>
<script src=""https://www.gstatic.com/firebasejs/8.6.7/firebase-database.js""></script>

<!-- TODO: Add SDKs for Firebase products that you want to usehttps://firebase.google.com/docs/web/setup#available-libraries -->
<script src=""https://www.gstatic.com/firebasejs/8.6.7/firebase-analytics.js""></script>

<script>// Your web app's Firebase configuration
    // For Firebase JS SDK v7.20.0 and later, measurementId is optional
    var firebaseConfig = {
        apiKey: ""AIzaSyCiSaknvNYmF3wd578-plD_5NWSA7PyjSY"",
        authDomain: ""esp8266-database-inventor.firebaseapp.com"",
        databaseURL: ""https://esp8266-database-inventor-default-rtdb.firebaseio.com"",
        projectId: ""esp8266-database-inventor"",
        storageBucket: ""esp8266-database-inventor.appspot.com"",
        messagingSenderId: ""423165376147"",
        appId: ""1:423165376147:web:01b7d90369ef89bd5bff66"",
        measurem");
            WriteLiteral(@"entId: ""G-6Y0CS5BME0""
    };
    // Initialize Firebase
    firebase.initializeApp(firebaseConfig);
    firebase.analytics();



    //functions
    // make sure that the name in ' ' match with name of your database child
    var temp = document.getElementById('temp');
    var dbRef = firebase.database().ref().child('TEMPERATURE');
    dbRef.on('value', snap => temp.innerText = snap.val());


    var wet = document.getElementById('wet');
    var dbRef2 = firebase.database().ref('HUMIDITY');
    dbRef2.on('value', snap => wet.innerHTML = snap.val());</script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9653d57bcad8182079f56daaa41eefc39fec0ab8334", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
