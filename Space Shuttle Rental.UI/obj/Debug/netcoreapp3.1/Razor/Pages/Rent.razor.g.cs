#pragma checksum "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "206f6e8f976bf4ed0ab1225a62fd9178e5fa4f09"
// <auto-generated/>
#pragma warning disable 1591
namespace Space_Shuttle.UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\_Imports.razor"
using Space_Shuttle.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\_Imports.razor"
using Space_Shuttle.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
using Space_Shuttle.Business.Classes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
using Space_Shuttle.Common.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
using Space_Shuttle.Common.Enums;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/rent")]
    public partial class Rent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Space Shuttle Rental</h1>\r\n");
            __builder.AddMarkupContent(1, "<h3>Rent</h3>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
 if (Error != string.Empty)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "=row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-12 alert alert-danger");
            __builder.AddAttribute(8, "role", "alert");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<strong>Error</strong> ");
            __builder.AddContent(11, 
#nullable restore
#line 16 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                                    Error

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 19 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, "\r\n\r\n");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "row");
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-12");
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "table");
            __builder.AddAttribute(23, "class", "table table-hover");
            __builder.AddAttribute(24, "style", "border:1px solid");
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.AddMarkupContent(26, @"<thead class=""thead-dark"">
                <tr>
                    <th scope=""col"">Registration №</th>
                    <th scope=""col"">Make</th>
                    <th scope=""col"">Distance traveled</th>
                    <th scope=""col"">Cost per light-year </th>
                    <th scope=""col"">Space Shuttle</th>
                    <th scope=""col"">Ƶ per day</th>
                    <th scope=""col"" style=""width:177px;"">Rent or Return</th>
                    <th scope=""col"" style=""width:95px!important"">Status</th>


                </tr>
            </thead>
            ");
            __builder.OpenElement(27, "tbody");
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "tr");
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "th");
            __builder.AddAttribute(32, "scope", "row");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "style", "height:31px;");
            __builder.AddAttribute(35, "placeholder", "Registration №");
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                                                                                                    RegistrationNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => RegistrationNumber = __value, RegistrationNumber));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "td");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "style", "height:31px;");
            __builder.AddAttribute(42, "placeholder", "Make");
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                                                                              Make

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Make = __value, Make));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "td");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "style", "height:31px;");
            __builder.AddAttribute(49, "placeholder", "Distance traveled");
            __builder.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                                                                                           DistanceTraveled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => DistanceTraveled = __value, DistanceTraveled));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.OpenElement(53, "td");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "style", "height:31px;");
            __builder.AddAttribute(56, "placeholder", "Cost per light-year");
            __builder.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                                                                                             CostPerLightYear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CostPerLightYear = __value, CostPerLightYear));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.OpenElement(60, "td");
            __builder.AddMarkupContent(61, "\r\n                        ");
            __builder.OpenElement(62, "select");
            __builder.AddAttribute(63, "style", "height:31px;");
            __builder.AddAttribute(64, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                                                             SelectedSpaceShuttleType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectedSpaceShuttleType = __value, SelectedSpaceShuttleType));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(66, "option");
            __builder.AddAttribute(67, "value", "1");
            __builder.AddContent(68, "Odyssey");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
