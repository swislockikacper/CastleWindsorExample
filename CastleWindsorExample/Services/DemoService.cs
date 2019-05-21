using CastleWindsorExample.Interfaces;
using CastleWindsorExample.Models;

namespace CastleWindsorExample.Services
{
    public class DemoService : IDemoService
    {
        private readonly IMessageService service;

        public DemoService(IMessageService service)
        {
            this.service = service;
        }

        public Message GetMessage()
            => new Message
               {
                   Content = service.GetMessage()
               };
    }
}