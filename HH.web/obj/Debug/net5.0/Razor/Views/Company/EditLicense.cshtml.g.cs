#pragma checksum "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5de64a3d0a1bb742074dffeaf4df481e0daadc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_EditLicense), @"mvc.1.0.view", @"/Views/Company/EditLicense.cshtml")]
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
#line 2 "C:\Users\User\Desktop\hh.web\HH.web\Views\_ViewImports.cshtml"
using HH.web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\hh.web\HH.web\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
using HH.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
using HH.bll.DTOs.LanguageDTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5de64a3d0a1bb742074dffeaf4df481e0daadc2", @"/Views/Company/EditLicense.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fe118e1b816e57df5165d7bb5fdc3ef6575bd1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_EditLicense : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HH.bll.DTOs.CompanyDTO.EditLicenseDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditLicense", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
  
    ViewData["Title"] = SharedLocalizer["Edit License"];


    int lngIndex = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <h1 class=\"page-header\">\r\n                ");
#nullable restore
#line 19 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
           Write(SharedLocalizer["Edit License"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h1>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5de64a3d0a1bb742074dffeaf4df481e0daadc26675", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5de64a3d0a1bb742074dffeaf4df481e0daadc26953", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 27 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d5de64a3d0a1bb742074dffeaf4df481e0daadc28623", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 28 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <div class=\"form-row\">\r\n                        <div class=\"col-lg-6\">\r\n");
#nullable restore
#line 31 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
                             foreach (LanguageDTO languageDTO in ViewBag.Languages)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <h2>");
#nullable restore
#line 33 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
                               Write(languageDTO.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                                <hr />\r\n");
#nullable restore
#line 35 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
                                {
                                    var licenseT = Model.LicenseTranslates.FirstOrDefault(p => p.LanguageCulture == languageDTO.Culture);

                                    if (licenseT != null)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1472, "\"", 1510, 3);
                WriteAttributeValue("", 1479, "LicenseTranslates[", 1479, 18, true);
#nullable restore
#line 40 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
WriteAttributeValue("", 1497, lngIndex, 1497, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1506, "].Id", 1506, 4, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1511, "\"", 1531, 1);
#nullable restore
#line 40 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
WriteAttributeValue("", 1519, licenseT.Id, 1519, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <input type=\"hidden\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 1618, "\"", 1669, 3);
                WriteAttributeValue("", 1625, "LicenseTranslates[", 1625, 18, true);
#nullable restore
#line 41 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
WriteAttributeValue("", 1643, lngIndex, 1643, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1652, "].LanguageCulture", 1652, 17, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1670, "\"", 1698, 1);
#nullable restore
#line 41 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
WriteAttributeValue("", 1678, languageDTO.Culture, 1678, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <div class=\"form-group\">\r\n                                            <label>");
#nullable restore
#line 43 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
                                              Write(SharedLocalizer["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                            <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 1941, "\"", 1982, 3);
                WriteAttributeValue("", 1948, "LicenseTranslates[", 1948, 18, true);
#nullable restore
#line 44 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
WriteAttributeValue("", 1966, lngIndex, 1966, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1975, "].Title", 1975, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1983, "\"", 2006, 1);
#nullable restore
#line 44 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
WriteAttributeValue("", 1991, licenseT.Title, 1991, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        </div>\r\n");
#nullable restore
#line 46 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
                                    }
                                }

                                lngIndex++;
                            }   

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                            <div class=\"col-lg-6\">\r\n                            <h2>");
#nullable restore
#line 54 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
                           Write(SharedLocalizer["Data"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                            <hr />\r\n                           <div class=\"form-group\">\r\n                                <label>");
#nullable restore
#line 57 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
                                  Write(SharedLocalizer["File"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                <div id=\"file\"></div>\r\n                            </div>\r\n");
#nullable restore
#line 60 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
                             if (Model.File != null && Model.File.Length > 0)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("iframe", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5de64a3d0a1bb742074dffeaf4df481e0daadc216319", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2774, "~/images/license/", 2774, 17, true);
#nullable restore
#line 62 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
AddHtmlAttributeValue("", 2791, Model.File, 2791, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 63 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <input type=\"hidden\" name=\"File\"");
                BeginWriteAttribute("value", " value=\"", 2906, "\"", 2925, 1);
#nullable restore
#line 64 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
WriteAttributeValue("", 2914, Model.File, 2914, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                            <div class=""form-group"">
                                <div id=""published""></div>
                            </div>
                        </div>
                    </div>

               
                <div class=""dx-fieldset"">
                    <br />
                    <div id=""summary""></div>
                    <br />
                    <div id=""button""></div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(function () {\r\n            $(\"#file\").dxFileUploader({\r\n                                            selectButtonText: \'");
#nullable restore
#line 87 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
                                                          Write(SharedLocalizer["Choose a file"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                                            name: \"FormFile\",\r\n                                            labelText: \'");
#nullable restore
#line 89 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
                                                   Write(SharedLocalizer["or drag file"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                                            accept: \"image/*\",\r\n                                            uploadMode: \'");
#nullable restore
#line 91 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
                                                    Write(SharedLocalizer["or drag"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                                            multiple: false,\r\n                                            });\r\n\r\n            let published = \'");
#nullable restore
#line 95 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
                        Write(Model.IsPublish);

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n            $(\"#published\").dxCheckBox({\r\n                value: (published.toLowerCase() == \'true\'),\r\n                text: \'");
#nullable restore
#line 98 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
                  Write(SharedLocalizer["Active"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                name: \'IsPublish\',\r\n            });\r\n\r\n            $(\"#button\").dxButton({\r\n                text: \'");
#nullable restore
#line 103 "C:\Users\User\Desktop\hh.web\HH.web\Views\Company\EditLicense.cshtml"
                  Write(SharedLocalizer["Edit"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                type: \"success\",\r\n                useSubmitBehavior: true,\r\n            });\r\n            $(\"#summary\").dxValidationSummary({});\r\n        });\r\n    </script>\r\n\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HH.bll.DTOs.CompanyDTO.EditLicenseDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
