using Domain.Codes;

namespace Domain.Extensions
{
	public static class CodeExtensions
	{
		public static T Create<T> (this int val) where T : TypeCodeBase<int, T>
		{
			return TypeCodeBase<int, T>.Create(val);
		}

		public static T Create<T> (this string val) where T : TypeCodeBase<string, T>
		{
			return TypeCodeBase<string, T>.Create(val);
		}
	}
}
