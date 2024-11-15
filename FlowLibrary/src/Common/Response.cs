
namespace FlowLibrary.Common
{
    /// <summary>
    /// Represents a response with status code, success flag, title, and errors.
    /// </summary>
    public class Response
    {
        /// <summary>
        /// Gets or sets the status code of the response. Default is 400.
        /// </summary>
        public int StatusCode { get; set; } = 400;

        /// <summary>
        /// Gets or sets a value indicating whether the response is successful. Default is false.
        /// </summary>
        public bool IsSuccessfully { get; set; } = false;

        /// <summary>
        /// Gets or sets the title of the response.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the collection of errors associated with the response.
        /// </summary>
        public IEnumerable<string> Errors { get; set; } = new List<string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response"/> class with specified title, status code, success flag, and errors.
        /// </summary>
        /// <param name="title">The title of the response.</param>
        /// <param name="statusCode">The status code of the response. Default is 400.</param>
        /// <param name="isSuccessfully">A value indicating whether the response is successful. Default is false.</param>
        /// <param name="errors">The collection of errors associated with the response.</param>
        public Response(string title, int statusCode = 400, bool isSuccessfully = false, IEnumerable<string> errors = default!)
        {
            Title = title;
            StatusCode = statusCode;
            IsSuccessfully = isSuccessfully;
            Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response"/> class.
        /// </summary>
        public Response()
        {
        }
    }
}
