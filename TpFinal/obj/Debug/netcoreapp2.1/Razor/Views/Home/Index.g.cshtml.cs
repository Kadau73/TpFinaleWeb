#pragma checksum "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9d999c9750c4a3d1a8b5482437de82b075fbc54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9d999c9750c4a3d1a8b5482437de82b075fbc54", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c748c720050b48fba7c289f18e857acb517d8434", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(56, 418, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5dbf0929e2e486c8cda0f31bf5b3f6a", async() => {
                BeginContext(62, 405, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <link rel=""stylesheet"" href=""/css/styles.css"" />
    <link rel=""stylesheet"" href=""/lib/bootstrap/dist/css/bootstrap.css"" />
    <title>Index</title>
    <style>
        .btn a {
            color: white;
            text-decoration: none;
        }

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
            BeginContext(474, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(476, 1031, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08b271fff5294fc194ae1a1b64621e3d", async() => {
                BeginContext(482, 153, true);
                WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1>Inscription Participant</h1>\r\n        <h2>Hackfest</h2>\r\n        <div class=\"btn btn-success\">\r\n            ");
                EndContext();
                BeginContext(636, 44, false);
#line 29 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Index.cshtml"
       Write(Html.ActionLink("Inscription", "Formulaire"));

#line default
#line hidden
                EndContext();
                BeginContext(680, 45, true);
                WriteLiteral("\r\n        </div>\r\n        <p>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 725, "\"", 770, 1);
#line 32 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Index.cshtml"
WriteAttributeValue("", 732, Url.Action("ListInscription", "Home"), 732, 38, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(771, 204, true);
                WriteLiteral(">Voir</a> les gens inscrit?\r\n        </p>\r\n    </div>\r\n    <div class=\"text-center\">\r\n        <h1>Inscription MembresCO</h1>\r\n        <h2>Hackfest</h2>\r\n        <div class=\"btn btn-success\">\r\n            ");
                EndContext();
                BeginContext(976, 53, false);
#line 39 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Index.cshtml"
       Write(Html.ActionLink("Inscription", "FormulaireMembresCO"));

#line default
#line hidden
                EndContext();
                BeginContext(1029, 45, true);
                WriteLiteral("\r\n        </div>\r\n        <p>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1074, "\"", 1116, 1);
#line 42 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Index.cshtml"
WriteAttributeValue("", 1081, Url.Action("ListMembreCO", "Home"), 1081, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1117, 201, true);
                WriteLiteral(">Voir</a> les autres membres?\r\n        </p>\r\n    </div>\r\n    <div class=\"text-center\">\r\n        <h1>Valider Paiement</h1>\r\n        <h2>Hackfest</h2>\r\n        <div class=\"btn btn-success\">\r\n            ");
                EndContext();
                BeginContext(1319, 42, false);
#line 49 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Index.cshtml"
       Write(Html.ActionLink("Connecter", "Connection"));

#line default
#line hidden
                EndContext();
                BeginContext(1361, 45, true);
                WriteLiteral("\r\n        </div>\r\n        <p>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1406, "\"", 1448, 1);
#line 52 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Index.cshtml"
WriteAttributeValue("", 1413, Url.Action("ListPaiement", "Home"), 1413, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1449, 51, true);
                WriteLiteral(">Voir</a> les paiement?\r\n        </p>\r\n    </div>\r\n");
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
            BeginContext(1507, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
