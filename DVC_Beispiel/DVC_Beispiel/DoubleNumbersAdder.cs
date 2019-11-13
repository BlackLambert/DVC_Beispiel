using System;
using System.Collections.Generic;
using System.Text;

namespace DVC_Beispiel
{
	class DoubleNumbersAdder : NumbersAdder
	{
		private double _result;
		private double _fist;
		private double _second;

		public DoubleNumbersAdder(double first,
			double second): base()
		{
			_fist = first;
			_second = second;
			_result = 0;
		}

		protected override void addNumbers()
		{
			_result = _fist + _second;
		}

		protected override string getResult()
		{
			return _result.ToString();
		}
	}
}
