using FlowLibrary.Abstractions;
using FlowLibrary.Contracts;

namespace FlowLibrary.Builders
{
    /// <summary>
    /// A builder class for constructing command objects with optional decorators.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request object.</typeparam>
    /// <typeparam name="TResponse">The type of the response object.</typeparam>
    public sealed class CommandBuilder<TRequest, TResponse>
    {
        private readonly IServiceProvider _serviceProvider;
        private Action<ICommand<TRequest, TResponse>> _addCommand;
        private ICommand<TRequest, TResponse>? _command;
        private CommandDecorator<TRequest, TResponse>? _tempDecorated;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBuilder{TRequest, TResponse}"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider for resolving dependencies.</param>
        /// <param name="addCommand">The action to add the constructed command.</param>
        public CommandBuilder(IServiceProvider serviceProvider, Action<ICommand<TRequest, TResponse>> addCommand)
        {
            _serviceProvider = serviceProvider;
            _addCommand = addCommand;
        }

        /// <summary>
        /// Sets the command to be built.
        /// </summary>
        /// <typeparam name="TCommand">The type of the command to set.</typeparam>
        /// <returns>The current instance of <see cref="CommandBuilder{TRequest, TResponse}"/>.</returns>
        public CommandBuilder<TRequest, TResponse> SetCommand<TCommand>() where TCommand : ICommand<TRequest, TResponse>
        {
            _command = (TCommand)_serviceProvider.GetRequiredService(typeof(TCommand));
            return this;
        }

        /// <summary>
        /// Adds a decorator to the command.
        /// </summary>
        /// <typeparam name="TDecorator">The type of the decorator to add.</typeparam>
        /// <returns>The current instance of <see cref="CommandBuilder{TRequest, TResponse}"/>.</returns>
        public CommandBuilder<TRequest, TResponse> WithDecorator<TDecorator>() where TDecorator : CommandDecorator<TRequest, TResponse>
        {
            ArgumentNullException.ThrowIfNull(_command);
            TDecorator decorator = (TDecorator)_serviceProvider.GetRequiredService(typeof(TDecorator));
            if (_tempDecorated is null)
            {
                decorator.SetNext(_command);
            }
            else
            {
                decorator.SetNext(_tempDecorated);
            }
            _tempDecorated = decorator;
            return this;
        }

        /// <summary>
        /// Builds the command and adds it using the provided action.
        /// </summary>
        public void Build()
        {
            ArgumentNullException.ThrowIfNull(_command);
            if (_tempDecorated is null)
            {
                _addCommand(_command);
            }
            else
            {
                _addCommand(_tempDecorated);
            }
        }
    }
}
