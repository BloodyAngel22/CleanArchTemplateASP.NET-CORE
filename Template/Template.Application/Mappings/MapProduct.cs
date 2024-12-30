using AutoMapper;
using Template.Application.DTOs;
using Template.Core.Entities;

namespace Template.Application.Mappings
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