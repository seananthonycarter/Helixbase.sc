using System.Web;
using Glass.Mapper.Sc;
using SagDemo.Feature.Hero.Models;
using SagDemo.Feature.Hero.ViewModels;

namespace SagDemo.Feature.Hero.Factories
{
    public class HeroViewModelFactory : IHeroViewModelFactory
    {
        private readonly IGlassHtml _glassHtml;

        public HeroViewModelFactory(IGlassHtml glassHtml)
        {
            _glassHtml = glassHtml;
        }

        public HeroViewModel CreateHeroViewModel(IHeroContentType heroItemDataSource, bool isExperienceEditor)
        {
            return new HeroViewModel
            {
                HeroImages = heroItemDataSource.HeroImages,
                HeroTitle = new HtmlString(_glassHtml.Editable(heroItemDataSource, i => i.HeroTitle,
                    new { EnclosingTag = "h2" })),
                IsExperienceEditor = isExperienceEditor
            };
        }
    }
}
