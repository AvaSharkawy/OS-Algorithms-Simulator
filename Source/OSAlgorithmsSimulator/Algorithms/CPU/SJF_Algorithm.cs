using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSAlgorithmsSimulator
{
	/// <summary>
	/// A class to represent CPU Shortest Job First algorithm
	/// </summary>
	public class SJF_Algorithm
	{
		#region Public Properties

		public List<OSASProcess> Processes { get; set; }

		public List<OSASProcess> TerminatedProcesses { get; set; }

		public bool Preemptive { get; set; }

		#endregion

		#region Constructor

		/// <summary>
		/// Default constructor
		/// </summary>
		public SJF_Algorithm()
		{
			Processes = new List<OSASProcess>();
			TerminatedProcesses = new List<OSASProcess>();
			Preemptive = false;
		}

		/// <summary>
		/// Parameterized constructor with a list of <see cref="OSASProcess"/>
		/// </summary>
		/// <param name="processes">The processes to calculate</param>
		/// <param name="preemitive">Indicates if we should use preemptive algorithm</param>
		public SJF_Algorithm(List<OSASProcess> processes,bool preemptive)
		{
			Processes = processes;
			TerminatedProcesses = new List<OSASProcess>();
			Preemptive = preemptive;
		}

		#endregion

		public void CalculateProcesses()
		{
			if (Preemptive)
				CalculatePreemptive();
			else
				CalculateNonPreemptive();
		}

		public void CalculateNonPreemptive()
		{
			List<OSASProcess> ArrivedProcess = new List<OSASProcess>();

			Processes = Processes.OrderBy(a => a.ArrivalTime).ToList();

			var currentTime = 0;
			while(Processes.Count > 0)
			{
				ArrivedProcess = Processes.Where(a => a.ArrivalTime <= currentTime).ToList();

				if(ArrivedProcess.Count == 0)
				{
					var process = new OSASProcess();
					process.Id = -1;
					process.StartTime = currentTime;
					process.BurstTime += (Processes.FirstOrDefault().ArrivalTime - currentTime);
					process.FinishTime = process.StartTime + process.BurstTime;
					process.RemainingTime = 0;
					currentTime = process.FinishTime;
					TerminatedProcesses.Add(process);
				}

				ArrivedProcess = ArrivedProcess.OrderBy(a => a.BurstTime).ToList();

				foreach(var p in ArrivedProcess)
				{
					p.StartTime = currentTime;

					currentTime += p.BurstTime;

					p.FinishTime = currentTime;

					p.RemainingTime = 0;

					p.WaitTime = p.StartTime - p.ArrivalTime;

					p.TurnAroundTime = p.FinishTime - p.ArrivalTime;

					Processes.Remove(Processes.FirstOrDefault(a => a.Id.Equals(p.Id)));
					TerminatedProcesses.Add(p);
				}
			}
		}

		public void CalculatePreemptive()
		{
			List<OSASProcess> ArrivedProcess = new List<OSASProcess>();

			Processes = Processes.OrderBy(a => a.ArrivalTime).ToList();

			var currentTime = 0;

			while(Processes.Count > 0)
			{
				point:
				ArrivedProcess = Processes.Where(a => a.ArrivalTime <= currentTime).ToList();

				if (ArrivedProcess.Count == 0)
				{
					var process = new OSASProcess();
					process.Id = -1;
					process.StartTime = currentTime;
					process.BurstTime += (Processes.FirstOrDefault().ArrivalTime - currentTime);
					process.FinishTime = process.StartTime + process.BurstTime;
					process.RemainingTime = 0;
					currentTime = process.FinishTime;

					TerminatedProcesses.Add(process);
				}

				ArrivedProcess = ArrivedProcess.OrderBy(a => a.RemainingTime).ToList();

				foreach(var p in ArrivedProcess)
				{
					p.StartTime = currentTime;

					while (p.RemainingTime > 0)
					{
						currentTime++;
						p.RemainingTime--;

						var minTime = MinimumTime(Processes, p, currentTime);
						if (minTime.HasValue)
						{
							if(p.RemainingTime > minTime.Value)
							{
								var process = new OSASProcess(p)
								{
									FinishTime = currentTime,
									WaitTime = p.StartTime - LastFinishOrArrival(TerminatedProcesses, p)
								};

								TerminatedProcesses.Add(process);
								goto point;
							}
						}
					}
					p.FinishTime = currentTime;
					p.WaitTime = p.StartTime - LastFinishOrArrival(TerminatedProcesses, p);
					p.TurnAroundTime = p.FinishTime - p.ArrivalTime;
					TerminatedProcesses.Add(p);

					if(p.RemainingTime <=0)
					{
						Processes.Remove(p);
						break;
					}
				}

			}
		}


		private int? MinimumTime(List<OSASProcess> processes,OSASProcess process,int currentTime)
		{
			var proc = processes.Where(b => b.Id != process.Id)
							.Where(a => a.ArrivalTime <= currentTime).ToList();

			return (proc.Count > 0) ? (int?)proc.Min(a => a.RemainingTime) : null;
		}

		private int LastFinishOrArrival(List<OSASProcess> processes, OSASProcess process)
		{
			var pro = processes.Where(a => a.Id.Equals(process.Id)).ToList();

			if (pro.Count > 0)
				return pro.OrderBy(a => a.FinishTime).LastOrDefault().FinishTime;
			else
				return process.ArrivalTime;
		}
	}
}
