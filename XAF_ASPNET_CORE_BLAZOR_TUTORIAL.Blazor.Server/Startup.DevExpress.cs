//------------------------------------------------------------------------------
//<auto-generated>
// Generated by the DevExpress.Blazor package.
// To prevent this operation, add the DxExtendStartupHost property to the project and set this property to False.
//
// XAF_ASPNET_CORE_BLAZOR_TUTORIAL.Blazor.Server.csproj:
//
// <Project Sdk="Microsoft.NET.Sdk.Web">
//  <PropertyGroup>
//    <TargetFramework>net5.0</TargetFramework>
//    <DxExtendStartupHost>False</DxExtendStartupHost>
//  </PropertyGroup>
//</auto-generated>
//------------------------------------------------------------------------------
using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(XAF_ASPNET_CORE_BLAZOR_TUTORIAL.Blazor.Server.DevExpressHostingStartup))]

namespace XAF_ASPNET_CORE_BLAZOR_TUTORIAL.Blazor.Server {
    public partial class DevExpressHostingStartup : IHostingStartup {
        void IHostingStartup.Configure(IWebHostBuilder builder) {
            builder.ConfigureServices((serviceCollection) => {
                serviceCollection.AddDevExpressBlazor();
            });
        }
    }
}
