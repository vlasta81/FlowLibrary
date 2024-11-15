using FlowLibrary.Builders;

namespace FlowLibrary.Contracts
{
    /// <summary>
    /// Interface for creating flow builders.
    /// </summary>
    public interface IFlowFactory
    {
        /// <summary>
        /// Creates a flow builder for the specified request and response types.
        /// </summary>
        /// <typeparam name="TRequest">The type of the request.</typeparam>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <returns>A flow builder for the specified request and response types.</returns>
        FlowBuilder<TRequest, TResponse> CreateFor<TRequest, TResponse>();
    }
}
