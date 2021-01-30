using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSignalR.Hubs
{
    public class ChatHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            var id = Context.ConnectionId;

            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }
        public async Task SendMessage(string message)
        {

            string msg = message.Trim();
            await Clients.All.SendAsync("ReceiveMessage", msg);
            //await Clients.Client("connectionid").SendAsync("ReceiveMessage", msg);
        }
    }
}
