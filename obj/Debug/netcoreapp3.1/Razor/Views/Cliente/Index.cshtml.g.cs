#pragma checksum "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cf251ff864f0851446613c1e36595d390d9f80f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Index), @"mvc.1.0.view", @"/Views/Cliente/Index.cshtml")]
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
#line 1 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\_ViewImports.cshtml"
using FerroApp.Consume;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\_ViewImports.cshtml"
using FerroApp.Consume.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cf251ff864f0851446613c1e36595d390d9f80f", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6c4d0c28a23c9c2b8a86fbf3a5e31e4058505c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FerroApp.Consume.Models.Cliente>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Cliente\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutAdmin2.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-content"">
    <div class=""section_content section_content--p30"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-9"">
                    <h2 class=""title-1 m-b-25"">Información</h2>
                    <table class=""table table-borderless table-striped table-earning"">
                        <thead>
                            <tr>
");
            WriteLiteral("                                <th>\r\n                                    ");
#nullable restore
#line 24 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Cliente\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 27 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Cliente\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.ApellidoPaterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 30 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Cliente\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.ApellidoMaterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 33 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Cliente\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 36 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Cliente\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Cp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n");
            WriteLiteral("                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 42 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Cliente\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n");
            WriteLiteral("                                    <td>\r\n                                        ");
#nullable restore
#line 52 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Cliente\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 55 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Cliente\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ApellidoPaterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 58 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Cliente\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ApellidoMaterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 61 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Cliente\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 64 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Cliente\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Cp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n");
            WriteLiteral("                                </tr>\r\n");
#nullable restore
#line 72 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Cliente\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FerroApp.Consume.Models.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
