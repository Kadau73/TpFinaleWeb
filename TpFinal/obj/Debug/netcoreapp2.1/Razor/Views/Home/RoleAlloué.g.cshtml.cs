#pragma checksum "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\RoleAlloué.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c4dd0e64827b2e78fb19c177409ecb5ff5b60e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RoleAlloué), @"mvc.1.0.view", @"/Views/Home/RoleAlloué.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/RoleAlloué.cshtml", typeof(AspNetCore.Views_Home_RoleAlloué))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c4dd0e64827b2e78fb19c177409ecb5ff5b60e5", @"/Views/Home/RoleAlloué.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c748c720050b48fba7c289f18e857acb517d8434", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RoleAlloué : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TpFinal.Models.Organisateur>
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
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\RoleAlloué.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(65, 22, true);
            WriteLiteral("\r\n<!DOCTYPE>\r\n<html>\r\n");
            EndContext();
            BeginContext(87, 329, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c74fff38dfb744d18490019c28aba7a6", async() => {
                BeginContext(93, 316, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <link rel=""stylesheet"" href=""/css/styles.css"" />
    <link rel=""stylesheet"" href=""/lib/bootstrap/dist/css/bootstrap.css"" />
    <title>RôleAlloué</title>
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
            BeginContext(416, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(418, 584, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8b0dc986844483c85e0150dc8bc1698", async() => {
                BeginContext(424, 53, true);
                WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1>Le rôle ");
                EndContext();
                BeginContext(478, 10, false);
#line 22 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\RoleAlloué.cshtml"
               Write(Model.Role);

#line default
#line hidden
                EndContext();
                BeginContext(488, 48, true);
                WriteLiteral(" à été alloué</h1>\r\n        <div class=\"lead\">\r\n");
                EndContext();
#line 24 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\RoleAlloué.cshtml"
             if (Model.Role != "")
            {

#line default
#line hidden
                BeginContext(587, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(605, 18, true);
                WriteLiteral("Role Enregistrer\r\n");
                EndContext();
#line 27 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\RoleAlloué.cshtml"
            }
            else
            {

#line default
#line hidden
                BeginContext(671, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(689, 32, true);
                WriteLiteral("Le membre n\'a pas reçu de rôle\r\n");
                EndContext();
#line 31 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\RoleAlloué.cshtml"
            }

#line default
#line hidden
                BeginContext(736, 35, true);
                WriteLiteral("            <p>\r\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 771, "\"", 813, 1);
#line 33 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\RoleAlloué.cshtml"
WriteAttributeValue("", 778, Url.Action("ListMembreCO", "Home"), 778, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(814, 116, true);
                WriteLiteral(">Voir</a> les autres membres?\r\n            </p>\r\n        </div>\r\n        <div class=\"btn btn-success\">\r\n            ");
                EndContext();
                BeginContext(931, 34, false);
#line 37 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\RoleAlloué.cshtml"
       Write(Html.ActionLink("Retour", "Index"));

#line default
#line hidden
                EndContext();
                BeginContext(965, 30, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
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
            BeginContext(1002, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TpFinal.Models.Organisateur> Html { get; private set; }
    }
}
#pragma warning restore 1591
