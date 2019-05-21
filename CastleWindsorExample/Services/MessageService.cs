using CastleWindsorExample.Interfaces;

namespace CastleWindsorExample.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
            => "Castle Windsor works!";
    }
}