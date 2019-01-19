using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using System;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            Console.WriteLine("--------------- ----------------------------" + user);
            Console.WriteLine("--------------- ----------------------------" + message);
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}