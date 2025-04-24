using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DB;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;

namespace EventBookingManagementSystem_Backend.Repositories.Implementations
{
    public class ItemCategoryRepository : IItemCategoryRepository
    {

        private readonly ApplicationDbContext _context;

        public ItemCategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Item_Category> AddAsync(Item_Category itemCategory)
        {
            _context.Item_Categories.Add(itemCategory);
            await _context.SaveChangesAsync();
            return itemCategory;
        }

        public async Task<Item_Category> GetByIdAsync(Guid id)
        {
            return await _context.Item_Categories.FindAsync(id);
        }

    }
}
