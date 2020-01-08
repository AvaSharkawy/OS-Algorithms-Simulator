using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSAlgorithmsSimulator
{
	public class VM_PageReplacment : VM_Algorithm_Base
	{
		#region Public Properties

		public VMAlgorithmType AlgorithmType { get; set; }

		#endregion

		#region Constructor

		/// <summary>
		/// Default constructor
		/// </summary>
		public VM_PageReplacment()
		{
			InputString = string.Empty;
			FramesCount = 0;
			CleanInputStringLength = InputString.Length;
			AlgorithmType = VMAlgorithmType.FIFO;
		}

		/// <summary>
		/// Parameterized constructor with input string and frames count to work-on
		/// </summary>
		/// <param name="inputString">The input string</param>
		/// <param name="framesCount">The frames count</param>
		public VM_PageReplacment(string inputString, int framesCount, VMAlgorithmType type)
		{
			InputString = inputString;
			FramesCount = framesCount;
			CleanInputStringLength = InputString.Length;
			AlgorithmType = type;
		}

		#endregion

		#region Algorithm Calculation Methods

		public void Calculate()
		{
			if (string.IsNullOrEmpty(InputString) || FramesCount <= 0)
				return;

			var list = new List<OSASVMObject>();

			for(int i = 0; i < CleanInputStringLength; i++)
			{
				// Get the object
				object obj = InputString[i];

				var vmObj = new OSASVMObject();

				vmObj.InputObject = obj;

				// Set this item index to current i value
				vmObj.Index = i;

				if (i == 0)
				{
					vmObj.Frames.Add(obj);
					vmObj.Hit = false;
					Faults++;
					list.Add(vmObj);
					continue;
				}

				// Store frames values of the previous object
				//(useful in the up-coming check of existence in the next loop iteration)
				vmObj.Frames = new List<object>(list[i - 1].Frames);

				// Check if the object exists in this copied frames
				var ex = vmObj.Frames.Exists(a => a.Equals(obj));

				if (ex)
				{
					vmObj.Hit = true;
					Hits++;				
				}
				else
				{
					vmObj.Hit = false;
					Faults++;

					if (vmObj.Frames.Count < FramesCount)
						vmObj.Frames.Add(obj);
					else
					{
						vmObj.Frames[ObjectToRemoveIndex(list, vmObj, i, InputString, AlgorithmType)] = obj;
					}
				}
				list.Add(vmObj);
			}

			OutputList = list;
		}

		#endregion

		#region Helper Methods

		private int ObjectToRemoveIndex(List<OSASVMObject> objects, OSASVMObject vmObj, int current, string input, VMAlgorithmType type)
		{
			int ObjToRemoveIndex = 0;

			if (type == VMAlgorithmType.FIFO)
			{
				var lastFObjects = objects.Where(a => a.Index < current && !a.Hit).ToList();

				var objToRemoveValue = lastFObjects[lastFObjects.Count - FramesCount].InputObject;

				return ObjToRemoveIndex = vmObj.Frames.FindIndex(a => a.Equals(objToRemoveValue));
			}
			else if(type == VMAlgorithmType.LRU)
			{
				var lastFObjects = objects.AsEnumerable().Reverse().Distinct().ToList();

				var objToRemoveValue = lastFObjects[FramesCount - 1].InputObject;

				return ObjToRemoveIndex = vmObj.Frames.FindIndex(a => a.Equals(objToRemoveValue));
			}
			else if(type == VMAlgorithmType.Optimal)
			{
				var rightString = input.Substring(current, input.Length - current);

				var rightUsed = rightString.Where(a => vmObj.Frames.Exists(b => b.Equals(a))).ToList();

				if (rightUsed.Count == 0)
					return ObjToRemoveIndex = 0;

				var grouped = rightUsed.GroupBy(a => a).ToList();
				
				if(grouped.Count < vmObj.Frames.Count)
				{
					var notExists = vmObj.Frames.Where(a => !grouped.Exists(b => b.Key.Equals(a))).ToList();

					var objToRemoveValue = notExists.FirstOrDefault();

					return ObjToRemoveIndex = vmObj.Frames.FindIndex(a => a.Equals(objToRemoveValue));
				}

				grouped = grouped.OrderByDescending(a => a.Count()).ToList();

				var objToRemoveValuee = grouped.LastOrDefault().Key;

				return ObjToRemoveIndex = vmObj.Frames.FindIndex(a => a.Equals(objToRemoveValuee));
			}
			else if(type == VMAlgorithmType.MFU)
			{
				// TODO: Implement MFU Algorithm
			}
			else if(type == VMAlgorithmType.SecondChance)
			{
				// TODO: Implement Second Chance Algorithm
			}


			return ObjToRemoveIndex;
		}

		#endregion
	}
}
