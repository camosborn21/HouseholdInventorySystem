using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HouseholdInventory.Data
{
	[Table("tblOwners")]
	public class Owner
	{
		[Key]
		[Index(IsUnique = true)]
		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public virtual ICollection<Asset> OwnedAssets { get; set; }
	}
}
