using OpenElection.Assigner.Handlers;

namespace OpenElection.Assigner;

public static class DiConfig
{
    public static IServiceCollection ConfigureServices(this IServiceCollection services)
    {
        services.AddScoped<VoterHandler>();
        return services;
    }
}