#pragma checksum "C:\Users\smj\source\repos\lms\Pages\License.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d9182452bb3458e05ea14ca4a32f56baba83a59"
// <auto-generated/>
#pragma warning disable 1591
namespace lms.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\smj\source\repos\lms\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\smj\source\repos\lms\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\smj\source\repos\lms\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\smj\source\repos\lms\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\smj\source\repos\lms\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\smj\source\repos\lms\_Imports.razor"
using lms;

#line default
#line hidden
#line 7 "C:\Users\smj\source\repos\lms\_Imports.razor"
using lms.Shared;

#line default
#line hidden
#line 8 "C:\Users\smj\source\repos\lms\_Imports.razor"
using lms.Constants;

#line default
#line hidden
#line 3 "C:\Users\smj\source\repos\lms\Pages\License.razor"
using Newtonsoft.Json;

#line default
#line hidden
#line 4 "C:\Users\smj\source\repos\lms\Pages\License.razor"
using lms.Models;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/default.aspx/license")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/default.aspx/license/{Id:int}")]
    public class License : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 6 "C:\Users\smj\source\repos\lms\Pages\License.razor"
 if (license != null)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "h3");
            __builder.AddAttribute(2, "class", "heading");
            __builder.AddContent(3, "License #");
            __builder.AddContent(4, 
#line 8 "C:\Users\smj\source\repos\lms\Pages\License.razor"
                                  license.Title

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "fieldset");
            __builder.AddAttribute(7, "class", "fieldset");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.AddMarkupContent(9, "<legend>License Information</legend>\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "form-row");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-group col-lg-6 col-md-6 col-sm-12");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.AddMarkupContent(16, "<label>System Name</label>\r\n                ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "value", 
#line 14 "C:\Users\smj\source\repos\lms\Pages\License.razor"
                                                    license.SystemName

#line default
#line hidden
            );
            __builder.AddAttribute(20, "readonly", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-group col-lg-6 col-md-6 col-sm-12");
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.AddMarkupContent(26, "<label>License Name</label>\r\n                ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "class", "form-control");
            __builder.AddAttribute(29, "value", 
#line 18 "C:\Users\smj\source\repos\lms\Pages\License.razor"
                                                    license.LicenseName

#line default
#line hidden
            );
            __builder.AddAttribute(30, "readonly", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "form-row");
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "form-group col-lg-8 col-md-8 col-sm-12");
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.AddMarkupContent(40, "<label>Description</label>\r\n                ");
            __builder.OpenElement(41, "textarea");
            __builder.AddAttribute(42, "class", "form-control");
            __builder.AddAttribute(43, "readonly", true);
            __builder.AddContent(44, 
#line 24 "C:\Users\smj\source\repos\lms\Pages\License.razor"
                                                         license.Description

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "form-row");
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "form-group col-lg-8 col-md-8 col-sm-12");
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.AddMarkupContent(54, "<label>License Key</label>\r\n                ");
            __builder.OpenElement(55, "input");
            __builder.AddAttribute(56, "class", "form-control");
            __builder.AddAttribute(57, "value", 
#line 30 "C:\Users\smj\source\repos\lms\Pages\License.razor"
                                                    license.LicenseKey

#line default
#line hidden
            );
            __builder.AddAttribute(58, "readonly", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "form-row");
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "form-group col-lg-6 col-md-6 col-sm-12");
            __builder.AddMarkupContent(67, "\r\n                ");
            __builder.AddMarkupContent(68, "<label>Contract Number</label>\r\n                ");
            __builder.OpenElement(69, "input");
            __builder.AddAttribute(70, "class", "form-control");
            __builder.AddAttribute(71, "value", 
#line 36 "C:\Users\smj\source\repos\lms\Pages\License.razor"
                                                    license.ContractNumber

#line default
#line hidden
            );
            __builder.AddAttribute(72, "readonly", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "form-row");
            __builder.AddMarkupContent(78, "\r\n            ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "form-group col-lg-3 col-md-3 col-sm-12");
            __builder.AddMarkupContent(81, "\r\n                ");
            __builder.AddMarkupContent(82, "<label>Start Date</label>\r\n                ");
            __builder.OpenElement(83, "input");
            __builder.AddAttribute(84, "class", "form-control");
            __builder.AddAttribute(85, "value", 
#line 42 "C:\Users\smj\source\repos\lms\Pages\License.razor"
                                                    license.StartDate.ToShortDateString()

#line default
#line hidden
            );
            __builder.AddAttribute(86, "readonly", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n            ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "form-group col-lg-3 col-md-3 col-sm-12");
            __builder.AddMarkupContent(91, "\r\n                ");
            __builder.AddMarkupContent(92, "<label>End Date</label>\r\n                ");
            __builder.OpenElement(93, "input");
            __builder.AddAttribute(94, "class", "form-control");
            __builder.AddAttribute(95, "value", 
#line 46 "C:\Users\smj\source\repos\lms\Pages\License.razor"
                                                    license.EndDate.ToShortDateString()

#line default
#line hidden
            );
            __builder.AddAttribute(96, "readonly", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n            ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "form-group col-lg-3 col-md-3 col-sm-12");
            __builder.AddMarkupContent(101, "\r\n                ");
            __builder.AddMarkupContent(102, "<label>Issued Date</label>\r\n                ");
            __builder.OpenElement(103, "input");
            __builder.AddAttribute(104, "class", "form-control");
            __builder.AddAttribute(105, "value", 
#line 50 "C:\Users\smj\source\repos\lms\Pages\License.razor"
                                                    license.IssuedDate.ToShortDateString()

#line default
#line hidden
            );
            __builder.AddAttribute(106, "readonly", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n            ");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "form-group col-lg-3 col-md-3 col-sm-12");
            __builder.AddMarkupContent(111, "\r\n                ");
            __builder.AddMarkupContent(112, "<label>Planned Renewal Date</label>\r\n                ");
            __builder.OpenElement(113, "input");
            __builder.AddAttribute(114, "class", "form-control");
            __builder.AddAttribute(115, "value", 
#line 54 "C:\Users\smj\source\repos\lms\Pages\License.razor"
                                                    license.PlannedRenewal.ToShortDateString()

#line default
#line hidden
            );
            __builder.AddAttribute(116, "readonly", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n        ");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "form-row");
            __builder.AddMarkupContent(122, "\r\n            ");
            __builder.OpenElement(123, "div");
            __builder.AddAttribute(124, "class", "form-group col-lg-3 col-md-3 col-sm-12");
            __builder.AddMarkupContent(125, "\r\n                ");
            __builder.AddMarkupContent(126, "<label>Quantity</label>\r\n                ");
            __builder.OpenElement(127, "input");
            __builder.AddAttribute(128, "class", "form-control");
            __builder.AddAttribute(129, "value", 
#line 60 "C:\Users\smj\source\repos\lms\Pages\License.razor"
                                                    license.Quantity

#line default
#line hidden
            );
            __builder.AddAttribute(130, "readonly", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n            ");
            __builder.OpenElement(133, "div");
            __builder.AddAttribute(134, "class", "form-group col-lg-3 col-md-3 col-sm-12");
            __builder.AddMarkupContent(135, "\r\n                ");
            __builder.AddMarkupContent(136, "<label>Utilized</label>\r\n                ");
            __builder.OpenElement(137, "input");
            __builder.AddAttribute(138, "class", "form-control");
            __builder.AddAttribute(139, "value", 
#line 64 "C:\Users\smj\source\repos\lms\Pages\License.razor"
                                                    license.Utilized

#line default
#line hidden
            );
            __builder.AddAttribute(140, "readonly", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n            ");
            __builder.OpenElement(143, "div");
            __builder.AddAttribute(144, "class", "form-group col-lg-3 col-md-3 col-sm-12");
            __builder.AddMarkupContent(145, "\r\n                ");
            __builder.AddMarkupContent(146, "<label>Cost</label>\r\n                ");
            __builder.OpenElement(147, "input");
            __builder.AddAttribute(148, "class", "form-control");
            __builder.AddAttribute(149, "value", 
#line 68 "C:\Users\smj\source\repos\lms\Pages\License.razor"
                                                    license.Cost

#line default
#line hidden
            );
            __builder.AddAttribute(150, "readonly", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n            ");
            __builder.OpenElement(153, "div");
            __builder.AddAttribute(154, "class", "form-group col-lg-3 col-md-3 col-sm-12");
            __builder.AddMarkupContent(155, "\r\n                ");
            __builder.AddMarkupContent(156, "<label>Type Of Cost</label>\r\n                ");
            __builder.OpenElement(157, "input");
            __builder.AddAttribute(158, "class", "form-control");
            __builder.AddAttribute(159, "value", 
#line 72 "C:\Users\smj\source\repos\lms\Pages\License.razor"
                                                    license.TypeOfCost

#line default
#line hidden
            );
            __builder.AddAttribute(160, "readonly", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n        ");
            __builder.OpenElement(164, "fieldset");
            __builder.AddAttribute(165, "class", "fieldset");
            __builder.AddMarkupContent(166, "\r\n            ");
            __builder.AddMarkupContent(167, "<legend>Owner Information</legend>\r\n            ");
            __builder.OpenElement(168, "div");
            __builder.AddAttribute(169, "class", "form-row");
            __builder.AddMarkupContent(170, "\r\n                ");
            __builder.OpenElement(171, "div");
            __builder.AddAttribute(172, "class", "form-group col-lg-4 col-md-4 col-sm-12");
            __builder.AddMarkupContent(173, "\r\n                    ");
            __builder.AddMarkupContent(174, "<label>Name</label>\r\n                    ");
            __builder.OpenElement(175, "input");
            __builder.AddAttribute(176, "class", "form-control");
            __builder.AddAttribute(177, "value", 
#line 80 "C:\Users\smj\source\repos\lms\Pages\License.razor"
                                                        license.Owner.Title

#line default
#line hidden
            );
            __builder.AddAttribute(178, "readonly", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(179, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(180, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\r\n");
#line 106 "C:\Users\smj\source\repos\lms\Pages\License.razor"
         if (license.Attachments)
        {

#line default
#line hidden
            __builder.AddContent(183, "            ");
            __builder.OpenElement(184, "fieldset");
            __builder.AddAttribute(185, "class", "fieldset noprint");
            __builder.AddAttribute(186, "id", "attachments");
            __builder.AddMarkupContent(187, "\r\n                ");
            __builder.AddMarkupContent(188, "<legend>Attachments</legend>\r\n                ");
            __builder.OpenElement(189, "table");
            __builder.AddAttribute(190, "id", "allAttachments");
            __builder.AddMarkupContent(191, "\r\n                    ");
            __builder.OpenElement(192, "tbody");
            __builder.AddMarkupContent(193, "\r\n");
#line 112 "C:\Users\smj\source\repos\lms\Pages\License.razor"
                         foreach (AttachmentFiles itemFile in license.AttachmentFiles)
                        {

#line default
#line hidden
            __builder.AddContent(194, "                            ");
            __builder.OpenElement(195, "tr");
            __builder.OpenElement(196, "td");
            __builder.OpenElement(197, "a");
            __builder.AddAttribute(198, "class", "btn btn-link");
            __builder.AddAttribute(199, "href", 
#line 114 "C:\Users\smj\source\repos\lms\Pages\License.razor"
                                                                    Navigator.BaseUri+Settings.AttachmentURL+itemFile.ServerRelativeUrl

#line default
#line hidden
            );
            __builder.AddAttribute(200, "target", "_blank");
            __builder.AddContent(201, 
#line 114 "C:\Users\smj\source\repos\lms\Pages\License.razor"
                                                                                                                                                           itemFile.FileName

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(202, "\r\n");
#line 115 "C:\Users\smj\source\repos\lms\Pages\License.razor"
                        }

#line default
#line hidden
            __builder.AddContent(203, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(204, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(205, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(206, "\r\n");
#line 119 "C:\Users\smj\source\repos\lms\Pages\License.razor"
        }

#line default
#line hidden
            __builder.AddContent(207, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(208, "\r\n");
#line 121 "C:\Users\smj\source\repos\lms\Pages\License.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 124 "C:\Users\smj\source\repos\lms\Pages\License.razor"
       
    [Parameter]
    public int Id { get; set; }
    private Value license = new Value();
    private Owner owner = new Owner();
    private AttachmentFiles file = new AttachmentFiles();
    private List<AttachmentFiles> files = new List<AttachmentFiles>();

    protected override async Task OnInitializedAsync()
    {
        await GetListItemAsync();
    }

    private async Task GetListItemAsync()
    {
        string response = string.Empty;
        license.AttachmentFiles = files;
        license.Owner = owner;
        HttpClient Http = new HttpClient();
        string uid = Settings.Id.ToString();
        Http.DefaultRequestHeaders.Add("Accept", "application/json");
        //response = await Http.GetStringAsync(Navigator.BaseUri + Settings.BaseURL + "_api/web/lists(guid'" + Settings.LicensesListGuid + "')/items('" + Id + "')?$select=*,AttachmentFiles/ServerRelativeUrl,AttachmentFiles/FileName,Owner/Title,Owner/UserName,Owner/EMail,Owner/Department,Owner/WorkPhone,Owner/Office&$expand=AttachmentFiles,Owner");
        response = await Http.GetStringAsync(Navigator.BaseUri + Settings.BaseURL + "_api/web/lists(guid'" + Settings.LicensesListGuid + "')/items('" + Id + "')?$select=*,AttachmentFiles/ServerRelativeUrl,AttachmentFiles/FileName,Owner/Title&$expand=AttachmentFiles,Owner");
        license = JsonConvert.DeserializeObject<Value>(response);
        StateHasChanged();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigator { get; set; }
    }
}
#pragma warning restore 1591