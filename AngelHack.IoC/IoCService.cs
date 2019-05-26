using AngelHack.Business;
using AngelHack.Business.Interfaces;
using AngelHack.Repository.Interfaces;
using AngelHack.Repository.Repos;
using Microsoft.Extensions.DependencyInjection;

namespace AngelHack.IoC
{
    public class IoCService
    {
        private IServiceCollection services;

        public void Register(IServiceCollection service)
        {
            RepositoryService(service);
            BusinessService(service);
        }

        public void RepositoryService(IServiceCollection service)
        {
            service.AddScoped<IPetRepository, PetRepository>();
        }

        public void BusinessService(IServiceCollection service)
        {
            service.AddScoped<IPetBusiness, PetBusiness>();
        }
    }
}
