
namespace FlowLibrary.Contracts
{
    /// <summary>
    /// Defines a contract for handling a request and returning a response asynchronously.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request.</typeparam>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    public interface IResponsibility<TRequest, TResponse>
    {
        /// <summary>
        /// Handles the specified request asynchronously and returns a response.
        /// </summary>
        /// <param name="request">The request to handle.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response.</returns>
        Task<TResponse?> HandleAsync(TRequest request);
    }
}
