using HH.bll.Services.AboutUsService;
using HH.bll.Services.BannerService;
using HH.bll.Services.ClientService;
using HH.bll.Services.CompanyService;
using HH.bll.Services.ContactService;
using HH.bll.Services.MissionService;
using HH.bll.Services.ProductService;
using HH.bll.Services.ProjectService;
using HH.bll.Services.ServiceService;
using Microsoft.Extensions.DependencyInjection;

namespace HH.web.Extensions
{
    public static class RepositoryExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<ICompanyService, CompanyService>();
            services.AddTransient<IServiceService, ServiceService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IAboutUsService, AboutUsService>();
            services.AddTransient<IMissionService, MissionService>();
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IBannerService, BannerService>();
            services.AddTransient<IProjectService, ProjectService>();
            services.AddTransient<IContactService, ContactService>();
            return services;
        }
    }
}
