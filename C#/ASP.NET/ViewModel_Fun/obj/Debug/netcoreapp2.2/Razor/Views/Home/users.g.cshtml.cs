#pragma checksum "C:\Users\Fabian\Desktop\Dojo_assignments\C#\ASP.NET\ViewModel_Fun\Views\Home\users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "869d0a87d41a6ed26a2cea1deeaa68dab9e13218"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_users), @"mvc.1.0.view", @"/Views/Home/users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/users.cshtml", typeof(AspNetCore.Views_Home_users))]
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
#line 1 "C:\Users\Fabian\Desktop\Dojo_assignments\C#\ASP.NET\ViewModel_Fun\Views\_ViewImports.cshtml"
using ViewModel_Fun;

#line default
#line hidden
#line 2 "C:\Users\Fabian\Desktop\Dojo_assignments\C#\ASP.NET\ViewModel_Fun\Views\_ViewImports.cshtml"
using ViewModel_Fun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"869d0a87d41a6ed26a2cea1deeaa68dab9e13218", @"/Views/Home/users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d67dacb5d440fdfd5c9974c666c8e8de3a51591", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
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
            BeginContext(19, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(56, 365, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "869d0a87d41a6ed26a2cea1deeaa68dab9e132183402", async() => {
                BeginContext(62, 352, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"" integrity=""sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk"" crossorigin=""anonymous"">
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
            BeginContext(421, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(423, 337, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "869d0a87d41a6ed26a2cea1deeaa68dab9e132184947", async() => {
                BeginContext(429, 168, true);
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"header text-center\">\r\n            <h1>Here are some Users!</h1>\r\n        </div>\r\n        <div class=\"users border\">\r\n");
                EndContext();
#line 17 "C:\Users\Fabian\Desktop\Dojo_assignments\C#\ASP.NET\ViewModel_Fun\Views\Home\users.cshtml"
             foreach (User user in Model)
            {

#line default
#line hidden
                BeginContext(655, 19, true);
                WriteLiteral("                <p>");
                EndContext();
                BeginContext(675, 14, false);
#line 19 "C:\Users\Fabian\Desktop\Dojo_assignments\C#\ASP.NET\ViewModel_Fun\Views\Home\users.cshtml"
              Write(user.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(689, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(691, 13, false);
#line 19 "C:\Users\Fabian\Desktop\Dojo_assignments\C#\ASP.NET\ViewModel_Fun\Views\Home\users.cshtml"
                              Write(user.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(704, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
#line 20 "C:\Users\Fabian\Desktop\Dojo_assignments\C#\ASP.NET\ViewModel_Fun\Views\Home\users.cshtml"
            }

#line default
#line hidden
                BeginContext(725, 28, true);
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
            BeginContext(760, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
