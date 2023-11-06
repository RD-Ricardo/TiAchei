using FluentValidation.Results;
using MediatR;

namespace TiAchei.Core.Messages
{
    public abstract class Command<TReponse> : Message, IRequest<RequestResponse<TReponse>>
    {
        public DateTime Timestamp { get; private set; }
        public ValidationResult ValidationResult { get; private set; }

        public Command()
        {
            ValidationResult = new ValidationResult();
            Timestamp = DateTime.UtcNow;
        }

        public abstract bool IsValid();
    }
}
