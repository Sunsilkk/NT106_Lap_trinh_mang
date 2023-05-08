using System;

namespace Multi_Client_Server_chat
{
    public class PrivateMessageEventArgs : EventArgs
    {
        public string Message { get; }
        public string Id { get; }
        public PrivateMessageEventArgs(string id, string message)
        {
            Message = message;
            Id = id;
        }
    }
}
