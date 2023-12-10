namespace BookingApp.Core.Models
{
    public class BookingRequest
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime DateOnly { get; set; }
    }
}