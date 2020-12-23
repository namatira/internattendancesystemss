using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceSytstemWebApplication.Hubs
{
    public class NotificationHub : Hub
    {
        public async Task sendNotification(string user, string time)
        {
            var _time = DateTime.Parse(time);
            
            await Clients.All.SendAsync("ReceiveMessage", user, _time.ToString("hh:mm tt"));
        }
    }
}
