using System.Collections.Generic;
using Glass.Mapper.Sc.Fields;

namespace SagDemo.Feature.Hero.Models
{
    public interface IHero
    {
        string HeroTitle { get; set; }
        IEnumerable<Image> HeroImages { get; set; }
    }
}
