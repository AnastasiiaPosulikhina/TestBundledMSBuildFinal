// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication18.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Anastasiia.Posulikhi\RiderProjects\TestBundledMSBuildFinal\WebApplication18\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anastasiia.Posulikhi\RiderProjects\TestBundledMSBuildFinal\WebApplication18\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Anastasiia.Posulikhi\RiderProjects\TestBundledMSBuildFinal\WebApplication18\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Anastasiia.Posulikhi\RiderProjects\TestBundledMSBuildFinal\WebApplication18\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Anastasiia.Posulikhi\RiderProjects\TestBundledMSBuildFinal\WebApplication18\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Anastasiia.Posulikhi\RiderProjects\TestBundledMSBuildFinal\WebApplication18\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Anastasiia.Posulikhi\RiderProjects\TestBundledMSBuildFinal\WebApplication18\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Anastasiia.Posulikhi\RiderProjects\TestBundledMSBuildFinal\WebApplication18\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Anastasiia.Posulikhi\RiderProjects\TestBundledMSBuildFinal\WebApplication18\_Imports.razor"
using WebApplication18;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Anastasiia.Posulikhi\RiderProjects\TestBundledMSBuildFinal\WebApplication18\_Imports.razor"
using WebApplication18.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Anastasiia.Posulikhi\RiderProjects\TestBundledMSBuildFinal\WebApplication18\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
