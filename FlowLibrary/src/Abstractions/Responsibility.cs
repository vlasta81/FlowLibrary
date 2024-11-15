
namespace FlowLibrary.Abstractions
{
    /// <summary>
    /// Represents an abstract base class for handling a request and producing a response.
    /// Implements the Chain of Responsibility pattern.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request.</typeparam>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    public abstract class Responsibility<TRequest, TResponse>
    {
        private Responsibility<TRequest, TResponse>? _next;

        /// <summary>
        /// Sets the next handler in the chain of responsibility.
        /// </summary>
        /// <param name="next">The next handler.</param>
        internal void SetNext(Responsibility<TRequest, TResponse> next)
        {
            _next = next;
        }

        /// <summary>
        /// Handles the request asynchronously. If the current handler cannot handle the request,
        /// it delegates to the next handler in the chain.
        /// </summary>
        /// <param name="request">The request to handle.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response.</returns>
        public virtual async Task<TResponse?> HandleAsync(TRequest request)
        {
            if (_next is not null)
            {
                return await _next.HandleAsync(request);
            }
            return default!;
        }
    }
}
