using SagDemo.Feature.Hero.ViewModels;
using SagDemo.Foundation.Core.Models;

namespace SagDemo.Feature.Hero.Mediators
{
    public interface IHeroMediator
    {
        MediatorResponse<HeroViewModel> RequestHeroViewModel();
    }
}
