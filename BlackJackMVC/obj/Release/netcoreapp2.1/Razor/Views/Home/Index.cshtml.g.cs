#pragma checksum "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14f567e1b42034a933583ab007f50762284e462c"
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
#line 1 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\_ViewImports.cshtml"
using BlackJackMVC;

#line default
#line hidden
#line 2 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\_ViewImports.cshtml"
using BlackJackMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14f567e1b42034a933583ab007f50762284e462c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5aed5e0f9c595474d4328704791546f86957025", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/blackjack.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("800"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blackjack photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "PlayGame";

#line default
#line hidden
            BeginContext(44, 601, true);
            WriteLiteral(@"
<style>

    #btBet {
        background-color: gold; /* Green */
        border: double;
        color: blue;
        text-align: center;
        text-decoration: none;
        display: inline-block;
        font-size: 12px;
    }

    #btPlay {
        background-color: gold;
        border: double;
        shape-margin: initial;
        padding: 10px 10px;
        color: red;
        font: bolder;
    }

    .row {
        background-color: darkgreen;
    }

    label, .col-md-d, .col-sm-6, #bet {
        color: goldenrod;
    }
</style>


<hr />
<div>
    ");
            EndContext();
            BeginContext(645, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0eedd9b021e54b72ad916698c3772943", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(728, 77, true);
            WriteLiteral("\r\n</div>\r\n<hr />\r\n<div>\r\n    <input id=\"btPlay\" type=\"button\" value=\"NewGame\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 805, "\"", 861, 3);
            WriteAttributeValue("", 815, "location.href=\'", 815, 15, true);
#line 42 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 830, Url.Action("NewGame", "Home"), 830, 30, false);

#line default
#line hidden
            WriteAttributeValue("", 860, "\'", 860, 1, true);
            EndWriteAttribute();
            BeginContext(862, 239, true);
            WriteLiteral(" />\r\n</div>\r\n<br />\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-6\">\r\n            <h3>Dealer Hand</h3>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-2 col-sm-3\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1101, "\"", 1123, 1);
#line 51 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 1107, TempData["dc1"], 1107, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1124, 125, true);
            WriteLiteral(" class=\"img-responsive\" />\r\n                </div>\r\n                <div class=\"col-md-2 col-sm-3\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1249, "\"", 1271, 1);
#line 54 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 1255, TempData["dc2"], 1255, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1272, 125, true);
            WriteLiteral(" class=\"img-responsive\" />\r\n                </div>\r\n                <div class=\"col-md-2 col-sm-3\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1397, "\"", 1419, 1);
#line 57 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 1403, TempData["dc3"], 1403, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1420, 125, true);
            WriteLiteral(" class=\"img-responsive\" />\r\n                </div>\r\n                <div class=\"col-md-2 col-sm-3\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1545, "\"", 1567, 1);
#line 60 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 1551, TempData["dc4"], 1551, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1568, 125, true);
            WriteLiteral(" class=\"img-responsive\" />\r\n                </div>\r\n                <div class=\"col-md-2 col-sm-3\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1693, "\"", 1715, 1);
#line 63 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 1699, TempData["dc5"], 1699, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1716, 125, true);
            WriteLiteral(" class=\"img-responsive\" />\r\n                </div>\r\n                <div class=\"col-md-2 col-sm-3\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1841, "\"", 1863, 1);
#line 66 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 1847, TempData["dc6"], 1847, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1864, 258, true);
            WriteLiteral(@" class=""img-responsive"" />
                </div>
            </div>
        </div>
        <div class=""col-sm-6"">
            <h3>Player Hand</h3>
            <div class=""row"">
                <div class=""col-md-2 col-sm-3"">
                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2122, "\"", 2144, 1);
#line 74 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 2128, TempData["mc1"], 2128, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2145, 125, true);
            WriteLiteral(" class=\"img-responsive\" />\r\n                </div>\r\n                <div class=\"col-md-2 col-sm-3\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2270, "\"", 2292, 1);
#line 77 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 2276, TempData["mc2"], 2276, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2293, 125, true);
            WriteLiteral(" class=\"img-responsive\" />\r\n                </div>\r\n                <div class=\"col-md-2 col-sm-3\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2418, "\"", 2440, 1);
#line 80 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 2424, TempData["mc3"], 2424, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2441, 125, true);
            WriteLiteral(" class=\"img-responsive\" />\r\n                </div>\r\n                <div class=\"col-md-2 col-sm-3\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2566, "\"", 2588, 1);
#line 83 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 2572, TempData["mc4"], 2572, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2589, 125, true);
            WriteLiteral(" class=\"img-responsive\" />\r\n                </div>\r\n                <div class=\"col-md-2 col-sm-3\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2714, "\"", 2736, 1);
#line 86 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 2720, TempData["mc5"], 2720, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2737, 125, true);
            WriteLiteral(" class=\"img-responsive\" />\r\n                </div>\r\n                <div class=\"col-md-2 col-sm-3\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2862, "\"", 2884, 1);
#line 89 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 2868, TempData["mc6"], 2868, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2885, 305, true);
            WriteLiteral(@" class=""img-responsive"" />
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-6"">
            <div>
                <label>
                    My Account: $
                </label>
                <label>
                    ");
            EndContext();
            BeginContext(3191, 21, false);
#line 101 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
               Write(TempData["myAccount"]);

#line default
#line hidden
            EndContext();
            BeginContext(3212, 194, true);
            WriteLiteral("\r\n                </label>\r\n            </div>\r\n            <div>\r\n                <label>\r\n                    My Bet: $\r\n                </label>\r\n                <label>\r\n                    ");
            EndContext();
            BeginContext(3407, 17, false);
#line 109 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
               Write(TempData["myBet"]);

#line default
#line hidden
            EndContext();
            BeginContext(3424, 176, true);
            WriteLiteral("\r\n                </label>\r\n                <br /><br />\r\n                <p id=\"bet\">Place your bet with chips:</p>\r\n                <input id=\"btBet\" type=\"button\" value=\"$1\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3600, "\"", 3653, 3);
            WriteAttributeValue("", 3610, "location.href=\'", 3610, 15, true);
#line 113 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 3625, Url.Action("Bet1", "Home"), 3625, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 3652, "\'", 3652, 1, true);
            EndWriteAttribute();
            BeginContext(3654, 64, true);
            WriteLiteral(" />\r\n                <input id=\"btBet\" type=\"button\" value=\"$10\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3718, "\"", 3772, 3);
            WriteAttributeValue("", 3728, "location.href=\'", 3728, 15, true);
#line 114 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 3743, Url.Action("Bet10", "Home"), 3743, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 3771, "\'", 3771, 1, true);
            EndWriteAttribute();
            BeginContext(3773, 64, true);
            WriteLiteral(" />\r\n                <input id=\"btBet\" type=\"button\" value=\"$25\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3837, "\"", 3891, 3);
            WriteAttributeValue("", 3847, "location.href=\'", 3847, 15, true);
#line 115 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 3862, Url.Action("Bet25", "Home"), 3862, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 3890, "\'", 3890, 1, true);
            EndWriteAttribute();
            BeginContext(3892, 64, true);
            WriteLiteral(" />\r\n                <input id=\"btBet\" type=\"button\" value=\"$50\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3956, "\"", 4010, 3);
            WriteAttributeValue("", 3966, "location.href=\'", 3966, 15, true);
#line 116 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 3981, Url.Action("Bet50", "Home"), 3981, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 4009, "\'", 4009, 1, true);
            EndWriteAttribute();
            BeginContext(4011, 65, true);
            WriteLiteral(" />\r\n                <input id=\"btBet\" type=\"button\" value=\"$100\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4076, "\"", 4131, 3);
            WriteAttributeValue("", 4086, "location.href=\'", 4086, 15, true);
#line 117 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 4101, Url.Action("Bet100", "Home"), 4101, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 4130, "\'", 4130, 1, true);
            EndWriteAttribute();
            BeginContext(4132, 71, true);
            WriteLiteral(" />\r\n                <input id=\"btBet\" type=\"button\" value=\"Bet All!!!\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4203, "\"", 4258, 3);
            WriteAttributeValue("", 4213, "location.href=\'", 4213, 15, true);
#line 118 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 4228, Url.Action("BetAll", "Home"), 4228, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 4257, "\'", 4257, 1, true);
            EndWriteAttribute();
            BeginContext(4259, 73, true);
            WriteLiteral(" />\r\n                <input id=\"btBet\" type=\"button\" value=\"Clear Bet!!!\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4332, "\"", 4389, 3);
            WriteAttributeValue("", 4342, "location.href=\'", 4342, 15, true);
#line 119 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 4357, Url.Action("BetClear", "Home"), 4357, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 4388, "\'", 4388, 1, true);
            EndWriteAttribute();
            BeginContext(4390, 126, true);
            WriteLiteral(" />\r\n            </div>\r\n            <br />\r\n            <div>\r\n\r\n                <input id=\"btPlay\" type=\"button\" value=\"Hit\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4516, "\"", 4568, 3);
            WriteAttributeValue("", 4526, "location.href=\'", 4526, 15, true);
#line 124 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 4541, Url.Action("Hit", "Home"), 4541, 26, false);

#line default
#line hidden
            WriteAttributeValue("", 4567, "\'", 4567, 1, true);
            EndWriteAttribute();
            BeginContext(4569, 67, true);
            WriteLiteral(" />\r\n                <input id=\"btPlay\" type=\"button\" value=\"Stand\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4636, "\"", 4690, 3);
            WriteAttributeValue("", 4646, "location.href=\'", 4646, 15, true);
#line 125 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 4661, Url.Action("Stand", "Home"), 4661, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 4689, "\'", 4689, 1, true);
            EndWriteAttribute();
            BeginContext(4691, 66, true);
            WriteLiteral(" />\r\n                <input id=\"btPlay\" type=\"button\" value=\"Deal\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4757, "\"", 4810, 3);
            WriteAttributeValue("", 4767, "location.href=\'", 4767, 15, true);
#line 126 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 4782, Url.Action("Deal", "Home"), 4782, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 4809, "\'", 4809, 1, true);
            EndWriteAttribute();
            BeginContext(4811, 89, true);
            WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-d\">\r\n            <h4>");
            EndContext();
            BeginContext(4901, 25, false);
#line 130 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
           Write(TempData["resultMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(4926, 23, true);
            WriteLiteral("</h4>\r\n            <h4>");
            EndContext();
            BeginContext(4950, 24, false);
#line 131 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
           Write(TempData["alertMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(4974, 43, true);
            WriteLiteral("</h4>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 135 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
 if (ViewBag.WarningMessage != null)
{

#line default
#line hidden
            BeginContext(5058, 95, true);
            WriteLiteral("    <script type=\"text/javascript\">\r\n        window.onload = function () {\r\n            alert(\"");
            EndContext();
            BeginContext(5154, 22, false);
#line 139 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
              Write(ViewBag.WarningMessage);

#line default
#line hidden
            EndContext();
            BeginContext(5176, 32, true);
            WriteLiteral("\");\r\n        };\r\n    </script>\r\n");
            EndContext();
#line 142 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(5211, 14, true);
            WriteLiteral("<br />\r\n<hr />");
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