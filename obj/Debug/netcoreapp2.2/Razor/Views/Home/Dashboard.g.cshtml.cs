#pragma checksum "/Users/angeloliwanag/Documents/CodingDojo/C#/ORM/BankAccount/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18f3b48d2287d1d01b7da576eb4578f93958b84e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
#line 1 "/Users/angeloliwanag/Documents/CodingDojo/C#/ORM/BankAccount/Views/_ViewImports.cshtml"
using BankAccount;

#line default
#line hidden
#line 2 "/Users/angeloliwanag/Documents/CodingDojo/C#/ORM/BankAccount/Views/_ViewImports.cshtml"
using BankAccount.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18f3b48d2287d1d01b7da576eb4578f93958b84e", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b20f887a8df0d276701ac0f260ce405b9af56dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Transaction>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Transaction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(25, 74, true);
            WriteLiteral("<div class=\"text-left\">\n    <h1 class=\"display-4 text-secondary\">Welcome, ");
            EndContext();
            BeginContext(100, 12, false);
#line 3 "/Users/angeloliwanag/Documents/CodingDojo/C#/ORM/BankAccount/Views/Home/Dashboard.cshtml"
                                             Write(ViewBag.Name);

#line default
#line hidden
            EndContext();
            BeginContext(112, 90, true);
            WriteLiteral("</h1>\n</div>\n<div class=\"text-right\">\n    <p>Current balance: <span class=\"text-primary\">$");
            EndContext();
            BeginContext(203, 15, false);
#line 6 "/Users/angeloliwanag/Documents/CodingDojo/C#/ORM/BankAccount/Views/Home/Dashboard.cshtml"
                                               Write(ViewBag.Balance);

#line default
#line hidden
            EndContext();
            BeginContext(218, 53, true);
            WriteLiteral("</span></p>\n    <a href=\"/LogOut\">Log Out</a>\n</div>\n");
            EndContext();
            BeginContext(271, 373, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18f3b48d2287d1d01b7da576eb4578f93958b84e5176", async() => {
                BeginContext(338, 11, true);
                WriteLiteral("\n    <div>\n");
                EndContext();
#line 11 "/Users/angeloliwanag/Documents/CodingDojo/C#/ORM/BankAccount/Views/Home/Dashboard.cshtml"
         if(ViewBag.Balance <= 0)
        {

#line default
#line hidden
                BeginContext(393, 59, true);
                WriteLiteral("            <p class=\"text-danger\">Money not available</p>\n");
                EndContext();
#line 14 "/Users/angeloliwanag/Documents/CodingDojo/C#/ORM/BankAccount/Views/Home/Dashboard.cshtml"
        }

#line default
#line hidden
                BeginContext(462, 175, true);
                WriteLiteral("        <label>Deposit/Withdraw</label>\n        <input type=\"number\" name=\"FormValue\">\n        <button class=\"btn btn-warning btn-sm\" type=\"submit\">Submit</button>\n    </div>\n");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(644, 189, true);
            WriteLiteral("\n<div class=\"col-5\" style=\"overflow-y: scroll; height: 300px;\">\n    <table class=\"table table-hover\">\n        <thead>\n            <th>Amount</th>\n            <th>Head</th>\n        </thead>\n");
            EndContext();
#line 26 "/Users/angeloliwanag/Documents/CodingDojo/C#/ORM/BankAccount/Views/Home/Dashboard.cshtml"
         foreach (var transaction in Model)
        {

#line default
#line hidden
            BeginContext(887, 33, true);
            WriteLiteral("        <tbody>\n            <td>$");
            EndContext();
            BeginContext(921, 18, false);
#line 29 "/Users/angeloliwanag/Documents/CodingDojo/C#/ORM/BankAccount/Views/Home/Dashboard.cshtml"
            Write(transaction.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(939, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(962, 21, false);
#line 30 "/Users/angeloliwanag/Documents/CodingDojo/C#/ORM/BankAccount/Views/Home/Dashboard.cshtml"
           Write(transaction.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(983, 23, true);
            WriteLiteral("</td>\n        </tbody>\n");
            EndContext();
#line 32 "/Users/angeloliwanag/Documents/CodingDojo/C#/ORM/BankAccount/Views/Home/Dashboard.cshtml"
        }

#line default
#line hidden
            BeginContext(1016, 19, true);
            WriteLiteral("    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Transaction>> Html { get; private set; }
    }
}
#pragma warning restore 1591
