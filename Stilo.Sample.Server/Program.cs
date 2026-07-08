using Stilo.Editor;
using Stilo.Maestro;
using Stilo.Reports;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR(o => o.MaximumReceiveMessageSize = 50 * 1024 * 1024);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddStiloMaestro();
builder.Services.AddStiloEditor();
builder.Services.AddStiloReports();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<Stilo.Sample.Server.Components.App>()
    .AddInteractiveServerRenderMode();

app.Run();
