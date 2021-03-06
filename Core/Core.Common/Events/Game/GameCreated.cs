using System;
using AFT.RegoV2.Core.Common.Interfaces;

namespace AFT.RegoV2.Core.Common.Events.Game
{
    public class GameCreated : DomainEventBase
    {
        public Guid Id { get; set; }
        public Guid GameProviderId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public GameCreated()
        {
        }
    }
}
