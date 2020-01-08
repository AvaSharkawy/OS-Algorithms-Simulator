using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSAlgorithmsSimulator
{
	/// <summary>
	/// A class to represent any CPU Algorithm
	/// </summary>
	public class CPU_Algorithm_Base
	{
		#region Public Properties

		/// <summary>
		/// List of original processes before calculations
		/// </summary>
		public List<OSASProcess> Processes { get; set; }

		/// <summary>
		/// List of terminated(finished) processes
		/// </summary>
		public List<OSASProcess> TerminatedProcesses { get; set; }

		/// <summary>
		/// A flag to determine of calculate method finished without problems
		/// </summary>
		public bool CalculatedSuccessfully { get; set; } = false;

		#endregion
	}
}
