
namespace FlowLibrary.Contracts
{
    /// <summary>
    /// Represents a handler for events of type <typeparamref name="IEvent"/>.
    /// </summary>
    /// <typeparam name="IEvent">The type of event to handle.</typeparam>
    public interface IEventHandler<IEvent>
    {
        /// <summary>
        /// Handles the specified event asynchronously.
        /// </summary>
        /// <param name="event">The event to handle.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task OnAsync(IEvent @event);
    }
}
