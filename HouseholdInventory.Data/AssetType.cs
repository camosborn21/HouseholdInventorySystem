using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace HouseholdInventory.Data
{
	[Table("tblAssetTypes")]
	public class AssetType
	{
		[Key]
		[Index(IsUnique = true)]
		public int TypeCode { get; set; }
		public string TypeName { get; set; }
		public virtual AssetCategory Category { get; set; }
		public virtual ICollection<Asset> TypedAssets { get; set; }
	}
}
