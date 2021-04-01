#pragma checksum "/Users/macbookair/Desktop/Ynov/dotNet/BridgeMonitor/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b229016cfce430b8d7dbf56047f865fea69c0f7"
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
#line 1 "/Users/macbookair/Desktop/Ynov/dotNet/BridgeMonitor/Views/_ViewImports.cshtml"
using BridgeMonitor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/macbookair/Desktop/Ynov/dotNet/BridgeMonitor/Views/_ViewImports.cshtml"
using BridgeMonitor.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b229016cfce430b8d7dbf56047f865fea69c0f7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f76db85423d1966422131999df760b0ec79fa9c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BridgeMonitor.Models.ClosingList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/macbookair/Desktop/Ynov/dotNet/BridgeMonitor/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Prochaine fermeture";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-left\">\r\n    <h1 class=\"display-4\">Prochaine fermeture</h1>\r\n    <ul class=\"list-group\">\r\n        <li class=\"list-group-item\">\r\n            Date de fermeture : ");
#nullable restore
#line 10 "/Users/macbookair/Desktop/Ynov/dotNet/BridgeMonitor/Views/Home/Index.cshtml"
                           Write(Model.NextClosing.FormattedClosingDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            Date de réouverture : ");
#nullable restore
#line 13 "/Users/macbookair/Desktop/Ynov/dotNet/BridgeMonitor/Views/Home/Index.cshtml"
                             Write(Model.NextClosing.FormattedReopeningDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            Bateau : ");
#nullable restore
#line 16 "/Users/macbookair/Desktop/Ynov/dotNet/BridgeMonitor/Views/Home/Index.cshtml"
                Write(Model.NextClosing.BoatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n\r\n        <li class=\"list-group-item\">\r\n            Durée de la fermeture : ");
#nullable restore
#line 20 "/Users/macbookair/Desktop/Ynov/dotNet/BridgeMonitor/Views/Home/Index.cshtml"
                               Write(Model.NextClosing.ClosingDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            Prochaine fermeture dans ");
#nullable restore
#line 23 "/Users/macbookair/Desktop/Ynov/dotNet/BridgeMonitor/Views/Home/Index.cshtml"
                                Write(Model.NextClosing.TimeUntilClosing);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n");
#nullable restore
#line 26 "/Users/macbookair/Desktop/Ynov/dotNet/BridgeMonitor/Views/Home/Index.cshtml"
             if(Model.NextClosing.TrafficRisk) {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("Risque élevé de bouchons !");
#nullable restore
#line 27 "/Users/macbookair/Desktop/Ynov/dotNet/BridgeMonitor/Views/Home/Index.cshtml"
                                                       
            } else {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("Risque faible de bouchons");
#nullable restore
#line 29 "/Users/macbookair/Desktop/Ynov/dotNet/BridgeMonitor/Views/Home/Index.cshtml"
                                                      
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </li>\r\n        \r\n    </ul>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BridgeMonitor.Models.ClosingList> Html { get; private set; }
    }
}
#pragma warning restore 1591
