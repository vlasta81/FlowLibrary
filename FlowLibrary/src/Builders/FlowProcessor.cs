using FlowLibrary.Abstractions;
using FlowLibrary.Contracts;

namespace FlowLibrary.Builders
{
    /// <summary>
    /// The <see cref="FlowProcessor{TRequest, TResponse}"/> class is responsible for processing a request through a series of middlewares, a command, and an optional chain of responsibility and response strategy.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request.</typeparam>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    public sealed class FlowProcessor<TRequest, TResponse>
    {
        private readonly ICommand<TRequest, TResponse> _command;
        private readonly Responsibility<TRequest, TResponse>? _chain;
        private readonly IResponseStrategy<TResponse>? _strategy;
        private readonly List<IMiddleware<TRequest, TResponse>> _middlewares;

        /// <summary>
        /// Initializes a new instance of the <see cref="FlowProcessor{TRequest, TResponse}"/> class.
        /// </summary>
        /// <param name="command">The command to execute if no middleware or chain handles the request.</param>
        /// <param name="chain">The optional chain of responsibility to handle the request.</param>
        /// <param name="strategy">The optional response strategy to apply to the command's response.</param>
        /// <param name="middlewares">The list of middlewares to process the request.</param>
        public FlowProcessor(ICommand<TRequest, TResponse> command, Responsibility<TRequest, TResponse>? chain, IResponseStrategy<TResponse>? strategy, List<IMiddleware<TRequest, TResponse>> middlewares)
        {
            _command = command;
            _chain = chain;
            _strategy = strategy;
            _middlewares = middlewares;
        }

        /// <summary>
        /// Invokes the middleware at the specified index.
        /// </summary>
        /// <param name="index">The index of the middleware to invoke.</param>
        /// <param name="request">The request to process.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response from the middleware or the next middleware in the chain.</returns>
        private async Task<TResponse?> InvokeMiddleware(int index, TRequest request)
        {
            if (index < _middlewares.Count)
            {
                return await _middlewares[index].InvokeAsync(request, async (req) => await InvokeMiddleware(index + 1, req));
            }
            return default;
        }

        /// <summary>
        /// Processes the request asynchronously through the chain of responsibility, middlewares, and command.
        /// </summary>
        /// <param name="request">The request to process.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response.</returns>
        public async Task<TResponse> ProcessAsync(TRequest request)
        {
            TResponse? chainResponse = default;
            if (_chain is not null)
            {
                chainResponse = await _chain.HandleAsync(request);
            }
            if (chainResponse is not null)
            {
                return chainResponse;
            }
            TResponse? middlewaresResponse = await InvokeMiddleware(0, request);
            if (middlewaresResponse is not null)
            {
                return middlewaresResponse;
            }
            TResponse commandResponse = await _command.ExecuteAsync(request);
            if (_strategy is not null)
            {
                return await _strategy.ApplyStrategyAsync(commandResponse);
            }
            return commandResponse;
        }
    }
}
