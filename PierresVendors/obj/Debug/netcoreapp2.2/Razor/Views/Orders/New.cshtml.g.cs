#pragma checksum "/Users/apple/Desktop/PierresVendors.Solution 10.36.55 PM/PierresVendors/Views/Orders/New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80f292306d767d48f9b52f780057f57ed2083251"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_New), @"mvc.1.0.view", @"/Views/Orders/New.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/New.cshtml", typeof(AspNetCore.Views_Orders_New))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80f292306d767d48f9b52f780057f57ed2083251", @"/Views/Orders/New.cshtml")]
    public class Views_Orders_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n  ");
            EndContext();
            BeginContext(25, 203, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80f292306d767d48f9b52f780057f57ed20832512858", async() => {
                BeginContext(31, 190, true);
                WriteLiteral("\n    <meta charset=\"utf-8\" />\n    <title>Pierres Vendors</title>\n    <link\n      rel=\"stylesheet\"\n      href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css\"\n    />\n  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(228, 3, true);
            WriteLiteral("\n  ");
            EndContext();
            BeginContext(231, 501, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80f292306d767d48f9b52f780057f57ed20832514219", async() => {
                BeginContext(237, 31, true);
                WriteLiteral("\n<h1>Enter Order to Add to the ");
                EndContext();
                BeginContext(269, 10, false);
#line 12 "/Users/apple/Desktop/PierresVendors.Solution 10.36.55 PM/PierresVendors/Views/Orders/New.cshtml"
                         Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(279, 11, true);
                WriteLiteral("</h1>\n<form");
                EndContext();
                BeginWriteAttribute("action", " action=\"", 290, "\"", 324, 3);
                WriteAttributeValue("", 299, "/vendors/", 299, 9, true);
#line 13 "/Users/apple/Desktop/PierresVendors.Solution 10.36.55 PM/PierresVendors/Views/Orders/New.cshtml"
WriteAttributeValue("", 308, Model.Id, 308, 9, false);

#line default
#line hidden
                WriteAttributeValue("", 317, "/orders", 317, 7, true);
                EndWriteAttribute();
                BeginContext(325, 97, true);
                WriteLiteral(" method=\"post\">\n  <div class=\"form-group\">\n    <input id=\"vendorId\" name=\"vendorId\" type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 422, "\"", 439, 1);
#line 15 "/Users/apple/Desktop/PierresVendors.Solution 10.36.55 PM/PierresVendors/Views/Orders/New.cshtml"
WriteAttributeValue("", 430, Model.Id, 430, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(440, 226, true);
                WriteLiteral(">\n    <label for=\"orderName\">Order Name</label>\n    <input id=\"orderName\" name=\"orderName\" type=\"text\" required>\n  </div>\n  <button type=\"submit\">Add</button>\n</form>\n\n<div class=\"footer\">\n  <a href=\"/\">Return to Home</a>\n  <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 666, "\"", 698, 3);
                WriteAttributeValue("", 673, "/vendors/", 673, 9, true);
#line 24 "/Users/apple/Desktop/PierresVendors.Solution 10.36.55 PM/PierresVendors/Views/Orders/New.cshtml"
WriteAttributeValue("", 682, Model.Id, 682, 9, false);

#line default
#line hidden
                WriteAttributeValue("", 691, "/orders", 691, 7, true);
                EndWriteAttribute();
                BeginContext(699, 26, true);
                WriteLiteral(">View Orders</a>\n</div>\n  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(732, 8, true);
            WriteLiteral("\n</html>");
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
