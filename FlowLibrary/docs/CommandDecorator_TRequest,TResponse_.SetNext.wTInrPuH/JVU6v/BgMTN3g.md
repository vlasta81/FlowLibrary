#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Abstractions](FlowLibrary.Abstractions.md 'FlowLibrary.Abstractions').[CommandDecorator&lt;TRequest,TResponse&gt;](CommandDecorator_TRequest,TResponse_.md 'FlowLibrary.Abstractions.CommandDecorator<TRequest,TResponse>')

## CommandDecorator<TRequest,TResponse>.SetNext(ICommand<TRequest,TResponse>) Method

Sets the next decorator in the chain.

```csharp
internal void SetNext(FlowLibrary.Contracts.ICommand<TRequest,TResponse> decorator);
```
#### Parameters

<a name='FlowLibrary.Abstractions.CommandDecorator_TRequest,TResponse_.SetNext(FlowLibrary.Contracts.ICommand_TRequest,TResponse_).decorator'></a>

`decorator` [FlowLibrary.Contracts.ICommand&lt;](ICommand_TRequest,TResponse_.md 'FlowLibrary.Contracts.ICommand<TRequest,TResponse>')[TRequest](CommandDecorator_TRequest,TResponse_.md#FlowLibrary.Abstractions.CommandDecorator_TRequest,TResponse_.TRequest 'FlowLibrary.Abstractions.CommandDecorator<TRequest,TResponse>.TRequest')[,](ICommand_TRequest,TResponse_.md 'FlowLibrary.Contracts.ICommand<TRequest,TResponse>')[TResponse](CommandDecorator_TRequest,TResponse_.md#FlowLibrary.Abstractions.CommandDecorator_TRequest,TResponse_.TResponse 'FlowLibrary.Abstractions.CommandDecorator<TRequest,TResponse>.TResponse')[&gt;](ICommand_TRequest,TResponse_.md 'FlowLibrary.Contracts.ICommand<TRequest,TResponse>')

The next decorator.