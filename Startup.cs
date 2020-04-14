using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using System;
using System.Globalization;
using System.Net.Http;

namespace BlazorApp8
{
    public class Startup
    {
        public Startup()//IJSRuntime jsInterop)
        {
            //var result = jsInterop.InvokeAsync<string>("blazorCulture.get").GetAwaiter().GetResult();
            //if (result != null)
            //{
            //    var culture = new CultureInfo(result);
            //    CultureInfo.DefaultThreadCurrentCulture = culture;
            //    CultureInfo.DefaultThreadCurrentUICulture = culture;
            //}
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSingleton(new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            services.AddLocalization();

        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");

        }
    }
}
