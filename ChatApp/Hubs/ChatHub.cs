﻿using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(string userId, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", userId, message);
        }

        public override Task OnConnectedAsync()
        {
            Clients.All.SendAsync("ReceiveMessage", "system", $"{Context.User} joined the conversation");
            return base.OnConnectedAsync();
        }
    }
}
