#pragma checksum "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f94b0e7ae542e07006060ddbf21a7c6cc4eb724"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrator_Dashboard), @"mvc.1.0.view", @"/Views/Administrator/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrator/Dashboard.cshtml", typeof(AspNetCore.Views_Administrator_Dashboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f94b0e7ae542e07006060ddbf21a7c6cc4eb724", @"/Views/Administrator/Dashboard.cshtml")]
    public class Views_Administrator_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<chat_application.Models.DashboardModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/message.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(76, 358, true);
            WriteLiteral(@"
<link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js""></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
<!------ Include the above in your HEAD tag ---------->


<html>
");
            EndContext();
            BeginContext(434, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f94b0e7ae542e07006060ddbf21a7c6cc4eb7245914", async() => {
                BeginContext(440, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
                BeginContext(444, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3f94b0e7ae542e07006060ddbf21a7c6cc4eb7246299", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(505, 31, true);
                WriteLiteral("\r\n    <style>\r\n\r\n    </style>\r\n");
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
            BeginContext(543, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(545, 7340, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f94b0e7ae542e07006060ddbf21a7c6cc4eb7248552", async() => {
                BeginContext(551, 998, true);
                WriteLiteral(@"
<div class=""container"">
<h3 class="" text-center"" id=""title"">Messaging</h3>
<div class=""messaging"">
  <div class=""inbox_msg"">
    <div class=""inbox_people"">
      <div class=""headind_srch"">
        <div class=""recent_heading"">
          <h4>Recent</h4>
        </div>
        <div class=""srch_bar"">
          <div class=""stylish-input-group"">
            <input type=""text"" class=""search-bar""  placeholder=""Search"" >
            <span class=""input-group-addon"">
            <button type=""button""> <i class=""fa fa-search"" aria-hidden=""true""></i> </button>
            </span> </div>
        </div>
      </div>
      <div class=""inbox_chat"">

        <div id=""users"">
          <div class='chat_list active_chat'  id='All'>
            <div class='chat_people'>
              <div class='chat_ib'>
                <h5 style=""cursor:pointer"" name=""SelectBroadcast"" onclick=""SelectBroadcast('All')"">Public Chat</h5>
              </div>
            </div>
          </div>
");
                EndContext();
#line 49 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
           foreach (var item in Model.users)
          {

#line default
#line hidden
                BeginContext(1608, 48, true);
                WriteLiteral("              <div class=\'chat_list active_chat\'");
                EndContext();
                BeginWriteAttribute("id", " id=\'", 1656, "\'", 1675, 1);
#line 51 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
WriteAttributeValue("", 1661, item.UserName, 1661, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1676, 308, true);
                WriteLiteral(@">
                <div class='chat_people'>
                  <div class='chat_ib'>
                    <div class='chat_img'> 
                      <img src='https://ptetutorials.com/images/user-profile.png'>
                    </div>
                    <h5 style=""cursor:pointer"" name=""SelectUser""");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1984, "\"", 2022, 3);
                WriteAttributeValue("", 1994, "SelectUser(\'", 1994, 12, true);
#line 57 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
WriteAttributeValue("", 2006, item.UserName, 2006, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 2020, "\')", 2020, 2, true);
                EndWriteAttribute();
                BeginContext(2023, 26, true);
                WriteLiteral("> \r\n                      ");
                EndContext();
                BeginContext(2050, 13, false);
#line 58 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
                 Write(item.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(2063, 196, true);
                WriteLiteral("\r\n                    </h5>\r\n                    <img src=\'../../../upload/icon/red.png\' style=\'width:10px; height:10px;\'>\r\n                  </div>\r\n                </div>\r\n              </div>\r\n");
                EndContext();
#line 64 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
          }

#line default
#line hidden
                BeginContext(2272, 18, true);
                WriteLiteral("        </div>\r\n\r\n");
                EndContext();
                BeginContext(2319, 376, true);
                WriteLiteral(@"        <div id=""groups"">
          <hr/>
                <h5 style=""display:inline;"">MEMBER GROUPS</h5>
                <img onclick=""$('#modalGroup').show()"" data-toggle=""modal"" data-target=""#modalGroup"" style=""display:inline;width:40px;height:40px;float:right;margin-right:15px;cursor:pointer;"" src=""https://image.flaticon.com/icons/svg/60/60732.svg"">
          <hr/>
");
                EndContext();
#line 73 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
           foreach (var item in Model.memberGroups)
          {

#line default
#line hidden
                BeginContext(2761, 46, true);
                WriteLiteral("            <div class=\'chat_list active_chat\'");
                EndContext();
                BeginWriteAttribute("id", " id=\'", 2807, "\'", 2822, 1);
#line 75 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
WriteAttributeValue("", 2812, item.Name, 2812, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2823, 420, true);
                WriteLiteral(@">
              <div class='chat_people'>
                <div class='chat_ib'>
                  <div class='chat_img'> 
                    <img style=""width:40px;height:40px;border-radius:100%;"" src=""https://st2.depositphotos.com/4520249/7735/v/950/depositphotos_77358214-stock-illustration-clients-public-group-icon.jpg"">
                  </div>
                  <h5 style=""cursor:pointer"" name=""SelectGroup""");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 3243, "\"", 3278, 3);
                WriteAttributeValue("", 3253, "SelectGroup(\'", 3253, 13, true);
#line 81 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
WriteAttributeValue("", 3266, item.Name, 3266, 10, false);

#line default
#line hidden
                WriteAttributeValue("", 3276, "\')", 3276, 2, true);
                EndWriteAttribute();
                BeginContext(3279, 24, true);
                WriteLiteral("> \r\n                    ");
                EndContext();
                BeginContext(3304, 9, false);
#line 82 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
               Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(3313, 94, true);
                WriteLiteral(" \r\n                  </h5>\r\n                </div>\r\n              </div>\r\n            </div>\r\n");
                EndContext();
#line 87 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
          }

#line default
#line hidden
                BeginContext(3420, 18, true);
                WriteLiteral("        </div>\r\n\r\n");
                EndContext();
                BeginContext(3469, 102, true);
                WriteLiteral("        <div id=\"users\">\r\n          <hr/>\r\n                <h5>DISCOVER GROUPS</h5>\r\n          <hr/>\r\n");
                EndContext();
#line 95 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
           foreach (var item in Model.groups.Where(x=> !Model.memberGroups.Contains(x)).ToList())
          {

#line default
#line hidden
                BeginContext(3683, 46, true);
                WriteLiteral("            <div class=\'chat_list active_chat\'");
                EndContext();
                BeginWriteAttribute("id", " id=\'", 3729, "\'", 3744, 1);
#line 97 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
WriteAttributeValue("", 3734, item.Name, 3734, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3745, 380, true);
                WriteLiteral(@">
              <div class='chat_people'>
                <div class='chat_ib'>
                  <div class='chat_img'> 
                    <img style=""width:40px;height:40px;border-radius:100%;"" src=""https://st2.depositphotos.com/4520249/7735/v/950/depositphotos_77358214-stock-illustration-clients-public-group-icon.jpg"">
                  </div>
                  <h5> ");
                EndContext();
                BeginContext(4126, 9, false);
#line 103 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
                  Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(4135, 164, true);
                WriteLiteral(" </h5><h8 style=\"border-style: groove; margin-left: 5px;\">private</h8>\r\n                  <h6 style=\"cursor:pointer; margin-left: 10px; border: 2px;\" id=\"JoinGroup\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 4299, "\"", 4332, 3);
                WriteAttributeValue("", 4309, "JoinGroup(\'", 4309, 11, true);
#line 104 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
WriteAttributeValue("", 4320, item.Name, 4320, 10, false);

#line default
#line hidden
                WriteAttributeValue("", 4330, "\')", 4330, 2, true);
                EndWriteAttribute();
                BeginContext(4333, 78, true);
                WriteLiteral(">JOIN</h6>\r\n                </div>\r\n              </div>\r\n            </div>\r\n");
                EndContext();
#line 108 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
          }

#line default
#line hidden
                BeginContext(4424, 129, true);
                WriteLiteral("        </div>\r\n      </div>\r\n    </div>\r\n    <div class=\"mesgs\">\r\n      <div class=\"msg_history\">\r\n        <div id=\"messages\">\r\n");
                EndContext();
#line 115 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
           foreach (var item in Model.messages.Where(x=>x.isRead == true || x.SenderName == Model.currentUserName).ToList())
          {
              

#line default
#line hidden
#line 117 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
               if(item.SenderName == Model.currentUserName) 
              {

#line default
#line hidden
                BeginContext(4771, 109, true);
                WriteLiteral("                <div class=\'outgoing_msg\'>\r\n                  <div class=\'sent_msg\'>\r\n                    <p>");
                EndContext();
                BeginContext(4881, 19, false);
#line 121 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
                  Write(item.MessageContent);

#line default
#line hidden
                EndContext();
                BeginContext(4900, 56, true);
                WriteLiteral("</p>\r\n                  </div>\r\n                </div>\r\n");
                EndContext();
#line 124 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
              }
              else 
              {

#line default
#line hidden
                BeginContext(5011, 177, true);
                WriteLiteral("                <div class=\'incoming_msg\'>\r\n                  <div class=\'incoming_msg_img\'>\r\n                    <img src=\'https://ptetutorials.com/images/user-profile.png\'><p>");
                EndContext();
                BeginContext(5189, 15, false);
#line 129 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
                                                                              Write(item.SenderName);

#line default
#line hidden
                EndContext();
                BeginContext(5204, 157, true);
                WriteLiteral("</p>\r\n                  </div>\r\n                  <div class=\'received_msg\'>\r\n                    <div class=\'received_withd_msg\'>\r\n                      <p>");
                EndContext();
                BeginContext(5362, 19, false);
#line 133 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
                    Write(item.MessageContent);

#line default
#line hidden
                EndContext();
                BeginContext(5381, 84, true);
                WriteLiteral("</p>\r\n                    </div>\r\n                  </div>\r\n                </div>\r\n");
                EndContext();
#line 137 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
              }

#line default
#line hidden
#line 137 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
               
          }

#line default
#line hidden
                BeginContext(5495, 10, true);
                WriteLiteral("          ");
                EndContext();
#line 139 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
           if(Model.messages.Where(x=> x.isRead == false && x.SenderName != Model.currentUserName).ToList().Count() > 0) 
          {

#line default
#line hidden
                BeginContext(5631, 76, true);
                WriteLiteral("            <hr/>\r\n            <div style=\"text-align:center;\"><p>Okunmamis ");
                EndContext();
                BeginContext(5708, 101, false);
#line 142 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
                                                    Write(Model.messages.Where(x=> x.isRead == false && x.SenderName != Model.currentUserName).ToList().Count());

#line default
#line hidden
                EndContext();
                BeginContext(5809, 46, true);
                WriteLiteral(" mesaj mevcut!!</p></div>\r\n            <hr/>\r\n");
                EndContext();
#line 144 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
             foreach (var item in Model.messages.Where(x=>x.isRead == false && x.SenderName != Model.currentUserName).ToList())
            {
                

#line default
#line hidden
                BeginContext(6017, 171, true);
                WriteLiteral("              <div class=\'incoming_msg\'>\r\n                <div class=\'incoming_msg_img\'>\r\n                  <img src=\'https://ptetutorials.com/images/user-profile.png\'><p>");
                EndContext();
                BeginContext(6189, 15, false);
#line 149 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
                                                                            Write(item.SenderName);

#line default
#line hidden
                EndContext();
                BeginContext(6204, 149, true);
                WriteLiteral("</p>\r\n                </div>\r\n                <div class=\'received_msg\'>\r\n                  <div class=\'received_withd_msg\'>\r\n                    <p>");
                EndContext();
                BeginContext(6354, 19, false);
#line 153 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
                  Write(item.MessageContent);

#line default
#line hidden
                EndContext();
                BeginContext(6373, 78, true);
                WriteLiteral("</p>\r\n                  </div>\r\n                </div>\r\n              </div>\r\n");
                EndContext();
#line 157 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
            }

#line default
#line hidden
#line 157 "E:\Bilgisayar Mühendisligi\8.Dönem\Ağ Programlama\Proje\chat-app-signalr\Views\Administrator\Dashboard.cshtml"
             
          }

#line default
#line hidden
                BeginContext(6479, 1399, true);
                WriteLiteral(@"        </div>
      </div>
      <div class=""type_msg"">
        <div class=""input_msg_write"">
          <input type=""text"" id=""message"" class=""write_msg"" placeholder=""Type a message"" />
          <button class=""msg_send_btn"" id=""sendButton"" type=""button""><i class=""fa fa-paper-plane-o"" aria-hidden=""true""></i></button>
        </div>
      </div>
    </div>
  </div>
  
  <div class=""modal"" id=""modalGroup"" tabindex=""-1"" role=""dialog"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"">Create Group</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <form action=""/administrator/create-group"" method=""post"">
            <div class=""form-group"">
                <input type=""text"" required placeholder=""Group Name"" class=""form-control inputbox"" id=""G");
                WriteLiteral(@"roupName"" name=""GroupName"" /><br />
            </div>
      </div>
      <div class=""modal-footer"">
        <button type=""submit"" class=""btn btn-primary"">Save</button>
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"" onclick=""$('#modalGroup').hide();"">Close</button>
      </div>
      </form>
    </div>
  </div>
</div>
</div></div>
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
            BeginContext(7885, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
            EndContext();
            BeginContext(7898, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f94b0e7ae542e07006060ddbf21a7c6cc4eb72427812", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7938, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(7940, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f94b0e7ae542e07006060ddbf21a7c6cc4eb72428992", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7979, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(7981, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f94b0e7ae542e07006060ddbf21a7c6cc4eb72430172", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8019, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<chat_application.Models.DashboardModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
