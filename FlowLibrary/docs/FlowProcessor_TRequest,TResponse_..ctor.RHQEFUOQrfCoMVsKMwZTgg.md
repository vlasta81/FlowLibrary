#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Builders](FlowLibrary.Builders.md 'FlowLibrary.Builders').[FlowProcessor&lt;TRequest,TResponse&gt;](FlowProcessor_TRequest,TResponse_.md 'FlowLibrary.Builders.FlowProcessor<TRequest,TResponse>')

## FlowProcessor(ICommand<TRequest,TResponse>, Responsibility<TRequest,TResponse>, IResponseStrategy<TResponse>, List<IMiddleware<TRequest,TResponse>>) Constructor

Initializes a new instance of the [FlowProcessor&lt;TRequest,TResponse&gt;](FlowProcessor_TRequest,TResponse_.md 'FlowLibrary.Builders.FlowProcessor<TRequest,TResponse>') class.

```csharp
public FlowProcessor(FlowLibrary.Contracts.ICommand<TRequest,TResponse> command, FlowLibrary.Abstractions.Responsibility<TRequest,TResponse>? chain, FlowLibrary.Contracts.IResponseStrategy<TResponse>? strategy, System.Collections.Generic.List<FlowLibrary.Contracts.IMiddleware<TRequest,TResponse>> middlewares);
```
#### Parameters

<a name='FlowLibrary.Builders.FlowProcessor_TRequest,TResponse_.FlowProcessor(FlowLibrary.Contracts.ICommand_TRequest,TResponse_,FlowLibrary.Abstractions.Responsibility_TRequest,TResponse_,FlowLibrary.Contracts.IResponseStrategy_TResponse_,System.Collections.Generic.List_FlowLibrary.Contracts.IMiddleware_TRequest,TResponse__).command'></a>

`command` [FlowLibrary.Contracts.ICommand&lt;](ICommand_TRequest,TResponse_.md 'FlowLibrary.Contracts.ICommand<TRequest,TResponse>')[TRequest](FlowProcessor_TRequest,TResponse_.md#FlowLibrary.Builders.FlowProcessor_TRequest,TResponse_.TRequest 'FlowLibrary.Builders.FlowProcessor<TRequest,TResponse>.TRequest')[,](ICommand_TRequest,TResponse_.md 'FlowLibrary.Contracts.ICommand<TRequest,TResponse>')[TResponse](FlowProcessor_TRequest,TResponse_.md#FlowLibrary.Builders.FlowProcessor_TRequest,TResponse_.TResponse 'FlowLibrary.Builders.FlowProcessor<TRequest,TResponse>.TResponse')[&gt;](ICommand_TRequest,TResponse_.md 'FlowLibrary.Contracts.ICommand<TRequest,TResponse>')

The command to execute if no middleware or chain handles the request.

<a name='FlowLibrary.Builders.FlowProcessor_TRequest,TResponse_.FlowProcessor(FlowLibrary.Contracts.ICommand_TRequest,TResponse_,FlowLibrary.Abstractions.Responsibility_TRequest,TResponse_,FlowLibrary.Contracts.IResponseStrategy_TResponse_,System.Collections.Generic.List_FlowLibrary.Contracts.IMiddleware_TRequest,TResponse__).chain'></a>

`chain` [FlowLibrary.Abstractions.Responsibility&lt;](Responsibility_TRequest,TResponse_.md 'FlowLibrary.Abstractions.Responsibility<TRequest,TResponse>')[TRequest](FlowProcessor_TRequest,TResponse_.md#FlowLibrary.Builders.FlowProcessor_TRequest,TResponse_.TRequest 'FlowLibrary.Builders.FlowProcessor<TRequest,TResponse>.TRequest')[,](Responsibility_TRequest,TResponse_.md 'FlowLibrary.Abstractions.Responsibility<TRequest,TResponse>')[TResponse](FlowProcessor_TRequest,TResponse_.md#FlowLibrary.Builders.FlowProcessor_TRequest,TResponse_.TResponse 'FlowLibrary.Builders.FlowProcessor<TRequest,TResponse>.TResponse')[&gt;](Responsibility_TRequest,TResponse_.md 'FlowLibrary.Abstractions.Responsibility<TRequest,TResponse>')

The optional chain of responsibility to handle the request.

<a name='FlowLibrary.Builders.FlowProcessor_TRequest,TResponse_.FlowProcessor(FlowLibrary.Contracts.ICommand_TRequest,TResponse_,FlowLibrary.Abstractions.Responsibility_TRequest,TResponse_,FlowLibrary.Contracts.IResponseStrategy_TResponse_,System.Collections.Generic.List_FlowLibrary.Contracts.IMiddleware_TRequest,TResponse__).strategy'></a>

`strategy` [FlowLibrary.Contracts.IResponseStrategy&lt;](IResponseStrategy_TResponse_.md 'FlowLibrary.Contracts.IResponseStrategy<TResponse>')[TResponse](FlowProcessor_TRequest,TResponse_.md#FlowLibrary.Builders.FlowProcessor_TRequest,TResponse_.TResponse 'FlowLibrary.Builders.FlowProcessor<TRequest,TResponse>.TResponse')[&gt;](IResponseStrategy_TResponse_.md 'FlowLibrary.Contracts.IResponseStrategy<TResponse>')

The optional response strategy to apply to the command's response.

<a name='FlowLibrary.Builders.FlowProcessor_TRequest,TResponse_.FlowProcessor(FlowLibrary.Contracts.ICommand_TRequest,TResponse_,FlowLibrary.Abstractions.Responsibility_TRequest,TResponse_,FlowLibrary.Contracts.IResponseStrategy_TResponse_,System.Collections.Generic.List_FlowLibrary.Contracts.IMiddleware_TRequest,TResponse__).middlewares'></a>

`middlewares` [System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[FlowLibrary.Contracts.IMiddleware&lt;](IMiddleware_TRequest,TResponse_.md 'FlowLibrary.Contracts.IMiddleware<TRequest,TResponse>')[TRequest](FlowProcessor_TRequest,TResponse_.md#FlowLibrary.Builders.FlowProcessor_TRequest,TResponse_.TRequest 'FlowLibrary.Builders.FlowProcessor<TRequest,TResponse>.TRequest')[,](IMiddleware_TRequest,TResponse_.md 'FlowLibrary.Contracts.IMiddleware<TRequest,TResponse>')[TResponse](FlowProcessor_TRequest,TResponse_.md#FlowLibrary.Builders.FlowProcessor_TRequest,TResponse_.TResponse 'FlowLibrary.Builders.FlowProcessor<TRequest,TResponse>.TResponse')[&gt;](IMiddleware_TRequest,TResponse_.md 'FlowLibrary.Contracts.IMiddleware<TRequest,TResponse>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

The list of middlewares to process the request.