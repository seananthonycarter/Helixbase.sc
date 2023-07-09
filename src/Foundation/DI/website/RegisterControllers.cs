using SagDemo.Foundation.DI.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace SagDemo.Foundation.DI
{
    public class RegisterControllers : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {

            //Sitecore.Diagnostics.Log.Info(".AddMvcControllers",this);
            serviceCollection.AddMvcControllers(
                "SagDemo.Feature.*");

        }
    }
}
