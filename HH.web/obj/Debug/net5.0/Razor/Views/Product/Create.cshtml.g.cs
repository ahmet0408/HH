#pragma checksum "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac73bf75d82bcffc024de3a3ac772b3efc12d6f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Create), @"mvc.1.0.view", @"/Views/Product/Create.cshtml")]
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
#line 2 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
using HH.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
using HH.bll.DTOs.LanguageDTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac73bf75d82bcffc024de3a3ac772b3efc12d6f3", @"/Views/Product/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fe118e1b816e57df5165d7bb5fdc3ef6575bd1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HH.bll.DTOs.ProductDTO.CreateProductDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("options"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 8 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
  
    ViewData["Title"] = SharedLocalizer["Create Product"];
    int lngIndex = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <h1 class=\"page-header\">\r\n                ");
#nullable restore
#line 17 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
           Write(SharedLocalizer["Create Product"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h1>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\" >\r\n        <div class=\"col-lg-12\" >\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac73bf75d82bcffc024de3a3ac772b3efc12d6f36804", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac73bf75d82bcffc024de3a3ac772b3efc12d6f37082", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 24 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
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
#line 27 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                             foreach (LanguageDTO languageDTO in ViewBag.Languages)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <h2>");
#nullable restore
#line 29 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                               Write(languageDTO.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                                <hr />\r\n                                <input type=\"hidden\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 1148, "\"", 1199, 3);
                WriteAttributeValue("", 1155, "ProductTranslates[", 1155, 18, true);
#nullable restore
#line 31 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
WriteAttributeValue("", 1173, lngIndex, 1173, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1182, "].LanguageCulture", 1182, 17, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1200, "\"", 1228, 1);
#nullable restore
#line 31 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
WriteAttributeValue("", 1208, languageDTO.Culture, 1208, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />                                                         \r\n                                    <label>");
#nullable restore
#line 32 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                                      Write(SharedLocalizer["Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                    <div");
                BeginWriteAttribute("id", " id=\"", 1410, "\"", 1429, 2);
                WriteAttributeValue("", 1415, "name-", 1415, 5, true);
#nullable restore
#line 33 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
WriteAttributeValue("", 1420, lngIndex, 1420, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                                    <label>");
#nullable restore
#line 34 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                                      Write(SharedLocalizer["Short description"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                    <div");
                BeginWriteAttribute("id", " id=\"", 1571, "\"", 1595, 2);
                WriteAttributeValue("", 1576, "shortdesc-", 1576, 10, true);
#nullable restore
#line 35 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
WriteAttributeValue("", 1586, lngIndex, 1586, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                                    <label>");
#nullable restore
#line 36 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                                      Write(SharedLocalizer["Description"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                    <div");
                BeginWriteAttribute("id", " id=\"", 1731, "\"", 1764, 2);
                WriteAttributeValue("", 1736, "description-editor-", 1736, 19, true);
#nullable restore
#line 37 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
WriteAttributeValue("", 1755, lngIndex, 1755, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                                    <script>\r\n                                    $( function() {\r\n                                        $(\"#name-");
#nullable restore
#line 40 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                                            Write(lngIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral("\").dxTextBox({\r\n                                            name: \"ProductTranslates[");
#nullable restore
#line 41 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
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
#line 45 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                                                     Write(SharedLocalizer["Enter"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n                                            }]\r\n                                        });\r\n                                        $(\"#shortdesc-");
#nullable restore
#line 48 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                                                 Write(lngIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral("\").dxTextBox({\r\n                                            name: \"ProductTranslates[");
#nullable restore
#line 49 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
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
#line 53 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                                                     Write(SharedLocalizer["Enter"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n                                            }]\r\n                                        });\r\n                                        $(\"#description-editor-");
#nullable restore
#line 56 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
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
                                                        ""bold"", ""italic"", ""strike"", ""underline"", ""separator"",
                                         ");
                WriteLiteral(@"                    ""alignLeft"", ""alignCenter"", ""alignRight"", ""alignJustify"", ""separator"",
                                                              ""orderedList"", ""bulletList"", ""separator"",
                                                              ""color"", ""background"", ""separator"",
                                                               ""link"", ""image"", ""separator"",
                                                               ""clear"", ""codeBlock"", ""blockquote"",
                                                    {
                                                        widget: ""dxButton"",
                                                        options: {
                                                            text: ""Show markup"",
                                                            stylingMode: ""text"",
                                                            onClick: function () {
                                                                popupInstance.show();");
                WriteLiteral(@"
                                                            }
                                                        }
                                                    }
                                                ]
                                            },
                                            name: `ProductTranslates[");
#nullable restore
#line 87 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                                                                Write(lngIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral("].Description`,\r\n                                        }).dxHtmlEditor(\"instance\");\r\n                                    });\r\n                                </script>\r\n");
#nullable restore
#line 91 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"

                                lngIndex++;
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n                        <div class=\"col-lg-6\">\r\n                            <h2>");
#nullable restore
#line 96 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                           Write(SharedLocalizer["Data"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                            <hr />\r\n                            <div class=\"form-group\">\r\n                                <label>");
#nullable restore
#line 99 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                                  Write(SharedLocalizer["Picture"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                <div id=\"image\"></div>\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>");
#nullable restore
#line 103 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                                  Write(SharedLocalizer["Sort order"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                <input type=\"number\" class=\"form-control\" name=\"SortOrder\" />\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>");
#nullable restore
#line 107 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                                  Write(SharedLocalizer["Request File"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                <div id=\"requestFile\"></div>\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>");
#nullable restore
#line 111 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                                  Write(SharedLocalizer["Download File"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                                <div id=""downloadFile""></div>
                            </div>
                              <div class=""form-group"">
                                <div id=""published""></div>
                            </div> 
                            <div class=""form-group"">
                                <label>");
#nullable restore
#line 118 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                                  Write(SharedLocalizer["Options"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                <div id=\"option\"></div>\r\n                            </div>  \r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ac73bf75d82bcffc024de3a3ac772b3efc12d6f322013", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 121 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OptionIds);

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
                WriteLiteral("\r\n    <script>\r\n     $(function () {\r\n         $(\"#image\").dxFileUploader({\r\n                selectButtonText: \'");
#nullable restore
#line 138 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                              Write(SharedLocalizer["Choose a picture"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                name: \"FormImage\",\r\n                labelText: \'");
#nullable restore
#line 140 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                       Write(SharedLocalizer["or drag picture"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                accept: \"image/*\",\r\n                uploadMode: \"or drag\",\r\n                multiple: false,\r\n            }).dxValidator({\r\n                validationRules: [{\r\n                    type: \"required\",\r\n                    message: \'");
#nullable restore
#line 147 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                         Write(SharedLocalizer["Upload picture"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n                }]\r\n            });\r\n            $(\"#requestFile\").dxFileUploader({\r\n                selectButtonText: \'");
#nullable restore
#line 151 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                              Write(SharedLocalizer["Choose a file"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                name: \"FormRequestFile\",\r\n                labelText: \'");
#nullable restore
#line 153 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                       Write(SharedLocalizer["or drag file"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                accept: \"*\",\r\n                uploadMode: \"or drag\",\r\n                multiple: false,\r\n            }).dxValidator({\r\n                validationRules: [{\r\n                    type: \"required\",\r\n                    message: \'");
#nullable restore
#line 160 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                         Write(SharedLocalizer["Upload file"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n                }]\r\n            });\r\n            $(\"#downloadFile\").dxFileUploader({\r\n                selectButtonText: \'");
#nullable restore
#line 164 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                              Write(SharedLocalizer["Choose a file"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                name: \"FormDownloadFile\",\r\n                labelText: \'");
#nullable restore
#line 166 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                       Write(SharedLocalizer["or drag file"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                accept: \"*\",\r\n                uploadMode: \"or drag\",\r\n                multiple: false,\r\n            }).dxValidator({\r\n                validationRules: [{\r\n                    type: \"required\",\r\n                    message: \'");
#nullable restore
#line 173 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                         Write(SharedLocalizer["Upload file"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'
                }]
            });
         let changedBySelectBox;
  let titleSelectBox;
  let clearSelectionButton;
  const dataGrid = $('#option').dxDataGrid({
    dataSource: ""/api/ProductAPI/GetAllOption"",
    keyExpr: 'optionId',
    showBorders: true,
    name: ""ProductOption"",
    selection: {
      mode: 'multiple',
    },
    columns: [
        {
      dataField: 'optionCode',
      caption: 'Option Name',
      valueExpr: 'optionCode'
    }],
    onSelectionChanged(selectedItems) {
        console.log(selectedItems);
        const data = selectedItems.selectedRowsData; 
        $(""#options"").val(
                data
                    .map((value) => `${value.optionId}`)
                    .join("", "")
            );
        }
    }).dxDataGrid('instance');
         $(""#published"").dxCheckBox({
                value: true,
                text: '");
#nullable restore
#line 205 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
                  Write(SharedLocalizer["Active"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                name: \'IsPublish\',\r\n            });\r\n          $(\"#button\").dxButton({\r\n                text: \'");
#nullable restore
#line 209 "C:\Users\User\Desktop\hh.web\HH.web\Views\Product\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HH.bll.DTOs.ProductDTO.CreateProductDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
