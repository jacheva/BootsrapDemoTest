#pragma checksum "C:\Users\ReDent\Desktop\sandra\BootstrapDemoTest\Views\Friends\AddFriend.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f31d151feaf60391f42ac9e896d561f998acb14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Friends_AddFriend), @"mvc.1.0.view", @"/Views/Friends/AddFriend.cshtml")]
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
#line 1 "C:\Users\ReDent\Desktop\sandra\BootstrapDemoTest\Views\_ViewImports.cshtml"
using BootsrapDemoTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ReDent\Desktop\sandra\BootstrapDemoTest\Views\_ViewImports.cshtml"
using BootsrapDemoTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f31d151feaf60391f42ac9e896d561f998acb14", @"/Views/Friends/AddFriend.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"149cae32104a5775284a4682ada4e964a6ba6c94", @"/Views/_ViewImports.cshtml")]
    public class Views_Friends_AddFriend : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BootsrapDemoTest.Models.FriendModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>AddFriend</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\ReDent\Desktop\sandra\BootstrapDemoTest\Views\Friends\AddFriend.cshtml"
  
    ViewBag.Title = "AddFriend";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Add a friend</h2>\r\n\r\n");
#nullable restore
#line 16 "C:\Users\ReDent\Desktop\sandra\BootstrapDemoTest\Views\Friends\AddFriend.cshtml"
 using (Html.BeginForm("AddFriend", "Friends", FormMethod.Post, new { @class = "form-horizontal" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 19 "C:\Users\ReDent\Desktop\sandra\BootstrapDemoTest\Views\Friends\AddFriend.cshtml"
   Write(Html.LabelFor(friend => friend.FriendID, new { @class = "control-label col-sm-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\ReDent\Desktop\sandra\BootstrapDemoTest\Views\Friends\AddFriend.cshtml"
       Write(Html.TextBoxFor(friend => friend.FriendID, new { @class = "form-control", type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-offset-2 col-sm-10\">\r\n            ");
#nullable restore
#line 26 "C:\Users\ReDent\Desktop\sandra\BootstrapDemoTest\Views\Friends\AddFriend.cshtml"
       Write(Html.ValidationMessageFor(friend => friend.FriendID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 31 "C:\Users\ReDent\Desktop\sandra\BootstrapDemoTest\Views\Friends\AddFriend.cshtml"
   Write(Html.LabelFor(friend => friend.Name, new { @class = "control-label col-sm-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\ReDent\Desktop\sandra\BootstrapDemoTest\Views\Friends\AddFriend.cshtml"
       Write(Html.TextBoxFor(friend => friend.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-offset-2 col-sm-10\">\r\n            ");
#nullable restore
#line 38 "C:\Users\ReDent\Desktop\sandra\BootstrapDemoTest\Views\Friends\AddFriend.cshtml"
       Write(Html.ValidationMessageFor(friend => friend.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 43 "C:\Users\ReDent\Desktop\sandra\BootstrapDemoTest\Views\Friends\AddFriend.cshtml"
   Write(Html.LabelFor(friend => friend.Hometown, new { @class = "control-label col-sm-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "C:\Users\ReDent\Desktop\sandra\BootstrapDemoTest\Views\Friends\AddFriend.cshtml"
       Write(Html.TextBoxFor(friend => friend.Hometown, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-offset-2 col-sm-10\">\r\n            ");
#nullable restore
#line 50 "C:\Users\ReDent\Desktop\sandra\BootstrapDemoTest\Views\Friends\AddFriend.cshtml"
       Write(Html.ValidationMessageFor(friend => friend.Hometown));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        <div class=\"col-sm-offset-2 col-sm-10\">\r\n            <input type=\"submit\" value=\"Submit\" class=\"btn btn-default\" />\r\n            ");
#nullable restore
#line 57 "C:\Users\ReDent\Desktop\sandra\BootstrapDemoTest\Views\Friends\AddFriend.cshtml"
       Write(Html.ActionLink("Back", "AllFriends", new { },
                new { style = "color: inherit; text-decoration: none", @class = "btn btn-default" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 61 "C:\Users\ReDent\Desktop\sandra\BootstrapDemoTest\Views\Friends\AddFriend.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BootsrapDemoTest.Models.FriendModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
