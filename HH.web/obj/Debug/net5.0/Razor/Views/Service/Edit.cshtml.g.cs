#pragma checksum "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef04c52f875f6f787e6ef05486d8af2688d49406"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Edit), @"mvc.1.0.view", @"/Views/Service/Edit.cshtml")]
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
#line 2 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
using HH.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
using HH.bll.DTOs.LanguageDTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef04c52f875f6f787e6ef05486d8af2688d49406", @"/Views/Service/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fe118e1b816e57df5165d7bb5fdc3ef6575bd1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HH.bll.DTOs.ServicesDTO.EditServiceDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 130px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 8 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
  
    ViewData["Title"] = SharedLocalizer["Edit Service"];


    int lngIndex = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <h1 class=\"page-header\">\r\n                ");
#nullable restore
#line 19 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
           Write(SharedLocalizer["Edit Service"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h1>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef04c52f875f6f787e6ef05486d8af2688d494067320", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef04c52f875f6f787e6ef05486d8af2688d494067598", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 27 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ef04c52f875f6f787e6ef05486d8af2688d494069261", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 28 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
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
#line 31 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
                             foreach (LanguageDTO languageDTO in ViewBag.Languages)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <h2>");
#nullable restore
#line 33 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
                               Write(languageDTO.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                                <hr />\r\n");
#nullable restore
#line 35 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
                                {
                                    var serviceT = Model.ServiceTranslates.FirstOrDefault(p => p.LanguageCulture == languageDTO.Culture);

                                    if (serviceT != null)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1466, "\"", 1504, 3);
                WriteAttributeValue("", 1473, "ServiceTranslates[", 1473, 18, true);
#nullable restore
#line 40 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
WriteAttributeValue("", 1491, lngIndex, 1491, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1500, "].Id", 1500, 4, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1505, "\"", 1525, 1);
#nullable restore
#line 40 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
WriteAttributeValue("", 1513, serviceT.Id, 1513, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <input type=\"hidden\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 1612, "\"", 1663, 3);
                WriteAttributeValue("", 1619, "ServiceTranslates[", 1619, 18, true);
#nullable restore
#line 41 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
WriteAttributeValue("", 1637, lngIndex, 1637, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1646, "].LanguageCulture", 1646, 17, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1664, "\"", 1692, 1);
#nullable restore
#line 41 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
WriteAttributeValue("", 1672, languageDTO.Culture, 1672, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <div class=\"form-group\">\r\n                                            <label>");
#nullable restore
#line 43 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
                                              Write(SharedLocalizer["Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                            <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 1934, "\"", 1974, 3);
                WriteAttributeValue("", 1941, "ServiceTranslates[", 1941, 18, true);
#nullable restore
#line 44 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
WriteAttributeValue("", 1959, lngIndex, 1959, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1968, "].Name", 1968, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1975, "\"", 1997, 1);
#nullable restore
#line 44 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
WriteAttributeValue("", 1983, serviceT.Name, 1983, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        </div>\r\n                                        <div class=\"form-group\">\r\n                                            <label>");
#nullable restore
#line 47 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
                                              Write(SharedLocalizer["Short description"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                            <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 2300, "\"", 2345, 3);
                WriteAttributeValue("", 2307, "ServiceTranslates[", 2307, 18, true);
#nullable restore
#line 48 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
WriteAttributeValue("", 2325, lngIndex, 2325, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2334, "].ShortDesc", 2334, 11, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2346, "\"", 2373, 1);
#nullable restore
#line 48 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
WriteAttributeValue("", 2354, serviceT.ShortDesc, 2354, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        </div>\r\n                                        <div class=\"form-group\">\r\n                                            <label>");
#nullable restore
#line 51 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
                                              Write(SharedLocalizer["Description"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                            <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 2670, "\"", 2717, 3);
                WriteAttributeValue("", 2677, "ServiceTranslates[", 2677, 18, true);
#nullable restore
#line 52 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
WriteAttributeValue("", 2695, lngIndex, 2695, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2704, "].Description", 2704, 13, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2718, "\"", 2747, 1);
#nullable restore
#line 52 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
WriteAttributeValue("", 2726, serviceT.Description, 2726, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        </div>\r\n");
#nullable restore
#line 54 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
                                    }
                                }

                                lngIndex++;
                            }   

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                            <div class=\"col-lg-6\">\r\n                            <h2>");
#nullable restore
#line 62 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
                           Write(SharedLocalizer["Data"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                            <hr />\r\n                            <div class=\"form-group\">\r\n                                <label>");
#nullable restore
#line 65 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
                                  Write(SharedLocalizer["Picture"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                <div id=\"image\"></div>\r\n                            </div>\r\n");
#nullable restore
#line 68 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
                             if (Model.Image != null && Model.Image.Length > 0)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ef04c52f875f6f787e6ef05486d8af2688d4940619650", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3519, "~/images/service/", 3519, 17, true);
#nullable restore
#line 70 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
AddHtmlAttributeValue("", 3536, Model.Image, 3536, 12, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 71 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <input type=\"hidden\" name=\"Image\"");
                BeginWriteAttribute("value", " value=\"", 3705, "\"", 3725, 1);
#nullable restore
#line 72 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
WriteAttributeValue("", 3713, Model.Image, 3713, 12, false);

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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n         var getMenus = new DevExpress.data.AspNet.createStore({\r\n             key: \"id\",\r\n             loadUrl: \"/api/ServiceAPI/GetAllServiceButThis/\"+");
#nullable restore
#line 95 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
                                                         Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@",
             onBeforeSend: function (method, ajaxOptions) {
                 ajaxOptions.xhrFields = { withCredentials: true };
            }
         });

        $(function () {
            $(""#image"").dxFileUploader({
                                            selectButtonText: '");
#nullable restore
#line 103 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
                                                          Write(SharedLocalizer["Choose a picture"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                                            name: \"FormImage\",\r\n                                            labelText: \'");
#nullable restore
#line 105 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
                                                   Write(SharedLocalizer["or drag picture"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                                            accept: \"image/*\",\r\n                                            uploadMode: \'");
#nullable restore
#line 107 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
                                                    Write(SharedLocalizer["or drag"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                                            multiple: false,\r\n                                        });\r\n\r\n            let published = \'");
#nullable restore
#line 111 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
                        Write(Model.IsPublish);

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n            $(\"#published\").dxCheckBox({\r\n                value: (published.toLowerCase() == \'true\'),\r\n                text: \'");
#nullable restore
#line 114 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
                  Write(SharedLocalizer["Active"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                name: \'IsPublish\',\r\n            });\r\n\r\n            $(\"#button\").dxButton({\r\n                text: \'");
#nullable restore
#line 119 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HH.bll.DTOs.ServicesDTO.EditServiceDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
