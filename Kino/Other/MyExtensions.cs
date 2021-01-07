using System;

namespace Kino.Other

{
	public static class MyExtensions
	{
		public static decimal? ToNullableDecimal(this string val)
		{
			decimal outValue = default;
			return decimal.TryParse(val, out outValue) ? (decimal?)outValue : null;
		}

		public static TimeSpan? ToNullableTimeSpan(this string val)
		{
			TimeSpan outValue;
			return TimeSpan.TryParse(val, out outValue) ? (TimeSpan?)outValue : null;
		}
	}
}
