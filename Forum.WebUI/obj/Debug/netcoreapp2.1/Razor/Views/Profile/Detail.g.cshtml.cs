#pragma checksum "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Profile\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "925a6f18ad06477a5eaa92c028812ab742ca40f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Detail), @"mvc.1.0.view", @"/Views/Profile/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profile/Detail.cshtml", typeof(AspNetCore.Views_Profile_Detail))]
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
#line 1 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\_ViewImports.cshtml"
using Forum.WebUI;

#line default
#line hidden
#line 2 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\_ViewImports.cshtml"
using Forum.WebUI.Models;

#line default
#line hidden
#line 1 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Profile\Detail.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"925a6f18ad06477a5eaa92c028812ab742ca40f0", @"/Views/Profile/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"460e703cda971f42e4d34f2b4380bccdbae5f74b", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Forum.WebUI.Models.ApplicationUser.ProfileModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadProfileImage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(160, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Profile\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(204, 275, true);
            WriteLiteral(@"
<div class=""container body-content"">
    <div class=""row sectionHeader"">
        <div class=""sectionHeading"">
            User  Profile
        </div>
    </div>
    <div class=""row userProfile"">
        <div class=""col-md-4"">
            <div id=""userProfileImage""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 479, "\"", 531, 3);
            WriteAttributeValue("", 487, "background-image:url(", 487, 21, true);
#line 17 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Profile\Detail.cshtml"
WriteAttributeValue("", 508, Model.ProfileImageUrl, 508, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 530, ")", 530, 1, true);
            EndWriteAttribute();
            BeginContext(532, 9, true);
            WriteLiteral("></div>\r\n");
            EndContext();
#line 18 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Profile\Detail.cshtml"
             if (User.Identity.Name == Model.UserName)
            {

#line default
#line hidden
            BeginContext(612, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(628, 490, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc21d85f008f4ad18f2fbc44bf3528f7", async() => {
                BeginContext(735, 376, true);
                WriteLiteral(@"
                    <div id=""upload"">
                        <label class=""btn btn-default btn-file"">
                            Browse <input type=""file"" name=""file"" style=""display:none"" />
                        </label>
                    </div>
                    <button type=""submit"" id=""btn-profile"" class=""btn btn-default"">Submit</button>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1118, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 28 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Profile\Detail.cshtml"
            }

#line default
#line hidden
            BeginContext(1135, 80, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-md-8\">\r\n            <span id=\"userName\">");
            EndContext();
            BeginContext(1216, 14, false);
#line 31 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Profile\Detail.cshtml"
                           Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1230, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 32 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Profile\Detail.cshtml"
             if (@Model.IsAdmin)
            {

#line default
#line hidden
            BeginContext(1288, 52, true);
            WriteLiteral("                <span class=\"isAdmin\">Admin</span>\r\n");
            EndContext();
#line 35 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Profile\Detail.cshtml"
            }

#line default
#line hidden
            BeginContext(1355, 50, true);
            WriteLiteral("            <span id=\"userRating\">Current Rating: ");
            EndContext();
            BeginContext(1406, 16, false);
#line 36 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Profile\Detail.cshtml"
                                             Write(Model.UserRating);

#line default
#line hidden
            EndContext();
            BeginContext(1422, 54, true);
            WriteLiteral("</span>\r\n            <span id=\"userEmailLabel\">Email: ");
            EndContext();
            BeginContext(1477, 11, false);
#line 37 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Profile\Detail.cshtml"
                                        Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1488, 63, true);
            WriteLiteral("</span>\r\n            <span id=\"userCreatedLabel\">Member Since: ");
            EndContext();
            BeginContext(1552, 17, false);
#line 38 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Profile\Detail.cshtml"
                                                 Write(Model.MemberSince);

#line default
#line hidden
            EndContext();
            BeginContext(1569, 47, true);
            WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<Forum.Entities.ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Forum.WebUI.Models.ApplicationUser.ProfileModel> Html { get; private set; }
    }
}
#pragma warning restore 1591