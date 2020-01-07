namespace OSAlgorithmsSimulator
{
	/// <summary>
	/// A class to represent our process that we will work on
	/// </summary>
	public class OSASProcess : OSASProcessBase
	{
		#region Public Properties

		/// <summary>
		/// The Id of this process
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// The priority level of this process
		/// </summary>
		public int Priority { get; set; }

		/// <summary>
		/// The start time of this process
		/// </summary>
		public int StartTime { get; set; }

		/// <summary>
		/// The remaining time of this process
		/// </summary>
		public int RemainingTime { get; set; }

		/// <summary>
		/// The finish time of this process
		/// </summary>
		public int FinishTime { get; set; }

		/// <summary>
		/// The time estimated before last start time
		/// </summary>
		public int WaitTime { get; set; }

		/// <summary>
		/// The estimated time from arrival time to finish
		/// </summary>
		public int TurnAroundTime { get; set; }

		/// <summary>
		/// Indicates if this process currently working
		/// </summary>
		public bool IsWorking { get; set; }

		#endregion

		#region Constructor

		/// <summary>
		/// Default constructor
		/// </summary>
		public OSASProcess()
		{

		}

		/// <summary>
		/// Parameterized constructor with process to clone
		/// </summary>
		/// <param name="process">The process to close</param>
		public OSASProcess(OSASProcess process)
		{
			Id = process.Id;
			Name = process.Name;
			ArrivalTime = process.ArrivalTime;
			StartTime = process.StartTime;
			FinishTime = process.FinishTime;
			RemainingTime = process.RemainingTime;
		} 

		#endregion
	}
}
