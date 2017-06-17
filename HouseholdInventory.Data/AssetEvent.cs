using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace HouseholdInventory.Data
{
	[Table("tblAssetEvents")]
	public class AssetEvent
	{
		[Key]
		[Index(IsUnique = true)]
		public int EventID { get; set; }
		public virtual Asset Asset { get; set; }
		public virtual LifeCyclePhase LifeCyclePhaseCode { get; set; }
		public DateTime EventDate { get; set; }
		public string Notes { get; set; }
	}
}
