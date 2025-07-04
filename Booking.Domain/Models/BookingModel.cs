﻿using Booking.Domain.Enums;

namespace Booking.Domain.Models;

public class BookingModel
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int ClientId { get; set; }
    public string ClientEmail {  get; set; } = string.Empty;
    //public int PaymentId { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public decimal CaluclatedPrice { get; set; }
    public DateTime CreatedAt { get; set; }
    public BookingStatusEnum Status { get; set; }
}
