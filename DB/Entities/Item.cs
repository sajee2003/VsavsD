using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Item
    {

        [Key]
        public Guid ItemId { get; set; }
        public string Name { get; set; }
        public string description { get; set; }
        

       [ForeignKey(nameof(item_Category))] 
        public Guid ItemCategoryId { get; set; }
        public Item_Category item_Category { get; set; }



        public ICollection<Asset_Item> Asset_Items { get; set; }

        public ICollection<Item_Price> Item_Prices { get; set; }


        public ICollection<Package_Item> Package_Items { get; set; }

        public ICollection<Booking_Package_Item> Booking_Package_Items { get; set; }
    }
}
