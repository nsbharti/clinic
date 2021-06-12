using System;

namespace API.Errors
{
    public class ApiResponces
    {
        public ApiResponces(int statusCode, string message= null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode{get; set;}
        public string Message {get; set;}
        
        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "Bad Request",
                401 => "Not Authorised",
                404 => "Resource Not found",
                500 => "Dark Side error path",
                _ => null
            };
        }
    
    }
}