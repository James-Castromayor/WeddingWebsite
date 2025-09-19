namespace WeddingWebsite.Models
{
    public class GuestInfo
    {
        public string Name { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public bool HasRsvped { get; set; }
        public RsvpModel? Rsvp { get; set; }
    }
}
