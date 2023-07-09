using SagDemo.Feature.Hero.Models;
using SagDemo.Foundation.Search.Models;

namespace SagDemo.Feature.Hero.Services
{
    public interface IHeroService
    {
        IHeroContentType GetHeroItems();
        BaseSearchResultItem GetHeroImagesSearch();
        bool IsExperienceEditor { get; }
    }
}
