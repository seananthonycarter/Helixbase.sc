using Helixbase.Foundation.DI.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace Helixbase.Foundation.DI
{
    public class RegisterControllers : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {

            //Sitecore.Diagnostics.Log.Info(".AddMvcControllers",this);
            serviceCollection.AddMvcControllers(
                "Helixbase.Feature.*");

        }
    }
}