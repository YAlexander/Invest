namespace Abstractions.Codes
{
	/// <summary>
	/// Base interface for type codes.
	/// </summary>
	/// <typeparam name="T">Type of code property</typeparam>
	public interface ITypeCodeBase<out T>
	{
		/// <summary>
		/// Human readable description of the item
		/// </summary>
		string Description { get; }

		/// <summary>
		/// Unique item code
		/// </summary>
		T Code { get; }
	}
}