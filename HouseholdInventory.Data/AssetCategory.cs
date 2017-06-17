using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace HouseholdInventory.Data
{
	[Table("tblAssetCategories")]
	public class AssetCategory
	{
		[Key]
		[Index(IsUnique =true)]
		public int CategoryCode { get; set; }
		public string CategoryName { get; set; }
		public virtual ICollection<AssetType> AssetTypes { get; set; }
	}
}
