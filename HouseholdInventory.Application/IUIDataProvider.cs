using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseholdInventory.Data;

namespace HouseholdInventory.Application
{
    public interface IUIDataProvider
    {
        ICollection<Asset> GetAssets();
        ICollection<Owner> GetOwners();
        Owner GetOwner(int ownerID);
        Asset GetAsset(int assetID);

    }
}
