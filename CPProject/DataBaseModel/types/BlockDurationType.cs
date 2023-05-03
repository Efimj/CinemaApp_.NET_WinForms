using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CPProject.DataBaseModel.types
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BlockDurationType
    {
        [EnumMember(Value = "-1")]
        [Description("Infinite")]
        Infinite = -1,

        [EnumMember(Value = "15")]
        [Description("Fifteen minutes")]
        FifteenMinutes = 15,

        [EnumMember(Value = "30")]
        [Description("Thirty minutes")]
        ThirtyMinutes = 30,

        [EnumMember(Value = "60")]
        [Description("One hour")]
        OneHour = 60,

        [EnumMember(Value = "240")]
        [Description("Four hours")]
        FourHours = 240,

        [EnumMember(Value = "1440")]
        [Description("One day")]
        OneDay = 1440,

        [EnumMember(Value = "2880")]
        [Description("Two days")]
        TwoDays = 2880,

        [EnumMember(Value = "10080")]
        [Description("One week")]
        OneWeek = 10080,

        [EnumMember(Value = "20160")]
        [Description("Two weeks")]
        TwoWeeks = 20160,
    }
}
