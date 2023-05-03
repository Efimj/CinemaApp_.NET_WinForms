using System.ComponentModel;

namespace CPProject.DataBaseModel.types
{
    public enum BlockDurationType
    {
        [Description("Infinite")]
        Infinite = -1,
        [Description("Fifteen minutes")]
        FifteenMinutes = 900,
        [Description("Thirty minutes")]
        ThirtyMinutes = 1800,
        [Description("One hour")]
        OneHour = 3600,
        [Description("Four hours")]
        FourHours = 14400,
        [Description("One day")]
        OneDay = 86400,
        [Description("Two days")]
        TwoDays = 172800,
        [Description("One week")]
        OneWeek = 604800,
        [Description("Two weeks")]
        TwoWeeks = 1209600
    }
}
