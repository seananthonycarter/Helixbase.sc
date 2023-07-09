using Glass.Mapper.Sc.Pipelines.AddMaps;
using SagDemo.Foundation.ORM.Extensions;

namespace SagDemo.Feature.Hero.ORM
{
    public class RegisterMappings : AddMapsPipeline  {
        public void Process(AddMapsPipelineArgs args)
        {
            args.MapsConfigFactory.AddFluentMaps("SagDemo.Feature.Hero");
        }
    }
}
