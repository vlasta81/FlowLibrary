using Microsoft.AspNetCore.Mvc;

namespace FlowLibrary.Common
{
    /// <summary>
    /// Represents a request body wrapper for an API endpoint.
    /// </summary>
    /// <typeparam name="TBody">The type of the body content.</typeparam>
    public class RequestBody<TBody>
    {
        /// <summary>
        /// Gets or sets the body content of the request.
        /// </summary>
        [FromBody]
        public TBody? Body { get; set; }
    }
}
