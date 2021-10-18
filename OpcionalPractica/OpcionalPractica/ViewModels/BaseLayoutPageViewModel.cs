using OpcionalPractica.StaticResources;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpcionalPractica.ViewModels
{
  public class BaseLayoutPageViewModel : BaseViewModel, IInitialize
    {
        public string WorkoutItem { get; set; }
        public BaseLayoutPageViewModel(INavigationService navigationService) : base(navigationService) { }

        public void Initialize(INavigationParameters parameters)
        {
            if (parameters.TryGetValue(NavigationConstants.Parameters.WorkoutItem, out string workoutItem))
            {
                WorkoutItem = workoutItem;
            }
        }
    }
}