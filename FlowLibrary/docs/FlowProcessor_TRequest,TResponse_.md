#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Builders](FlowLibrary.Builders.md 'FlowLibrary.Builders')

## FlowProcessor<TRequest,TResponse> Class

The [FlowProcessor&lt;TRequest,TResponse&gt;](FlowProcessor_TRequest,TResponse_.md 'FlowLibrary.Builders.FlowProcessor<TRequest,TResponse>') class is responsible for processing a request through a series of middlewares, a command, and an optional chain of responsibility and response strategy.

```csharp
public sealed class FlowProcessor<TRequest,TResponse>
```
#### Type parameters

<a name='FlowLibrary.Builders.FlowProcessor_TRequest,TResponse_.TRequest'></a>

`TRequest`

The type of the request.

<a name='FlowLibrary.Builders.FlowProcessor_TRequest,TResponse_.TResponse'></a>

`TResponse`

The type of the response.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FlowProcessor<TRequest,TResponse>

| Constructors | |
| :--- | :--- |
| [FlowProcessor(ICommand&lt;TRequest,TResponse&gt;, Responsibility&lt;TRequest,TResponse&gt;, IResponseStrategy&lt;TResponse&gt;, List&lt;IMiddleware&lt;TRequest,TResponse&gt;&gt;)](FlowProcessor_TRequest,TResponse_..ctor.RHQEFUOQrfCoMVsKMwZTgg.md 'FlowLibrary.Builders.FlowProcessor<TRequest,TResponse>.FlowProcessor(FlowLibrary.Contracts.ICommand<TRequest,TResponse>, FlowLibrary.Abstractions.Responsibility<TRequest,TResponse>, FlowLibrary.Contracts.IResponseStrategy<TResponse>, System.Collections.Generic.List<FlowLibrary.Contracts.IMiddleware<TRequest,TResponse>>)') | Initializes a new instance of the [FlowProcessor&lt;TRequest,TResponse&gt;](FlowProcessor_TRequest,TResponse_.md 'FlowLibrary.Builders.FlowProcessor<TRequest,TResponse>') class. |

| Methods | |
| :--- | :--- |
| [ProcessAsync(TRequest)](FlowProcessor_TRequest,TResponse_.ProcessAsync.bkRaBD+s5HVBAdScAUYusA.md 'FlowLibrary.Builders.FlowProcessor<TRequest,TResponse>.ProcessAsync(TRequest)') | Processes the request asynchronously through the chain of responsibility, middlewares, and command. |
