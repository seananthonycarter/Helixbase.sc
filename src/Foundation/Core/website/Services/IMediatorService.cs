using SagDemo.Foundation.Core.Models;
using SagDemo.Foundation.Core.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace SagDemo.Foundation.Core.Services
{
    public interface IMediatorService
    {
        MediatorResponse<T> GetMediatorResponse<T>(
            string code,
            T viewModel = default(T),
            ValidationResult validationResult = null,
            object parameters = null,
            MessageViewModel messageViewModel = null);
    }
}
