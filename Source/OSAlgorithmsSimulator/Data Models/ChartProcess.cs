using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSAlgorithmsSimulator
{
	public class ChartProcess
	{
		public string YCategory { get; set; }

		public double XValue { get; set; }

		public string SeriesLabel { get; set; }


		public ChartProcess(string ycat, double xVal,string seriesLabel)
		{
			YCategory = ycat;
			XValue = xVal;
			SeriesLabel = seriesLabel;
		}
	}
}
