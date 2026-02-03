using MongoDB.Bson;
using System;

namespace EXE201.Models
{
    public class Product
    {
        public ObjectId Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int DiscountPrice { get; set; }
        public int Quantity { get; set; }
        public string Material { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public string MainImage { get; set; }
        public int Views { get; set; }
        public int Sold { get; set; }
        public bool Status { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsNew { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

