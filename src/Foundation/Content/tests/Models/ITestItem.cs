using SagDemo.Foundation.ORM.Models;

namespace SagDemo.Foundation.Content.Tests.Models
{
    public interface ITestItem : IGlassBase
    {
        string Title { get; set; }
    }
}
