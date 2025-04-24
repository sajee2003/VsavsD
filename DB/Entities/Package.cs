﻿namespace EventBookingManagementSystem_Backend.DB.Entities
{
    public class Package
    {
        public Guid PackageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal price { get; set; }


        public ICollection<Package_Item> Package_Items { get; set; }
    }
}
