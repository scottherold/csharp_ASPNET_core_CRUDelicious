#pragma checksum "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\CRUDelicious\Views\Main\DisplayRecipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "120c47b63430211f95f647ba24fce05356c5d451"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_DisplayRecipe), @"mvc.1.0.view", @"/Views/Main/DisplayRecipe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/DisplayRecipe.cshtml", typeof(AspNetCore.Views_Main_DisplayRecipe))]
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
#line 2 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"120c47b63430211f95f647ba24fce05356c5d451", @"/Views/Main/DisplayRecipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cef2ead125d8866b9bded51c834cbb4710f8913", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_DisplayRecipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Destroy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Main", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 224, true);
            WriteLiteral("<!-- Insert Model Here -->\r\n<div class=\"row justify-content-center\">\r\n    <div class=\"col-lg-10 rounded justify-content-center m-4 bg-white\">\r\n        <div class=\"row justify-content-center mt-3 mb-1 mx-3\">\r\n            <h1>");
            EndContext();
            BeginContext(238, 10, false);
#line 6 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\CRUDelicious\Views\Main\DisplayRecipe.cshtml"
           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(248, 162, true);
            WriteLiteral("</h1>\r\n        </div>\r\n        <div class=\"row justify-content-center mb-3 mx-3\">\r\n            <div class=\"col-8 text-center border-bottom\">\r\n                <h4>");
            EndContext();
            BeginContext(411, 10, false);
#line 10 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\CRUDelicious\Views\Main\DisplayRecipe.cshtml"
               Write(Model.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(421, 136, true);
            WriteLiteral("</h4>\r\n            </div>\r\n        </div>\r\n        <div class=\"row m-3\">\r\n            <div class=\"col text-center\">\r\n                <p>");
            EndContext();
            BeginContext(558, 17, false);
#line 15 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\CRUDelicious\Views\Main\DisplayRecipe.cshtml"
              Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(575, 273, true);
            WriteLiteral(@"</p>
            </div>
        </div>
        <div class=""row my-1 ml-5 mr-2 justify-content-start"">
            <div class=""col-lg-2 text-left"">
                <h6>Calories:</h6>
            </div>
            <div class=""col-lg-3 text-left"">
                <p>");
            EndContext();
            BeginContext(849, 14, false);
#line 23 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\CRUDelicious\Views\Main\DisplayRecipe.cshtml"
              Write(Model.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(863, 279, true);
            WriteLiteral(@"</p>
            </div>
        </div>
        <div class=""row my-1 ml-5 mr-2 mb-3 justify-content-start"">
            <div class=""col-lg-2 text-left"">
                <h6>Tastiness:</h6>
            </div>
            <div class=""col-lg-3 text-left"">
                <p>");
            EndContext();
            BeginContext(1143, 15, false);
#line 31 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\CRUDelicious\Views\Main\DisplayRecipe.cshtml"
              Write(Model.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(1158, 189, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"row mt-3 mx-3 mb-5 justify-content-center border-bottom\">\r\n            <div class=\"col-lg-2 m-4 text-center\">\r\n                ");
            EndContext();
            BeginContext(1347, 203, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8380e1eac5684ab5b2c7b60ee3170079", async() => {
                BeginContext(1443, 100, true);
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-danger\">Delete</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-dishId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\CRUDelicious\Views\Main\DisplayRecipe.cshtml"
                                                                                     WriteLiteral(Model.DishId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["dishId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-dishId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["dishId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1550, 92, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-2 m-4 text-center\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1642, "\"", 1667, 2);
            WriteAttributeValue("", 1649, "edit/", 1649, 5, true);
#line 41 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\CRUDelicious\Views\Main\DisplayRecipe.cshtml"
WriteAttributeValue("", 1654, Model.DishId, 1654, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1668, 90, true);
            WriteLiteral(" class=\"btn btn-success\">Edit</a> \r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
