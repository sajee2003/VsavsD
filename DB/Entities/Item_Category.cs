using System.ComponentModel.DataAnnotations;

namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Item_Category
    {

        [Key]
        public Guid ItemCategoryId { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
