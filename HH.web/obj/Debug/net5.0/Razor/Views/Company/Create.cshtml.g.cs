#pragma checksum "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c6958f05b59fed27767f1a7cb553b8bc436f085"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_Create), @"mvc.1.0.view", @"/Views/Company/Create.cshtml")]
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
#line 2 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\_ViewImports.cshtml"
using HH.web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
using HH.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
using HH.bll.DTOs.LanguageDTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c6958f05b59fed27767f1a7cb553b8bc436f085", @"/Views/Company/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fe118e1b816e57df5165d7bb5fdc3ef6575bd1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HH.bll.DTOs.CompanyDTO.CreateNewsDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
  
    ViewData["Title"] = SharedLocalizer["Create news"];
    int lngIndex = 0;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <h1 class=\"page-header\">\r\n                ");
#nullable restore
#line 18 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
           Write(SharedLocalizer["Create news"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h1>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\" >\r\n        <div class=\"col-lg-12\" >\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c6958f05b59fed27767f1a7cb553b8bc436f0856076", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c6958f05b59fed27767f1a7cb553b8bc436f0856354", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 25 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
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
#line 28 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
                             foreach (LanguageDTO languageDTO in ViewBag.Languages)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <h2>");
#nullable restore
#line 30 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
                               Write(languageDTO.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                                <hr />\r\n                                <input type=\"hidden\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 1141, "\"", 1189, 3);
                WriteAttributeValue("", 1148, "NewsTranslates[", 1148, 15, true);
#nullable restore
#line 32 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
WriteAttributeValue("", 1163, lngIndex, 1163, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1172, "].LanguageCulture", 1172, 17, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1190, "\"", 1218, 1);
#nullable restore
#line 32 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
WriteAttributeValue("", 1198, languageDTO.Culture, 1198, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />                                                         \r\n                                    <label>");
#nullable restore
#line 33 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
                                      Write(SharedLocalizer["Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                    <div");
                BeginWriteAttribute("id", " id=\"", 1400, "\"", 1419, 2);
                WriteAttributeValue("", 1405, "name-", 1405, 5, true);
#nullable restore
#line 34 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
WriteAttributeValue("", 1410, lngIndex, 1410, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                                    <label>");
#nullable restore
#line 35 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
                                      Write(SharedLocalizer["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                    <div");
                BeginWriteAttribute("id", " id=\"", 1549, "\"", 1569, 2);
                WriteAttributeValue("", 1554, "title-", 1554, 6, true);
#nullable restore
#line 36 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
WriteAttributeValue("", 1560, lngIndex, 1560, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                                    <label>");
#nullable restore
#line 37 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
                                      Write(SharedLocalizer["Short description"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                    <div");
                BeginWriteAttribute("id", " id=\"", 1711, "\"", 1735, 2);
                WriteAttributeValue("", 1716, "shortdesc-", 1716, 10, true);
#nullable restore
#line 38 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
WriteAttributeValue("", 1726, lngIndex, 1726, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                                    <label>");
#nullable restore
#line 39 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
                                      Write(SharedLocalizer["Description"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                    <div");
                BeginWriteAttribute("id", " id=\"", 1871, "\"", 1904, 2);
                WriteAttributeValue("", 1876, "description-editor-", 1876, 19, true);
#nullable restore
#line 40 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
WriteAttributeValue("", 1895, lngIndex, 1895, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                                    <script>\r\n                                    $( function() {\r\n                                        $(\"#name-");
#nullable restore
#line 43 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
                                            Write(lngIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral("\").dxTextBox({\r\n                                            name: \"NewsTranslates[");
#nullable restore
#line 44 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
                                                             Write(lngIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"].Name""
                                        }).dxValidator({
                                            validationRules: [{
                                                type: ""required"",
                                                message: '");
#nullable restore
#line 48 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
                                                     Write(SharedLocalizer["Enter"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n                                            }]\r\n                                        });\r\n                                        $(\"#title-");
#nullable restore
#line 51 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
                                             Write(lngIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral("\").dxTextBox({\r\n                                            name: \"NewsTranslates[");
#nullable restore
#line 52 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
                                                             Write(lngIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"].Title""
                                        }).dxValidator({
                                            validationRules: [{
                                                type: ""required"",
                                                message: '");
#nullable restore
#line 56 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
                                                     Write(SharedLocalizer["Enter"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n                                            }]\r\n                                        });\r\n                                        $(\"#shortdesc-");
#nullable restore
#line 59 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
                                                 Write(lngIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral("\").dxTextBox({\r\n                                            name: \"NewsTranslates[");
#nullable restore
#line 60 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
                                                             Write(lngIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"].ShortDesc""
                                        }).dxValidator({
                                            validationRules: [{
                                                type: ""required"",
                                                message: '");
#nullable restore
#line 64 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
                                                     Write(SharedLocalizer["Enter"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n                                            }]\r\n                                        });\r\n                                        $(\"#description-editor-");
#nullable restore
#line 67 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
                                                          Write(lngIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""").dxHtmlEditor({
                                            height: 250,
                                            toolbar: {
                                                items: [
                                                    ""undo"", ""redo"", ""separator"",
                                                    {
                                                        formatName: ""header"",
                                                        formatValues: [false, 1, 2, 3, 4, 5]
                                                    },
                                                    {
                                                        formatName: ""size"",
                                                        formatValues: [""8pt"", ""10pt"", ""12pt"", ""14pt"", ""18pt"", ""24pt"", ""36pt""]
                                                    },
                                                    {
                                                    formatName: ""font"",
                        ");
                WriteLiteral(@"                            formatValues: ['Arial', 'Courier New', 'Georgia', 'Impact', 'Lucida Console', 'Tahoma', 'Times New Roman', 'Verdana', 'IBM Plex Sans'],
                                                     },
                                                        ""bold"", ""italic"", ""strike"", ""underline"", ""separator"",
                                                             ""alignLeft"", ""alignCenter"", ""alignRight"", ""alignJustify"", ""separator"",
                                                              ""orderedList"", ""bulletList"", ""separator"",
                                                              ""color"", ""background"", ""separator"",
                                                               ""link"", ""image"", ""separator"",
                                                               ""clear"", ""codeBlock"", ""blockquote"",
                                                    {
                                                        widget: ""dxButton"",
                            ");
                WriteLiteral(@"                            options: {
                                                            text: ""Show markup"",
                                                            stylingMode: ""text"",
                                                            onClick: function () {
                                                                popupInstance.show();
                                                            }
                                                        }
                                                    }
                                                ]
                                            },
                                            name: `NewsTranslates[");
#nullable restore
#line 102 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
                                                             Write(lngIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral("].Description`,\r\n                                        }).dxHtmlEditor(\"instance\");\r\n                                    });\r\n                                </script>\r\n");
#nullable restore
#line 106 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"

                                lngIndex++;
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n                        <div class=\"col-lg-6\"> \r\n                            <h2>");
#nullable restore
#line 111 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
                           Write(SharedLocalizer["Data"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                            <hr />\r\n                            <div class=\"form-group\">\r\n                                <label>");
#nullable restore
#line 114 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
                                  Write(SharedLocalizer["Picture"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" *</label>
                                <div id=""image""></div>
                            </div>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n          </div>\r\n      </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n     $(function () {\r\n         $(\"#image\").dxFileUploader({\r\n                selectButtonText: \'");
#nullable restore
#line 136 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
                              Write(SharedLocalizer["Choose a picture"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                name: \"FormImage\",\r\n                labelText: \'");
#nullable restore
#line 138 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
                       Write(SharedLocalizer["or drag picture"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                accept: \"image/*\",\r\n                uploadMode: \"or drag\",\r\n                multiple: false,\r\n            }).dxValidator({\r\n                validationRules: [{\r\n                    type: \"required\",\r\n                    message: \'");
#nullable restore
#line 145 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
                         Write(SharedLocalizer["Upload picture"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n                }]\r\n            });\r\n         $(\"#published\").dxCheckBox({\r\n                value: true,\r\n                text: \'");
#nullable restore
#line 150 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
                  Write(SharedLocalizer["Active"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                name: \'IsPublish\',\r\n            });\r\n          $(\"#button\").dxButton({\r\n                text: \'");
#nullable restore
#line 154 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Company\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HH.bll.DTOs.CompanyDTO.CreateNewsDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
