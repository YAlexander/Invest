namespace Abstractions.Entities
{
	public interface IValuedPaper : IEntity
	{
		string Code { get; }
		string? Series { get; set; }
		int Number { get; set; }
		string? Issuer { get; set; }
	}
}
