#pragma checksum "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45a822e7ddfa632d6c23ca3c6d6a344445542e8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Product\Index.cshtml"
using HH.web.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Product\Index.cshtml"
using HH.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Product\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45a822e7ddfa632d6c23ca3c6d6a344445542e8b", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fe118e1b816e57df5165d7bb5fdc3ef6575bd1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Product\Index.cshtml"
  
    ViewData["Title"] = SharedLocalizer["Products"];


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <h1 class=\"page-header\">\r\n                ");
#nullable restore
#line 16 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Product\Index.cshtml"
           Write(SharedLocalizer["Products"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </h1>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div id=\"gridContainer\">\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(function () {\r\n            let url = `");
#nullable restore
#line 30 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Product\Index.cshtml"
                  Write(API.GetAllProduct);

#line default
#line hidden
#nullable disable
                WriteLiteral("`;\r\n            var returnUrl = \'");
#nullable restore
#line 31 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Product\Index.cshtml"
                        Write(Context.Request.Path);

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Product\Index.cshtml"
                                             Write(Context.Request.QueryString);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
            $(""#gridContainer"").dxDataGrid({
                dataSource: DevExpress.data.AspNet.createStore({
                    key: ""productId"",
                    loadUrl: url,
                    insertUrl: url,
                    updateUrl: url,
                    deleteUrl: url,
                    onBeforeSend: function (method, ajaxOptions) {
                        ajaxOptions.xhrFields = { withCredentials: true };
                    }
                }),
                onInitNewRow: function(e) {
                    var url = `");
#nullable restore
#line 44 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Product\Index.cshtml"
                          Write(Url.Action("Create", "Product"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`;
                    window.location = url;
                },
                filterPanel: {
                    visible: false
                },
                filterRow: { visible: false },
                remoteOperations: true,
                onRowUpdating: function (e) {
                    e.newData = Object.assign(e.oldData, e.newData)
                },
                scrolling: {
                    mode: ""virtual"",
                    rowRenderingMode: ""virtual""
                },
                paging: {
                    pageSize: 100
                },
                editing: {
                    useIcons: true,
                    allowUpdating: true,
                    allowDeleting: true,
                    allowAdding: true
                },
                headerFilter: {
                    visible: true
                },
                wordWrapEnabled: true,
                showColumnLines: true,
                showRowLines: true,
           ");
                WriteLiteral(@"     rowAlternationEnabled: true,
                showBorders: true,
                searchPanel: {
                    visible: true
                },
                stateStoring: {
                    enabled: true,
                    type: ""localStorage"",
                    storageKey: ""ProductAdmin""
                },
                columns: [
                    {
                        caption: '");
#nullable restore
#line 86 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Product\Index.cshtml"
                             Write(SharedLocalizer["Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        dataField: \"name\",\r\n                        allowHeaderFiltering: false\r\n                    },\r\n                    {\r\n                        caption: \'");
#nullable restore
#line 91 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Product\Index.cshtml"
                             Write(SharedLocalizer["Short description"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        dataField: \"shortDesc\",\r\n                        allowHeaderFiltering: false\r\n                    },\r\n                    {\r\n                        caption: \'");
#nullable restore
#line 96 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Product\Index.cshtml"
                             Write(SharedLocalizer["Description"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        dataField: \"description\",\r\n                        allowHeaderFiltering: false\r\n                    },\r\n                    {\r\n                        caption: \'");
#nullable restore
#line 101 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Product\Index.cshtml"
                             Write(SharedLocalizer["Picture"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        dataField: \"image\",\r\n                        allowHeaderFiltering: false\r\n                    },\r\n                     {\r\n                        caption: \'");
#nullable restore
#line 106 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Product\Index.cshtml"
                             Write(SharedLocalizer["Sort Order"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        dataField: \"sortOrder\",\r\n                        width: 130,\r\n                        allowHeaderFiltering: false\r\n                    },\r\n                    {\r\n                        caption: \'");
#nullable restore
#line 112 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Product\Index.cshtml"
                             Write(SharedLocalizer["Request File"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        dataField: \"requestFile\",\r\n                        allowHeaderFiltering: false\r\n                    },\r\n                    {\r\n                        caption: \'");
#nullable restore
#line 117 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Product\Index.cshtml"
                             Write(SharedLocalizer["Download File"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        dataField: \"downloadFile\",\r\n                        allowHeaderFiltering: false\r\n                    },\r\n                     {\r\n                        caption: \'");
#nullable restore
#line 122 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Product\Index.cshtml"
                             Write(SharedLocalizer["Active"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        dataField: ""isPublish"",
                        width: ""130"",
                        allowHeaderFiltering: false
                    },
                    {
                        type: ""buttons"",
                        width: 110,
                        buttons: [
                            {
                                hint: '");
#nullable restore
#line 132 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Product\Index.cshtml"
                                  Write(SharedLocalizer["Edit"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                                icon: \"edit\",\r\n                                onClick: function (e) {\r\n                                    var idString = e.row.data.productId;\r\n                                    var url = `");
#nullable restore
#line 136 "C:\Users\User\Desktop\React\HH.web\HH.web\Views\Product\Index.cshtml"
                                          Write(Url.Action("Edit", "Product"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`;
                                    window.location = url + '?id=' + idString;
                                }
                            },
                            ""delete""
                        ]
                    }
                ]
            });

        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
