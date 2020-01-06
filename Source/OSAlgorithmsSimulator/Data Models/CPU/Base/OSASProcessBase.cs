namespace OSAlgorithmsSimulator
{
	/// <summary>
	/// A base class to represent OSAS Process
	/// </summary>
	public class OSASProcessBase
	{
		/// <summary>
		/// The name of this process
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The burst time for this process
		/// </summary>
		public int BurstTime { get; set; }

		/// <summary>
		/// The arrival time of this process
		/// </summary>
		public int ArrivalTime { get; set; }

	}
}
