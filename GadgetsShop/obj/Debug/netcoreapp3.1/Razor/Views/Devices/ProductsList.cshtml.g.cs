#pragma checksum "D:\Programming\DevicesShop\GadgetsShop\Views\Devices\ProductsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c185a8876c56fc51c07cb6f8ce81fd88a262d0a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Devices_ProductsList), @"mvc.1.0.view", @"/Views/Devices/ProductsList.cshtml")]
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
#line 1 "D:\Programming\DevicesShop\GadgetsShop\Views\_ViewImports.cshtml"
using DevicesShop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c185a8876c56fc51c07cb6f8ce81fd88a262d0a4", @"/Views/Devices/ProductsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12432a9491968fa5631ea5300f16ee1d4c97d86d", @"/Views/_ViewImports.cshtml")]
    public class Views_Devices_ProductsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>All devices</h1>\r\n<h3>");
#nullable restore
#line 3 "D:\Programming\DevicesShop\GadgetsShop\Views\Devices\ProductsList.cshtml"
Write(Model.CurrentCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 4 "D:\Programming\DevicesShop\GadgetsShop\Views\Devices\ProductsList.cshtml"
   
    foreach(var device in Model.Devices) 
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <h3>Model: ");
#nullable restore
#line 8 "D:\Programming\DevicesShop\GadgetsShop\Views\Devices\ProductsList.cshtml"
                  Write(device.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <p>Price: $");
#nullable restore
#line 9 "D:\Programming\DevicesShop\GadgetsShop\Views\Devices\ProductsList.cshtml"
                  Write(device.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        </div>\r\n");
#nullable restore
#line 12 "D:\Programming\DevicesShop\GadgetsShop\Views\Devices\ProductsList.cshtml"
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
