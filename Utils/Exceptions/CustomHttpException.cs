using System.Net;

namespace Generador_ideas.Utils.Exceptions
{
    public class CustomHttpException : Exception
    { 
            public HttpStatusCode StatusCode { get; }

            public CustomHttpException(string message, HttpStatusCode statusCode) : base(message)
            {
                StatusCode = statusCode;
            }
        
    }
}
