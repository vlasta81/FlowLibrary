
namespace FlowLibrary.Contracts
{
    /// <summary>
    /// Represents a command that can be executed asynchronously with a request and response.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request parameter.</typeparam>
    /// <typeparam name="TResponse">The type of the response result.</typeparam>
    public interface ICommand<TRequest, TResponse>
    {
        /// <summary>
        /// Executes the command asynchronously with the specified request.
        /// </summary>
        /// <param name="request">The request parameter.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response.</returns>
        Task<TResponse> ExecuteAsync(TRequest request);
    }
}
