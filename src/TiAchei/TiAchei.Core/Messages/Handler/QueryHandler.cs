using FluentValidation.Results;
using MediatR;

namespace TiAchei.Core.Messages.Handler
{
    public abstract class QueryHandler<TQuery, TReponse> : IRequestHandler<TQuery, RequestResponse<TReponse>> where TQuery : Query<TReponse>
    {
        public ValidationResult ValidationResult { get; set; }

        protected QueryHandler()
        {
            ValidationResult = new ValidationResult();
        }

        protected void AdicionarErro(string mensagem)
        {
            ValidationResult.Errors.Add(new ValidationFailure(string.Empty, mensagem));
        }

        abstract public Task<RequestResponse<TReponse>> Handle(TQuery request, CancellationToken cancellationToken);
    }
}
