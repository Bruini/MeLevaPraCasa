using Microsoft.Extensions.DependencyInjection;

namespace AngelHack.Repository
{
    public class IoCService
    {
        public void ChildServiceRegister(IServiceCollection service)
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