
# FlowLibrary

FlowLibrary je knihovna pro vytváření a správu toků zpracování požadavků a odpovědí v aplikacích .NET 9 Core API. 
Umožňuje snadné sestavení řetězce odpovědností, middleware a příkazu s podporou dekorátorů, což zjednodušuje správu složitých toků zpracování.

### Klíčové vlastnosti

•	Chain Of Responsibility: Umožňuje definovat sekvenci kroků, které se provádějí před zpracováním požadavku.

•	Middleware: Podpora pro přidávání middleware komponent, které mohou manipulovat s požadavky a odpověďmi.

•	Command and Decorators: Umožňuje definovat příkaz s možností přidání dekorátorů pro rozšíření funkcionality.

•	Events: Umožňuje definovat a spuštět události.

•	Repository and Unit Of Work: Umožňuje spravovat entity jako repozitáře s podporou Entity Framework transakcí.

•	Strategy: Snadné formátování výstupu.

•	Flexibilní konfigurace: Snadná konfigurace a sestavení toků pomocí Fluent API.

### Stažení

Aktuální knihovna ke stažení zde: DOWNLOAD.

### Instalace

Ve Visual Studiu přidejte referenci na dll knihovnu FlowLibrary.dll nebo si sestavte vlastní knihovnu.

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

## Použití

### Request a Response

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

### IFlowFactory a IFlowEvents

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

### IFlowUnit a Repository

```csharp
using FlowLibrary.Contracts;
```
```csharp
private IFlowUnit _flowUnit;
```

```csharp
var detailsRepo = _flowUnit.GetRepository<UserDetails>();
```

#### Manuální správa transakce:

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

#### Pomocí helper metody "ExecuteInTransactionAsync":

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

#### Pomocí helper metody s návratovou hodnotou:

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

## Licence

(c) 2024 vlasta81, MIT licence
