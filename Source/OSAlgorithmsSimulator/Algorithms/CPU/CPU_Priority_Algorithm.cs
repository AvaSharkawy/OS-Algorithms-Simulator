using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSAlgorithmsSimulator
{
	/// <summary>
	/// A class to represent CPU Priority algorithm
	/// </summary>
	public class CPU_Priority_Algorithm : CPU_Algorithm_Base
	{
		#region Public Properties

		/// <summary>
		/// Indicates if we should treat priority numbers from lower 
		/// to higher or opposite
		/// </summary>
		public bool Ascending { get; set; }

		#endregion

		#region Constructor

		/// <summary>
		/// Default constructor
		/// </summary>
		public CPU_Priority_Algorithm()
		{
			Processes = new List<OSASProcess>();
			TerminatedProcesses = new List<OSASProcess>();
			Ascending = true;
		}

		/// <summary>
		/// Parameterized constructor with a list of <see cref="OSASProcess"/>
		/// </summary>
		/// <param name="processes">The processes to calculate</param>
		/// <param name="ascending">Indicates if we should treat priority numbers from lower 
		/// to higher or opposite</param>
		public CPU_Priority_Algorithm(List<OSASProcess> processes, bool ascending)
		{
			Processes = processes;
			TerminatedProcesses = new List<OSASProcess>();
			Ascending = ascending;
		}

		#endregion

		#region Algorithm Simulate Methods

		public void SimulateProcesses()
		{
			if (Processes.Count <= 0)
				return;

			//Processes = Processes.OrderBy(a => a.ArrivalTime).ToList();

			var currentTime = 0;

			while (Processes.Count > 0) 
			{
				var ArrivedProcesses = Processes.Where(a => a.ArrivalTime <= currentTime).ToList();

				if (ArrivedProcesses.Count == 0)
				{
					var process = new OSASProcess();
					process.Id = -1;
					process.StartTime = currentTime;
					process.BurstTime += (Processes.FirstOrDefault().ArrivalTime - currentTime);
					process.FinishTime = process.StartTime + process.BurstTime;
					process.RemainingTime = 0;
					currentTime = process.FinishTime;
					TerminatedProcesses.Add(process);
					continue;
				}

				// Order Arrived processes by priority
				ArrivedProcesses = Ascending ? ArrivedProcesses.OrderBy(a => a.Priority).ToList() :
												ArrivedProcesses.OrderByDescending(a => a.Priority).ToList();

				var p = ArrivedProcesses.FirstOrDefault();

				p.StartTime = currentTime;

				currentTime += p.BurstTime;

				p.FinishTime = currentTime;

				p.RemainingTime = 0;

				p.WaitTime = p.StartTime - p.ArrivalTime;

				p.TurnAroundTime = p.FinishTime - p.ArrivalTime;

				Processes.Remove(p);
				TerminatedProcesses.Add(p);
			}
			
		}

		#endregion
	}
}
