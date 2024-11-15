#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Builders](FlowLibrary.Builders.md 'FlowLibrary.Builders')

## MiddlewaresBuilder<TRequest,TResponse> Class

A builder class for configuring and adding middlewares to the middleware pipeline.

```csharp
public sealed class MiddlewaresBuilder<TRequest,TResponse>
```
#### Type parameters

<a name='FlowLibrary.Builders.MiddlewaresBuilder_TRequest,TResponse_.TRequest'></a>

`TRequest`

The type of the request object.

<a name='FlowLibrary.Builders.MiddlewaresBuilder_TRequest,TResponse_.TResponse'></a>

`TResponse`

The type of the response object.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; MiddlewaresBuilder<TRequest,TResponse>

| Constructors | |
| :--- | :--- |
| [MiddlewaresBuilder(IServiceProvider, Action&lt;IMiddleware&lt;TRequest,TResponse&gt;&gt;)](MiddlewaresBuilder_TRequest,TResponse_..ctor.S5MFstXfVb5TLKWdtntL+w.md 'FlowLibrary.Builders.MiddlewaresBuilder<TRequest,TResponse>.MiddlewaresBuilder(System.IServiceProvider, System.Action<FlowLibrary.Contracts.IMiddleware<TRequest,TResponse>>)') | Initializes a new instance of the [MiddlewaresBuilder&lt;TRequest,TResponse&gt;](MiddlewaresBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.MiddlewaresBuilder<TRequest,TResponse>') class. |

| Methods | |
| :--- | :--- |
| [Build()](MiddlewaresBuilder_TRequest,TResponse_.Build().md 'FlowLibrary.Builders.MiddlewaresBuilder<TRequest,TResponse>.Build()') | Builds the middleware pipeline by adding all configured middlewares. |
| [Use&lt;TMiddleware&gt;()](MiddlewaresBuilder_TRequest,TResponse_.Use_TMiddleware_().md 'FlowLibrary.Builders.MiddlewaresBuilder<TRequest,TResponse>.Use<TMiddleware>()') | Adds a middleware of type [TMiddleware](MiddlewaresBuilder_TRequest,TResponse_.Use_TMiddleware_().md#FlowLibrary.Builders.MiddlewaresBuilder_TRequest,TResponse_.Use_TMiddleware_().TMiddleware 'FlowLibrary.Builders.MiddlewaresBuilder<TRequest,TResponse>.Use<TMiddleware>().TMiddleware') to the pipeline. |
