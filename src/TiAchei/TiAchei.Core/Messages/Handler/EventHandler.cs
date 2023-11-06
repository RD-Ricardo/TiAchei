using MediatR;

namespace TiAchei.Core.Messages.Handler
{
    public abstract class EventHandler<TEvent> : INotificationHandler<TEvent> where TEvent : Event
    {
        public abstract Task Handle(TEvent notification, CancellationToken cancellationToken);
    }
}
