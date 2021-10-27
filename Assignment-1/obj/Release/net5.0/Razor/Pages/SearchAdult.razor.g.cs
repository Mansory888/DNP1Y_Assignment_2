#pragma checksum "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\Pages\SearchAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "445d6cc7ee8a97114c6905f979f3c60556f37fcc"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment_1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\_Imports.razor"
using Assignment_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\_Imports.razor"
using Assignment_1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\Pages\SearchAdult.razor"
using Assignment_1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\Pages\SearchAdult.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/SearchAdult")]
    public partial class SearchAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>SearchAdult</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.OpenElement(2, "p");
            __builder.AddAttribute(3, "style", "float: left; margin: 20px");
            __builder.AddMarkupContent(4, "\r\n        Filter by First Name: ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\Pages\SearchAdult.razor"
                                                           (arg) => FilterByFirstName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "style", "width: 50px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    \r\n    ");
            __builder.OpenElement(10, "p");
            __builder.AddAttribute(11, "style", "float: left; margin: 20px");
            __builder.AddMarkupContent(12, "\r\n        Filter by Last Name: ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "type", "text");
            __builder.AddAttribute(15, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\Pages\SearchAdult.razor"
                                                          (arg) => FilterByLastName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "style", "width: 50px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    \r\n    ");
            __builder.OpenElement(18, "p");
            __builder.AddAttribute(19, "style", "float: left; margin: 20px");
            __builder.AddMarkupContent(20, "\r\n        Filter by Age: ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "number");
            __builder.AddAttribute(23, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\Pages\SearchAdult.razor"
                                                      (arg) => FilterByAge(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "style", "width: 50px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\Pages\SearchAdult.razor"
 if (AdultsToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "<p><em>Loading... </em></p>");
#nullable restore
#line 27 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\Pages\SearchAdult.razor"
} else if (!AdultsToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(26, "<p><em>No adults exist</em></p>");
#nullable restore
#line 32 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\Pages\SearchAdult.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "table");
            __builder.AddAttribute(28, "class", "table ");
            __builder.AddMarkupContent(29, @"<thead><tr><th>First Name</th>
            <th>Last Name</th>
            <th>Hair Color</th>
            <th>Eye Color</th>
            <th>Age</th>
            <th>Weight</th>
            <th>Height</th>
            <th>Sex</th>
            <th>Job</th></tr></thead>
        ");
            __builder.OpenElement(30, "tbody");
#nullable restore
#line 50 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\Pages\SearchAdult.razor"
         foreach (var adult in AdultsToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "tr");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 53 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\Pages\SearchAdult.razor"
                     adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 54 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\Pages\SearchAdult.razor"
                     adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 55 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\Pages\SearchAdult.razor"
                     adult.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 56 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\Pages\SearchAdult.razor"
                     adult.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 57 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\Pages\SearchAdult.razor"
                     adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 58 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\Pages\SearchAdult.razor"
                     adult.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 59 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\Pages\SearchAdult.razor"
                     adult.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 60 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\Pages\SearchAdult.razor"
                     adult.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 61 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\Pages\SearchAdult.razor"
                     string.Join(",", adult.JobTitle)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\Pages\SearchAdult.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 67 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\Pages\SearchAdult.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\Pages\SearchAdult.razor"
       
    private IList<Adult> AllAdults;
    private IList<Adult> AdultsToShow;

    private string? FName;
    private string? LName;
    private int? Age;

    protected override async Task OnInitializedAsync()
    {
        AllAdults = FamilyManager.getAdults();
        AdultsToShow = AllAdults;
    }

    private void FilterByFirstName(ChangeEventArgs args)
    {
        FName = null;

        try
        {
            FName = args.Value.ToString();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        ExecuteFilter();
    }

    private void FilterByLastName(ChangeEventArgs args)
    {
        LName = null;

        try
        {
            LName = args.Value.ToString();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        ExecuteFilter();
    }

    private void FilterByAge(ChangeEventArgs args)
    {
        Age = null;

        try
        {
            Age = int.Parse(args.Value.ToString());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        ExecuteFilter();
    }

    private void ExecuteFilter()
    {
        AdultsToShow = AllAdults.Where(t => (FName != null && t.FirstName == FName || FName == null || FName == "") &&
                                            (LName != null && t.LastName == LName || LName == null || LName == "") &&
                                            (Age != null && t.Age == Age || Age == null)).ToList();
    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITFamilyManager FamilyManager { get; set; }
    }
}
#pragma warning restore 1591
