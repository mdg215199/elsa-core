using Microsoft.Extensions.DependencyInjection;

namespace Elsa.Activities.McxExecution
{
    public static class ServiceCollectionExtensions
    {        
        public static IServiceCollection AddConsoleActivities(this IServiceCollection services)
        {
            return services
                .AddActivity<ReadLine>()
                .AddActivity<WriteLine>();
        }
    }
}