#pragma checksum "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\MVC .NET CORE\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b35110f32a55756c8a62533e04f5a536ca97a17d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_AddHelper), @"mvc.1.0.view", @"/Views/Product/AddHelper.cshtml")]
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
#line 1 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\MVC .NET CORE\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\_ViewImports.cshtml"
using ControllerAndRoutingDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\MVC .NET CORE\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\_ViewImports.cshtml"
using ControllerAndRoutingDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35110f32a55756c8a62533e04f5a536ca97a17d", @"/Views/Product/AddHelper.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09bffa1383412f3568d4047e76a3d6543c5ea643", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_AddHelper : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\MVC .NET CORE\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml"
  
    String title = "Add Product using Helper method";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 7 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\MVC .NET CORE\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml"
Write(title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 8 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\MVC .NET CORE\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml"
 using (Html.BeginForm("SaveHelperRequest", "Product", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
#nullable restore
#line 11 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\MVC .NET CORE\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml"
   Write(Html.Label("Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;\r\n        ");
#nullable restore
#line 12 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\MVC .NET CORE\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml"
   Write(Html.TextBox("Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n        ");
#nullable restore
#line 15 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\MVC .NET CORE\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml"
   Write(Html.Label("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;\r\n        ");
#nullable restore
#line 16 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\MVC .NET CORE\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml"
   Write(Html.TextBox("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n        ");
#nullable restore
#line 19 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\MVC .NET CORE\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml"
   Write(Html.Label("Qty"));

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;\r\n        ");
#nullable restore
#line 20 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\MVC .NET CORE\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml"
   Write(Html.TextBox("Qty"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n        ");
#nullable restore
#line 23 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\MVC .NET CORE\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml"
   Write(Html.Label("Rate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;\r\n        ");
#nullable restore
#line 24 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\MVC .NET CORE\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml"
   Write(Html.TextBox("Rate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n<input type =\"submit\" value=\"Save\" />\r\n    </p>\r\n");
#nullable restore
#line 29 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\MVC .NET CORE\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
