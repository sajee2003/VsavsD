using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventBookingManagementSystem_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemCategoryController : ControllerBase
    {
        private readonly IItemCategoryRepository _repository;  

        public ItemCategoryController(IItemCategoryRepository repository)
        {
            _repository = repository;
        }

        // POST: api/ItemCategory
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ItemCategoryRequest dto)
        {
            if (dto == null)
            {
                return BadRequest("Invalid input.");
            }

            var newItemCategory = new Item_Category
            {
                ItemCategoryId = Guid.NewGuid(),  
                name = dto.Name,
                description = dto.Description
            };

            try
            {
                var createdItemCategory = await _repository.AddAsync(newItemCategory);
                return Ok(createdItemCategory);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