#nullable restore
#line 47 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                         foreach (var SpaceShuttle in BP.SpaceShuttleShuttlesNames)
                        { 

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, "                            ");
            __builder.OpenElement(71, "option");
            __builder.AddAttribute(72, "value", 
#nullable restore
#line 49 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                                           SpaceShuttle

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(73, 
#nullable restore
#line 49 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                                                         SpaceShuttle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n");
#nullable restore
#line 50 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(75, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.OpenElement(78, "td");
            __builder.AddAttribute(79, "style", "border-right:1px dashed lightgray");
            __builder.OpenElement(80, "button");
            __builder.AddAttribute(81, "class", "btn btn-outline-success btn-sm");
            __builder.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                                                                                                                           AddSpaceShuttle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(83, "Add");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n\r\n                    ");
            __builder.OpenElement(85, "td");
            __builder.AddMarkupContent(86, "\r\n                        ");
            __builder.OpenElement(87, "select");
            __builder.AddAttribute(88, "style", "height:31px;");
            __builder.AddAttribute(89, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                                                             SelectedCustomerID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectedCustomerID = __value, SelectedCustomerID));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(91, "\r\n");
#nullable restore
#line 59 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                             foreach (var customer in BP.GetCustomers())
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(92, "                                ");
            __builder.OpenElement(93, "option");
            __builder.AddAttribute(94, "value", 
#nullable restore
#line 61 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                                               customer.CustomerID

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(95, 
#nullable restore
#line 61 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                                                                    customer.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n");
#nullable restore
#line 62 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(97, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                    ");
            __builder.OpenElement(100, "td");
            __builder.OpenElement(101, "input");
            __builder.AddAttribute(102, "style", "width:100%; height:31px;");
            __builder.AddAttribute(103, "placeholder", "Distance");
            __builder.AddAttribute(104, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 66 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                                                                                              Distance

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(105, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Distance = __value, Distance));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n");
#nullable restore
#line 69 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                 foreach (var spaceshuttle in SpaceShuttles)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(108, "                    ");
            __builder.OpenElement(109, "tr");
            __builder.AddMarkupContent(110, "\r\n                        ");
            __builder.OpenElement(111, "th");
            __builder.AddAttribute(112, "scope", "row");
            __builder.AddContent(113, 
#nullable restore
#line 72 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                                         spaceshuttle.RegistrationNo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                        ");
            __builder.OpenElement(115, "td");
            __builder.AddContent(116, 
#nullable restore
#line 73 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                             spaceshuttle.Make

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                        ");
            __builder.OpenElement(118, "td");
            __builder.AddContent(119, 
#nullable restore
#line 74 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                             spaceshuttle.DistanceTraveled

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n                        ");
            __builder.OpenElement(121, "td");
            __builder.AddContent(122, 
#nullable restore
#line 75 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                             spaceshuttle.CostPerLightYear

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                        ");
            __builder.OpenElement(124, "td");
            __builder.AddContent(125, 
#nullable restore
#line 76 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                             spaceshuttle.Shuttles

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                        ");
            __builder.OpenElement(127, "td");
            __builder.AddContent(128, 
#nullable restore
#line 77 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                             spaceshuttle.CostPerDay

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                        ");
            __builder.OpenElement(130, "td");
            __builder.AddMarkupContent(131, "\r\n");
#nullable restore
#line 79 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                             if (spaceshuttle.Status.Equals(SpaceShuttleStatus.Booked))
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(132, "                                ");
            __builder.OpenElement(133, "button");
            __builder.AddAttribute(134, "style", "width:100%;");
            __builder.AddAttribute(135, "class", " btn btn-outline-danger btn-sm");
            __builder.AddAttribute(136, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                                                                                                               e => ReturnSpaceShuttle(spaceshuttle.ID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(137, "Return");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n");
#nullable restore
#line 82 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(139, "                                ");
            __builder.OpenElement(140, "button");
            __builder.AddAttribute(141, "style", "width:100%;");
            __builder.AddAttribute(142, "class", " btn btn-outline-primary btn-sm");
            __builder.AddAttribute(143, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                                                                                                                e =>RentSpaceShuttle(spaceshuttle.ID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(144, "Rent");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n");
#nullable restore
#line 86 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"

                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(146, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n                        ");
            __builder.OpenElement(148, "td");
            __builder.OpenElement(149, "span");
            __builder.AddAttribute(150, "class", " badge" + " badge-" + (
#nullable restore
#line 89 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                                                        spaceshuttle.Status.Equals(SpaceShuttleStatus.Available) ? "dark" : "danger"

#line default
#line hidden
#nullable disable
            ) + " badge-pill" + " float-right");
            __builder.AddAttribute(151, "style", "margin-top:3px;");
            __builder.AddContent(152, 
#nullable restore
#line 89 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                                                                                                                                                                                       spaceshuttle.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n");
#nullable restore
#line 92 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(155, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 101 "C:\Users\Admin\OneDrive\Desktop\Studier\C#\Space Shuttle Rental Assignment\Space Shuttle Rental.UI\Pages\Rent.razor"
       
    #region Variables
    string Error = string.Empty;
    int SelectedCustomerID = default;
    string Distance = string.Empty;
    string Make = string.Empty;
    string RegistrationNumber = string.Empty;
    string DistanceTraveled = string.Empty;
    string CostPerLightYear = string.Empty;
    string SelectedSpaceShuttleType = default;
    IEnumerable<ISpaceShuttle> SpaceShuttles;
    #endregion

    protected override void OnInitialized()
    {
        SpaceShuttles = BP.GetSpaceShuttles();
    }

    void ReturnSpaceShuttle(int ID)
    {
        try
        {

        }

        catch (Exception ex)
        {

            Error = ex.Message;
        }
    }

    void RentSpaceShuttle(int ID)

    {
        try
        {

        }

        catch (Exception ex)
        {

            Error = ex.Message;
        }

    }
    void AddSpaceShuttle()
    {
        try
        {

        }

        catch (Exception ex)
        {
            Error = ex.Message;
        }


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BookingProcessor BP { get; set; }
    }
}
#pragma warning restore 1591