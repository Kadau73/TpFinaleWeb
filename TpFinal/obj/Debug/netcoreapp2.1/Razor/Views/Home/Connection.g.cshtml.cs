#pragma checksum "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Connection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "049bf9a463c89451f97b8fb3b3f3d46d3a4f2077"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Connection), @"mvc.1.0.view", @"/Views/Home/Connection.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Connection.cshtml", typeof(AspNetCore.Views_Home_Connection))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"049bf9a463c89451f97b8fb3b3f3d46d3a4f2077", @"/Views/Home/Connection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c748c720050b48fba7c289f18e857acb517d8434", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Connection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TpFinal.Models.Organisateur>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/monStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Connection.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(65, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(94, 292, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e9efca6002847d693392bbf86c9e321", async() => {
                BeginContext(100, 195, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/css/styles.css\" />\r\n    <link rel=\"stylesheet\" href=\"/lib/bootstrap/dist/css/bootstrap.css\" />\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    ");
                EndContext();
                BeginContext(295, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7f5f7acfbfda4ede89f4892d0cdd9ebf", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(346, 33, true);
                WriteLiteral("\r\n    <title>Connection</title>\r\n");
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
            BeginContext(386, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(388, 1692, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3233d48de4a413b98c52636610234ba", async() => {
                BeginContext(394, 173, true);
                WriteLiteral("\r\n    <div class=\"panel panel-success\">\r\n        <div class=\"panel-heading text-center\">\r\n            <h4>Connection</h4>\r\n        </div>\r\n        <div class=\"panel-body\">\r\n");
                EndContext();
#line 23 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Connection.cshtml"
             using (Html.BeginForm())
            {
                

#line default
#line hidden
                BeginContext(638, 24, false);
#line 25 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Connection.cshtml"
           Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(664, 112, true);
                WriteLiteral("                <div class=\"form-group\">\r\n                    <label>Utilisateur :</label>\r\n                    ");
                EndContext();
                BeginContext(777, 72, false);
#line 28 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Connection.cshtml"
               Write(Html.TextBoxFor(i => i.CodeUtilisateur, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(849, 139, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Mot de passe :</label>\r\n                    ");
                EndContext();
                BeginContext(989, 65, false);
#line 32 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Connection.cshtml"
               Write(Html.TextBoxFor(i => i.Password, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1054, 136, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Role Membre</label>\r\n                    ");
                EndContext();
                BeginContext(1191, 467, false);
#line 36 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Connection.cshtml"
               Write(Html.DropDownListFor(i => i.Role,
                        new[]
                        {
                            new SelectListItem()
                            {
                                Text = " Responsable des Finances",
                                Value = "RFinances"
                            },
                            
                        },
                        "Choisissez une option", new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1658, 26, true);
                WriteLiteral("\r\n                </div>\r\n");
                EndContext();
                BeginContext(1686, 221, true);
                WriteLiteral("                <div class=\"text-center\">\r\n                    <input class=\"btn btn-success\" type=\"submit\" value=\"Go\" />\r\n                </div>\r\n                <div>\r\n                    <p>\r\n                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1907, "\"", 1942, 1);
#line 54 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Connection.cshtml"
WriteAttributeValue("", 1914, Url.Action("Index", "Home"), 1914, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1943, 87, true);
                WriteLiteral(">Retourner</a> à la page d\'acceuil?\r\n                    </p>\r\n                </div>\r\n");
                EndContext();
#line 57 "C:\420-Application_Web\TpFinaleWeb\TpFinal\Views\Home\Connection.cshtml"
            }

#line default
#line hidden
                BeginContext(2045, 28, true);
                WriteLiteral("        </div>\r\n    </div>\r\n");
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
            BeginContext(2080, 9, true);
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
