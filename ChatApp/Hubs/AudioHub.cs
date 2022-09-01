using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Hubs
{
    public class AudioHub: Hub
    {
        public async Task SendAudioMessage(string user, byte[] audio)
        {

            await Clients.All.SendAsync("ReceiveAudioMessage", user, audio);
        }
    }
}
