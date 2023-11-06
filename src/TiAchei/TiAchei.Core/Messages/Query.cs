using FluentValidation.Results;
using MediatR;

namespace TiAchei.Core.Messages
{
    public abstract class Query<TResponse> : Message, IRequest<RequestResponse<TResponse>>
    {
        public DateTime Timestamp { get; private set; }
        public ValidationResult ValidationResult { get; private set; }

        public Query()
        {
            ValidationResult = new ValidationResult();
            Timestamp = DateTime.Now;
        }

        public abstract bool IsValid();
    }
}
