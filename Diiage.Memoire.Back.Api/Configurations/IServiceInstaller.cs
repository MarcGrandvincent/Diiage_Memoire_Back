using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Diiage.Memoire.Back.Api.Configurations;

public interface IServiceInstaller
{
    void Install(IServiceCollection services, IConfiguration configuration);
}