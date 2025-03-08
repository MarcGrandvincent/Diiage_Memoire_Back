namespace Diiage.Memoire.Back.Api.Configurations.Installers;

public class CorsServiceInstaller : IServiceInstaller, IApplicationInstaller
{
    private const string CorsPolicyName = "AllowConfiguredOrigins";
    
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        var allowedOrigins = new string[]
        {
            "http://localhost:4200",
        };
        
        services.AddCors(options =>
        {
            options.AddPolicy(CorsPolicyName,
                corsPolicyBuilder =>
                {
                    corsPolicyBuilder
                        .WithOrigins(allowedOrigins)
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials();
                });
        });
    }

    public void Setup(WebApplication app, IConfiguration configuration)
    {
        app.UseCors(CorsPolicyName);
    }
}