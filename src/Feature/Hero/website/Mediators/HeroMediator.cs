using SagDemo.Feature.Hero.Factories;
using SagDemo.Feature.Hero.Services;
using SagDemo.Feature.Hero.ViewModels;
using SagDemo.Foundation.Core.Models;
using SagDemo.Foundation.Core.Services;
using SagDemo.Foundation.Core.ViewModels;

namespace SagDemo.Feature.Hero.Mediators
{
    public class HeroMediator : IHeroMediator
    {
        private readonly IHeroService _heroService;
        private readonly IMediatorService _mediatorService;
        private readonly IHeroViewModelFactory _heroViewModelFactory;

        public HeroMediator(IHeroService heroService, IMediatorService mediatorService,
            IHeroViewModelFactory heroViewModelFactory)
        {
            _heroService = heroService;
            _mediatorService = mediatorService;
            _heroViewModelFactory = heroViewModelFactory;
        }

        /// <summary>
        ///     Mediator pattern could be overkill in this instance, but here as an example to return response codes to a controller, and
        ///     keep the controller dumb as a result. Also enables little/none error handling in views.
        /// </summary>
        /// <returns>A mediator response with the result of the view model instantiation</returns>
        public MediatorResponse<HeroViewModel> RequestHeroViewModel()
        {
            var heroItemDataSource = _heroService.GetHeroItems();

            if (heroItemDataSource == null)
            {
                return _mediatorService.GetMediatorResponse<HeroViewModel>(
                    MediatorCodes.HeroResponse.DataSourceError,
                    messageViewModel: new MessageViewModel(_heroService.IsExperienceEditor, Messages.DataSourceMissing, Messages.Header));
            }

            var viewModel =
                _heroViewModelFactory.CreateHeroViewModel(heroItemDataSource, _heroService.IsExperienceEditor);

            if (viewModel == null)
            {
                return _mediatorService.GetMediatorResponse<HeroViewModel>(
                    MediatorCodes.HeroResponse.ViewModelError,
                    messageViewModel: new MessageViewModel(_heroService.IsExperienceEditor, Messages.ViewModelError, Messages.Header));
            }

            return _mediatorService.GetMediatorResponse(MediatorCodes.HeroResponse.Ok, viewModel);
        }
    }
}
