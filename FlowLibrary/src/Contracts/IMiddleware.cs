
namespace FlowLibrary.Contracts
{
    /// <summary>
    /// Defines a middleware interface for processing requests and responses.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request object.</typeparam>
    /// <typeparam name="TResponse">The type of the response object.</typeparam>
    public interface IMiddleware<TRequest, TResponse>
    {
        /// <summary>
        /// Invokes the middleware with the specified request and the next middleware in the pipeline.
        /// </summary>
        /// <param name="request">The request object.</param>
        /// <param name="next">The next middleware function in the pipeline.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response object.</returns>
        Task<TResponse?> InvokeAsync(TRequest request, Func<TRequest, Task<TResponse?>> next);
    }
}
