#pragma checksum "C:\Users\InfoPublic\Desktop\MatrixCRUDTech\MatrixCRUDTech\Views\IndicadorProgramas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e9103e1e085c4bf22df1b7e80c1a62b117f165b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_IndicadorProgramas_Details), @"mvc.1.0.view", @"/Views/IndicadorProgramas/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/IndicadorProgramas/Details.cshtml", typeof(AspNetCore.Views_IndicadorProgramas_Details))]
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
#line 1 "C:\Users\InfoPublic\Desktop\MatrixCRUDTech\MatrixCRUDTech\Views\_ViewImports.cshtml"
using MatrixCRUDTech;

#line default
#line hidden
#line 2 "C:\Users\InfoPublic\Desktop\MatrixCRUDTech\MatrixCRUDTech\Views\_ViewImports.cshtml"
using MatrixCRUDTech.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e9103e1e085c4bf22df1b7e80c1a62b117f165b", @"/Views/IndicadorProgramas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bcf4b4716db8517bc6adec1052ea77bd9baf6fb", @"/Views/_ViewImports.cshtml")]
    public class Views_IndicadorProgramas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MatrixCRUDTech.Models.IndicadorPrograma>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\InfoPublic\Desktop\MatrixCRUDTech\MatrixCRUDTech\Views\IndicadorProgramas\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(93, 131, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>IndicadorPrograma</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(225, 45, false);
#line 14 "C:\Users\InfoPublic\Desktop\MatrixCRUDTech\MatrixCRUDTech\Views\IndicadorProgramas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(270, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(314, 41, false);
#line 17 "C:\Users\InfoPublic\Desktop\MatrixCRUDTech\MatrixCRUDTech\Views\IndicadorProgramas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(355, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(399, 47, false);
#line 20 "C:\Users\InfoPublic\Desktop\MatrixCRUDTech\MatrixCRUDTech\Views\IndicadorProgramas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ObjPrograma));

#line default
#line hidden
            EndContext();
            BeginContext(446, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(490, 50, false);
#line 23 "C:\Users\InfoPublic\Desktop\MatrixCRUDTech\MatrixCRUDTech\Views\IndicadorProgramas\Details.cshtml"
       Write(Html.DisplayFor(model => model.ObjPrograma.Codigo));

#line default
#line hidden
            EndContext();
            BeginContext(540, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(584, 45, false);
#line 26 "C:\Users\InfoPublic\Desktop\MatrixCRUDTech\MatrixCRUDTech\Views\IndicadorProgramas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UndMedida));

#line default
#line hidden
            EndContext();
            BeginContext(629, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(673, 41, false);
#line 29 "C:\Users\InfoPublic\Desktop\MatrixCRUDTech\MatrixCRUDTech\Views\IndicadorProgramas\Details.cshtml"
       Write(Html.DisplayFor(model => model.UndMedida));

#line default
#line hidden
            EndContext();
            BeginContext(714, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(758, 50, false);
#line 32 "C:\Users\InfoPublic\Desktop\MatrixCRUDTech\MatrixCRUDTech\Views\IndicadorProgramas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IndiceApuracao));

#line default
#line hidden
            EndContext();
            BeginContext(808, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(852, 46, false);
#line 35 "C:\Users\InfoPublic\Desktop\MatrixCRUDTech\MatrixCRUDTech\Views\IndicadorProgramas\Details.cshtml"
       Write(Html.DisplayFor(model => model.IndiceApuracao));

#line default
#line hidden
            EndContext();
            BeginContext(898, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(942, 50, false);
#line 38 "C:\Users\InfoPublic\Desktop\MatrixCRUDTech\MatrixCRUDTech\Views\IndicadorProgramas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IndiceDesejado));

#line default
#line hidden
            EndContext();
            BeginContext(992, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1036, 46, false);
#line 41 "C:\Users\InfoPublic\Desktop\MatrixCRUDTech\MatrixCRUDTech\Views\IndicadorProgramas\Details.cshtml"
       Write(Html.DisplayFor(model => model.IndiceDesejado));

#line default
#line hidden
            EndContext();
            BeginContext(1082, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1126, 40, false);
#line 44 "C:\Users\InfoPublic\Desktop\MatrixCRUDTech\MatrixCRUDTech\Views\IndicadorProgramas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(1166, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1210, 36, false);
#line 47 "C:\Users\InfoPublic\Desktop\MatrixCRUDTech\MatrixCRUDTech\Views\IndicadorProgramas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(1246, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1293, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e9103e1e085c4bf22df1b7e80c1a62b117f165b9511", async() => {
                BeginContext(1348, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\InfoPublic\Desktop\MatrixCRUDTech\MatrixCRUDTech\Views\IndicadorProgramas\Details.cshtml"
                           WriteLiteral(Model.IdIndicador);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1356, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1364, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e9103e1e085c4bf22df1b7e80c1a62b117f165b11859", async() => {
                BeginContext(1386, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(1402, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MatrixCRUDTech.Models.IndicadorPrograma> Html { get; private set; }
    }
}
#pragma warning restore 1591
