using System;
using System.Collections.Generic;
using System.Text;

namespace MathTutorApp
{
    internal class Student
    {
		private string name;
		private int grade;
		private int[] numAsk = { 0, 0, 0 };
		private int[] numCorr = { 0, 0, 0 };

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public int Grade
		{
			get { return grade; }
			set { grade = value; }
		}

		public int AddAsk
		{
			get { return numAsk[0]; }
			set { numAsk[0] = value; }
		}

		public int SubAsk
		{
			get { return numAsk[1]; }
			set { numAsk[1] = value; }
		}

		public int MultAsk
		{
			get { return numAsk[2]; }
			set { numAsk[2] = value; }
		}

		public int AddCorr
		{
			get { return numCorr[0]; }
			set { numCorr[0] = value; }
		}

		public int SubCorr
		{
			get { return numCorr[1]; }
			set { numCorr[1] = value; }
		}

		public int MultCorr
		{
			get { return numCorr[2]; }
			set { numCorr[2] = value; }
		}
	}
}
