using EventBookingManagementSystem_Backend.DB;
using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace EventBookingManagementSystem_Backend.Repositories.Implementations
{
    public class ItemRepository : IItemRepository
    {
        private readonly ApplicationDbContext _context;

        public ItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Item>> GetAllAsync()
        {
            return await _context.Items.Include(i => i.item_Category).ToListAsync();
        }

        public async Task<Item?> GetByIdAsync(Guid id)
        {
            return await _context.Items
                .Include(i => i.item_Category)
                .FirstOrDefaultAsync(i => i.ItemId == id);
        }

        public async Task<Item> AddAsync(Item item)
        {
            _context.Items.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<Item> UpdateAsync(Item item)
        {

             _context.Items.Update(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<bool> DeleteAsync(Item item)
        {
            //var item = await _context.Items.FindAsync(id);
            //if (item == null) return false;

            _context.Items.Remove(item);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
