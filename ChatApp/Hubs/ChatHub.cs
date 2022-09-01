using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Hubs
{
    public class ChatHub : Hub
    {
        //public async Task SendMessage(string userId, string message)
        //{
        //    await Clients.All.SendAsync("ReceiveMessage", userId, message);
        //}


        public async Task JoinChat(string user)
        {
            //await Clients.Group.SendMessage("", user);
            await Clients.All.SendAsync("JoinChat", user);
        }

        public async Task LeaveChat(string user)
        {
            await Clients.All.SendAsync("LeaveChat", user);
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        public async Task SendAudioMessage(string user, string message, byte[] audio, string audioPath)
        {

            await Clients.All.SendAsync("ReceiveAudioMessage", user, message, audio, audioPath);
        }
        //public override Task OnConnectedAsync()
        //{
        //    Clients.All.SendAsync("ReceiveMessage", "system", $"{Context.ConnectionId} joined the conversation");
        //    return base.OnConnectedAsync();
        //}
    }
}
