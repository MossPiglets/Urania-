﻿using System.ComponentModel;

namespace Urania.Core.Data {
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum AwgName {
        [Description(" ")]
        Unknown = 0,
        [Description("10")]
        Ten,
        [Description("11")]
        Eleven,
        [Description("12")]
        Twelve,
        [Description("13")]
        Thirteen,
        [Description("14")]
        Fourteen,
        [Description("15")]
        Fifteen,
        [Description("16")]
        Sixteen,
        [Description("17")]
        Seventeen,
        [Description("18")]
        Eighteen,
        [Description("19")]
        Nineteen,
        [Description("20")]
        Twenty,
        [Description("21")]
        TwentyOne,
        [Description("22")]
        TwentyTwo,
        [Description("23")]
        TwentyThree,
        [Description("24")]
        TwentyFour,
        [Description("25")]
        TwentyFive,
        [Description("26")]
        TwentySix,
        [Description("27")]
        TwentySeven,
        [Description("28")]
        TwentyEight,
        [Description("29")]
        TwentyNine,
        [Description("30")]
        Thirty,
        [Description("31")]
        ThirtyOne,
        [Description("32")]
        ThirtyTwo,
        [Description("33")]
        ThirtyThree,
        [Description("34")]
        ThirtyFour,
        [Description("35")]
        ThirtyFive,
        [Description("36")]
        ThirtySix,
        [Description("37")]
        ThirtySeven,
        [Description("38")]
        ThirtyEight,
        [Description("39")]
        ThirtyNine,
        [Description("40")]
        Forty
    }
}