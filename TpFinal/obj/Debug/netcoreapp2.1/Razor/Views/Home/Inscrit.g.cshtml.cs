#pragma checksum "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Inscrit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "583ec195fb5324e2deabd3f020a617e4388a4bca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Inscrit), @"mvc.1.0.view", @"/Views/Home/Inscrit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Inscrit.cshtml", typeof(AspNetCore.Views_Home_Inscrit))]
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
#line 1 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\_ViewImports.cshtml"
using TpFinal;

#line default
#line hidden
#line 2 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\_ViewImports.cshtml"
using TpFinal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"583ec195fb5324e2deabd3f020a617e4388a4bca", @"/Views/Home/Inscrit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c748c720050b48fba7c289f18e857acb517d8434", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Inscrit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TpFinal.Models.InscrireParticipant>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Inscrit.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(72, 22, true);
            WriteLiteral("\r\n<!DOCTYPE>\r\n<html>\r\n");
            EndContext();
            BeginContext(94, 326, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d745a0f1f17d4a8db29886715a1f7625", async() => {
                BeginContext(100, 313, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <link rel=""stylesheet"" href=""/css/styles.css"" />
    <link rel=""stylesheet"" href=""/lib/bootstrap/dist/css/bootstrap.css"" />
    <title>Inscrit</title>
    <style>
        body {
            background-color: #f1f1f1;
        }
    </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(420, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(422, 469, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3441515a077c4a8fa2e94ea2b42e80b1", async() => {
                BeginContext(428, 51, true);
                WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1>Merci ");
                EndContext();
                BeginContext(480, 12, false);
#line 22 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Inscrit.cshtml"
             Write(Model.Prenom);

#line default
#line hidden
                EndContext();
                BeginContext(492, 37, true);
                WriteLiteral(" !</h1>\r\n        <div class=\"lead\">\r\n");
                EndContext();
#line 24 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Inscrit.cshtml"
             if (Model.Montant > 0)
            {

#line default
#line hidden
                BeginContext(581, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(599, 25, true);
                WriteLiteral("Inscription Enregistrer\r\n");
                EndContext();
#line 27 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Inscrit.cshtml"
            }
            else
            {

#line default
#line hidden
                BeginContext(672, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(690, 23, true);
                WriteLiteral("Inscription gratuite?\r\n");
                EndContext();
#line 31 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Inscrit.cshtml"
            }

#line default
#line hidden
                BeginContext(728, 35, true);
                WriteLiteral("            <p>\r\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 763, "\"", 808, 1);
#line 33 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Inscrit.cshtml"
WriteAttributeValue("", 770, Url.Action("ListInscription", "Home"), 770, 38, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(809, 75, true);
                WriteLiteral(">Voir</a> les gens inscrit?\r\n            </p>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(891, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TpFinal.Models.InscrireParticipant> Html { get; private set; }
    }
}
#pragma warning restore 1591
