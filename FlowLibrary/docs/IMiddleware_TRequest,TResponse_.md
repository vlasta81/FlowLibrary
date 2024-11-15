#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Contracts](FlowLibrary.Contracts.md 'FlowLibrary.Contracts')

## IMiddleware<TRequest,TResponse> Interface

Defines a middleware interface for processing requests and responses.

```csharp
public interface IMiddleware<TRequest,TResponse>
```
#### Type parameters

<a name='FlowLibrary.Contracts.IMiddleware_TRequest,TResponse_.TRequest'></a>

`TRequest`

The type of the request object.

<a name='FlowLibrary.Contracts.IMiddleware_TRequest,TResponse_.TResponse'></a>

`TResponse`

The type of the response object.

| Methods | |
| :--- | :--- |
| [InvokeAsync(TRequest, Func&lt;TRequest,Task&lt;TResponse&gt;&gt;)](IMiddleware_TRequest,TResponse_.InvokeAsync.jLrsvzdTELXweLi/cyDn+g.md 'FlowLibrary.Contracts.IMiddleware<TRequest,TResponse>.InvokeAsync(TRequest, System.Func<TRequest,System.Threading.Tasks.Task<TResponse>>)') | Invokes the middleware with the specified request and the next middleware in the pipeline. |
