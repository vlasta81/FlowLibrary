using FlowLibrary.Abstractions;
using FlowLibrary.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FlowLibrary.Extensions
{
    /// <summary>
    /// Provides extension methods for setting up Flow services in an <see cref="IServiceCollection"/>.
    /// </summary>
    public static class FlowExtension
    {
        /// <summary>
        /// Adds Flow services to the specified <see cref="IServiceCollection"/>.
        /// </summary>
        /// <typeparam name="TContext">The type of the <see cref="DbContext"/> to use.</typeparam>
        /// <param name="services">The <see cref="IServiceCollection"/> to add services to.</param>
        /// <param name="assembly">The <see cref="Assembly"/> to scan for Flow components.</param>
        /// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
        public static IServiceCollection AddFlow<TContext>(this IServiceCollection services, Assembly assembly) where TContext : DbContext
        {
            services.AddScoped<IFlowFactory, FlowFactory>();
            services.AddScoped<IFlowEvents, FlowEvents>();
            services.AddScoped<IFlowUnit, FlowUnit>(svcp =>
            {
                TContext context = svcp.CreateScope().ServiceProvider.GetRequiredService<TContext>();
                return new FlowUnit(context);
            });
            Type[]? types = assembly.GetTypes();
            List<Type>? commandTypes = types.Where(t => t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICommand<,>))).ToList();
            foreach (Type? commandType in commandTypes)
            {
                Type? interfaceType = commandType.GetInterfaces().First(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICommand<,>));
                if (interfaceType is not null)
                    services.AddScoped(commandType);
            }
            List<Type>? strategyTypes = types.Where(t => t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IResponseStrategy<>))).ToList();
            foreach (Type? strategyType in strategyTypes)
            {
                Type? interfaceType = strategyType.GetInterfaces().First(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IResponseStrategy<>));
                if (interfaceType is not null) services.AddScoped(strategyType);
            }
            List<Type>? middlewareTypes = types.Where(t => t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMiddleware<,>))).ToList();
            foreach (Type? middlewareType in middlewareTypes)
            {
                Type? interfaceType = middlewareType.GetInterfaces().First(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMiddleware<,>));
                if (interfaceType is not null) services.AddScoped(middlewareType);
            }
            List<Type>? eventsTypes = types.Where(t => t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IEventHandler<>))).ToList();
            foreach (Type? eventType in eventsTypes)
            {
                IEnumerable<Type>? interfaceTypes = eventType.GetInterfaces().Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IEventHandler<>));
                foreach (Type? @interface in interfaceTypes)
                {
                    if (@interface is not null) services.AddScoped(@interface, eventType);
                }
            }
            List<Type>? chainTypes = types.Where(t => t.BaseType != null && t.BaseType.IsGenericType && t.BaseType.GetGenericTypeDefinition() == typeof(Responsibility<,>)).ToList();
            foreach (Type? chainType in chainTypes)
            {
                Type? baseType = chainType.BaseType;
                if (baseType is not null)
                    services.AddScoped(chainType);
            }
            return services;
        }
    }
}
