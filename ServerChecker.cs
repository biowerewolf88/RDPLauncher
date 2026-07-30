using System;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace RDPLauncher
{
    public static class ServerChecker
    {
        public static async Task<bool> CheckPortAsync(string host, int port, int timeout = 3000)
        {
            try
            {
                using TcpClient client = new();

                var connectTask = client.ConnectAsync(host, port);

                var completedTask = await Task.WhenAny(connectTask, Task.Delay(timeout));

                return completedTask == connectTask && client.Connected;
            }
            catch
            {
                return false;
            }
        }
    }
}