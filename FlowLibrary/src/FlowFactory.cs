using FlowLibrary.Builders;
using FlowLibrary.Contracts;

namespace FlowLibrary
{
    /// <summary>
    /// Factory class for creating instances of <see cref="FlowBuilder{TRequest, TResponse}"/>.
    /// </summary>
    public sealed class FlowFactory : IFlowFactory
    {
        private readonly IServiceProvider _serviceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="FlowFactory"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider to be used for dependency injection.</param>
        public FlowFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        /// <summary>
        /// Creates a new instance of <see cref="FlowBuilder{TRequest, TResponse}"/>.
        /// </summary>
        /// <typeparam name="TRequest">The type of the request.</typeparam>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <returns>A new instance of <see cref="FlowBuilder{TRequest, TResponse}"/>.</returns>
        public FlowBuilder<TRequest, TResponse> CreateFor<TRequest, TResponse>()
        {
            return new FlowBuilder<TRequest, TResponse>(_serviceProvider);
        }
    }
}
