#pragma checksum "E:\EFcore\EFcoreMVC\Views\Role\ShowAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d37edbbb77dd37b1dbe70b6ef6d75da5a0d144c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_ShowAll), @"mvc.1.0.view", @"/Views/Role/ShowAll.cshtml")]
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
#line 1 "E:\EFcore\EFcoreMVC\Views\_ViewImports.cshtml"
using EFcoreMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\EFcore\EFcoreMVC\Views\_ViewImports.cshtml"
using EFcoreMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d37edbbb77dd37b1dbe70b6ef6d75da5a0d144c", @"/Views/Role/ShowAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba6869af36159c4679a7311423a2f817a13ce788", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_ShowAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "E:\EFcore\EFcoreMVC\Views\Role\ShowAll.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <p><b><a class=""btn editordelete btn-primary"" href=""/Role/AddRole"">Add Role</a></b></p>
    
<section id=""about"" class=""wow fadeInUp"">
    <div class=""container"">
        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th scope=""col""><b>S.N.</b></th>
                    <th scope=""col""><b>Role</b></th>
                </tr>
            </thead>
            <tbody id=""tableBody"">
");
#nullable restore
#line 17 "E:\EFcore\EFcoreMVC\Views\Role\ShowAll.cshtml"
                  
                    var i = 1;
                    foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 22 "E:\EFcore\EFcoreMVC\Views\Role\ShowAll.cshtml"
                           Write(item.RoleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <button class=\"btn editordelete btn-primary\" data-bind=\"");
#nullable restore
#line 24 "E:\EFcore\EFcoreMVC\Views\Role\ShowAll.cshtml"
                                                                                   Write(item.RoleID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" id=\"btnDeleteRole\">Delete</button>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 27 "E:\EFcore\EFcoreMVC\Views\Role\ShowAll.cshtml"
                        i++;
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n<p><b><a href=\"/User/ShowAll\">Back to User</a></b></p>\r\n</section>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d37edbbb77dd37b1dbe70b6ef6d75da5a0d144c5428", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
$(function(){
   $(""#tableBody"").on(""click"",""#btnDeleteRole"",function(){
        debugger;
        var RoleID = $(this).attr('data-bind');
        $.ajax({
            url: '/Role/Delete?id='+RoleID,
            type: ""get"",
            async: false,
            success: function(){
                alert(""Role Deleted Successfully"");
                window.location.href=""/Role/ShowAll"";
            },
            error: function(){
                alert(""Error!"");
            }
        });
    });

});
</script>");
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
