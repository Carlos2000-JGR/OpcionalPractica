using OpcionalPractica.Models;
using System.Collections.ObjectModel;

namespace OpcionalPractica.StaticResources
{
    public static ObservableCollection<MenuNames> QuickHelpItems { get; } = new ObservableCollection<MenuNames>
        {
            new MenuNames("ExpressIcon","Anxiety"),
            new MenuNames("EmojiIcon","Stress"),
            new MenuNames("Wind","Breathe"),
            new MenuNames("SpringMorning","Sleep")

        };
    public static class Titles
    {
        public static string QuickHelp { get; } = "Quick Help";
        public static string DailyMeditations { get; } = "Daily Meditations";
        public static string NewMusic { get; } = "New Music";
        public static string ArticleTitles { get; } = "Article Title";
    }

    //public static class Tabs
    //{
    //    public static string TabTitleIcon1 { get; } = "TitleIcon1";
    //    public static string TabTitleIcon2 { get; } = "TitoleIcon2";
    //    public static string TabTitleIcon3 { get; } = "TitleIcon3";
    //    public static string TabTitleIcon4 { get; } = "TitleIcon4";
    //    public static string TabTitleIcon5 { get; } = "TitleIcon5";
    //}


    public static class Icons
    {
        public static string Search { get; } = "Magnifier";
        public static string Export { get; } = "ExportIcon";
        public static string AddToCalendar { get; } = "CalendarIcon";
        public static string Favorite { get; } = "HeartIcon";
        public static string Tab1 { get; } = "APCE";
        public static string Tab2 { get; } = "VideoIcon";
        public static string Tab3 { get; } = "MoonIcon";
        public static string Tab4 { get; } = "DiscIcon";
        public static string Tab5 { get; } = "UserIcon";
    }

    public static class Options
    {
        public static string TabIcon1 { get; } = "Today";
        public static string TabIcon2 { get; } = "Yoga";
        public static string TabIcon3 { get; } = "Meditation";
        public static string TabIcon4 { get; } = "Meal";
        public static string TabIcon5 { get; } = "Profile";
    }
    public static class Data
    {
      

        public static WorkoutItem MainDailyMeditationItem { get; } = new WorkoutItem(
            new ObservableCollection<string>(){ "MainRestRelax.jpg" }, "Rest & Relax", "", 30);

        public static ObservableCollection<WorkoutItem> DailyMeditationItems { get; } = new ObservableCollection<WorkoutItem>
        {
             new WorkoutItem(new ObservableCollection<string>(){ "MainBlenheimPalace.jpg", "MainFirstSeason.jpg" },"Blenheim Palace", "Small batch banjo Cosby sweater, pug " + "polaroid Neutra asymmetrical " + "chambray. Bespoke Etsy wolf, Carles " +
            "PBR Odd Future ethical keytar fashion " +  "axe. Polariod artisan wayfarers fap. " + "Plaid salvia gluten-free, Inteligentsia " + "irony tote bag raw denim selfies organic " + "McSweeney's jean shorts ethical.\n" +
            "Leggins mlkshk four loko small batch, " + "occupy banh mi semiotics letterpress ")
            new WorkoutItem(new ObservableCollection<string>(){ "RainingSidewalk.jpg", "FirstSeason.jpg" },"Raining Sidewalk"),
            new WorkoutItem(new ObservableCollection<string>(){ "SpringMorning.jpg", "FirstSeason.jpg" },"Spring Morning"),
            new WorkoutItem(new ObservableCollection<string>(){ "FirstSeason.jpg", "FirstSeason.jpg" },"First Season"),
           
        };
    }
}
