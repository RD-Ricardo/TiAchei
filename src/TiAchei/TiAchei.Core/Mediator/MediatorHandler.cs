using FluentValidation.Results;
using MediatR;
using TiAchei.Core.Messages;

namespace TiAchei.Core.Mediator
{
    public class MediatorHandler : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public MediatorHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task<RequestResponse<TResponse>> SendCommandAsync<TCommand, TResponse>(TCommand command) where TCommand : Command<TResponse>
        {
            return _mediator.Send(command);
        }

        public Task<RequestResponse<TResponse>> SendQueryAsync<TQuery, TResponse>(TQuery query) where TQuery : Query<TResponse>
        {
           return _mediator.Send(query);
        }

        public async Task PublisherEvent<TEvent>(TEvent tevent) where TEvent : Event
        {
            await _mediator.Publish(tevent);
        }
    }
}
