using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HospitalManagment.Data;
using Volo.Abp.DependencyInjection;

namespace HospitalManagment.EntityFrameworkCore;

public class EntityFrameworkCoreHospitalManagmentDbSchemaMigrator
    : IHospitalManagmentDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreHospitalManagmentDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the HospitalManagmentDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<HospitalManagmentDbContext>()
            .Database
            .MigrateAsync();
    }
}
