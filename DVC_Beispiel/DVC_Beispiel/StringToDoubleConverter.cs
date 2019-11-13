using System;

namespace DVC_Beispiel
{
	internal class StringToDoubleConverter : StringToNumberConverter<double>
	{
		private readonly char[] _floatingNumberSeparators = new char[] { '.', ',' };

		public double Result { get; private set; } = 0;
		public bool WasSuccessful { get; private set; } = false;

		private string _input;

		public StringToDoubleConverter(string input)
		{
			_input = input;
		}

		public void Convert()
		{
			try
			{
				convert();
			}
			catch (Exception)
			{
				WasSuccessful = false;
			}
		}

		private void convert()
		{
			if (!inputContainsSeparator())
				throw new FormatException("The provided input is no floating number.");
			string editedInput = _input;
			if (_input.Contains(_floatingNumberSeparators[0]))
				editedInput = _input.Replace(_floatingNumberSeparators[0], _floatingNumberSeparators[1]);
			Result = double.Parse(editedInput);
			WasSuccessful = true;
		}

		private bool inputContainsSeparator()
		{
			bool containsSeparator = false;
			foreach (char separator in _floatingNumberSeparators)
				containsSeparator |= _input.Contains(separator);
			return containsSeparator;
		}
	}
}