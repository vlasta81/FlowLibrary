#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Abstractions](FlowLibrary.Abstractions.md 'FlowLibrary.Abstractions').[Responsibility&lt;TRequest,TResponse&gt;](Responsibility_TRequest,TResponse_.md 'FlowLibrary.Abstractions.Responsibility<TRequest,TResponse>')

## Responsibility<TRequest,TResponse>.SetNext(Responsibility<TRequest,TResponse>) Method

Sets the next handler in the chain of responsibility.

```csharp
internal void SetNext(FlowLibrary.Abstractions.Responsibility<TRequest,TResponse> next);
```
#### Parameters

<a name='FlowLibrary.Abstractions.Responsibility_TRequest,TResponse_.SetNext(FlowLibrary.Abstractions.Responsibility_TRequest,TResponse_).next'></a>

`next` [FlowLibrary.Abstractions.Responsibility&lt;](Responsibility_TRequest,TResponse_.md 'FlowLibrary.Abstractions.Responsibility<TRequest,TResponse>')[TRequest](Responsibility_TRequest,TResponse_.md#FlowLibrary.Abstractions.Responsibility_TRequest,TResponse_.TRequest 'FlowLibrary.Abstractions.Responsibility<TRequest,TResponse>.TRequest')[,](Responsibility_TRequest,TResponse_.md 'FlowLibrary.Abstractions.Responsibility<TRequest,TResponse>')[TResponse](Responsibility_TRequest,TResponse_.md#FlowLibrary.Abstractions.Responsibility_TRequest,TResponse_.TResponse 'FlowLibrary.Abstractions.Responsibility<TRequest,TResponse>.TResponse')[&gt;](Responsibility_TRequest,TResponse_.md 'FlowLibrary.Abstractions.Responsibility<TRequest,TResponse>')

The next handler.