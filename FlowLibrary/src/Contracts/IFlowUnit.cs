
namespace FlowLibrary.Contracts
{
    /// <summary>
    /// Represents a unit of work that encapsulates a set of operations to be performed on a repository.
    /// </summary>
    public interface IFlowUnit : IDisposable
    {
        /// <summary>
        /// Gets the repository for the specified entity type.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <returns>The repository for the specified entity type.</returns>
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;

        /// <summary>
        /// Saves all changes made in this unit of work asynchronously.
        /// </summary>
        /// <returns>A task that represents the asynchronous save operation. The task result contains the number of state entries written to the database.</returns>
        Task<int> SaveChangesAsync();

        /// <summary>
        /// Begins a transaction asynchronously.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task BeginTransactionAsync();

        /// <summary>
        /// Commits the current transaction asynchronously.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task CommitTransactionAsync();

        /// <summary>
        /// Rolls back the current transaction asynchronously.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task RollbackTransactionAsync();

        /// <summary>
        /// Executes the specified action within a transaction asynchronously and returns a result.
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="action">The action to execute.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the result of the action.</returns>
        Task<TResult> ExecuteInTransactionAsync<TResult>(Func<Task<TResult>> action);

        /// <summary>
        /// Executes the specified action within a transaction asynchronously.
        /// </summary>
        /// <param name="action">The action to execute.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task ExecuteInTransactionAsync(Func<Task> action);
    }
}
