#pragma checksum "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\Services\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04881447aac2a2c3a6851d396f6fb6e7a23dc3ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PcSMS.Pages.Services.Pages_Services_Details), @"mvc.1.0.razor-page", @"/Pages/Services/Details.cshtml")]
namespace PcSMS.Pages.Services
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\_ViewImports.cshtml"
using PcSMS;

#line default
#line hidden
#line 3 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\_ViewImports.cshtml"
using PcSMS.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04881447aac2a2c3a6851d396f6fb6e7a23dc3ff", @"/Pages/Services/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66c73876e155df90816cccb54a7716fb80424351", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Services_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Services/History", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Comments..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\Services\Details.cshtml"
  
	ViewData["Title"] = "Details";
	Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            WriteLiteral("\r\n<div class=\"container pt-4 pb-2 row\">\r\n\t<div class=\"col-6\">\r\n\t\t<h2 class=\"text-info py-2\">Service Details</h2>\r\n\t</div>\r\n\t<div class=\"col-3 offset-3 text-right py-2\">\r\n\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04881447aac2a2c3a6851d396f6fb6e7a23dc3ff5474", async() => {
                WriteLiteral(" Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-vessId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 13 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\Services\Details.cshtml"
                                              WriteLiteral(Model.serviceHeader.VesselId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["vessId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-vessId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["vessId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
	</div>
</div>
<div class=""container backgroundWhite"">
	<div class=""card"">
		<div class=""card-header bg-primary ml-0 row container"">
			<div class=""col-1 text-center pt-3 text-light-50 "">
				<i class=""far fa-user fa-2x""></i>
			</div>
			<div class=""col-5"">
				<label class=""text-light"">");
#line 23 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\Services\Details.cshtml"
                                     Write(Model.serviceHeader.Vessel.ApplicationUser.Name);

#line default
#line hidden
            WriteLiteral("</label><br />\r\n\t\t\t\t<label class=\"text-light\">");
#line 24 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\Services\Details.cshtml"
                                     Write(Model.serviceHeader.Vessel.ApplicationUser.Email);

#line default
#line hidden
            WriteLiteral(" / ");
#line 24 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\Services\Details.cshtml"
                                                                                         Write(Model.serviceHeader.Vessel.ApplicationUser.PhoneNumber);

#line default
#line hidden
            WriteLiteral("</label><br />\r\n\r\n\t\t\t</div>\r\n\r\n\t\t\t<div class=\"col-5 text-right\">\r\n\t\t\t\t<label class=\"text-light\">");
#line 29 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\Services\Details.cshtml"
                                     Write(Model.serviceHeader.Vessel.Model);

#line default
#line hidden
            WriteLiteral(" ");
#line 29 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\Services\Details.cshtml"
                                                                       Write(Model.serviceHeader.Vessel.Color);

#line default
#line hidden
            WriteLiteral(" </label><br />\r\n\t\t\t\t<label class=\"text-light\">");
#line 30 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\Services\Details.cshtml"
                                     Write(Model.serviceHeader.Vessel.Year);

#line default
#line hidden
            WriteLiteral(@" </label>
			</div>
			<div class=""col-1 text-center pt-3 text-light-50 "">
				<i class=""fas fa-ship fa-2x""></i>
			</div>
		</div>
		<div class=""card-body"">
			<div class=""row pt-3"">

				<div class=""col-7"">

					<table class=""table table-striped border"">
						<tr class=""table-secondary"">
							<th>
								");
#line 44 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\Services\Details.cshtml"
                           Write(Html.DisplayNameFor(m => Model.serviceDetails[0].ServiceName));

#line default
#line hidden
            WriteLiteral("\r\n\t\t\t\t\t\t\t</th>\r\n\t\t\t\t\t\t\t<th>\r\n\t\t\t\t\t\t\t\t");
#line 47 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\Services\Details.cshtml"
                           Write(Html.DisplayNameFor(m => Model.serviceDetails[0].ServicePrice));

#line default
#line hidden
            WriteLiteral("\r\n\t\t\t\t\t\t\t</th>\r\n\r\n\t\t\t\t\t\t</tr>\r\n");
#line 51 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\Services\Details.cshtml"
                         foreach (var item in Model.serviceDetails)
						{

#line default
#line hidden
            WriteLiteral("\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t");
#line 55 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\Services\Details.cshtml"
                               Write(Html.DisplayFor(m => item.ServiceName));

#line default
#line hidden
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t");
#line 58 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\Services\Details.cshtml"
                               Write(Html.DisplayFor(m => item.ServicePrice));

#line default
#line hidden
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</td>\r\n\r\n\t\t\t\t\t\t\t</tr>\r\n");
#line 62 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\Services\Details.cshtml"
						}

#line default
#line hidden
            WriteLiteral("\t\t\t\t\t\t<tr style=\"background-color:#e2fee2\">\r\n\t\t\t\t\t\t\t<td colspan=\"1\">\r\n\t\t\t\t\t\t\t\t<h6 class=\"text-success\">Total Price :</h6>\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td colspan=\"2\">\r\n\t\t\t\t\t\t\t\t<h6 class=\"text-success\">$");
#line 68 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\Services\Details.cshtml"
                                                     Write(Model.serviceHeader.TotalPrice);

#line default
#line hidden
            WriteLiteral("</h6>\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t</tr>\r\n\r\n\t\t\t\t\t</table>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-5 px-4 pb-2\">\t\t\t\t\t\r\n\t\t\t\t\t<div class=\"row py-2\">\r\n\t\t\t\t\t\t<div class=\"col-12\">\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04881447aac2a2c3a6851d396f6fb6e7a23dc3ff12672", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#line 77 "D:\aWinter2020\COMP313 Project2\PROJECT2-repo\PcSMS\PcSMS\Pages\Services\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.serviceHeader.Details);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PcSMS.Pages.Services.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PcSMS.Pages.Services.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PcSMS.Pages.Services.DetailsModel>)PageContext?.ViewData;
        public PcSMS.Pages.Services.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591