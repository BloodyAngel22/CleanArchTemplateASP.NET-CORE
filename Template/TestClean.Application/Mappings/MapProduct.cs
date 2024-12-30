using AutoMapper;
using TestClean.Core.Models;

namespace TestClean.Application.Mappings
{
    public class MapProduct: Profile
    {
		public MapProduct()
		{
			CreateMap<Product, ProductDTO>();
			CreateMap<ProductDTO, Product>();
		}
    }
}