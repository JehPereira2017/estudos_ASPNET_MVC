#pragma checksum "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2408e6b7134d4ff83768d433e128767a50cb39e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estabelecimento_Delete), @"mvc.1.0.view", @"/Views/Estabelecimento/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Estabelecimento/Delete.cshtml", typeof(AspNetCore.Views_Estabelecimento_Delete))]
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
#line 1 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\_ViewImports.cshtml"
using CadastroCNPJ;

#line default
#line hidden
#line 2 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\_ViewImports.cshtml"
using CadastroCNPJ.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2408e6b7134d4ff83768d433e128767a50cb39e5", @"/Views/Estabelecimento/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a1a8dc181bd006a6c0c6eba2a916d2f7b43a5a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Estabelecimento_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CadastroCNPJ.Models.Estabelecimento>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(88, 153, true);
            WriteLiteral("\r\n\r\n<h3>Tem certeza que deseja deletar?</h3>\r\n<div>\r\n    <h4>Estabelecimento</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(242, 47, false);
#line 14 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Razaosocial));

#line default
#line hidden
            EndContext();
            BeginContext(289, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(333, 43, false);
#line 17 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Razaosocial));

#line default
#line hidden
            EndContext();
            BeginContext(376, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(420, 48, false);
#line 20 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NomeFantasia));

#line default
#line hidden
            EndContext();
            BeginContext(468, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(512, 44, false);
#line 23 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NomeFantasia));

#line default
#line hidden
            EndContext();
            BeginContext(556, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(600, 40, false);
#line 26 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cnpj));

#line default
#line hidden
            EndContext();
            BeginContext(640, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(684, 36, false);
#line 29 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cnpj));

#line default
#line hidden
            EndContext();
            BeginContext(720, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(764, 41, false);
#line 32 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(805, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(849, 37, false);
#line 35 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(886, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(930, 48, false);
#line 38 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DataCadastro));

#line default
#line hidden
            EndContext();
            BeginContext(978, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1022, 44, false);
#line 41 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DataCadastro));

#line default
#line hidden
            EndContext();
            BeginContext(1066, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1110, 46, false);
#line 44 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(1156, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1200, 42, false);
#line 47 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(1242, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1286, 42, false);
#line 50 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(1328, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1372, 38, false);
#line 53 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(1410, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1454, 44, false);
#line 56 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
            EndContext();
            BeginContext(1498, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1542, 40, false);
#line 59 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Telefone));

#line default
#line hidden
            EndContext();
            BeginContext(1582, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1626, 43, false);
#line 62 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Agencia));

#line default
#line hidden
            EndContext();
            BeginContext(1669, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1713, 39, false);
#line 65 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Agencia));

#line default
#line hidden
            EndContext();
            BeginContext(1752, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1796, 41, false);
#line 68 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Conta));

#line default
#line hidden
            EndContext();
            BeginContext(1837, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1881, 37, false);
#line 71 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Conta));

#line default
#line hidden
            EndContext();
            BeginContext(1918, 95, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Categoria\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2014, 72, false);
#line 77 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdCategoriaNavigation.DescricaoCategoria));

#line default
#line hidden
            EndContext();
            BeginContext(2086, 92, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Cidade\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2179, 60, false);
#line 83 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdCidadeNavigation.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(2239, 92, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Estado\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2332, 59, false);
#line 89 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdEstadoNavigation.IdEstado));

#line default
#line hidden
            EndContext();
            BeginContext(2391, 92, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Status\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2484, 79, false);
#line 95 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StatusEstabelecimentoNavigation.DescricaoStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2563, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2601, 231, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14ec680df332456783546e2b447654ac", async() => {
                BeginContext(2627, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2637, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5c57f3314072406db8ed51d26f6a4efe", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 100 "C:\Web_Curso\estudos_ASPNET_MVC\cadastrocnpj\Views\Estabelecimento\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdEstabelecimento);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2688, 85, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Deletar\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2773, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9b20dde55ba42918ebc9bb4e4384545", async() => {
                    BeginContext(2795, 20, true);
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
                BeginContext(2819, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2832, 10, true);
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
