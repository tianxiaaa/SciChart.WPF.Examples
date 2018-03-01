﻿using System;
using System.Windows.Markup;

namespace SciChart.Sandbox.Examples.MarketProfileTradingExample
{
    public class EnumValuesExtension : MarkupExtension
    {
        private readonly Type _enumType;

        public EnumValuesExtension(Type enumType)
        {
            _enumType = enumType;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Enum.GetNames(_enumType);
        }
    }
}
