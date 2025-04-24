using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DB;

namespace EventBookingManagementSystem_Backend.Repositories.Interfaces
{
    public interface IItemCategoryRepository 


    {
         Task<Item_Category> GetByIdAsync(Guid id);
        Task<Item_Category> AddAsync(Item_Category itemCategory);
    }
}
