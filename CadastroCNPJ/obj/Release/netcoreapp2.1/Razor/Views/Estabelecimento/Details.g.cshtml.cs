#pragma checksum "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fc8d3463536c884bb4d6736c3b290368eb2603d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estabelecimento_Details), @"mvc.1.0.view", @"/Views/Estabelecimento/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Estabelecimento/Details.cshtml", typeof(AspNetCore.Views_Estabelecimento_Details))]
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
#line 1 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\_ViewImports.cshtml"
using CadastroCNPJ;

#line default
#line hidden
#line 2 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\_ViewImports.cshtml"
using CadastroCNPJ.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fc8d3463536c884bb4d6736c3b290368eb2603d", @"/Views/Estabelecimento/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a1a8dc181bd006a6c0c6eba2a916d2f7b43a5a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Estabelecimento_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CadastroCNPJ.Models.Estabelecimento>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
  
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
            BeginContext(90, 129, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Estabelecimento</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(220, 47, false);
#line 14 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Razaosocial));

#line default
#line hidden
            EndContext();
            BeginContext(267, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(311, 43, false);
#line 17 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
       Write(Html.DisplayFor(model => model.Razaosocial));

#line default
#line hidden
            EndContext();
            BeginContext(354, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(398, 48, false);
#line 20 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NomeFantasia));

#line default
#line hidden
            EndContext();
            BeginContext(446, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(490, 44, false);
#line 23 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
       Write(Html.DisplayFor(model => model.NomeFantasia));

#line default
#line hidden
            EndContext();
            BeginContext(534, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(578, 40, false);
#line 26 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cnpj));

#line default
#line hidden
            EndContext();
            BeginContext(618, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(662, 36, false);
#line 29 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cnpj));

#line default
#line hidden
            EndContext();
            BeginContext(698, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(742, 41, false);
#line 32 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(783, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(827, 37, false);
#line 35 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(864, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(908, 48, false);
#line 38 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataCadastro));

#line default
#line hidden
            EndContext();
            BeginContext(956, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1000, 44, false);
#line 41 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataCadastro));

#line default
#line hidden
            EndContext();
            BeginContext(1044, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1088, 46, false);
#line 44 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(1134, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1178, 42, false);
#line 47 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
       Write(Html.DisplayFor(model => model.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(1220, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1264, 42, false);
#line 50 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(1306, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1350, 38, false);
#line 53 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
       Write(Html.DisplayFor(model => model.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(1388, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1432, 44, false);
#line 56 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
            EndContext();
            BeginContext(1476, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1520, 40, false);
#line 59 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
       Write(Html.DisplayFor(model => model.Telefone));

#line default
#line hidden
            EndContext();
            BeginContext(1560, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1604, 43, false);
#line 62 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Agencia));

#line default
#line hidden
            EndContext();
            BeginContext(1647, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1691, 39, false);
#line 65 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
       Write(Html.DisplayFor(model => model.Agencia));

#line default
#line hidden
            EndContext();
            BeginContext(1730, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1774, 41, false);
#line 68 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Conta));

#line default
#line hidden
            EndContext();
            BeginContext(1815, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1859, 37, false);
#line 71 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
       Write(Html.DisplayFor(model => model.Conta));

#line default
#line hidden
            EndContext();
            BeginContext(1896, 95, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Categoria\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1992, 72, false);
#line 77 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdCategoriaNavigation.DescricaoCategoria));

#line default
#line hidden
            EndContext();
            BeginContext(2064, 92, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Cidade\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2157, 62, false);
#line 83 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdCidadeNavigation.IdMunicipio));

#line default
#line hidden
            EndContext();
            BeginContext(2219, 92, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Estado\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2312, 59, false);
#line 89 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdEstadoNavigation.IdEstado));

#line default
#line hidden
            EndContext();
            BeginContext(2371, 92, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Status\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2464, 79, false);
#line 95 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
       Write(Html.DisplayFor(model => model.StatusEstabelecimentoNavigation.DescricaoStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2543, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2590, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71a3e7d755c3474381981cbe40c8afb6", async() => {
                BeginContext(2653, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 100 "C:\Web_Curso\estudos_ASPNET_MVC\CadastroCNPJ\Views\Estabelecimento\Details.cshtml"
                             WriteLiteral(Model.IdEstabelecimento);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2661, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2669, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3de237301764783b6120ff4316f0e86", async() => {
                BeginContext(2691, 20, true);
                WriteLiteral("Voltar para listagem");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2715, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CadastroCNPJ.Models.Estabelecimento> Html { get; private set; }
    }
}
#pragma warning restore 1591
