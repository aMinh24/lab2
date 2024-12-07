using Microsoft.AspNetCore.SignalR;

namespace Lab2.Hub
{
    public class DiscussionHub : Microsoft.AspNetCore.SignalR.Hub
    {
        public async Task SendComment(int discussionId, string userName, string userAvatar, string content)
        {
            Console.WriteLine("\n---SendComment---\n");
            await Clients.Others.SendAsync("ReceiveComment", discussionId, userName, userAvatar, content); // Gửi đến tất cả clients
        }
    }
}
