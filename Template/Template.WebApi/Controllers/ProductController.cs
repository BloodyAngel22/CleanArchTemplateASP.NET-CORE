using Microsoft.AspNetCore.Mvc;
using Template.Application.DTOs;
using Template.Application.Services;
using Template.Core.Exceptions;

namespace Template.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
		private readonly ProductService _productService;

		public ProductController(ProductService productService)
		{
			_productService = productService;
		}

		[HttpGet]
		public async Task<IActionResult> GetProducts()
		{
			try
			{
				return Ok(await _productService.GetProducts());
			}
			catch (Exception)
			{
				return StatusCode(500, "Internal Server Error");
			}
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetProduct(Guid id)
		{
			try
			{
				return Ok(await _productService.GetProduct(id));
			}
			catch (Exception)
			{
				return StatusCode(500, "Internal Server Error");
			}
		}

		[HttpPost]
		public async Task<IActionResult> CreateProduct(ProductDTO product)
		{
			try
			{
				await _productService.CreateProduct(product);
				return Ok("Product created successfully");
			}
			catch (ValidateException ex)
			{
				return BadRequest(new { Errors = ex.Errors});
			}
			catch (Exception)
			{
				return StatusCode(500, "Internal Server Error");
			}
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateProduct(Guid id, ProductDTO product)
		{
			try
			{
				await _productService.UpdateProduct(id, product);
				return Ok("Product updated successfully");
			}
			catch (ValidateException ex)
			{
				return BadRequest(new { Errors = ex.Errors });
			}
			catch (Exception)
			{
				return StatusCode(500, "Internal Server Error");
			}
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteProduct(Guid id)
		{
			try
			{
				await _productService.DeleteProduct(id);
				return Ok("Product deleted successfully");
			}
			catch (Exception)
			{
				return StatusCode(500, "Internal Server Error");
			}
		}
    }
}