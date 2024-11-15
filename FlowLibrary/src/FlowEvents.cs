using FlowLibrary.Contracts;

namespace FlowLibrary
{
    /// <summary>
    /// Represents a class that handles the raising of events to their respective handlers.
    /// </summary>
    public sealed class FlowEvents : IFlowEvents
    {
        private readonly IServiceProvider _serviceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="FlowEvents"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider used to resolve event handlers.</param>
        public FlowEvents(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        /// <summary>
        /// Raises an event asynchronously to all registered event handlers.
        /// </summary>
        /// <typeparam name="TEvent">The type of the event.</typeparam>
        /// <param name="event">The event to raise.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public async Task RaiseAsync<TEvent>(TEvent @event) where TEvent : IEvent
        {
            IEnumerable<IEventHandler<TEvent>?> eventHandlers = (IEnumerable<IEventHandler<TEvent>?>)_serviceProvider.GetServices(typeof(IEventHandler<TEvent>));
            List<Task> tasks = new List<Task>();
            foreach (IEventHandler<TEvent>? eventHandler in eventHandlers)
            {
                if (eventHandler is not null)
                {
                    tasks.Add(eventHandler.OnAsync(@event));
                }
            }
            await Task.WhenAll(tasks);
        }
    }
}
