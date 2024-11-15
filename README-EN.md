
# FlowLibrary

FlowLibrary is a library for creating and managing request and response processing flows in .NET 9 Core API applications. It allows easy construction of a chain of responsibilities, middleware, and commands with support for decorators, simplifying the management of complex processing flows.

### Key Features

•	Chain Of Responsibility: Allows defining a sequence of steps to be executed before processing a request.

•	Middleware: Support for adding middleware components that can manipulate requests and responses.

•	Command and Decorators: Allows defining a command with the ability to add decorators to extend functionality.

•	Events: Allows defining and triggering events.

•	Repository and Unit Of Work: Allows managing entities as repositories with support for Entity Framework transactions.

•	Strategy: Easy output formatting.

•	Flexible Configuration: Easy configuration and construction of flows using Fluent API.

### Download

Current library available for download here: DOWNLOAD.

### Installation

In Visual Studio, add a reference to the FlowLibrary.dll or build your own library.

## Flow

```
<TRequest> ↓
	ChainOfResponsibility?
		return <TResponse> ←
		return null →
			Middlewares?
				return <TResponse> ←
				return null →
					Command!
						return <TResponse> ←
					Decorators?
						return <TResponse> ←
					Strategy?
						return <TResponse> ←
<TResponse> ←
```

## Usage

### Request and Response

```csharp
public class MyRequest
{        
}
```
```csharp
public class MyResponse
{        
}
```

### Chain Of Responsibility

```csharp
using FlowLibrary.Abstractions;
```
```csharp
public class FirstResponsibility : Responsibility<MyRequest, MyResponse>
{
	public override async Task<MyResponse?> HandleAsync(MyRequest request)
	{
		Console.WriteLine("FirstResponsibility");
		return await base.HandleAsync(request);
	}
}
```

### Middleware

```csharp
using FlowLibrary.Contracts;
```
```csharp
public class FirstMiddleware : IMiddleware<MyRequest, MyResponse?>
{
	public async Task<MyResponse?> InvokeAsync(MyRequest request, Func<MyRequest, Task<MyResponse?>> next)
	{
		Console.WriteLine("FirstMiddleware before");
		MyResponse? response = await next(request);
		Console.WriteLine("FirstMiddleware after");
		return response;
	}
}
```

### Event

```csharp
using FlowLibrary.Contracts;
```
```csharp
public class FirstEvent : IEvent
{
} 
```

### Event handler

```csharp
using FlowLibrary.Contracts;
```
```csharp
public class EmailEvents : IEventHandler<FirstEvent>
{
	public async Task OnAsync(FirstEvent @event)
	{
		Console.WriteLine("EmailEvents: FirstEvent");
		await Task.CompletedTask;
	}
}
```

### Command

```csharp
using FlowLibrary.Contracts;
```
```csharp
public class MyCommand : ICommand<MyRequest, MyResponse>
{
	public async Task<MyResponse> ExecuteAsync(MyRequest request)
	{
		Console.WriteLine("MyCommand");
		return await Task.Run(() => new MyResponse());
	}
}
```

### Command decorator

```csharp
using FlowLibrary.Abstractions;
```
```csharp
public class FirstDecorator : CommandDecorator<MyRequest, MyResponse>
{
	public override async Task<MyResponse> ExecuteAsync(MyRequest request)
	{
		Console.WriteLine("FirstDecorator");
		return await base.ExecuteAsync(request);
	}
}
```

### Response strategy

```csharp
using FlowLibrary.Contracts;
```
```csharp
public class FirstStrategy : IResponseStrategy<MyResponse>
{
	public async Task<MyResponse> ApplyStrategyAsync(MyResponse response)
	{
		Console.WriteLine("FirstStrategy");
		return await Task.Run(() => response);
	}
}
```

### IFlowFactory and IFlowEvents

```csharp
using FlowLibrary.Contracts;
using FlowLibrary.Builders;
```
```csharp
private IFlowFactory _flowFactory;
private IFlowEvents _flowEvents;
```
```csharp
await _flowEvents.RaiseAsync(new FirstEvent());
```
```csharp
FlowBuilder<MyRequest, MyResponse> flow = _flowFactory.CreateFor<MyRequest, MyResponse>();

flow.AddChainOfResponsibilities()
	.SetNext<FirstResponsibility>()
	...
	.Build();

flow.AddMiddlewares()
	.Use<FirstMiddleware>()
	...
	.Build();

flow.AddCommand()
	.SetCommand<MyCommand>()
	.WithDecorator<FirstDecorator>()
	...
	.Build();

flow.SetResponseStrategy<FirstStrategy>();

FlowProcessor<MyRequest, MyResponse> flowProcessor = flow.Build();

return await flowProcessor.ProcessAsync(new MyRequest());
```

### IFlowUnit and Repository

```csharp
using FlowLibrary.Contracts;
```
```csharp
private IFlowUnit _flowUnit;
```

```csharp
var detailsRepo = _flowUnit.GetRepository<UserDetails>();
```

#### Manual transaction management:

```csharp
public async Task CreateWithDetailsAsync(UserDetails details)
{
    try 
    {
        await _flowUnit.BeginTransactionAsync();        
        var detailsRepo = _flowUnit.GetRepository<UserDetails>();        
        await detailsRepo.AddAsync(details);        
        await _flowUnit.CommitTransactionAsync();
    }
    catch
    {
        await _flowUnit.RollbackTransactionAsync();
        throw;
    }
}
```

#### Using the helper method "ExecuteInTransactionAsync":

```csharp
public async Task CreateWithDetailsAsync(UserDetails details)
{
    await _flowUnit.ExecuteInTransactionAsync(async () =>
    {
        var detailsRepo = _flowUnit.GetRepository<UserDetails>();        
        await detailsRepo.AddAsync(details);
    });
}
```

#### Using the helper method with a return value:

```csharp
public async Task<UserDetails> CreateWithDetailsAsync(UserDetails details)
{
    return await _flowUnit.ExecuteInTransactionAsync(async () =>
    {
        var detailsRepo = _flowUnit.GetRepository<UserDetails>();        
        await detailsRepo.AddAsync(details);        
        return details;
    });
}
```

## License

(c) 2024 vlasta81, MIT license
