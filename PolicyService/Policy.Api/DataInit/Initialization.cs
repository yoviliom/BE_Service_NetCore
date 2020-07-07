using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Policy.Application.Implementations;
using Policy.Application.Interfaces;
using Policy.Data.EF;
using Policy.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy.Api.DataInit
{
    public static class Initialization
    {
        public static IServiceCollection AddCustomMvc(this IServiceCollection services)
        {
            // Add framework services.
            services.AddControllers(options =>
            {
                //options.Filters.Add(typeof(HttpGlobalExceptionFilter));
            })
                //.AddNewtonsoftJson()
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
            ;

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                    .SetIsOriginAllowed((host) => true)
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

            return services;
        }

        public static void RegisterServiceBusinessInterface(this IServiceCollection services)
        {
            services.AddTransient(typeof(IUnitOfWork), typeof(EFUnitOfWork));
            services.AddTransient(typeof(IRepository<,>), typeof(EFRepository<,>));

            services.AddTransient<IProvinceService, ProvinceService>();
            services.AddTransient<IStudentService, StudentService>();
            services.AddTransient<ITeacherService, TeacherService>();
            services.AddTransient<IPermissionService, PermissionService>();
        }
        //public static IServiceCollection AddCustomSwagger(this IServiceCollection services, IConfiguration configuration)
        //{
        //    services.AddSwaggerGen(options =>
        //    {
        //        options.DescribeAllEnumsAsStrings();
        //        options.SwaggerDoc("v1", new OpenApiInfo
        //        {
        //            Title = "Policy repository - Policy HTTP API",
        //            Version = "v1",
        //            Description = "The Policy Service HTTP API"
        //        });

        //    });

        //    return services;
        //}

        //public static IEnumerable<string> GetApiVersions(Assembly webApiAssembly)
        //{
        //    var apiVersion = webApiAssembly.DefinedTypes
        //        .Where(x => x.IsSubclassOf(typeof(Controller)) && x.GetCustomAttributes<ApiVersionAttribute>().Any())
        //        .Select(y => y.GetCustomAttribute<ApiVersionAttribute>())
        //        .SelectMany(v => v.Versions)
        //        .Distinct()
        //        .OrderBy(x => x);

        //    return apiVersion.Select(x => x.ToString());
        //}

        //public static IServiceCollection AddCustomDbContext(this IServiceCollection services, IConfiguration configuration)
        //{
        //    services.AddEntityFrameworkNpgsql()
        //           .AddDbContext<PolicyContext>(options =>
        //           {
        //               options.UseNpgsql(configuration["ConnectionStrings:PostgresSQL"],
        //                   npgsqlOptionsAction: sqlOptions =>
        //                   {
        //                       sqlOptions.MigrationsAssembly(typeof(Startup).GetTypeInfo().Assembly.GetName().Name);
        //                       sqlOptions.EnableRetryOnFailure(maxRetryCount: 15, maxRetryDelay: TimeSpan.FromSeconds(30), errorCodesToAdd: null);
        //                   });
        //           },
        //               ServiceLifetime.Scoped  //Showing explicitly that the DbContext is shared across the HTTP request scope (graph of objects started in the HTTP request)
        //           );

        //    return services;
        //}
    }
}
