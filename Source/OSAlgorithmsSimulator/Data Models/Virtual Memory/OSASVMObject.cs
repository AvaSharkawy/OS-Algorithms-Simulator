using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSAlgorithmsSimulator
{
	/// <summary>
	/// A class to represent Virtual memory frames with Hit or Fault condition
	/// </summary>
	public class OSASVMObject
	{
		#region Public Properties

		/// <summary>
		/// The index of this object
		/// </summary>
		public int Index { get; set; }

		/// <summary>
		/// The input object(Head) of this object
		/// </summary>
		public object InputObject { get; set; }

		/// <summary>
		/// List of objects inside frames
		/// </summary>
		public List<object> Frames { get; set; }

		/// <summary>
		/// Indicates if Hit or Fault
		/// </summary>
		public bool Hit { get; set; }

		#endregion

		#region Constructor

		/// <summary>
		/// Default constructor
		/// </summary>
		public OSASVMObject()
		{
			Frames = new List<object>();
		}


		public OSASVMObject(List<object> framesList)
		{
			Frames = framesList;
		}

		public OSASVMObject(OSASVMObject vmObject)
		{
			InputObject = vmObject.InputObject;
			Frames = vmObject.Frames;
			Hit = vmObject.Hit;
		}

		#endregion

		#region Override Methods

		public override bool Equals(object obj)
		{
			var item = obj as OSASVMObject;

			if (item == null)
			{
				return false;
			}

			return this.InputObject.Equals(item.InputObject);
		}

		public override int GetHashCode()
		{
			return this.InputObject.GetHashCode();
		}

		#endregion
	}
}
