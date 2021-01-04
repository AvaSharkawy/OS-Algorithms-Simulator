namespace OSAlgorithmsSimulator
{
	/// <summary>
	/// Virtual memory algorithms types
	/// </summary>
	public enum VMAlgorithmType
	{
		/// <summary>
		/// First In First Out Algorithm
		/// </summary>
		FIFO = 0,

		/// <summary>
		/// Least Recently Used
		/// </summary>
		LRU = 1,

		/// <summary>
		/// Optimal page replacement
		/// </summary>
		Optimal = 2,

		/// <summary>
		/// Most Frequently Used
		/// </summary>
		MFU = 3,

		/// <summary>
		/// Second chance page replacement algorithm
		/// </summary>
		SecondChance = 4,

		/// <summary>
		/// Least Frequently Used
		/// </summary>
		LFU = 5,
	}
}
