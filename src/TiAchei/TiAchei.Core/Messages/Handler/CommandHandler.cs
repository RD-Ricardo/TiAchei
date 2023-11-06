using FluentValidation.Results;
using MediatR;
using TiAchei.Core.Data;

namespace TiAchei.Core.Messages.Handler
{
    public abstract class CommandHandler<TCommand, TReponse> : IRequestHandler<TCommand, RequestResponse<TReponse>> where TCommand : Command<TReponse>
    {
        public ValidationResult ValidationResult { get; set; }

        protected CommandHandler()
        {
            ValidationResult = new ValidationResult();
        }

        protected void AdicionarErro(string mensagem)
        {
            ValidationResult.Errors.Add(new ValidationFailure(string.Empty, mensagem));
        }

        protected async Task<ValidationResult> PersistirDaodos(IUnitOfWork uow)
        { 
            if (!await uow.Commit()) AdicionarErro("Houve um erro ao persistir os dados");

            return ValidationResult;
        }

        public abstract Task<RequestResponse<TReponse>> Handle(TCommand request, CancellationToken cancellationToken);
    }
}
