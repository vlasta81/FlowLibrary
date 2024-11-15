
namespace FlowLibrary.Contracts
{
    /// <summary>
    /// Interface for handling flow events.
    /// </summary>
    public interface IFlowEvents
    {
        /// <summary>
        /// Raises an event asynchronously.
        /// </summary>
        /// <typeparam name="TEvent">The type of the event.</typeparam>
        /// <param name="event">The event to raise.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task RaiseAsync<TEvent>(TEvent @event) where TEvent : IEvent;
    }
}
