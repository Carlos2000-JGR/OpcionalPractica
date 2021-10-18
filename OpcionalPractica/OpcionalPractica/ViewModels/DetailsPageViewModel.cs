using OpcionalPractica.Models;
using OpcionalPractica.StaticResources;
using Prism.Navigation;
using System.Collections.ObjectModel;

namespace OpcionalPractica.ViewModels
{
    public class DetailsPageViewModel : BaseViewModel, IInitialize
    {
        public WorkoutItem SeeWorkoutItem { get; set; }
        public DetailsPageViewModel(INavigationService navigationService) : base(navigationService) { }
        public void Initialize(INavigationParameters parameters)
        {
            if (parameters.TryGetValue(NavigationConstants.Parameters.WorkoutItem, out WorkoutItem dailyMeditationItem))
            {
                SeeWorkoutItem = dailyMeditationItem;
            }
        }
    }
}
