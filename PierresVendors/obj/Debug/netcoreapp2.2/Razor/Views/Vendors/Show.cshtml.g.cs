#pragma checksum "/Users/apple/Desktop/PierresVendors.Solution 10.36.55 PM/PierresVendors/Views/Vendors/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b1504007b16f06b1100bbbe391f231466d95bc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendors_Show), @"mvc.1.0.view", @"/Views/Vendors/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendors/Show.cshtml", typeof(AspNetCore.Views_Vendors_Show))]
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
#line 1 "/Users/apple/Desktop/PierresVendors.Solution 10.36.55 PM/PierresVendors/Views/Vendors/Show.cshtml"
using PierresVendors.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b1504007b16f06b1100bbbe391f231466d95bc5", @"/Views/Vendors/Show.cshtml")]
    public class Views_Vendors_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/apple/Desktop/PierresVendors.Solution 10.36.55 PM/PierresVendors/Views/Vendors/Show.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(57, 181, true);
            WriteLiteral("\n<h2>Here are all the Orders this Vendor has.</h2>\n\n<div class=\"row\">\n  <div class=\"form-group col-md-4\">    \n    <p> </p>\n  </div>\n  <div class=\"form-group col-md-8\">    \n    <ul>\n");
            EndContext();
#line 14 "/Users/apple/Desktop/PierresVendors.Solution 10.36.55 PM/PierresVendors/Views/Vendors/Show.cshtml"
       foreach (Order order in @Model["orders"])
      {

#line default
#line hidden
            BeginContext(295, 14, true);
            WriteLiteral("        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 309, "\'", 361, 4);
            WriteAttributeValue("", 316, "/vendors/", 316, 9, true);
#line 16 "/Users/apple/Desktop/PierresVendors.Solution 10.36.55 PM/PierresVendors/Views/Vendors/Show.cshtml"
WriteAttributeValue("", 325, Model["vendor"].Id, 325, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 344, "/orders/", 344, 8, true);
#line 16 "/Users/apple/Desktop/PierresVendors.Solution 10.36.55 PM/PierresVendors/Views/Vendors/Show.cshtml"
WriteAttributeValue("", 352, order.Id, 352, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(362, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(364, 10, false);
#line 16 "/Users/apple/Desktop/PierresVendors.Solution 10.36.55 PM/PierresVendors/Views/Vendors/Show.cshtml"
                                                               Write(order.Name);

#line default
#line hidden
            EndContext();
            BeginContext(374, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 17 "/Users/apple/Desktop/PierresVendors.Solution 10.36.55 PM/PierresVendors/Views/Vendors/Show.cshtml"
      }

#line default
#line hidden
            BeginContext(392, 48, true);
            WriteLiteral("    </ul>\n  </div>\n</div>\n\n\n\n<h4>Orders Total: $");
            EndContext();
            BeginContext(441, 21, false);
#line 24 "/Users/apple/Desktop/PierresVendors.Solution 10.36.55 PM/PierresVendors/Views/Vendors/Show.cshtml"
              Write(Model["vendor"].Total);

#line default
#line hidden
            EndContext();
            BeginContext(462, 12, true);
            WriteLiteral("</h4>\n\n<p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 474, "\'", 520, 3);
            WriteAttributeValue("", 481, "/vendors/", 481, 9, true);
#line 26 "/Users/apple/Desktop/PierresVendors.Solution 10.36.55 PM/PierresVendors/Views/Vendors/Show.cshtml"
WriteAttributeValue("", 490, Model["vendor"].Id, 490, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 509, "/orders/new", 509, 11, true);
            EndWriteAttribute();
            BeginContext(521, 127, true);
            WriteLiteral(">Add a new Order</a></p>\n<form action=\"/items/delete\" method=\"post\" id=\"show-form\">\n  <button>Clear All Orders</button>\n</form>");
            EndContext();
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
