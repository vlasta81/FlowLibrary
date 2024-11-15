#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Contracts](FlowLibrary.Contracts.md 'FlowLibrary.Contracts').[IFlowEvents](IFlowEvents.md 'FlowLibrary.Contracts.IFlowEvents')

## IFlowEvents.RaiseAsync<TEvent>(TEvent) Method

Raises an event asynchronously.

```csharp
System.Threading.Tasks.Task RaiseAsync<TEvent>(TEvent @event)
    where TEvent : FlowLibrary.Contracts.IEvent;
```
#### Type parameters

<a name='FlowLibrary.Contracts.IFlowEvents.RaiseAsync_TEvent_(TEvent).TEvent'></a>

`TEvent`

The type of the event.
#### Parameters

<a name='FlowLibrary.Contracts.IFlowEvents.RaiseAsync_TEvent_(TEvent).event'></a>

`event` [TEvent](IFlowEvents.RaiseAsync.hHbmey0jXzcYmR7nmZ7ARg.md#FlowLibrary.Contracts.IFlowEvents.RaiseAsync_TEvent_(TEvent).TEvent 'FlowLibrary.Contracts.IFlowEvents.RaiseAsync<TEvent>(TEvent).TEvent')

The event to raise.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task that represents the asynchronous operation.