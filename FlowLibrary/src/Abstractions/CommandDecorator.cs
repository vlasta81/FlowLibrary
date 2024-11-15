using FlowLibrary.Contracts;

namespace FlowLibrary.Abstractions
{
    /// <summary>
    /// Abstract base class for command decorators.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request.</typeparam>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    public abstract class CommandDecorator<TRequest, TResponse> : ICommand<TRequest, TResponse>
    {
        private ICommand<TRequest, TResponse>? _decorator;

        /// <summary>
        /// Sets the next decorator in the chain.
        /// </summary>
        /// <param name="decorator">The next decorator.</param>
        internal void SetNext(ICommand<TRequest, TResponse> decorator)
        {
            _decorator = decorator;
        }

        /// <summary>
        /// Executes the command asynchronously.
        /// </summary>
        /// <param name="request">The request object.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response object.</returns>
        public virtual Task<TResponse> ExecuteAsync(TRequest request)
        {
            return _decorator!.ExecuteAsync(request);
        }
    }
}
