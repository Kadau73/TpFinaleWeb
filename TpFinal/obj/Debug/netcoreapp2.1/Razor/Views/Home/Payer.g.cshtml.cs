#pragma checksum "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Payer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ae4727d327d1f376ce3340ff9b98259eb9e910e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Payer), @"mvc.1.0.view", @"/Views/Home/Payer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Payer.cshtml", typeof(AspNetCore.Views_Home_Payer))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ae4727d327d1f376ce3340ff9b98259eb9e910e", @"/Views/Home/Payer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c748c720050b48fba7c289f18e857acb517d8434", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Payer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TpFinal.Models.Paiement>
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
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Payer.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(61, 22, true);
            WriteLiteral("\r\n<!DOCTYPE>\r\n<html>\r\n");
            EndContext();
            BeginContext(83, 324, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d3440ab6685422dacc7c1583d9ddb7e", async() => {
                BeginContext(89, 311, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <link rel=""stylesheet"" href=""/css/styles.css"" />
    <link rel=""stylesheet"" href=""/lib/bootstrap/dist/css/bootstrap.css"" />
    <title>Payer</title>
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
            BeginContext(407, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(409, 455, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d877e0d4e3b4b3685c971c4523d403c", async() => {
                BeginContext(415, 94, true);
                WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1>Paiement Reçu!</h1>\r\n        <div class=\"lead\">\r\n");
                EndContext();
#line 24 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Payer.cshtml"
             if (Model.Montant > 0)
            {

#line default
#line hidden
                BeginContext(561, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(579, 25, true);
                WriteLiteral("Inscription Enregistrer\r\n");
                EndContext();
#line 27 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Payer.cshtml"
            }
            else
            {

#line default
#line hidden
                BeginContext(652, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(670, 23, true);
                WriteLiteral("Inscription gratuite?\r\n");
                EndContext();
#line 31 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Payer.cshtml"
            }

#line default
#line hidden
                BeginContext(708, 35, true);
                WriteLiteral("            <p>\r\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 743, "\"", 785, 1);
#line 33 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Payer.cshtml"
WriteAttributeValue("", 750, Url.Action("ListPaiement", "Home"), 750, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(786, 71, true);
                WriteLiteral(">Voir</a> les paiement?\r\n            </p>\r\n        </div>\r\n    </div>\r\n");
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
            BeginContext(864, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TpFinal.Models.Paiement> Html { get; private set; }
    }
}
#pragma warning restore 1591
