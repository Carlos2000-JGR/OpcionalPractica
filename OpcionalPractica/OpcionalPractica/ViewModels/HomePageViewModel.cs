using OpcionalPractica.Models;
using OpcionalPractica.StaticResources;
using OpcionalPractica.ViewModels;
using Prism.Commands;
using Prism.Navigation;
using System;
using OpcionalPractica.Models;
using System.Collections.Generic;
using System.Text;

namespace OpcionalPractica.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        public DelegateCommand<WorkoutItem> GoToDetailsCommand { get; }
        public HomePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            GoToDetailsCommand = new DelegateCommand<WorkoutItem>(
                async (WorkoutItem meditationItem) =>
                {
                    await navigationService.NavigateAsync($"{NavigationConstants.Paths.DetailsPage}", new NavigationParameters()
                    {
                        { NavigationConstants.Parameters.WorkoutItem, meditationItem }
                    });
                });
        }



        private WorkoutItem _selectedDailyMeditationItem;
        public WorkoutItem SelectedMeditationItem
        {
            get
            {
                return _selectedDailyMeditationItem;
            }

            set
            {
                _selectedDailyMeditationItem = value;
                if (_selectedDailyMeditationItem != null)
                {
                    GoToDetailsCommand.Execute(_selectedDailyMeditationItem);
                }
            }
        }

     
    }
}
