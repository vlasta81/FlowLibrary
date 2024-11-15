#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Contracts](FlowLibrary.Contracts.md 'FlowLibrary.Contracts').[IEventHandler&lt;IEvent&gt;](IEventHandler_IEvent_.md 'FlowLibrary.Contracts.IEventHandler<IEvent>')

## IEventHandler<IEvent>.OnAsync(IEvent) Method

Handles the specified event asynchronously.

```csharp
System.Threading.Tasks.Task OnAsync(IEvent @event);
```
#### Parameters

<a name='FlowLibrary.Contracts.IEventHandler_IEvent_.OnAsync(IEvent).event'></a>

`event` [IEvent](IEventHandler_IEvent_.md#FlowLibrary.Contracts.IEventHandler_IEvent_.IEvent 'FlowLibrary.Contracts.IEventHandler<IEvent>.IEvent')

The event to handle.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task that represents the asynchronous operation.