using System;
using System.Collections.Generic;
using System.Text;

namespace DVC_Beispiel
{
	public abstract class NumbersAdder
	{
		public string Result { get; private set; }

		public NumbersAdder()
		{
			Result = "Not calculated yet";
		}

		public void CalculateResult()
		{
			addNumbers();
			Result = getResult();
		}

		protected abstract void addNumbers();
		protected abstract string getResult();
	}
}
