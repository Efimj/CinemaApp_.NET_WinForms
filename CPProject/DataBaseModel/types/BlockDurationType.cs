using System.ComponentModel;

namespace CPProject.DataBaseModel.types
{
    public enum BlockDurationType
    {
        [Description("Infinite")]
        Infinite,
        [Description("Fifteen minutes")]
        FifteenMinutes,
        [Description("Thirty minutes")]
        ThirtyMinutes,
        [Description("One hour")]
        OneHour,
        [Description("Four hours")]
        FourHours,
        [Description("One day")]
        OneDay,
        [Description("Two days")]
        TwoDays,
        [Description("One week")]
        OneWeek,
        [Description("Two weeks")]
        TwoWeeks
    }
}
