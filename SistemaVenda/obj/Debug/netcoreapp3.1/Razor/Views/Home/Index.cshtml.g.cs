#pragma checksum "C:\Users\sival\OneDrive\CursosCSharp\AspNetUdemy\SistemaVenda\SistemaVenda\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c019f378d75e2f512e4ec50262a9390ed647140"
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
#line 1 "C:\Users\sival\OneDrive\CursosCSharp\AspNetUdemy\SistemaVenda\SistemaVenda\Views\_ViewImports.cshtml"
using SistemaVenda;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sival\OneDrive\CursosCSharp\AspNetUdemy\SistemaVenda\SistemaVenda\Views\_ViewImports.cshtml"
using SistemaVenda.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\sival\OneDrive\CursosCSharp\AspNetUdemy\SistemaVenda\SistemaVenda\Views\Home\Index.cshtml"
using SistemaVenda.Entidades;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c019f378d75e2f512e4ec50262a9390ed647140", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9542d2a040dc74eba97c4a394c73aefd7909e77c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Categoria>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\sival\OneDrive\CursosCSharp\AspNetUdemy\SistemaVenda\SistemaVenda\Views\Home\Index.cshtml"
 foreach(var item  in Model)
{
    var aux = item.Codigo + "-" + item.Descricao;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span>");
#nullable restore
#line 8 "C:\Users\sival\OneDrive\CursosCSharp\AspNetUdemy\SistemaVenda\SistemaVenda\Views\Home\Index.cshtml"
     Write(aux);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n");
#nullable restore
#line 9 "C:\Users\sival\OneDrive\CursosCSharp\AspNetUdemy\SistemaVenda\SistemaVenda\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Categoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
