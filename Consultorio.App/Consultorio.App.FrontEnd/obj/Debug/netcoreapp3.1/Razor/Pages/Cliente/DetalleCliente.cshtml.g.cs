#pragma checksum "C:\Users\ASUS\OneDrive\Escritorio\U\ProyectoConsultorio-1\Consultorio.App\Consultorio.App.FrontEnd\Pages\Cliente\DetalleCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39258850b665070ef37d293a285143ece570d8c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Consultorio.App.FrontEnd.Pages.Cliente.Pages_Cliente_DetalleCliente), @"mvc.1.0.razor-page", @"/Pages/Cliente/DetalleCliente.cshtml")]
namespace Consultorio.App.FrontEnd.Pages.Cliente
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
#line 1 "C:\Users\ASUS\OneDrive\Escritorio\U\ProyectoConsultorio-1\Consultorio.App\Consultorio.App.FrontEnd\Pages\_ViewImports.cshtml"
using Consultorio.App.FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39258850b665070ef37d293a285143ece570d8c8", @"/Pages/Cliente/DetalleCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932b505c31a826811756a8115dee8ee3c7ce4bac", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cliente_DetalleCliente : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Detalle Cliente</h1>\r\n\r\n<ul>\r\n    <li>Documento: ");
#nullable restore
#line 8 "C:\Users\ASUS\OneDrive\Escritorio\U\ProyectoConsultorio-1\Consultorio.App\Consultorio.App.FrontEnd\Pages\Cliente\DetalleCliente.cshtml"
              Write(Model.cliente.Documento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Nombre: ");
#nullable restore
#line 9 "C:\Users\ASUS\OneDrive\Escritorio\U\ProyectoConsultorio-1\Consultorio.App\Consultorio.App.FrontEnd\Pages\Cliente\DetalleCliente.cshtml"
           Write(Model.cliente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Apellido: ");
#nullable restore
#line 10 "C:\Users\ASUS\OneDrive\Escritorio\U\ProyectoConsultorio-1\Consultorio.App\Consultorio.App.FrontEnd\Pages\Cliente\DetalleCliente.cshtml"
             Write(Model.cliente.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Fecha de naciemineto: ");
#nullable restore
#line 11 "C:\Users\ASUS\OneDrive\Escritorio\U\ProyectoConsultorio-1\Consultorio.App\Consultorio.App.FrontEnd\Pages\Cliente\DetalleCliente.cshtml"
                         Write(Model.cliente.FechaNacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Ciudad: ");
#nullable restore
#line 12 "C:\Users\ASUS\OneDrive\Escritorio\U\ProyectoConsultorio-1\Consultorio.App\Consultorio.App.FrontEnd\Pages\Cliente\DetalleCliente.cshtml"
           Write(Model.cliente.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Correo Electronico:");
#nullable restore
#line 13 "C:\Users\ASUS\OneDrive\Escritorio\U\ProyectoConsultorio-1\Consultorio.App\Consultorio.App.FrontEnd\Pages\Cliente\DetalleCliente.cshtml"
                      Write(Model.cliente.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Direccion: ");
#nullable restore
#line 14 "C:\Users\ASUS\OneDrive\Escritorio\U\ProyectoConsultorio-1\Consultorio.App\Consultorio.App.FrontEnd\Pages\Cliente\DetalleCliente.cshtml"
              Write(Model.cliente.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Telefono: ");
#nullable restore
#line 15 "C:\Users\ASUS\OneDrive\Escritorio\U\ProyectoConsultorio-1\Consultorio.App\Consultorio.App.FrontEnd\Pages\Cliente\DetalleCliente.cshtml"
             Write(Model.cliente.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Genero: ");
#nullable restore
#line 16 "C:\Users\ASUS\OneDrive\Escritorio\U\ProyectoConsultorio-1\Consultorio.App\Consultorio.App.FrontEnd\Pages\Cliente\DetalleCliente.cshtml"
           Write(Model.cliente.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.DetalleClienteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetalleClienteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetalleClienteModel>)PageContext?.ViewData;
        public MyApp.Namespace.DetalleClienteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
