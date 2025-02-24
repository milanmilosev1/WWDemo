using MediatR;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using WWDemo.Application.DTOs;
using WWDemo.Data.Products;

namespace WWDemo.Application.Products.Queries.GetProductBySerialNumber
{
    public class GetProductsBySerialNumberHandler : IRequestHandler<GetProductBySerialNumberQuery, ProductRepresentation>
    {
        private readonly IProductRepository _productRepository;

        public GetProductsBySerialNumberHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductRepresentation> Handle(GetProductBySerialNumberQuery request, CancellationToken cancellationToken)
        {
            var serialNumber = request.SerialNumber;
            var product = await _productRepository.GetProductBySerialNumber(serialNumber!);
            var result = new ProductRepresentation { Category = product?.Category, Name = product?.Name, Price = product?.Price, SerialNumber = product?.SerialNumber };

            return result;
        }
    }
}
