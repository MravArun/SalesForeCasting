namespace SalesForeCasting.Infrastructure.Entities;

public class Product

{
    public string OrderId { get; set; }

    public string ProductId { get; set; }

    public string Category { get; set; }

    public string Subcategory { get; set; }

    public string ProductName { get; set; }

    public decimal Sales { get; set; }

    public int Quantity { get; set; }

    public decimal Discount { get; set; }

    public decimal Profit { get; set; }

    public Order Order { get; set; }
    
}

