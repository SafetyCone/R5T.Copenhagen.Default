using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Canterbury;
using R5T.Dacia;


namespace R5T.Copenhagen.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="CDrivePathProvider"/> implementation of <see cref="ICDrivePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultCDrivePathProvider(this IServiceCollection services,
            ServiceAction<ICDriveNameConvention> addCDriveNameConvention)
        {
            services
                .AddSingleton<ICDrivePathProvider, CDrivePathProvider>()
                .RunServiceAction(addCDriveNameConvention)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="CDrivePathProvider"/> implementation of <see cref="ICDrivePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<ICDrivePathProvider> AddDefaultCDrivePathProviderAction(this IServiceCollection services,
            ServiceAction<ICDriveNameConvention> addCDriveNameConvention)
        {
            var serviceAction = new ServiceAction<ICDrivePathProvider>(() => services.AddDefaultCDrivePathProvider(
                addCDriveNameConvention));
            return serviceAction;
        }
    }
}
