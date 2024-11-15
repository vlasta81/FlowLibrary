using FlowLibrary.Contracts;

namespace FlowLibrary.Builders
{
    /// <summary>
    /// A builder class for configuring and adding middlewares to the middleware pipeline.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request object.</typeparam>
    /// <typeparam name="TResponse">The type of the response object.</typeparam>
    public sealed class MiddlewaresBuilder<TRequest, TResponse>
    {
        private readonly Action<IMiddleware<TRequest, TResponse>> _addMiddleware;
        private List<IMiddleware<TRequest, TResponse>> _middlewares;
        private readonly IServiceProvider _serviceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="MiddlewaresBuilder{TRequest, TResponse}"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider for resolving middleware instances.</param>
        /// <param name="addMiddleware">The action to add a middleware to the pipeline.</param>
        public MiddlewaresBuilder(IServiceProvider serviceProvider, Action<IMiddleware<TRequest, TResponse>> addMiddleware)
        {
            _addMiddleware = addMiddleware;
            _middlewares = new List<IMiddleware<TRequest, TResponse>>();
            _serviceProvider = serviceProvider;
        }

        /// <summary>
        /// Adds a middleware of type <typeparamref name="TMiddleware"/> to the pipeline.
        /// </summary>
        /// <typeparam name="TMiddleware">The type of the middleware to add.</typeparam>
        /// <returns>The current instance of <see cref="MiddlewaresBuilder{TRequest, TResponse}"/>.</returns>
        public MiddlewaresBuilder<TRequest, TResponse> Use<TMiddleware>() where TMiddleware : IMiddleware<TRequest, TResponse?>
        {
            TMiddleware middleware = (TMiddleware)_serviceProvider.GetRequiredService(typeof(TMiddleware));
            _middlewares.Add(middleware);
            return this;
        }

        /// <summary>
        /// Builds the middleware pipeline by adding all configured middlewares.
        /// </summary>
        public void Build()
        {
            foreach (IMiddleware<TRequest, TResponse> middleware in _middlewares)
            {
                _addMiddleware(middleware);
            }
        }
    }



}
