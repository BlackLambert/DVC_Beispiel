using System;
using System.Collections.Generic;
using System.Text;

namespace DVC_Beispiel
{
	interface StringToNumberConverter<TNum>
	{
		TNum Result { get; }
		bool WasSuccessful { get; }
		void Convert();
	}
}
