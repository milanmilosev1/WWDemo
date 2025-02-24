using WWDemo.Application.Products.Queries.GetProductBySerialNumber;

namespace WWDemo.Api.Requests
{
	public class AddProductRequest
	{
		public string? SerialNumber { get; set; }
		public string? Name { get; set; }
		public string? Price { get; set; }
		public string? Category { get; set; }
	}
}
