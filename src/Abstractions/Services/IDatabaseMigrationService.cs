using UaBid.Backend.Abstractions.Entities;

namespace UaBid.Backend.Abstractions.Services
{
	public interface IDatabaseMigrationService
	{
		void MigrateDatabase (IDatabaseConfiguration configuration);
	}
}
