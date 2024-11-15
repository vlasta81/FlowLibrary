#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Builders](FlowLibrary.Builders.md 'FlowLibrary.Builders').[MiddlewaresBuilder&lt;TRequest,TResponse&gt;](MiddlewaresBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.MiddlewaresBuilder<TRequest,TResponse>')

## MiddlewaresBuilder<TRequest,TResponse>.Use<TMiddleware>() Method

Adds a middleware of type [TMiddleware](MiddlewaresBuilder_TRequest,TResponse_.Use_TMiddleware_().md#FlowLibrary.Builders.MiddlewaresBuilder_TRequest,TResponse_.Use_TMiddleware_().TMiddleware 'FlowLibrary.Builders.MiddlewaresBuilder<TRequest,TResponse>.Use<TMiddleware>().TMiddleware') to the pipeline.

```csharp
public FlowLibrary.Builders.MiddlewaresBuilder<TRequest,TResponse> Use<TMiddleware>()
    where TMiddleware : FlowLibrary.Contracts.IMiddleware<TRequest, TResponse?>;
```
#### Type parameters

<a name='FlowLibrary.Builders.MiddlewaresBuilder_TRequest,TResponse_.Use_TMiddleware_().TMiddleware'></a>

`TMiddleware`

The type of the middleware to add.

#### Returns
[FlowLibrary.Builders.MiddlewaresBuilder&lt;](MiddlewaresBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.MiddlewaresBuilder<TRequest,TResponse>')[TRequest](MiddlewaresBuilder_TRequest,TResponse_.md#FlowLibrary.Builders.MiddlewaresBuilder_TRequest,TResponse_.TRequest 'FlowLibrary.Builders.MiddlewaresBuilder<TRequest,TResponse>.TRequest')[,](MiddlewaresBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.MiddlewaresBuilder<TRequest,TResponse>')[TResponse](MiddlewaresBuilder_TRequest,TResponse_.md#FlowLibrary.Builders.MiddlewaresBuilder_TRequest,TResponse_.TResponse 'FlowLibrary.Builders.MiddlewaresBuilder<TRequest,TResponse>.TResponse')[&gt;](MiddlewaresBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.MiddlewaresBuilder<TRequest,TResponse>')  
The current instance of [MiddlewaresBuilder&lt;TRequest,TResponse&gt;](MiddlewaresBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.MiddlewaresBuilder<TRequest,TResponse>').