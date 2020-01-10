using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSAlgorithmsSimulator
{
	/// <summary>
	/// A class to represent any Virtual Memory Algorithm
	/// </summary>
	public class VM_Algorithm_Base
	{
		#region Private Members

		string mInputString;

		#endregion

		#region Public Properties

		/// <summary>
		/// The input string that algorithm will work-on
		/// </summary>
		public string InputString
		{
			get { return mInputString; }
			set
			{
				if (value == mInputString)
					return;

				// build new string from digits and letters
				mInputString = new string(value.Where(a => char.IsLetterOrDigit(a)).ToArray());
			}
		}

		/// <summary>
		/// Number of hits after algorithm calculations finished
		/// </summary>
		public int Hits { get; set; }

		/// <summary>
		/// Number of faults after algorithm calculations finished
		/// </summary>
		public int Faults { get; set; }

		/// <summary>
		/// The input frames that algorithm will work-on
		/// </summary>
		public int FramesCount { get; set; }

		/// <summary>
		/// List of finished <see cref="OSASVMObject"/>s
		/// </summary>
		public List<OSASVMObject> OutputList { get; set; }

		#endregion
	}
}
