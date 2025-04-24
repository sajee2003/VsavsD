using System.ComponentModel.DataAnnotations;

namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Package_Item
    {
        [Key]
        public Guid PackageItemId { get; set; }
        
        public Guid PackageId { get; set; }
        public Package package { get; set; }

        public Guid ItemId { get; set; }
        public Guid item { get; set; }

        public Guid AssetId { get; set; }
        public Asset asset { get; set; }
            
    }
}
