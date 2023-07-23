namespace ECommerce.Core.Entity
{
	public abstract class EntityBase
	{
		public int Id { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }
		public bool Status { get; set; } = false;
	}
}
