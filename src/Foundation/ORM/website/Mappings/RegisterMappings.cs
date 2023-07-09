using Glass.Mapper.Sc.Pipelines.AddMaps;
using SagDemo.Foundation.ORM.Extensions;

namespace SagDemo.Foundation.ORM.Mappings
{
    public class RegisterMappings : AddMapsPipeline  {
        public void Process(AddMapsPipelineArgs args)
        {
            args.MapsConfigFactory.AddFluentMaps("SagDemo.Foundation.ORM");
        }
    }
}
