using System.Collections.ObjectModel;

namespace OpcionalPractica.Models
{
    public class WorkoutItem
    {
        public ObservableCollection<string> Images { get; }

        public WorkoutItem(ObservableCollection<string> images, string title, string description, int duration, string durationMeasure = "mins.")
        {
            Images = images;

            Title = title;

            Description = description;

            Duration = duration;

            DurationMeasure = durationMeasure;
        }



      
        public string Title { get; }
        public string Description { get; }
        public int Duration { get; }
        public string DurationMeasure { get; }
      
    }
}
