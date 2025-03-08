using Diiage.Memoire.Back.Api.Configurations;
using Diiage.Memoire.Back.Api.Configurations.Installers.ProblemsDetails;
using Diiage.Memoire.Back.Application;
using Diiage.Memoire.Back.Persistence;
using Hellang.Middleware.ProblemDetails;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication(builder.Configuration)
    .AddPersistence(builder.Configuration)
    .AddMemoryCache()
    .InstallServices(builder.Configuration, typeof(IServiceInstaller).Assembly)
    .SetupProblemDetails(builder.Environment.IsDevelopment());

builder.Services.AddAuthorization();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.InstallApps(
    app.Configuration,
    typeof(IServiceInstaller).Assembly);

app.UseCors("AllowConfiguredOrigins");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.UseProblemDetails();

app.Run();