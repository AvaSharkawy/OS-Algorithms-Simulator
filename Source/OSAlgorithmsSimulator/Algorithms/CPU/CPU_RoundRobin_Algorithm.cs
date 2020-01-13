using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSAlgorithmsSimulator
{
	/// <summary>
	/// A class to represent CPU Round Robin Algorithm
	/// </summary>
	public class CPU_RoundRobin_Algorithm : CPU_Algorithm_Base
	{
		#region Public Properties

		/// <summary>
		/// The time unit for this algorithm
		/// </summary>
		public int TimeUnit { get; set; }

		#endregion

		#region Constructor

		/// <summary>
		/// Default Constructor
		/// </summary>
		public CPU_RoundRobin_Algorithm()
		{
			Processes = new List<OSASProcess>();
			TerminatedProcesses = new List<OSASProcess>();
			TimeUnit = 0;
		}

		public CPU_RoundRobin_Algorithm(List<OSASProcess> processes, int timeUnit)
		{
			Processes = processes;
			TerminatedProcesses = new List<OSASProcess>();
			TimeUnit = timeUnit;
		}

		#endregion

		#region Algorithm Simulate Methods

		public void SimulateProcesses()
		{
			if (Processes.Count <= 0)
				return;

			// If Time unit smaller than or equal 0
			if(TimeUnit <= 0)
			{
				// Use FSFC(First Come First Served) Algorithm
				var Fcfs = new CPU_FCFS_Algorithm(Processes);

				Fcfs.SimulateProcesses();

				TerminatedProcesses = Fcfs.TerminatedProcesses;

				// and return here
				return;
			}

			var currentTime = 0;

			point:

			var PQueue = Processes.Where(a => a.ArrivalTime <= currentTime).OrderBy(a=>a.ArrivalTime).ToList();

			if (PQueue.Count == 0)
			{
				var process = new OSASProcess();
				process.Id = -1;
				process.StartTime = currentTime;
				process.BurstTime += (Processes.OrderBy(a=>a.ArrivalTime).FirstOrDefault().ArrivalTime - currentTime);
				process.FinishTime = process.StartTime + process.BurstTime;
				process.RemainingTime = 0;
				currentTime = process.FinishTime;
				TerminatedProcesses.Add(process);
				goto point;
			}

			while (PQueue.Count > 0)
			{
				var p = PQueue.FirstOrDefault();

				if (p.RemainingTime > TimeUnit)
				{
					PQueue.Remove(p);

					p.StartTime = currentTime;

					p.RemainingTime -= TimeUnit;

					currentTime += TimeUnit;

					var pro = new OSASProcess(p)
					{
						FinishTime = currentTime,
						WaitTime = p.StartTime - LastFinishOrArrival(TerminatedProcesses, p)
					};

					TerminatedProcesses.Add(pro);
					Processes.Remove(p);

					PQueue.AddRange(Processes.Where(a => a.ArrivalTime <= currentTime &&
													!PQueue.Exists(b => b.Id.Equals(a.Id)) &&
													a.Id != p.Id).OrderBy(a => a.ArrivalTime));
					
					PQueue.Add(p);
				}
				else
				{
					PQueue.Remove(p);

					p.StartTime = currentTime;

					currentTime += p.RemainingTime;

					p.RemainingTime = 0;

					p.WaitTime = p.StartTime - LastFinishOrArrival(TerminatedProcesses, p);

					p.FinishTime = currentTime;

					p.TurnAroundTime = p.FinishTime - p.ArrivalTime;

					TerminatedProcesses.Add(p);
					Processes.Remove(p);

					PQueue.AddRange(Processes.Where(a => a.ArrivalTime <= currentTime &&
													!PQueue.Exists(b => b.Id.Equals(a.Id)))
												.OrderBy(a => a.ArrivalTime));
				}

				if(PQueue.Count == 0 && Processes.Count > 0)
				{
					var process = new OSASProcess();
					process.Id = -1;
					process.StartTime = currentTime;
					process.BurstTime += (Processes.OrderBy(a => a.ArrivalTime).FirstOrDefault().ArrivalTime - currentTime);
					process.FinishTime = process.StartTime + process.BurstTime;
					process.RemainingTime = 0;
					currentTime = process.FinishTime;
					TerminatedProcesses.Add(process);
					PQueue.AddRange(Processes.Where(a => a.ArrivalTime <= currentTime &&
													!PQueue.Exists(b => b.Id.Equals(a.Id)))
												.OrderBy(a => a.ArrivalTime));
				}
			}

			Processes.Clear();

			CalculatedSuccessfully = true;
		}

		#endregion

		#region Helper Methods

		private int LastFinishOrArrival(List<OSASProcess> processes, OSASProcess process)
		{
			var pro = processes.Where(a => a.Id.Equals(process.Id)).ToList();

			if (pro.Count > 0)
				return pro.OrderBy(a => a.FinishTime).LastOrDefault().FinishTime;
			else
				return process.ArrivalTime;
		}

		#endregion
	}
}
