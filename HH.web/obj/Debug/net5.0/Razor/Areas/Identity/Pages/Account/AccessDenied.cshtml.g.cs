#pragma checksum "C:\Users\User\Desktop\React\HH.web\HH.web\Areas\Identity\Pages\Account\AccessDenied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f9f02de66a0df9d16251f7463b1b1ec2a5e3ea4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_AccessDenied), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/AccessDenied.cshtml")]
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
#line 1 "C:\Users\User\Desktop\React\HH.web\HH.web\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\React\HH.web\HH.web\Areas\Identity\Pages\_ViewImports.cshtml"
using HH.web.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\React\HH.web\HH.web\Areas\Identity\Pages\_ViewImports.cshtml"
using HH.web.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\Desktop\React\HH.web\HH.web\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using HH.web.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\React\HH.web\HH.web\Areas\Identity\Pages\Account\AccessDenied.cshtml"
using HH.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\React\HH.web\HH.web\Areas\Identity\Pages\Account\AccessDenied.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\React\HH.web\HH.web\Areas\Identity\Pages\Account\AccessDenied.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f9f02de66a0df9d16251f7463b1b1ec2a5e3ea4", @"/Areas/Identity/Pages/Account/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35718a1617532bd81b5b0d312afa8659cf785b85", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41bc3e74cfccf3ba0ece4dc49404f00838247631", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_AccessDenied : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 9 "C:\Users\User\Desktop\React\HH.web\HH.web\Areas\Identity\Pages\Account\AccessDenied.cshtml"
  
    ViewData["Title"] = SharedLocalizer["Access denied"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"h-full\">\n    <div class=\"container bg-white sm:pt-12 pt-4 relative\">\n        <div class=\"lg:px-24 px-4\">\n            <h1 class=\"font-bold text-2xl sm:text-3xl lg:max-w-3xl lg:text-3xl\">\n                ");
#nullable restore
#line 17 "C:\Users\User\Desktop\React\HH.web\HH.web\Areas\Identity\Pages\Account\AccessDenied.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </h1>\n            <p class=\"sm:text-xl text-base sm:mt-8 mt-4\">");
#nullable restore
#line 19 "C:\Users\User\Desktop\React\HH.web\HH.web\Areas\Identity\Pages\Account\AccessDenied.cshtml"
                                                    Write(SharedLocalizer["You do not have access to this resource"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\n        </div>\n\n    </div>\n</div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<SharedResource> SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccessDeniedModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccessDeniedModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccessDeniedModel>)PageContext?.ViewData;
        public AccessDeniedModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
