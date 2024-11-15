using FlowLibrary.Abstractions;
using FlowLibrary.Contracts;

namespace FlowLibrary.Builders
{
    /// <summary>
    /// A builder class for constructing a flow with a command, chain of responsibilities, middlewares, and a response strategy.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request.</typeparam>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    public sealed class FlowBuilder<TRequest, TResponse>
    {
        private List<IMiddleware<TRequest, TResponse>> _middlewares;
        private IResponseStrategy<TResponse>? _strategy;
        private ICommand<TRequest, TResponse>? _command;
        private Responsibility<TRequest, TResponse>? _chain;
        private readonly IServiceProvider _serviceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="FlowBuilder{TRequest, TResponse}"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider for dependency injection.</param>
        public FlowBuilder(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _middlewares = new List<IMiddleware<TRequest, TResponse>>();
        }

        /// <summary>
        /// Adds a command to the flow.
        /// </summary>
        /// <returns>A <see cref="CommandBuilder{TRequest, TResponse}"/> to configure the command.</returns>
        /// <exception cref="InvalidOperationException">Thrown if a command has already been added to the flow.</exception>
        public CommandBuilder<TRequest, TResponse> AddCommand()
        {
            if (_command is null)
            {
                return new CommandBuilder<TRequest, TResponse>(_serviceProvider, (cmd) => { _command = cmd; });
            }
            throw new InvalidOperationException("A command has already been added to the flow.");
        }

        /// <summary>
        /// Adds a chain of responsibilities to the flow.
        /// </summary>
        /// <returns>A <see cref="ResponsibilityBuilder{TRequest, TResponse}"/> to configure the chain of responsibilities.</returns>
        public ResponsibilityBuilder<TRequest, TResponse> AddChainOfResponsibilities()
        {
            return new ResponsibilityBuilder<TRequest, TResponse>(_serviceProvider, (chain) => { _chain = chain; });
        }

        /// <summary>
        /// Adds middlewares to the flow.
        /// </summary>
        /// <returns>A <see cref="MiddlewaresBuilder{TRequest, TResponse}"/> to configure the middlewares.</returns>
        public MiddlewaresBuilder<TRequest, TResponse> AddMiddlewares()
        {
            return new MiddlewaresBuilder<TRequest, TResponse>(_serviceProvider, (middleware) => { _middlewares.Add(middleware); });
        }

        /// <summary>
        /// Sets the response strategy for the flow.
        /// </summary>
        /// <typeparam name="TStrategy">The type of the response strategy.</typeparam>
        /// <returns>The current <see cref="FlowBuilder{TRequest, TResponse}"/> instance.</returns>
        public FlowBuilder<TRequest, TResponse> SetResponseStrategy<TStrategy>() where TStrategy : IResponseStrategy<TResponse>
        {
            TStrategy strategy = (TStrategy)_serviceProvider.GetRequiredService(typeof(TStrategy));
            _strategy = strategy;
            return this;
        }

        /// <summary>
        /// Builds the flow processor with the configured components.
        /// </summary>
        /// <returns>A <see cref="FlowProcessor{TRequest, TResponse}"/> instance.</returns>
        /// <exception cref="ArgumentNullException">Thrown if the command is not set.</exception>
        public FlowProcessor<TRequest, TResponse> Build()
        {
            ArgumentNullException.ThrowIfNull(_command);
            return new FlowProcessor<TRequest, TResponse>(_command, _chain, _strategy, _middlewares);
        }
    }
}
