using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace HouseholdInventory.Data
{
	[Table("tblLifeCyclePhases")]
	public class LifeCyclePhase
	{
		[Key]
		[Index(IsUnique =true)]
		public int LifeCycleCode { get; set; }
		public string PhaseName { get; set; }
		public string Description { get; set; }
		public virtual ICollection<AssetEvent> LifeCycleEvents { get; set; }
	}
}
