using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSAlgorithmsSimulator
{
	/// <summary>
	/// A class to calculate process using FCFS algorithm
	/// </summary>
	public class CPU_FCFS_Algorithm : CPU_Algorithm_Base
	{
		#region Constructor

		/// <summary>
		/// Default constructor
		/// </summary>
		public CPU_FCFS_Algorithm()
		{
			Processes = new List<OSASProcess>();
			TerminatedProcesses = new List<OSASProcess>();
		}

		/// <summary>
		/// Parameterized constructor with list of <see cref="OSASProcess"/>
		/// </summary>
		/// <param name="processes">The processes to calculate</param>
		public CPU_FCFS_Algorithm(List<OSASProcess> processes)
		{
			Processes = processes;
			TerminatedProcesses = new List<OSASProcess>();
		}

		#endregion

		#region Algorithm Simulate Methods

		public void SimulateProcesses()
		{
			if (Processes.Count <= 0)
				return;

			// order processes by arrival time
			Processes = Processes.OrderBy(a => a.ArrivalTime).ToList();


			var currentTime = 0;

			while (Processes.Count > 0)
			{
				if (Processes[0].ArrivalTime > currentTime)
				{
					var process = new OSASProcess();

					process.Id = -1;
					process.StartTime = currentTime;
					process.BurstTime += Processes[0].ArrivalTime - currentTime;
					process.FinishTime = process.StartTime + process.BurstTime;
					process.RemainingTime = 0;
					currentTime = process.FinishTime;

					TerminatedProcesses.Add(process);
					continue;
				}

				Processes[0].StartTime = Math.Max(currentTime, Processes[0].ArrivalTime);

				Processes[0].IsWorking = true;

				currentTime = Processes[0].StartTime;

				currentTime += Processes[0].BurstTime;

				Processes[0].FinishTime = currentTime;

				Processes[0].RemainingTime = 0;

				Processes[0].IsWorking = false;

				Processes[0].WaitTime = Processes[0].StartTime - Processes[0].ArrivalTime;

				Processes[0].TurnAroundTime = Processes[0].FinishTime - Processes[0].ArrivalTime;

				TerminatedProcesses.Add(Processes[0]);
				Processes.Remove(Processes[0]);
			}

			CalculatedSuccessfully = true;
		}

		#endregion
	}
}
