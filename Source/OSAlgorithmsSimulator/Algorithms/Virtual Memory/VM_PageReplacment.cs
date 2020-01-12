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
			AlgorithmType = type;
		}

		#endregion

		#region Algorithm Calculation Methods

		public void Calculate()
		{
			if (string.IsNullOrEmpty(InputString) || FramesCount <= 0)
				return;

			var list = new List<OSASVMObject>();

			for(int i = 0; i < InputString.Length; i++)
			{
				// Get the object
				object obj = InputString[i];

				var vmObj = new OSASVMObject();

				vmObj.InputObject = obj;

				// Set this item index to current i value
				vmObj.Index = i;

				if (i == 0)
				{
					vmObj.Frames.Add(new OSASFrameObject(obj));
					vmObj.Hit = false;
					Faults++;
					list.Add(vmObj);
					continue;
				}

				// Store frames values of the previous object
				//(useful in the up-coming check of existence in the next loop iteration)
				vmObj.Frames = new List<OSASFrameObject>(list[i - 1].Frames);

				// Check if the object exists in this copied frames
				var ex = vmObj.Frames.Contains(obj);

				if (ex)
				{
					vmObj.Hit = true;
					Hits++;

					vmObj.Frames.Find(a => a.Value.Equals(obj)).SecondChance = true;
				}
				else
				{
					vmObj.Hit = false;
					Faults++;

					if (vmObj.Frames.Count < FramesCount)
						vmObj.Frames.Add(new OSASFrameObject(obj));
					else
						vmObj.Frames[ObjectToRemoveIndex(list, vmObj, i, InputString, AlgorithmType)] = new OSASFrameObject(obj);
				}
				list.Add(vmObj);
			}

			OutputList = list;
		}

		#endregion

		#region Helper Methods

		private int ObjectToRemoveIndex(List<OSASVMObject> objects, OSASVMObject vmObj, int current, string input, VMAlgorithmType type)
		{
			int ObjToRemoveIndex = -1;

			if (type == VMAlgorithmType.FIFO)
			{
				var lastFObjects = objects.Where(a => a.Index < current && !a.Hit).ToList();

				var objToRemoveValue = lastFObjects[lastFObjects.Count - FramesCount].InputObject;

				return ObjToRemoveIndex = vmObj.Frames.FindIndex(a => a.Equals(objToRemoveValue));
			}
			else if (type == VMAlgorithmType.LRU)
			{
				var lastFObjects = objects.AsEnumerable().Reverse().Distinct().ToList();

				var objToRemoveValue = lastFObjects[FramesCount - 1].InputObject;

				return ObjToRemoveIndex = vmObj.Frames.FindIndex(a => a.Equals(objToRemoveValue));
			}
			else if (type == VMAlgorithmType.Optimal)
			{
				var rightString = input.Substring(current, input.Length - current);

				var rightUsed = rightString.Where(a => vmObj.Frames.Exists(b => b.Equals(a))).ToList();

				if (rightUsed.Count == 0)
					return ObjToRemoveIndex = 0;

				var grouped = rightUsed.GroupBy(a => a).ToList();

				if (grouped.Count < vmObj.Frames.Count)
				{
					var notExists = vmObj.Frames.Where(a => !grouped.Exists(b => b.Key.Equals(a))).ToList();

					var objToRemoveValue = notExists.FirstOrDefault();

					return ObjToRemoveIndex = vmObj.Frames.FindIndex(a => a.Equals(objToRemoveValue));
				}

				grouped = grouped.OrderByDescending(a => a.Count()).ToList();

				var objToRemoveValuee = grouped.LastOrDefault().Key;

				return ObjToRemoveIndex = vmObj.Frames.FindIndex(a => a.Equals(objToRemoveValuee));
			}
			else if (type == VMAlgorithmType.MFU)
			{
				var groupedObjects = vmObj.Frames.Select(a => new
				{
					obj = a,
					count = input.Substring(0, current).Where(b => b.Equals(a.Value)).Count()
				});

				var max = groupedObjects.Max(a => a.count);

				// Now get the objects with this max count value
				var maxCountObjects = groupedObjects.Where(a => a.count == max);

				return ObjToRemoveIndex = vmObj.Frames.FindIndex(a => a.Equals(maxCountObjects.FirstOrDefault().obj.Value));
			}
			else if (type == VMAlgorithmType.SecondChance)
			{
				//var orderedObjects = objects.SelectMany(a => a.Frames).
				//	Where(e=>vmObj.Frames.Exists(f=>f.Equals(e))).
				//	GroupBy(b => b).
				//	OrderByDescending(c => c.Count());

				var orderedObjects = GetValuesCounts(objects, vmObj).OrderBy(a => a.Value);

			point:

				foreach (var obj in orderedObjects.Reverse())
				{
					var frameObj = vmObj.Frames.Find(a => a.Equals(obj.Key));

					if (frameObj == null)
						continue;

					if (frameObj.SecondChance)
					{
						frameObj.SecondChance = false;
						continue;
					}
					else
					{
						return ObjToRemoveIndex = vmObj.Frames.FindIndex(a => a.Equals(obj.Key));
					}
				}

				goto point;
			}

			return ObjToRemoveIndex;
		}

		private Dictionary<object,int> GetValuesCounts(List<OSASVMObject> objects, OSASVMObject vmObj)
		{
			var dic = new Dictionary<object, int>();
			for (var i = 0; i < vmObj.Frames.Count; i++) 
			{
				dic.Add(vmObj.Frames[i].Value, 0);

				foreach (var obj in objects.AsEnumerable().Reverse())
				{
					if (obj.Frames.Count > i)

						if (obj.Frames[i].Value == vmObj.Frames[i].Value)
							dic[vmObj.Frames[i].Value]++;
						else
							break;
				}
			}
			return dic;
		}

		#endregion
	}
}
