using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace HouseholdInventory.Data
{
	public class InventoryContext : DbContext
	{
		public InventoryContext() : base("InventoryConnectionString")
		{ }

		public DbSet<Asset> Assets { get; set; }
		public DbSet<Owner> Owners { get; set; }
		public DbSet<AssetCategory> Categories { get; set; }
		public DbSet<AssetType> Types { get; set; }
		public DbSet<LifeCyclePhase> LifeCyclePhases { get; set; }
		public DbSet<AssetEvent> AssetEvents { get; set;}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Owner>()
				.HasMany(_ => _.OwnedAssets)
				.WithOptional(_ => _.Owner);
			modelBuilder.Entity<AssetCategory>()
				.HasMany(_ => _.AssetTypes)
				.WithOptional(_ => _.Category);
			modelBuilder.Entity<AssetType>()
				.HasMany(_ => _.TypedAssets)
				.WithOptional(_ => _.Type);
			modelBuilder.Entity<LifeCyclePhase>()
				.HasMany(_ => _.LifeCycleEvents)
				.WithOptional(_ => _.LifeCyclePhaseCode);
			modelBuilder.Entity<Asset>()
				.HasMany(_ => _.AssetEvents)
				.WithOptional(_ => _.Asset);
		}
	}
}
