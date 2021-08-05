#pragma checksum "C:\Users\LTech\source\repos\ChatApplication.Solution\ChatApplication.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08069b0fbad39fea230952a4d441d14511802a32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\LTech\source\repos\ChatApplication.Solution\ChatApplication.Web\Views\_ViewImports.cshtml"
using ChatApplication.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LTech\source\repos\ChatApplication.Solution\ChatApplication.Web\Views\_ViewImports.cshtml"
using ChatApplication.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LTech\source\repos\ChatApplication.Solution\ChatApplication.Web\Views\_ViewImports.cshtml"
using EntityLibrary.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08069b0fbad39fea230952a4d441d14511802a32", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44bfa1e7eb0f1c87c57c95ec80518a5db7d92c17", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\LTech\source\repos\ChatApplication.Solution\ChatApplication.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
<div class=""container app"">
    <div class=""row app-one"">
        <div class=""col-sm-4 side"">
            <div class=""side-one"">
                <div class=""row heading"">
                    <div class=""col-sm-3 col-xs-3 heading-avatar"">
                        <div class=""heading-avatar-icon"">
                            <img src=""https://bootdey.com/img/Content/avatar/avatar1.png"">
                        </div>
                    </div>
                    <div class=""col-sm-1 col-xs-1  heading-dot  pull-right"">
                        <i class=""fa fa-ellipsis-v fa-2x  pull-right"" aria-hidden=""true""></i>
                    </div>
                    <div class=""col-sm-2 col-xs-2 heading-compose  pull-right"">
                        <i class=""fa fa-comments fa-2x  pull-right"" aria-hidden=""true""></i>
                    </div>
                </div>

                <div clas");
            WriteLiteral(@"s=""row searchBox"">
                    <div class=""col-sm-12 searchBox-inner"">
                        <div class=""form-group has-feedback"">
                            <input id=""searchText"" type=""text"" class=""form-control"" name=""searchText"" placeholder=""Search"">
                            <span class=""glyphicon glyphicon-search form-control-feedback""></span>
                        </div>
                    </div>
                </div>
                <div class=""sideBar"">
                    <div class=""sideBar-body"" id=""left-sidebar-content"">
");
#nullable restore
#line 34 "C:\Users\LTech\source\repos\ChatApplication.Solution\ChatApplication.Web\Views\Home\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row sidebar-user-area\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1793, "\"", 1832, 3);
            WriteAttributeValue("", 1803, "GetReleatedMessages(", 1803, 20, true);
#nullable restore
#line 36 "C:\Users\LTech\source\repos\ChatApplication.Solution\ChatApplication.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1823, item.Id, 1823, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1831, ")", 1831, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""col-sm-3 col-xs-3 sideBar-avatar"">
                                <div class=""avatar-icon"">
                                    <img src=""https://bootdey.com/img/Content/avatar/avatar1.png"">
                                </div>
                            </div>
                            <div class=""col-sm-9 col-xs-9 sideBar-main"">
                                <div class=""row"">
                                    <div class=""col-sm-8 col-xs-8 sideBar-name"">
                                        <span class=""name-meta"">
                                            ");
#nullable restore
#line 46 "C:\Users\LTech\source\repos\ChatApplication.Solution\ChatApplication.Web\Views\Home\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 46 "C:\Users\LTech\source\repos\ChatApplication.Solution\ChatApplication.Web\Views\Home\Index.cshtml"
                                                  Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </span>
                                    </div>
                                    <div class=""col-sm-4 col-xs-4 pull-right sideBar-time"">
                                        <span class=""time-meta pull-right"">
                                            18:18
                                        </span>
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 57 "C:\Users\LTech\source\repos\ChatApplication.Solution\ChatApplication.Web\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>

            <!--<div class=""side-two"">
                <div class=""row newMessage-heading"">
                    <div class=""row newMessage-main"">
                        <div class=""col-sm-2 col-xs-2 newMessage-back"">
                            <i class=""fa fa-arrow-left"" aria-hidden=""true""></i>
                        </div>
                        <div class=""col-sm-10 col-xs-10 newMessage-title"">
                            New Chat
                        </div>
                    </div>
                </div>
                <div class=""row composeBox"">
                    <div class=""col-sm-12 composeBox-inner"">
                        <div class=""form-group has-feedback"">
                            <input id=""composeText"" type=""text"" class=""form-control"" name=""searchText"" placeholder=""Search People"">
                            <span class=""glyphicon glyphicon-search form-control-feedback""></span>
           ");
            WriteLiteral(@"             </div>
                    </div>
                </div>
                <div class=""row compose-sideBar"">
                    <div class=""row sideBar-body"">
                        <div class=""col-sm-3 col-xs-3 sideBar-avatar"">
                            <div class=""avatar-icon"">
                                <img src=""https://bootdey.com/img/Content/avatar/avatar1.png"">
                            </div>
                        </div>
                        <div class=""col-sm-9 col-xs-9 sideBar-main"">
                            <div class=""row"">
                                <div class=""col-sm-8 col-xs-8 sideBar-name"">
                                    <span class=""name-meta"">
                                        John Doe
                                    </span>
                                </div>
                                <div class=""col-sm-4 col-xs-4 pull-right sideBar-time"">
                                    <span class=""time-meta pull-right"">
   ");
            WriteLiteral("                                     18:18\r\n                                    </span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>-->\r\n");
            WriteLiteral(@"            <!--</div>
            </div>-->
        </div>

        <div class=""col-sm-8 conversation"">
            <div class=""row heading"">
                <div class=""col-sm-2 col-md-1 col-xs-3 heading-avatar"">
                    <div class=""heading-avatar-icon"">
                        <img src=""https://bootdey.com/img/Content/avatar/avatar6.png"">
                    </div>
                </div>
                <div class=""col-sm-8 col-xs-7 heading-name"">
                    <a class=""heading-name-meta"">
                        John Doe
                    </a>
                    <span class=""heading-online"">Online</span>
                </div>
                <div class=""col-sm-1 col-xs-1  heading-dot pull-right"">
                    <i class=""fa fa-ellipsis-v fa-2x  pull-right"" aria-hidden=""true""></i>
                </div>
            </div>

            <div class=""row message"" id=""conversation"">
");
            WriteLiteral("\r\n");
            WriteLiteral(@"

            </div>
            <div class=""row reply"">
                <div class=""col-sm-1 col-xs-1 reply-emojis"">
                    <i class=""fa fa-smile-o fa-2x""></i>
                </div>
                <div class=""col-sm-9 col-xs-9 reply-main"">
                    <textarea class=""form-control"" rows=""1"" id=""comment""></textarea>
                </div>
                <div class=""col-sm-1 col-xs-1 reply-recording"">
                    <i class=""fa fa-microphone fa-2x"" aria-hidden=""true""></i>
                </div>
                <div class=""col-sm-1 col-xs-1 reply-send"">
                    <a id=""btn-send"" onclick=""SendMessage(this)"" data-releated-user-id="""">
                        <i class=""fa fa-send fa-2x"" aria-hidden=""true""></i>
                    </a>
                </div>
            </div>
        </div>
    </div>
</div>





<script>
    $(function () {
        $("".heading-compose"").click(function () {
            $("".side-two"").css({
                ""left");
            WriteLiteral(@""": ""0""
            });
        });

        $("".newMessage-back"").click(function () {
            $("".side-two"").css({
                ""left"": ""-100%""
            });
        });
    })
    $(""#comment"").on('keyup', function (e) {
        if (e.key === 'Enter' || e.keyCode === 13) {
            $(""#btn-send"").click();
        }
        return;
    });

    function ScrollSendBottom() {
        $(""#conversation"").animate({ scrollTop: 10000 }, '300');
    }


    function GetReleatedMessages(id) {
        $(""#btn-send"").attr(""data-releated-user-id"",id);
        signalRconnection.invoke(""GetMessage"", id);
        setTimeout(() => { ScrollSendBottom();},450)
        
    }

    function SendMessage(element) {
        var relatedUserId = $(element).attr(""data-releated-user-id"");
        let messageText = $(""#comment"").val();
        $.ajax({
            type: ""POST"",
            url:'");
#nullable restore
#line 247 "C:\Users\LTech\source\repos\ChatApplication.Solution\ChatApplication.Web\Views\Home\Index.cshtml"
            Write(Url.Action("SendMessage", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            data: {
                messageText,
                userId: relatedUserId
            },
            success: (response) => {
                if (response==1) {
                    signalRconnection.invoke(""GetMessage"", relatedUserId);
                    $(""#comment"").val('');
                    ScroolSlide();
                }
            }
        });

    }
    function ScroolSlide(scrollscore=75) {
        var scroll_top = $(""#conversation"").scrollTop();
        $(""#conversation"").animate({ scrollTop: scroll_top + scrollscore }, '300');
    }
</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ChatApplication.Web.Session.SessionHelper sessionHelper { get; private set; }
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
