﻿namespace EventBookingManagementSystem_Backend.DTOs.RequestModels
{
    public class ItemRequest
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public Guid ItemCategoryId { get; set; }
    }
}
