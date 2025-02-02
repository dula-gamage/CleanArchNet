namespace Core.Entities {

	/// <summary>
	/// All common properties goes here, where all entities must have.
	/// </summary>
	public abstract class BaseEntity {
		public Guid CreatedBy { get; set; }
		public DateTime CreatedOn { get; set; }
		public Guid ModifiedBy { get; set; }
		public Guid ModifiedOn { get; set; }
	}
}
