#pragma checksum "C:\Users\Fabian\Desktop\Dojo_assignments\C#\ORM\Chefs_N_Dishes\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b465ce41b50cc6ab1beeaa6b4bdfde59ef812985"
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
#line 1 "C:\Users\Fabian\Desktop\Dojo_assignments\C#\ORM\Chefs_N_Dishes\Views\_ViewImports.cshtml"
using Chefs_N_Dishes;

#line default
#line hidden
#line 2 "C:\Users\Fabian\Desktop\Dojo_assignments\C#\ORM\Chefs_N_Dishes\Views\_ViewImports.cshtml"
using Chefs_N_Dishes.Models;

#line default
#line hidden
#line 3 "C:\Users\Fabian\Desktop\Dojo_assignments\C#\ORM\Chefs_N_Dishes\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b465ce41b50cc6ab1beeaa6b4bdfde59ef812985", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bca1e007867c6297778622838d8ba6df73a1ff4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Chef>>
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
            BeginContext(56, 366, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b465ce41b50cc6ab1beeaa6b4bdfde59ef8129853560", async() => {
                BeginContext(62, 353, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Chef List</title>
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
            BeginContext(422, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(424, 1810, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b465ce41b50cc6ab1beeaa6b4bdfde59ef8129855107", async() => {
                BeginContext(430, 825, true);
                WriteLiteral(@"
    <div class=""container"">
        <div class=""text-right"">
            <a href=""/new"">Add a Chef</a>
        </div>
        <div class=""row text-center"">
            <h3>Chefs | <a href=""/dishes"">Dishes</a></h3>
        </div>
        <div class=""row"">
            <div class=""col-8"">
                <h4 class=""border-bottom pb-3"">Check out these Chefs</h4>
                <div class=""list mt-3"">
                    <table class=""table table-dark"">
                        <thead>
                            <tr>
                                <th scope=""col"">Name</th>
                                <th scope=""col"">Age</th>
                                <th scope=""col"">Number of Dishes</th>
                            </tr>
                        </thead>
                        <tbody>
");
                EndContext();
#line 32 "C:\Users\Fabian\Desktop\Dojo_assignments\C#\ORM\Chefs_N_Dishes\Views\Home\Index.cshtml"
                             foreach (Chef item in Model)
                            {

#line default
#line hidden
                BeginContext(1345, 78, true);
                WriteLiteral("                                <tr>\r\n                                    <th>");
                EndContext();
                BeginContext(1424, 14, false);
#line 35 "C:\Users\Fabian\Desktop\Dojo_assignments\C#\ORM\Chefs_N_Dishes\Views\Home\Index.cshtml"
                                   Write(item.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(1438, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1440, 13, false);
#line 35 "C:\Users\Fabian\Desktop\Dojo_assignments\C#\ORM\Chefs_N_Dishes\Views\Home\Index.cshtml"
                                                   Write(item.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(1453, 47, true);
                WriteLiteral("</th>\r\n                                    <th>");
                EndContext();
#line 36 "C:\Users\Fabian\Desktop\Dojo_assignments\C#\ORM\Chefs_N_Dishes\Views\Home\Index.cshtml"
                                          int age = DateTime.Now.Year - item.Birthday.Year;

#line default
#line hidden
                BeginContext(1553, 3, false);
#line 36 "C:\Users\Fabian\Desktop\Dojo_assignments\C#\ORM\Chefs_N_Dishes\Views\Home\Index.cshtml"
                                                                                       Write(age);

#line default
#line hidden
                EndContext();
                BeginContext(1556, 7, true);
                WriteLiteral("</th>\r\n");
                EndContext();
#line 37 "C:\Users\Fabian\Desktop\Dojo_assignments\C#\ORM\Chefs_N_Dishes\Views\Home\Index.cshtml"
                                      
                                        int returnStatement = 0;
                                        if (item.CreatedDishes != null)
                                        {
                                            returnStatement = item.CreatedDishes.Count();
                                        }
                                    

#line default
#line hidden
                BeginContext(1958, 40, true);
                WriteLiteral("                                    <th>");
                EndContext();
                BeginContext(1999, 15, false);
#line 44 "C:\Users\Fabian\Desktop\Dojo_assignments\C#\ORM\Chefs_N_Dishes\Views\Home\Index.cshtml"
                                   Write(returnStatement);

#line default
#line hidden
                EndContext();
                BeginContext(2014, 46, true);
                WriteLiteral("</th>\r\n                                </tr>\r\n");
                EndContext();
#line 46 "C:\Users\Fabian\Desktop\Dojo_assignments\C#\ORM\Chefs_N_Dishes\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(2091, 136, true);
                WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
            BeginContext(2234, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Chef>> Html { get; private set; }
    }
}
#pragma warning restore 1591
