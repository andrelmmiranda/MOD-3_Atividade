#pragma checksum "C:\Users\Micro\source\repos\ViagemTour\ViagemTour\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffee0a2dad40fa3b38cb30ecad8b7c859d9d03e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffee0a2dad40fa3b38cb30ecad8b7c859d9d03e4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eed0504a8b08f666ddf94dc6b5849bab4bd00122", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Micro\source\repos\ViagemTour\ViagemTour\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    ViewData["class"] = "HomePage";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>
-->

<div id=""home"">
    <div id=""main-text-group"">
        <h2>Conheça a Viagens Tour</h2>
        <p>Viagens seguras e com preço amigável, para todas as partes do mundo!</p>
        <p id=""aviso"">*Lorem ipsum dolor sit amet consectetur adipisicing elit. Corporis quia facere molestias neque consectetur quae dolor illum excepturi qui voluptas est quaerat expedita, magni commodi quas illo animi quisquam consequuntur.</p>
    </div>
</div>

");
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
