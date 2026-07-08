using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Stilo.Editor;
using Stilo.Maestro;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<Stilo.Sample.Wasm.App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddStiloMaestro();
builder.Services.AddStiloEditor();

await builder.Build().RunAsync();
