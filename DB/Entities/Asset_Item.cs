using System.ComponentModel.DataAnnotations;

namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Asset_Item
    {
        [Key]
        public Guid AssetItemId { get; set; }
        public Guid AssetId { get; set; }
        public Asset asset { get; set; }

        public Guid ItemId { get; set; }
        public Item item { get; set; }

    }
}
