
namespace FlowLibrary.Contracts
{
    /// <summary>
    /// Defines a strategy for processing a response of type <typeparamref name="TResponse"/>.
    /// </summary>
    /// <typeparam name="TResponse">The type of the response to be processed.</typeparam>
    public interface IResponseStrategy<TResponse>
    {
        /// <summary>
        /// Applies the strategy to the given response asynchronously.
        /// </summary>
        /// <param name="response">The response to which the strategy will be applied.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the processed response.</returns>
        Task<TResponse> ApplyStrategyAsync(TResponse response);
    }
}
