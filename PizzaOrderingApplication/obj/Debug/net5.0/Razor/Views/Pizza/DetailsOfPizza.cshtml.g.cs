#pragma checksum "C:\Users\Lenovo\OneDrive\Desktop\Softura\Project-A\PizzaOrderingApplication\Views\Pizza\DetailsOfPizza.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "283bb3b20fce53a4d8ba0956368d3431b0992a53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_DetailsOfPizza), @"mvc.1.0.view", @"/Views/Pizza/DetailsOfPizza.cshtml")]
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
#line 1 "C:\Users\Lenovo\OneDrive\Desktop\Softura\Project-A\PizzaOrderingApplication\Views\_ViewImports.cshtml"
using PizzaOrderingApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\OneDrive\Desktop\Softura\Project-A\PizzaOrderingApplication\Views\_ViewImports.cshtml"
using PizzaOrderingApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"283bb3b20fce53a4d8ba0956368d3431b0992a53", @"/Views/Pizza/DetailsOfPizza.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0cdca5a9da40735e5963c506a389057e603f017", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_DetailsOfPizza : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaOrderingApplication.Models.PizzaDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Lenovo\OneDrive\Desktop\Softura\Project-A\PizzaOrderingApplication\Views\Pizza\DetailsOfPizza.cshtml"
  
    ViewData["Title"] = "DetailsOfPizza";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>

    #div2 {
        position: relative;
        float: left;
        padding: 10px;
        margin: 10px;
        left: 0px;
        top: 0px;
        transition: left 3s top 3s;
    }

    #img {
        height: 230px;
        width: 500px;
    }

    #dl {
        font-family: 'Monotype Corsiva';
        font-size: 20px;
    }
</style>

<div id=""div2"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "283bb3b20fce53a4d8ba0956368d3431b0992a534275", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 520, "~/Images/", 520, 9, true);
#nullable restore
#line 31 "C:\Users\Lenovo\OneDrive\Desktop\Softura\Project-A\PizzaOrderingApplication\Views\Pizza\DetailsOfPizza.cshtml"
AddHtmlAttributeValue("", 529, Model.PizzaImage, 529, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<div id=\"div2\">\r\n    <h4 style=\"font-family:\'Monotype Corsiva\'\">Pizza Details</h4>\r\n    <hr />\r\n    <dl class=\"row\" id=\"dl\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Lenovo\OneDrive\Desktop\Softura\Project-A\PizzaOrderingApplication\Views\Pizza\DetailsOfPizza.cshtml"
       Write(Html.DisplayNameFor(model => model.PizzaName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Lenovo\OneDrive\Desktop\Softura\Project-A\PizzaOrderingApplication\Views\Pizza\DetailsOfPizza.cshtml"
       Write(Html.DisplayFor(model => model.PizzaName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\Lenovo\OneDrive\Desktop\Softura\Project-A\PizzaOrderingApplication\Views\Pizza\DetailsOfPizza.cshtml"
       Write(Html.DisplayNameFor(model => model.PizzaType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\Lenovo\OneDrive\Desktop\Softura\Project-A\PizzaOrderingApplication\Views\Pizza\DetailsOfPizza.cshtml"
       Write(Html.DisplayFor(model => model.PizzaType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\Lenovo\OneDrive\Desktop\Softura\Project-A\PizzaOrderingApplication\Views\Pizza\DetailsOfPizza.cshtml"
       Write(Html.DisplayNameFor(model => model.PizzaSize));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\Lenovo\OneDrive\Desktop\Softura\Project-A\PizzaOrderingApplication\Views\Pizza\DetailsOfPizza.cshtml"
       Write(Html.DisplayFor(model => model.PizzaSize));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\Lenovo\OneDrive\Desktop\Softura\Project-A\PizzaOrderingApplication\Views\Pizza\DetailsOfPizza.cshtml"
       Write(Html.DisplayNameFor(model => model.PizzaSecality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\Lenovo\OneDrive\Desktop\Softura\Project-A\PizzaOrderingApplication\Views\Pizza\DetailsOfPizza.cshtml"
       Write(Html.DisplayFor(model => model.PizzaSecality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\Lenovo\OneDrive\Desktop\Softura\Project-A\PizzaOrderingApplication\Views\Pizza\DetailsOfPizza.cshtml"
       Write(Html.DisplayNameFor(model => model.PizzaPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\Lenovo\OneDrive\Desktop\Softura\Project-A\PizzaOrderingApplication\Views\Pizza\DetailsOfPizza.cshtml"
       Write(Model.PizzaPrice.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("hi-IN")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaOrderingApplication.Models.PizzaDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
