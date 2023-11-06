using FluentValidation.Results;

namespace TiAchei.Core.Messages
{
    public class RequestResponse<TResponse>
    {
        public TResponse Response { get; private set; }
        public bool Success { get; private set; }
        public ValidationResult ValidationResult { get; private set; }

        public RequestResponse(bool success, ValidationResult validationResult, TResponse response = default)
        {
            Success = success;
            ValidationResult = validationResult;
            Response = response;
        }
    }
}
