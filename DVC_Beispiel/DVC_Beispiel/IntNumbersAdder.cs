using System;
using System.Collections.Generic;
using System.Text;

namespace DVC_Beispiel
{
	class IntNumbersAdder: NumbersAdder
	{
		private int _result;
		private int _fist;
		private int _second;

		public IntNumbersAdder(int first,
			int second) : base()
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
