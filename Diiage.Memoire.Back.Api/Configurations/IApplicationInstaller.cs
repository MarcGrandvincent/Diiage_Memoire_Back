using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace Diiage.Memoire.Back.Api.Configurations;

public interface IApplicationInstaller
{
    void Setup(WebApplication application, IConfiguration configuration);
}