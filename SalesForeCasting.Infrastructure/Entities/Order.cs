using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace SalesForeCasting.Infrastructure.Entities;

public class Order
{
    [Key]
    public long Id { get; set; }
    
    public string OrderId { get; set; }

    public DateTime ShipDate { get; set; }

    public ShipMode ShipMode { get; set; }

    public string CustomerId { get; set; }

    public string CustomerName { get; set; }

    public string Segment { get; set; }

    public string Country { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string PostalCode { get; set; }

    public string Region { get; set; }
}


public enum ShipMode
{
    StandardClass,
    FirstClass,
    SecondClass,
    SameDay
}