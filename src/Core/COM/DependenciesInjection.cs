using Microsoft.Extensions.DependencyInjection;
using Oil_level_glass.Core.COM.Api7.Glass;
using Oil_level_glass.Core.COM.Api7.Housing;
using Oil_level_glass.Core.COM.Api7.OilLevelGlass;
using Oil_level_glass.Core.COM.Api7.RubberStrip;
using Oil_level_glass.Core.Glass;
using Oil_level_glass.Core.Housing;
using Oil_level_glass.Core.OilLevelGlass;
using Oil_level_glass.Core.RubberStrip;

namespace Oil_level_glass.Core.COM
{
    public static class DependenciesInjection
    {
        public static IServiceCollection AddCreators(this IServiceCollection services)
        {
            services.AddTransient<IGlassPartCreator, GlassPartCreator7>();
            services.AddTransient<IHousingCreator, HousingPartCreator7>();
            services.AddTransient<IRubberStripCreator, RubberStripPartCreator7>();

            services.AddTransient<IOilLevelGlassCreator, OilLevelGlassPartCreator>();

            return services;
        }
    }
}
