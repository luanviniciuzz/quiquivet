#pragma checksum "C:\Users\Samsung\Desktop\SENAC\Tec Info WEB\Projeto Integrador\Modulo A\Atividade 3\Views\Consultorio\DetalhesCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc2ea997f7e0336acc9deb9062243a19604665ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consultorio_DetalhesCliente), @"mvc.1.0.view", @"/Views/Consultorio/DetalhesCliente.cshtml")]
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
#line 1 "C:\Users\Samsung\Desktop\SENAC\Tec Info WEB\Projeto Integrador\Modulo A\Atividade 3\Views\_ViewImports.cshtml"
using Atividade_3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Samsung\Desktop\SENAC\Tec Info WEB\Projeto Integrador\Modulo A\Atividade 3\Views\_ViewImports.cshtml"
using Atividade_3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc2ea997f7e0336acc9deb9062243a19604665ff", @"/Views/Consultorio/DetalhesCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99e43bac888d357e5918e26d191ba197ce983de5", @"/Views/_ViewImports.cshtml")]
    public class Views_Consultorio_DetalhesCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Atividade_3.Models.Cliente>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Samsung\Desktop\SENAC\Tec Info WEB\Projeto Integrador\Modulo A\Atividade 3\Views\Consultorio\DetalhesCliente.cshtml"
  
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalhes: ");
#nullable restore
#line 7 "C:\Users\Samsung\Desktop\SENAC\Tec Info WEB\Projeto Integrador\Modulo A\Atividade 3\Views\Consultorio\DetalhesCliente.cshtml"
         Write(Html.DisplayFor(model => model.nomeCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div>    \r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "C:\Users\Samsung\Desktop\SENAC\Tec Info WEB\Projeto Integrador\Modulo A\Atividade 3\Views\Consultorio\DetalhesCliente.cshtml"
       Write(Html.DisplayNameFor(model => model.idCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\Users\Samsung\Desktop\SENAC\Tec Info WEB\Projeto Integrador\Modulo A\Atividade 3\Views\Consultorio\DetalhesCliente.cshtml"
       Write(Html.DisplayFor(model => model.idCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\Users\Samsung\Desktop\SENAC\Tec Info WEB\Projeto Integrador\Modulo A\Atividade 3\Views\Consultorio\DetalhesCliente.cshtml"
       Write(Html.DisplayNameFor(model => model.nomeCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\Samsung\Desktop\SENAC\Tec Info WEB\Projeto Integrador\Modulo A\Atividade 3\Views\Consultorio\DetalhesCliente.cshtml"
       Write(Html.DisplayFor(model => model.nomeCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Samsung\Desktop\SENAC\Tec Info WEB\Projeto Integrador\Modulo A\Atividade 3\Views\Consultorio\DetalhesCliente.cshtml"
       Write(Html.DisplayNameFor(model => model.dtNascimentoCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\Samsung\Desktop\SENAC\Tec Info WEB\Projeto Integrador\Modulo A\Atividade 3\Views\Consultorio\DetalhesCliente.cshtml"
       Write(Html.DisplayFor(model => model.dtNascimentoCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\Users\Samsung\Desktop\SENAC\Tec Info WEB\Projeto Integrador\Modulo A\Atividade 3\Views\Consultorio\DetalhesCliente.cshtml"
       Write(Html.DisplayNameFor(model => model.rgCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\Samsung\Desktop\SENAC\Tec Info WEB\Projeto Integrador\Modulo A\Atividade 3\Views\Consultorio\DetalhesCliente.cshtml"
       Write(Html.DisplayFor(model => model.rgCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\Samsung\Desktop\SENAC\Tec Info WEB\Projeto Integrador\Modulo A\Atividade 3\Views\Consultorio\DetalhesCliente.cshtml"
       Write(Html.DisplayNameFor(model => model.cpfCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\Samsung\Desktop\SENAC\Tec Info WEB\Projeto Integrador\Modulo A\Atividade 3\Views\Consultorio\DetalhesCliente.cshtml"
       Write(Html.DisplayFor(model => model.cpfCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "C:\Users\Samsung\Desktop\SENAC\Tec Info WEB\Projeto Integrador\Modulo A\Atividade 3\Views\Consultorio\DetalhesCliente.cshtml"
       Write(Html.DisplayNameFor(model => model.telefoneCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "C:\Users\Samsung\Desktop\SENAC\Tec Info WEB\Projeto Integrador\Modulo A\Atividade 3\Views\Consultorio\DetalhesCliente.cshtml"
       Write(Html.DisplayFor(model => model.telefoneCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n         <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 49 "C:\Users\Samsung\Desktop\SENAC\Tec Info WEB\Projeto Integrador\Modulo A\Atividade 3\Views\Consultorio\DetalhesCliente.cshtml"
       Write(Html.DisplayNameFor(model => model.emailCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 52 "C:\Users\Samsung\Desktop\SENAC\Tec Info WEB\Projeto Integrador\Modulo A\Atividade 3\Views\Consultorio\DetalhesCliente.cshtml"
       Write(Html.DisplayFor(model => model.emailCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>       \r\n    </dl>\r\n</div>\r\n<div>\r\n    <a class=\"text-body\" href=\"/Consultorio/ListaCliente\" style=\"text-decoration:none\">Voltar</a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Atividade_3.Models.Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591
