#pragma checksum "C:\Users\Micro\source\repos\ViagemTour\ViagemTour\Views\Admin\MensagemContatos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7ccb36d4046f20547fd2272d7da5590c7b81d10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_MensagemContatos), @"mvc.1.0.view", @"/Views/Admin/MensagemContatos.cshtml")]
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
#line 1 "C:\Users\Micro\source\repos\ViagemTour\ViagemTour\Views\_ViewImports.cshtml"
using ViagemTour;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Micro\source\repos\ViagemTour\ViagemTour\Views\_ViewImports.cshtml"
using ViagemTour.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7ccb36d4046f20547fd2272d7da5590c7b81d10", @"/Views/Admin/MensagemContatos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eed0504a8b08f666ddf94dc6b5849bab4bd00122", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_MensagemContatos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Micro\source\repos\ViagemTour\ViagemTour\Views\Admin\MensagemContatos.cshtml"
  
    ViewData["Title"] = "MensagemContatos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div style=\"display:flex; justify-content: space-between; align-items: center\">\r\n    <h1 style=\"display:inline-block\">Mensagens</h1>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7ccb36d4046f20547fd2272d7da5590c7b81d104129", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Micro\source\repos\ViagemTour\ViagemTour\Views\Admin\MensagemContatos.cshtml"
 if (ViewBag.dados.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>N??o existem mensagens dispon??veis para serem listadas</p>\r\n");
#nullable restore
#line 13 "C:\Users\Micro\source\repos\ViagemTour\ViagemTour\Views\Admin\MensagemContatos.cshtml"
}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Nome</th>
                <th scope=""col"">Email</th>
                <th scope=""col"">Mensagem</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 28 "C:\Users\Micro\source\repos\ViagemTour\ViagemTour\Views\Admin\MensagemContatos.cshtml"
              int n = ViewBag.dados.Count; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Micro\source\repos\ViagemTour\ViagemTour\Views\Admin\MensagemContatos.cshtml"
             foreach (Contato contato in ViewBag.dados)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 32 "C:\Users\Micro\source\repos\ViagemTour\ViagemTour\Views\Admin\MensagemContatos.cshtml"
                               Write(n);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\Micro\source\repos\ViagemTour\ViagemTour\Views\Admin\MensagemContatos.cshtml"
                   Write(contato.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\Micro\source\repos\ViagemTour\ViagemTour\Views\Admin\MensagemContatos.cshtml"
                   Write(contato.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\Micro\source\repos\ViagemTour\ViagemTour\Views\Admin\MensagemContatos.cshtml"
                   Write(contato.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 37 "C:\Users\Micro\source\repos\ViagemTour\ViagemTour\Views\Admin\MensagemContatos.cshtml"
                   Write(Html.ActionLink("Apagar", "DeleteContato", new { id = contato.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Micro\source\repos\ViagemTour\ViagemTour\Views\Admin\MensagemContatos.cshtml"
                n--;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 44 "C:\Users\Micro\source\repos\ViagemTour\ViagemTour\Views\Admin\MensagemContatos.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
