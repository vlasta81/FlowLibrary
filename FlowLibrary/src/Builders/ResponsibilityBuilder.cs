using FlowLibrary.Abstractions;

namespace FlowLibrary.Builders
{
    /// <summary>
    /// A builder class for constructing a chain of responsibility pattern.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request.</typeparam>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    public sealed class ResponsibilityBuilder<TRequest, TResponse>
    {
        private Responsibility<TRequest, TResponse>? _chain;
        private Responsibility<TRequest, TResponse>? _tempChain;
        private IServiceProvider _serviceProvider;
        private readonly Action<Responsibility<TRequest, TResponse>> _addResponsibility;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsibilityBuilder{TRequest, TResponse}"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider for resolving dependencies.</param>
        /// <param name="addResponsibility">The action to add the constructed responsibility chain.</param>
        public ResponsibilityBuilder(IServiceProvider serviceProvider, Action<Responsibility<TRequest, TResponse>> addResponsibility)
        {
            _serviceProvider = serviceProvider;
            _addResponsibility = addResponsibility;
        }

        /// <summary>
        /// Sets the next responsibility in the chain.
        /// </summary>
        /// <typeparam name="TResponsibility">The type of the responsibility to add.</typeparam>
        /// <returns>The current instance of <see cref="ResponsibilityBuilder{TRequest, TResponse}"/>.</returns>
        public ResponsibilityBuilder<TRequest, TResponse> SetNext<TResponsibility>() where TResponsibility : Responsibility<TRequest, TResponse>
        {
            TResponsibility chainElement = (TResponsibility)_serviceProvider.GetRequiredService(typeof(TResponsibility));
            if (_chain == null)
            {
                _chain = chainElement;
                _tempChain = chainElement;
            }
            else
            {
                _tempChain!.SetNext(chainElement);
                _tempChain = chainElement;
            }
            return this;
        }

        /// <summary>
        /// Builds the responsibility chain and adds it using the provided action.
        /// </summary>
        public void Build()
        {
            _addResponsibility(_chain!);
        }
    }
}
