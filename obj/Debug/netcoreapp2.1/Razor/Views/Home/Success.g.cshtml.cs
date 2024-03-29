#pragma checksum "/Users/michaelheverly/Desktop/c#/ActivityCenter/Views/Home/Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "378f57e834162bde148c7806acdfdf6d0bb9f790"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Success), @"mvc.1.0.view", @"/Views/Home/Success.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Success.cshtml", typeof(AspNetCore.Views_Home_Success))]
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
#line 1 "/Users/michaelheverly/Desktop/c#/ActivityCenter/Views/_ViewImports.cshtml"
using ActivityCenter;

#line default
#line hidden
#line 2 "/Users/michaelheverly/Desktop/c#/ActivityCenter/Views/_ViewImports.cshtml"
using ActivityCenter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"378f57e834162bde148c7806acdfdf6d0bb9f790", @"/Views/Home/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e339c4346f16b3c5483ad512c481a4e17eb8f1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 44, true);
            WriteLiteral("<h1>Dojo Activity Center</h1>\n\n<h4>Welcome, ");
            EndContext();
            BeginContext(45, 14, false);
#line 3 "/Users/michaelheverly/Desktop/c#/ActivityCenter/Views/Home/Success.cshtml"
        Write(ViewBag.u.Name);

#line default
#line hidden
            EndContext();
            BeginContext(59, 398, true);
            WriteLiteral(@"</h4>

<a href=""/logout""><button class=""btn btn-info"">Logout</button></a>
<br>
<br>


<table class=""table"">
  <thead>
    <tr>
      <th scope=""col"">Activity</th>
      <th scope=""col"">Date and Time</th>
      <th scope=""col"">Duration</th>
      <th scope=""col"">Event Coordinator</th>
      <th scope=""col"">No. of Participants</th>
      <th scope=""col"">Actions</th>
    </tr>
  </thead>
  <tbody>
");
            EndContext();
#line 22 "/Users/michaelheverly/Desktop/c#/ActivityCenter/Views/Home/Success.cshtml"
     foreach(Party party in ViewBag.Partys)
    {

#line default
#line hidden
            BeginContext(507, 21, true);
            WriteLiteral("    <tr>\n      <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 528, "\"", 558, 2);
            WriteAttributeValue("", 535, "/details/", 535, 9, true);
#line 25 "/Users/michaelheverly/Desktop/c#/ActivityCenter/Views/Home/Success.cshtml"
WriteAttributeValue("", 544, party.PartyId, 544, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(559, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(561, 11, false);
#line 25 "/Users/michaelheverly/Desktop/c#/ActivityCenter/Views/Home/Success.cshtml"
                                       Write(party.Title);

#line default
#line hidden
            EndContext();
            BeginContext(572, 16, true);
            WriteLiteral("</td>\n      <td>");
            EndContext();
            BeginContext(589, 28, false);
#line 26 "/Users/michaelheverly/Desktop/c#/ActivityCenter/Views/Home/Success.cshtml"
     Write(party.Date.ToString("MM/dd"));

#line default
#line hidden
            EndContext();
            BeginContext(617, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(619, 2, true);
            WriteLiteral("@ ");
            EndContext();
            BeginContext(622, 30, false);
#line 26 "/Users/michaelheverly/Desktop/c#/ActivityCenter/Views/Home/Success.cshtml"
                                      Write(party.Time.ToString("hh':'mm"));

#line default
#line hidden
            EndContext();
            BeginContext(652, 16, true);
            WriteLiteral("</td>\n      <td>");
            EndContext();
            BeginContext(669, 14, false);
#line 27 "/Users/michaelheverly/Desktop/c#/ActivityCenter/Views/Home/Success.cshtml"
     Write(party.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(683, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(685, 10, false);
#line 27 "/Users/michaelheverly/Desktop/c#/ActivityCenter/Views/Home/Success.cshtml"
                     Write(party.Type);

#line default
#line hidden
            EndContext();
            BeginContext(695, 16, true);
            WriteLiteral("</td>\n      <td>");
            EndContext();
            BeginContext(712, 18, false);
#line 28 "/Users/michaelheverly/Desktop/c#/ActivityCenter/Views/Home/Success.cshtml"
     Write(party.Planner.Name);

#line default
#line hidden
            EndContext();
            BeginContext(730, 16, true);
            WriteLiteral("</td>\n      <td>");
            EndContext();
            BeginContext(747, 26, false);
#line 29 "/Users/michaelheverly/Desktop/c#/ActivityCenter/Views/Home/Success.cshtml"
     Write(party.AttendingUsers.Count);

#line default
#line hidden
            EndContext();
            BeginContext(773, 17, true);
            WriteLiteral("</td>\n      <td>\n");
            EndContext();
#line 31 "/Users/michaelheverly/Desktop/c#/ActivityCenter/Views/Home/Success.cshtml"
          
          if(@ViewBag.UserId == @party.PlannerId)
          {

#line default
#line hidden
            BeginContext(863, 14, true);
            WriteLiteral("            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 877, "\"", 906, 2);
            WriteAttributeValue("", 884, "/delete/", 884, 8, true);
#line 34 "/Users/michaelheverly/Desktop/c#/ActivityCenter/Views/Home/Success.cshtml"
WriteAttributeValue("", 892, party.PartyId, 892, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(907, 12, true);
            WriteLiteral(">Delete</a>\n");
            EndContext();
#line 35 "/Users/michaelheverly/Desktop/c#/ActivityCenter/Views/Home/Success.cshtml"
          }
          else
          {
              bool joined = false;
              foreach(Join j in @party.AttendingUsers)
              {
                if(j.UserId == @ViewBag.UserId)
                {
                  joined = true;
                }
              }
              if(joined)
              {

#line default
#line hidden
            BeginContext(1238, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1256, "\"", 1284, 2);
            WriteAttributeValue("", 1263, "/leave/", 1263, 7, true);
#line 48 "/Users/michaelheverly/Desktop/c#/ActivityCenter/Views/Home/Success.cshtml"
WriteAttributeValue("", 1270, party.PartyId, 1270, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1285, 11, true);
            WriteLiteral(">Leave</a>\n");
            EndContext();
#line 49 "/Users/michaelheverly/Desktop/c#/ActivityCenter/Views/Home/Success.cshtml"
              }
              else
              {

#line default
#line hidden
            BeginContext(1347, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1365, "\"", 1392, 2);
            WriteAttributeValue("", 1372, "/join/", 1372, 6, true);
#line 52 "/Users/michaelheverly/Desktop/c#/ActivityCenter/Views/Home/Success.cshtml"
WriteAttributeValue("", 1378, party.PartyId, 1378, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1393, 10, true);
            WriteLiteral(">Join</a>\n");
            EndContext();
#line 53 "/Users/michaelheverly/Desktop/c#/ActivityCenter/Views/Home/Success.cshtml"
              } 
          }
        

#line default
#line hidden
            BeginContext(1442, 22, true);
            WriteLiteral("      </td>\n    </tr>\n");
            EndContext();
#line 58 "/Users/michaelheverly/Desktop/c#/ActivityCenter/Views/Home/Success.cshtml"
    }

#line default
#line hidden
            BeginContext(1470, 104, true);
            WriteLiteral("  </tbody>\n</table>\n<a href=\"/party/new\"><button class=\"btn btn-primary\">Add a new Activity</button></a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
