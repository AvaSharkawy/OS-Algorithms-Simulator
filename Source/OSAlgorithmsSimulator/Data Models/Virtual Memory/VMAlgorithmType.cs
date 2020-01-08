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
		FIFO = 1,

		/// <summary>
		/// Least Recently Used
		/// </summary>
		LRU = 2,

		/// <summary>
		/// Optimal page replacement
		/// </summary>
		Optimal = 3,

		/// <summary>
		/// Most Frequently Used
		/// </summary>
		MFU = 4,

		/// <summary>
		/// Second chance page replacement algorithm
		/// </summary>
		SecondChance = 5,
	}
}
