#pragma checksum "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fef031ea7fdf8c1415be6b25ef5a85e09095b640"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Create), @"mvc.1.0.view", @"/Views/Service/Create.cshtml")]
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
#line 2 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Create.cshtml"
using HH.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Create.cshtml"
using HH.bll.DTOs.LanguageDTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Create.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fef031ea7fdf8c1415be6b25ef5a85e09095b640", @"/Views/Service/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fe118e1b816e57df5165d7bb5fdc3ef6575bd1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HH.bll.DTOs.ServicesDTO.CreateServiceDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Create.cshtml"
  
    ViewData["Title"] = SharedLocalizer["Create Service"];

    int lngIndex = 0;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <h1 class=\"page-header\">\r\n                ");
#nullable restore
#line 19 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Create.cshtml"
           Write(SharedLocalizer["Create Service"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h1>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\" >\r\n        <div class=\"col-lg-12\" >\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fef031ea7fdf8c1415be6b25ef5a85e09095b6406819", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fef031ea7fdf8c1415be6b25ef5a85e09095b6407097", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 26 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Create.cshtml"
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
                WriteLiteral("\r\n                    <div class=\"form-row\">\r\n                        <div class=\"col-lg-6\">\r\n");
#nullable restore
#line 29 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Create.cshtml"
                             foreach (LanguageDTO languageDTO in ViewBag.Languages)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <h2>");
#nullable restore
#line 31 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Create.cshtml"
                               Write(languageDTO.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                                <hr />\r\n                                <input type=\"hidden\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 1153, "\"", 1204, 3);
                WriteAttributeValue("", 1160, "ServiceTranslates[", 1160, 18, true);
#nullable restore
#line 33 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Create.cshtml"
WriteAttributeValue("", 1178, lngIndex, 1178, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1187, "].LanguageCulture", 1187, 17, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1205, "\"", 1233, 1);
#nullable restore
#line 33 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Create.cshtml"
WriteAttributeValue("", 1213, languageDTO.Culture, 1213, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />                                                         \r\n                                    <div class=\"form-group\">\r\n                                       <label>");
#nullable restore
#line 35 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Create.cshtml"
                                         Write(SharedLocalizer["Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                       <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 1516, "\"", 1556, 3);
                WriteAttributeValue("", 1523, "ServiceTranslates[", 1523, 18, true);
#nullable restore
#line 36 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Create.cshtml"
WriteAttributeValue("", 1541, lngIndex, 1541, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1550, "].Name", 1550, 6, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    </div>\r\n                                    <div class=\"form-group\">\r\n                                       <label>");
#nullable restore
#line 39 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Create.cshtml"
                                         Write(SharedLocalizer["ShortDescription"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                       <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 1838, "\"", 1883, 3);
                WriteAttributeValue("", 1845, "ServiceTranslates[", 1845, 18, true);
#nullable restore
#line 40 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Create.cshtml"
WriteAttributeValue("", 1863, lngIndex, 1863, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1872, "].ShortDesc", 1872, 11, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    </div>\r\n                                    <div class=\"form-group\">\r\n                                       <label>");
#nullable restore
#line 43 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Create.cshtml"
                                         Write(SharedLocalizer["Description"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                       <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 2160, "\"", 2207, 3);
                WriteAttributeValue("", 2167, "ServiceTranslates[", 2167, 18, true);
#nullable restore
#line 44 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Create.cshtml"
WriteAttributeValue("", 2185, lngIndex, 2185, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2194, "].Description", 2194, 13, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    </div>\r\n");
#nullable restore
#line 46 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Create.cshtml"

                                lngIndex++;
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n                        <div class=\"col-lg-6\"> \r\n                            <div class=\"form-group\">\r\n                                <label>");
#nullable restore
#line 52 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Create.cshtml"
                                  Write(SharedLocalizer["Image"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                <input type=\"file\" class=\"form-control\" name=\"FormImage\" />\r\n                            </div>\r\n                             <div class=\"form-group\">\r\n                                <label>");
#nullable restore
#line 56 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Create.cshtml"
                                  Write(SharedLocalizer["Active"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fef031ea7fdf8c1415be6b25ef5a85e09095b64014809", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 57 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IsPublish);

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
                WriteLiteral(@"
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n          </div>\r\n      </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n     $(function () {\r\n          $(\"#button\").dxButton({\r\n                text: \'");
#nullable restore
#line 75 "C:\Users\User\Desktop\hh.web\HH.web\Views\Service\Create.cshtml"
                  Write(SharedLocalizer["Add"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                type: \"success\",\r\n                useSubmitBehavior: true,\r\n            });\r\n            $(\"#summary\").dxValidationSummary({});\r\n        });\r\n        </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HH.bll.DTOs.ServicesDTO.CreateServiceDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591