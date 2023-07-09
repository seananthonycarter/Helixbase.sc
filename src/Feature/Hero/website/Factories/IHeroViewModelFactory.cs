using SagDemo.Feature.Hero.Models;
using SagDemo.Feature.Hero.ViewModels;

namespace SagDemo.Feature.Hero.Factories
{
    public interface IHeroViewModelFactory
    {
        HeroViewModel CreateHeroViewModel(IHeroContentType heroItemDataSource, bool isExperienceEditor);
    }
}
