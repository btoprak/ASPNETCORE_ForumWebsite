#pragma checksum "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "857d92a2a2d792cfc36cc92aa966e801f1f7a6b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Index), @"mvc.1.0.view", @"/Views/Post/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Index.cshtml", typeof(AspNetCore.Views_Post_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"857d92a2a2d792cfc36cc92aa966e801f1f7a6b4", @"/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"460e703cda971f42e4d34f2b4380bccdbae5f74b", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Forum.WebUI.Models.Post.PostIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Forum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Topic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-back"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reply", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreatePost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-newReply"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(88, 168, true);
            WriteLiteral("\r\n<div class=\"container body-content\">\r\n    <div class=\"row postHeader\">\r\n        <div class=\"postHeading\">\r\n            <span class=\"postIndexTitle\">\r\n                ");
            EndContext();
            BeginContext(257, 11, false);
#line 10 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml"
           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(268, 57, true);
            WriteLiteral("\r\n            </span>\r\n            <span id=\"headingBtn\">");
            EndContext();
            BeginContext(325, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de1676be77e445d6842cf423aa13e0f2", async() => {
                BeginContext(421, 8, true);
                WriteLiteral("Back to ");
                EndContext();
                BeginContext(430, 15, false);
#line 12 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml"
                                                                                                                                     Write(Model.ForumName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 12 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml"
                                                                                 WriteLiteral(Model.ForumId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(449, 178, true);
            WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div class=\"row\" id=\"postIndexContent\">\r\n        <div class=\"col-md-3 postAuthorContainer\">\r\n            <div class=\"postAuthorImage\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 627, "\"", 680, 4);
            WriteAttributeValue("", 635, "background-image:url(", 635, 21, true);
#line 19 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml"
WriteAttributeValue("", 656, Model.AuthorImageUrl, 656, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 677, ");", 677, 2, true);
            WriteAttributeValue(" ", 679, "", 680, 1, true);
            EndWriteAttribute();
            BeginContext(681, 21, true);
            WriteLiteral("></div>\r\n            ");
            EndContext();
            BeginContext(702, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "928c52012baf4611a162eb7009c01ceb", async() => {
                BeginContext(782, 16, false);
#line 20 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml"
                                                                                      Write(Model.AuthorName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 20 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml"
                                                              WriteLiteral(Model.AuthorId);

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
            BeginContext(802, 37, true);
            WriteLiteral("\r\n            <span class=\"postData\">");
            EndContext();
            BeginContext(840, 13, false);
#line 21 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml"
                              Write(Model.Created);

#line default
#line hidden
            EndContext();
            BeginContext(853, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 22 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml"
             if (Model.IsAuthorAdmin)
            {

#line default
#line hidden
            BeginContext(916, 60, true);
            WriteLiteral("                <span class=\"isAdmin smaller\">Admin</span>\r\n");
            EndContext();
#line 25 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(991, 124, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-md-9 postContentContainer\">\r\n            <div class=\"postContent\">\r\n                ");
            EndContext();
            BeginContext(1116, 27, false);
#line 29 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml"
           Write(Html.Raw(Model.PostContent));

#line default
#line hidden
            EndContext();
            BeginContext(1143, 97, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\" id=\"replyDivider\"></div>\r\n");
            EndContext();
#line 34 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml"
     if (User.Identity.IsAuthenticated)
    {

#line default
#line hidden
            BeginContext(1288, 81, true);
            WriteLiteral("        <div class=\"row\" id=\"postReplyRow\">\r\n            <span>\r\n                ");
            EndContext();
            BeginContext(1369, 154, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df81a8217d3a4133a85ae20018f1234f", async() => {
                BeginContext(1469, 50, true);
                WriteLiteral("\r\n                    Post Reply\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml"
                                                                    WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1523, 39, true);
            WriteLiteral("\r\n            </span>\r\n        </div>\r\n");
            EndContext();
#line 43 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1569, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 45 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml"
     if (Model.Replies.Any())
    {
        foreach (var reply in Model.Replies)
        {

#line default
#line hidden
            BeginContext(1666, 153, true);
            WriteLiteral("            <div class=\"row replyContent\">\r\n                <div class=\"col-md-3 replyAuthorContainer\">\r\n                    <div class=\"postAuthorImage\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1819, "\"", 1870, 3);
            WriteAttributeValue("", 1827, "background-image:url(", 1827, 21, true);
#line 51 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml"
WriteAttributeValue("", 1848, reply.AuthorImageUrl, 1848, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 1869, ")", 1869, 1, true);
            EndWriteAttribute();
            BeginContext(1871, 29, true);
            WriteLiteral("></div>\r\n                    ");
            EndContext();
            BeginContext(1900, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be619327ac6648489e49fb38598aa26d", async() => {
                BeginContext(1980, 16, false);
#line 52 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml"
                                                                                              Write(reply.AuthorName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml"
                                                                      WriteLiteral(reply.AuthorId);

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
            BeginContext(2000, 54, true);
            WriteLiteral("\r\n                    (<span class=\"postAuthorRating\">");
            EndContext();
            BeginContext(2055, 18, false);
#line 53 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml"
                                               Write(reply.AuthorRating);

#line default
#line hidden
            EndContext();
            BeginContext(2073, 17, true);
            WriteLiteral("</span>) <br />\r\n");
            EndContext();
#line 54 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml"
                     if (@reply.IsAuthorAdmin)
                    {

#line default
#line hidden
            BeginContext(2161, 111, true);
            WriteLiteral("                        <div class=\"isAdmin profileLabel smaller\">Admin</div>\r\n                        <br />\r\n");
            EndContext();
#line 58 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2295, 43, true);
            WriteLiteral("                    <span class=\"postDate\">");
            EndContext();
            BeginContext(2339, 13, false);
#line 59 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml"
                                      Write(reply.Created);

#line default
#line hidden
            EndContext();
            BeginContext(2352, 166, true);
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"col-md-9 replyContentContainer\">\r\n                    <div class=\"postContent\">\r\n                        ");
            EndContext();
            BeginContext(2519, 28, false);
#line 63 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml"
                   Write(Html.Raw(reply.ReplyContent));

#line default
#line hidden
            EndContext();
            BeginContext(2547, 74, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 67 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml"
        }
    }
    else
    {

#line default
#line hidden
            BeginContext(2656, 136, true);
            WriteLiteral("        <div class=\"noPosts\">\r\n            <h3>\r\n                There are no replies to this post.\r\n            </h3>\r\n        </div>\r\n");
            EndContext();
#line 76 "C:\Users\Toprak\source\repos\Forum.AspNetCore\Forum.WebUI\Views\Post\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2799, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Forum.WebUI.Models.Post.PostIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
