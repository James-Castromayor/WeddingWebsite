using WeddingWebsite.Models;

namespace WeddingWebsite.Services
{
    public class ChatService
    {
        public Task<string> GetResponseAsync(string question, string guestName)
        {
            var lowerQuestion = question.ToLower();

            if (lowerQuestion.Contains("time") || lowerQuestion.Contains("when"))
                return Task.FromResult("The ceremony starts at 6:00 PM on December 15th, 2024. Please arrive 15 minutes early! 🕕");

            if (lowerQuestion.Contains("dress") || lowerQuestion.Contains("attire"))
                return Task.FromResult("The dress code is semi-formal. Think cocktail attire - dress pants or nice dresses! 👔👗");

            if (lowerQuestion.Contains("location") || lowerQuestion.Contains("where") || lowerQuestion.Contains("venue"))
                return Task.FromResult("We're getting married at The Grand Ballroom, 123 Wedding Lane, San Francisco, CA 94102! 🏛️");

            if (lowerQuestion.Contains("food") || lowerQuestion.Contains("dinner") || lowerQuestion.Contains("menu"))
                return Task.FromResult("We'll have a delicious buffet dinner with vegetarian and gluten-free options! 🍽️");

            return Task.FromResult($"Hi {guestName}! For specific details, please contact Eurish & James. We're happy to help! 📞");
        }
    }
}