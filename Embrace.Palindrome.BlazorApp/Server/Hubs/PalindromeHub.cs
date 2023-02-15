using Embrace.Palindrome.BlazorApp.Data;
using Microsoft.AspNetCore.SignalR;

namespace Embrace.Palindrome.BlazorApp.Server.Hubs
{
    public class PalindromeHub : Hub
    {
        public async Task GetPalindrome(int min, int max)
        {
            PalindromeService service = new PalindromeService();
            await Clients.All.SendAsync("ReceivePalindrome", service.Generate(min, max));
        }

    }
}
