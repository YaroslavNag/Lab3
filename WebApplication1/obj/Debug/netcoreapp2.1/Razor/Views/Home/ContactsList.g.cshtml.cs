#pragma checksum "C:\Users\429283-18\Desktop\WebApplication1\WebApplication1\Views\Home\ContactsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "844c5a883f78ce80880017b4d3f4b6723257a8be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ContactsList), @"mvc.1.0.view", @"/Views/Home/ContactsList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ContactsList.cshtml", typeof(AspNetCore.Views_Home_ContactsList))]
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
#line 1 "C:\Users\429283-18\Desktop\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\429283-18\Desktop\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"844c5a883f78ce80880017b4d3f4b6723257a8be", @"/Views/Home/ContactsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ContactsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.Contact>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\429283-18\Desktop\WebApplication1\WebApplication1\Views\Home\ContactsList.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(66, 31, true);
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(97, 317, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab2191b561aa42929edfc2664c742c19", async() => {
                BeginContext(103, 304, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Index</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
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
            BeginContext(414, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(416, 2610, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9604361b87d49cbb6ce2c19f0f37215", async() => {
                BeginContext(422, 382, true);
                WriteLiteral(@"
    <table id=""table_of_contacts_id"" class=""table table-hover table-dark"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Name</th>
                <th scope=""col"">Email</th>
                <th scope=""col"">Phone</th>
                <th scope=""col"">Group</th>
            </tr>
        </thead>
        <tbody>
");
                EndContext();
#line 27 "C:\Users\429283-18\Desktop\WebApplication1\WebApplication1\Views\Home\ContactsList.cshtml"
             foreach (var contact in ViewBag.Contacts)
            {

#line default
#line hidden
                BeginContext(875, 58, true);
                WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
                EndContext();
                BeginContext(934, 10, false);
#line 30 "C:\Users\429283-18\Desktop\WebApplication1\WebApplication1\Views\Home\ContactsList.cshtml"
                               Write(contact.Id);

#line default
#line hidden
                EndContext();
                BeginContext(944, 31, true);
                WriteLiteral("</th>\r\n                    <td>");
                EndContext();
                BeginContext(976, 12, false);
#line 31 "C:\Users\429283-18\Desktop\WebApplication1\WebApplication1\Views\Home\ContactsList.cshtml"
                   Write(contact.Name);

#line default
#line hidden
                EndContext();
                BeginContext(988, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1020, 13, false);
#line 32 "C:\Users\429283-18\Desktop\WebApplication1\WebApplication1\Views\Home\ContactsList.cshtml"
                   Write(contact.Email);

#line default
#line hidden
                EndContext();
                BeginContext(1033, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1065, 13, false);
#line 33 "C:\Users\429283-18\Desktop\WebApplication1\WebApplication1\Views\Home\ContactsList.cshtml"
                   Write(contact.Phone);

#line default
#line hidden
                EndContext();
                BeginContext(1078, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1110, 13, false);
#line 34 "C:\Users\429283-18\Desktop\WebApplication1\WebApplication1\Views\Home\ContactsList.cshtml"
                   Write(contact.Group);

#line default
#line hidden
                EndContext();
                BeginContext(1123, 30, true);
                WriteLiteral("</td>\r\n                </tr>\r\n");
                EndContext();
#line 36 "C:\Users\429283-18\Desktop\WebApplication1\WebApplication1\Views\Home\ContactsList.cshtml"
            }

#line default
#line hidden
                BeginContext(1168, 80, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n    <br />\r\n    <select id=\"group_id\">\r\n        ");
                EndContext();
                BeginContext(1248, 20, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc4edeee38ee42f0a0cdd927281ee675", async() => {
                    BeginContext(1256, 3, true);
                    WriteLiteral("All");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1268, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1278, 24, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54522f7c998148eaa3a17f9fcaea12f7", async() => {
                    BeginContext(1286, 7, true);
                    WriteLiteral("Friends");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1302, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1312, 27, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "500930407e0f4a2683d50337f4e9955a", async() => {
                    BeginContext(1320, 10, true);
                    WriteLiteral("Colleagues");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1339, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1349, 26, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87a6cca2fa7548baa132512896e500ca", async() => {
                    BeginContext(1357, 9, true);
                    WriteLiteral("Relatives");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1375, 33, true);
                WriteLiteral("\r\n    </select>\r\n    <br />\r\n    ");
                EndContext();
                BeginContext(1408, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06e5c4407f1a4a8a9a184b714e013d12", async() => {
                    BeginContext(1430, 9, true);
                    WriteLiteral("Main page");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1443, 1576, true);
                WriteLiteral(@"

    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>

    <script>
        var groupSelect = document.getElementById(""group_id"");
        function changeOption() {
            var selectedOption = groupSelect.options[groupSelect.selectedIndex];
            $.ajax({
                url: 'http://localhost:49368/Home/ContactsList?group=' + selectedOption.text,
                type: 'GET',
                success: function (data) {
                    $(""#table_of_contacts_id tbody tr"").remove();
                    for (let i = 0; i < data.length;");
                WriteLiteral(@" i++) {
                        $('#table_of_contacts_id > tbody:last-child').append('<tr><th scope=""row"">'
                            + data[i].id + '</th><td>'
                            + data[i].name + '</td><td>'
                            + data[i].email + '</td><td>'
                            + data[i].phone + '</td><td>'
                            + data[i].group + '</td></tr>');
                    }
                }
            });
        }
        groupSelect.addEventListener(""change"", changeOption);
    </script>
");
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
            BeginContext(3026, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.Contact> Html { get; private set; }
    }
}
#pragma warning restore 1591