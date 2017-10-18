using System;
namespace SoccerStats
{
    public class GameResult
    {
        public DateTime GameDate { get; set; }
        public string TeamName { get; set; }
        public HomeOrAway HomeORAway { get; set; }
        public int Goals { get; set; }
        public int GoalAttemps { get; set; }
        public int ShotsOnGoals { get; set; }
        public int ShotsOffGoal { get; set; }
        public double PossessionPercent { get; set; }
        public double ConversionRate
        {
            get {
                return (double) Goals / GoalAttemps;
            }
        }

    }

    public enum HomeOrAway
    {
        Home,
        Away
    }
}
