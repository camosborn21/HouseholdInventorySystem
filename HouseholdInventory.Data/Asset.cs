using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace HouseholdInventory.Data
{
	[Table("tblAssets")]
	public class Asset
	{
		[Key]
		[Index(IsUnique =true)]
		public int ID { get; set; }
		public string AssetName { get; set; }
		public virtual AssetType Type { get; set; }
		public string SerialNumber { get; set; }
		public virtual Owner Owner { get; set; }
		public virtual ICollection<AssetEvent> AssetEvents { get; set; }
	}
}
