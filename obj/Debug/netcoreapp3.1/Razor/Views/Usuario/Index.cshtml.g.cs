#pragma checksum "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33a1b4aec9865534cac452072e9d0a17d52efef0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33a1b4aec9865534cac452072e9d0a17d52efef0", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6c4d0c28a23c9c2b8a86fbf3a5e31e4058505c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FerroApp.Consume.Models.Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Usuario\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-content"">
    <div class=""section_content section_content--p30"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-9"">
                    <h2 class=""title-1 m-b-25"">Usuarios</h2>
                    <table class=""table table-borderless table-striped table-earning"">
                        <thead>
                            <tr>
                                <th>
                                    ");
#nullable restore
#line 18 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Usuario\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.IdUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 21 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Usuario\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 24 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Usuario\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Contraseña));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th></th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 30 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Usuario\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 34 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Usuario\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.IdUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 37 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Usuario\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 40 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Usuario\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Contraseña));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 43 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Usuario\Index.cshtml"
                                   Write(Html.ActionLink("Editar", "Update", new {  IdUsuario = item.IdUsuario  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                                        ");
#nullable restore
#line 44 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Usuario\Index.cshtml"
                                   Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                                        ");
#nullable restore
#line 45 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Usuario\Index.cshtml"
                                   Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 48 "C:\Users\carna\Desktop\Version 3.0 Proyecto FerroApp Nuevo datatype y views actualizadas con nuevos controlladores\FerroApp.Consume\Views\Usuario\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FerroApp.Consume.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
