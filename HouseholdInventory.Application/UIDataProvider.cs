using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseholdInventory.Data;
namespace HouseholdInventory.Application
{
    public class UIDataProvider : IUIDataProvider
    {
        private InventoryContext _inventoryContext = new InventoryContext();
        public Asset GetAsset(int assetID)
        {
            return _inventoryContext.Assets.Single(c => c.ID == assetID);
        }

        public ICollection<Asset> GetAssets()
        {
            return _inventoryContext.Assets.ToList();
        }

        public Owner GetOwner(int ownerID)
        {
            return _inventoryContext.Owners.Single(c => c.ID == ownerID);
        }

        public ICollection<Owner> GetOwners()
        {
            return _inventoryContext.Owners.ToList();
        }
    }
}
