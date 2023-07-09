using SagDemo.Foundation.ORM.Models;

namespace SagDemo.Feature.Hero.Models
{
    // Use a Glass Base item for all Modules for infer types and to avoid 'Type Hijacking'
    public interface IHeroGlassBase : IGlassBase
    {
    }
}
