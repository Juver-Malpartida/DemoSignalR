using Microsoft.AspNet.SignalR;

namespace DemoSignalR
{
    public class MyHub : Hub
    {
        public void Announce(string message)
        {
            Clients.All.Announce(message);

        }
    }
}