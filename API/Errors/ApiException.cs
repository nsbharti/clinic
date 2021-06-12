namespace API.Errors
{
    public class ApiException : ApiResponces
    {
        public ApiException(int statusCode, string message = null, string details = null) :
         base(statusCode, message)
        {
             Details = details;
        }
        public string Details { get; set; }
    }
}