using System;

namespace DVC_Beispiel
{
	class StringToNumberConverterFactory
	{
		public StringToNumberConverter<TNum> Create<TNum>(string input)
		{
			Type requestedType = typeof(TNum);

			if (requestedType == typeof(double))
				return new StringToDoubleConverter(input) as StringToNumberConverter<TNum>;
			else if(requestedType == typeof(int))
				return new StringToIntConverter(input) as StringToNumberConverter<TNum>;
			else
				throw new NotImplementedException($"There is no {nameof(StringToNumberConverter<TNum>)} implemented for type {requestedType}.");
		}
	}
}
