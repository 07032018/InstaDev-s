#pragma checksum "C:\Users\JoViO\OneDrive\Documentos\GitHub\InstaDev-s\Views\EdicaoDePerfil\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "284fca117aaa9f786e3ae6acd3aa0710c7ffcc87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EdicaoDePerfil_Index), @"mvc.1.0.view", @"/Views/EdicaoDePerfil/Index.cshtml")]
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
#line 1 "C:\Users\JoViO\OneDrive\Documentos\GitHub\InstaDev-s\Views\_ViewImports.cshtml"
using InstaDev_s;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"284fca117aaa9f786e3ae6acd3aa0710c7ffcc87", @"/Views/EdicaoDePerfil/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5d7a878715c99d5678c43065c35e3e81c224eb6", @"/Views/_ViewImports.cshtml")]
    public class Views_EdicaoDePerfil_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\JoViO\OneDrive\Documentos\GitHub\InstaDev-s\Views\EdicaoDePerfil\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""E-contain"">
    <div class=""E-conteudo1"">
        <div class=""E-container"">
            <hr class=""E-linha"">
            <h2>Editar Perfil</h2>
        </div>
        <div class=""E-container1"">
            <div class=""E-conteudo"">
                <div class=""E-foto-user"">
                    <div>
                        <img src=""imgEdicaoDePerfil/User.svg""");
            BeginWriteAttribute("alt", " alt=\"", 427, "\"", 433, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""E-info-user"">
                        <h2>yes_baby</h2>
                        <div class=""E-alterar"">
                            <h3>Alterar foto de perfil</h3>
                        </div>
                    </div>
                </div>
                <div class=""E-editarnome"">
                    <div class=""E-nomeimput"">
                        <label>Nome</label>
                    </div>
                    <div class=""E-Editar"">
                        <input class=""E-imputnome"" value=""Marcos Jeeves"" type=""text"">
                        <p class=""E-texto1"">Ajude as pessoas a descobrir sua conta usando o nome pelo qual <br>
                            você é conhecido: seu
                            nome
                            completo, apelido ou nome <br> comercial.</p>
                        <p>Você pode alterar o seu nome apenas duas vezes a cada 14 dias.</p>
                    </div>
                </");
            WriteLiteral(@"div>
                <div class=""E-editperfil"">
                    <div class=""E-labelperfil"">
                        <Label>Nome de perfil</Label>
                    </div>
                    <div class=""E-imputusuario1"">
                        <input class=""E-imputusuario"" value=""Yes_baby"" type=""text"">
                        <p class=""E-texto2"">Na maioria dos casos, você poderá alterar seu nome de usuário <br>
                            novamente para
                            nascimento_tr por mais 14 dias.</p>
                        <p><strong>Informações Pessoais</strong></p>
                        <p>Forneça suas informações pessoais, mesmo se a conta for usada <br> para uma empresa,
                            um
                            animal de estimação ou outra coisa. Elas <br> não farão parte do seu perfil público.
                        </p>

                    </div>
                </div>
                <div class=""E-editemail1"">
                    <Label>E");
            WriteLiteral(@"mail</Label>
                    <input class=""E-imputemail"" value=""yes_baby@email.com"" type=""text""></imput>
                </div>
                <div class=""E-botao"">
                    <button class=""E-enviar"">Enviar</button> <a href=""#"">Desativar minha conta definitivamente</a>
                </div>
            </div>
        </div>
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
