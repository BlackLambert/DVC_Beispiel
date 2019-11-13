using System;
using System.Collections.Generic;
using System.Text;

namespace DVC_Beispiel
{
	class StringToIntConverter : StringToNumberConverter<int>
	{
		public int Result { get; private set; } = 0;
		public bool WasSuccessful { get; private set; } = false;

		private string _input;

		public StringToIntConverter(string input)
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
			Result = int.Parse(_input);
			WasSuccessful = true;
		}
	}
}
