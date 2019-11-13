using System;
using System.Collections.Generic;
using System.Text;

namespace DVC_Beispiel
{
	public class NumbersAdderFactory
	{
		public NumbersAdder Create(string first, string second)
		{
			StringToNumberConverterFactory converterFactory = new StringToNumberConverterFactory();
			string[] input = new string[] { first , second };

			StringToNumberConverter<int> intConverterForFirst = converterFactory.Create<int>(first);
			intConverterForFirst.Convert();
			StringToNumberConverter<int> intConverterForSecond = converterFactory.Create<int>(second);
			intConverterForSecond.Convert();
			StringToNumberConverter<double> doubleConverterForFirst = converterFactory.Create<double>(first);
			doubleConverterForFirst.Convert();
			StringToNumberConverter<double> doubleConverterForSecond = converterFactory.Create<double>(second);
			doubleConverterForSecond.Convert();

			if (doubleConverterForFirst.WasSuccessful && doubleConverterForSecond.WasSuccessful)
				return new DoubleNumbersAdder(doubleConverterForFirst.Result, doubleConverterForSecond.Result);
			if (doubleConverterForFirst.WasSuccessful && intConverterForSecond.WasSuccessful)
				return new DoubleNumbersAdder(doubleConverterForFirst.Result, (double)intConverterForSecond.Result);
			if(intConverterForFirst.WasSuccessful && doubleConverterForSecond.WasSuccessful)
				return new DoubleNumbersAdder((double)intConverterForFirst.Result, doubleConverterForSecond.Result);
			bool intConversionWasNotSuccessful = !(intConverterForFirst.WasSuccessful && intConverterForSecond.WasSuccessful);
			if (intConversionWasNotSuccessful)
				throw new FormatException("The provided Input could not be processed. " +
					"This indicates that the input is no number.");
			return new IntNumbersAdder(intConverterForFirst.Result, intConverterForSecond.Result);
		}
	}
}