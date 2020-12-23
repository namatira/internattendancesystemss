#pragma checksum "C:\Users\sengk\Desktop\AttendanceSytstemV2.0\AttendanceSytstemWebApplication\Pages\AmbaDashboard\Schedule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d3cddcfab646f89d586b481be03a226ae452786"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AttendanceSytstemWebApplication.Pages.AmbaDashboard.Pages_AmbaDashboard_Schedule), @"mvc.1.0.razor-page", @"/Pages/AmbaDashboard/Schedule.cshtml")]
namespace AttendanceSytstemWebApplication.Pages.AmbaDashboard
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
#line 1 "C:\Users\sengk\Desktop\AttendanceSytstemV2.0\AttendanceSytstemWebApplication\Pages\_ViewImports.cshtml"
using AttendanceSytstemWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sengk\Desktop\AttendanceSytstemV2.0\AttendanceSytstemWebApplication\Pages\AmbaDashboard\Schedule.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d3cddcfab646f89d586b481be03a226ae452786", @"/Pages/AmbaDashboard/Schedule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1d450acf24a53efd858184d78353afa785e4785", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AmbaDashboard_Schedule : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "UpsertSchedule", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info form-control text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ambaSchedule.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\sengk\Desktop\AttendanceSytstemV2.0\AttendanceSytstemWebApplication\Pages\AmbaDashboard\Schedule.cshtml"
  
    ViewData["Title"] = "Schedule";
    ViewData["User"] = @HttpContext.Session.GetString("Amba_Username");
    Layout = "~/Pages/Shared/_AmbassadorLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container col-12 border-0 shadow p-3 mt-5\" style=\"background-color: #e9f4f5\">\r\n    <h2 class=\"m-2 mb-4\">Time Schedule</h2>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d3cddcfab646f89d586b481be03a226ae4527865303", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\sengk\Desktop\AttendanceSytstemV2.0\AttendanceSytstemWebApplication\Pages\AmbaDashboard\Schedule.cshtml"
         if (Model.Schedules.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\sengk\Desktop\AttendanceSytstemV2.0\AttendanceSytstemWebApplication\Pages\AmbaDashboard\Schedule.cshtml"
             foreach (var item in Model.Schedules)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"col-12 border shadow p-3 m-1 rounded justify-content-center\"  style=\"background-color: #f5f9fa\">\r\n                    <h5>");
#nullable restore
#line 18 "C:\Users\sengk\Desktop\AttendanceSytstemV2.0\AttendanceSytstemWebApplication\Pages\AmbaDashboard\Schedule.cshtml"
                   Write(Html.DisplayFor(m => item.Date));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                    <p class=\"h6\">Time: ");
#nullable restore
#line 19 "C:\Users\sengk\Desktop\AttendanceSytstemV2.0\AttendanceSytstemWebApplication\Pages\AmbaDashboard\Schedule.cshtml"
                                   Write(Html.DisplayFor(m => item.StartTime));

#line default
#line hidden
#nullable disable
                WriteLiteral(" To ");
#nullable restore
#line 19 "C:\Users\sengk\Desktop\AttendanceSytstemV2.0\AttendanceSytstemWebApplication\Pages\AmbaDashboard\Schedule.cshtml"
                                                                            Write(Html.DisplayFor(m => item.EndTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <div class=\"d-flex justify-content-end\">\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 959, "\"", 1014, 2);
                WriteAttributeValue("", 966, "UpsertSchedule?id=", 966, 18, true);
#nullable restore
#line 21 "C:\Users\sengk\Desktop\AttendanceSytstemV2.0\AttendanceSytstemWebApplication\Pages\AmbaDashboard\Schedule.cshtml"
WriteAttributeValue("", 984, Html.DisplayFor(m => item.Id), 984, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-success form-control text-white mr-1 d-flex col-2 justify-content-center"" style=""cursor: pointer"">Edit</a>
                        <a class=""btn btn-danger form-control text-white d-flex col-2 justify-content-center"" style=""cursor: pointer""");
                BeginWriteAttribute("onclick", " onclick=\"", 1272, "\"", 1340, 3);
                WriteAttributeValue("", 1282, "Delete(\'/api/Schedule?id=\'+", 1282, 27, true);
#nullable restore
#line 22 "C:\Users\sengk\Desktop\AttendanceSytstemV2.0\AttendanceSytstemWebApplication\Pages\AmbaDashboard\Schedule.cshtml"
WriteAttributeValue("", 1309, Html.DisplayFor(m => item.Id), 1309, 30, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1339, ")", 1339, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Delete</a>\r\n                    </div>\r\n                </div>\r\n                <br/>\r\n");
#nullable restore
#line 26 "C:\Users\sengk\Desktop\AttendanceSytstemV2.0\AttendanceSytstemWebApplication\Pages\AmbaDashboard\Schedule.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\sengk\Desktop\AttendanceSytstemV2.0\AttendanceSytstemWebApplication\Pages\AmbaDashboard\Schedule.cshtml"
             

        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p class=\"p-3 m-1\">No Schedule Record</p>\r\n");
#nullable restore
#line 32 "C:\Users\sengk\Desktop\AttendanceSytstemV2.0\AttendanceSytstemWebApplication\Pages\AmbaDashboard\Schedule.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d3cddcfab646f89d586b481be03a226ae4527869642", async() => {
                    WriteLiteral("New Schedule");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d3cddcfab646f89d586b481be03a226ae45278612045", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AttendanceSytstemWebApplication.Pages.AmbaDashboard.ScheduleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AttendanceSytstemWebApplication.Pages.AmbaDashboard.ScheduleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AttendanceSytstemWebApplication.Pages.AmbaDashboard.ScheduleModel>)PageContext?.ViewData;
        public AttendanceSytstemWebApplication.Pages.AmbaDashboard.ScheduleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
