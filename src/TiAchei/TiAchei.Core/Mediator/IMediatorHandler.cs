using FluentValidation.Results;
using TiAchei.Core.Messages;

namespace TiAchei.Core.Mediator
{
    public interface IMediatorHandler
    {
        Task<RequestResponse<TResponse>> SendCommandAsync<TCommand, TResponse>(TCommand command) where TCommand : Command<TResponse>;
        Task<RequestResponse<TResponse>> SendQueryAsync<TQuery, TResponse>(TQuery query) where TQuery : Query<TResponse>;
        Task PublisherEvent<TEvent>(TEvent tevent) where TEvent : Event;
    }
}
