using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSAlgorithmsSimulator
{
	/// <summary>
	/// A class to represent an object inside Virtual memory frames
	/// </summary>
	public class OSASFrameObject
	{
		/// <summary>
		/// The value inside the frame
		/// </summary>
		public object Value { get; set; }

		/// <summary>
		/// Indicates if second chance or not
		/// </summary>
		public bool SecondChance { get; set; }


		#region Constructor

		public OSASFrameObject()
		{
			Value = null;
			SecondChance = false;
		} 

		public OSASFrameObject(object value,bool secondChance = false)
		{
			Value = value;
			SecondChance = secondChance;
		}

		#endregion

		#region Override Methods

		public override bool Equals(object obj)
		{
			if(obj is OSASFrameObject)
			{
				return (obj as OSASFrameObject).Value == this.Value;
			}
			else
			{
				return obj.Equals(this.Value);
			}
		}

		public override int GetHashCode()
		{
			return this.Value.GetHashCode();
		}

		public override string ToString()
		{
			return this.Value.ToString();
		}

		#endregion
	}
}
