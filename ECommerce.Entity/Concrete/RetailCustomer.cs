namespace ECommerce.Entity.Concrete;

public class RetailCustomer:User
{
	public string FirstName { get; set; }
	public string Lastname { get; set; }
	public DateTime Age { get; set; }
}