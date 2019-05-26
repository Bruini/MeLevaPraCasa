using Microsoft.Extensions.DependencyInjection;

namespace AngelHack.IoC
{
    public class IoCService
    {
        private IServiceCollection services;

        public void Register(IServiceCollection service)
        {
            RepositoryService(service);
            DomainService(service);
        }

        public void RepositoryService(IServiceCollection service)
        {
            //service.AddScoped<IPetRepository, PetRepository>();
        }

        public void DomainService(IServiceCollection service)
        {
            //service.AddScoped<IPetDomain, PetDomain>();
        }
    }
}
