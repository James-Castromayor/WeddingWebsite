namespace WeddingWebsite.Models
{
    public class RsvpModel
    {
        public bool IsAttending { get; set; }
        public int GuestCount { get; set; } = 1;
        public string? DietaryRestrictions { get; set; }
        public string? SpecialRequests { get; set; }
    }
}
