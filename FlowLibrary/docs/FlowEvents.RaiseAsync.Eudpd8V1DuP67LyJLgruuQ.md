#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary](FlowLibrary.md 'FlowLibrary').[FlowEvents](FlowEvents.md 'FlowLibrary.FlowEvents')

## FlowEvents.RaiseAsync<TEvent>(TEvent) Method

Raises an event asynchronously to all registered event handlers.

```csharp
public System.Threading.Tasks.Task RaiseAsync<TEvent>(TEvent @event)
    where TEvent : FlowLibrary.Contracts.IEvent;
```
#### Type parameters

<a name='FlowLibrary.FlowEvents.RaiseAsync_TEvent_(TEvent).TEvent'></a>

`TEvent`

The type of the event.
#### Parameters

<a name='FlowLibrary.FlowEvents.RaiseAsync_TEvent_(TEvent).event'></a>

`event` [TEvent](FlowEvents.RaiseAsync.Eudpd8V1DuP67LyJLgruuQ.md#FlowLibrary.FlowEvents.RaiseAsync_TEvent_(TEvent).TEvent 'FlowLibrary.FlowEvents.RaiseAsync<TEvent>(TEvent).TEvent')

The event to raise.

Implements [RaiseAsync&lt;TEvent&gt;(TEvent)](IFlowEvents.RaiseAsync.hHbmey0jXzcYmR7nmZ7ARg.md 'FlowLibrary.Contracts.IFlowEvents.RaiseAsync<TEvent>(TEvent)')

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task that represents the asynchronous operation.