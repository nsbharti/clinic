using System.Collections.Generic;

namespace API.Errors
{
    public class ApiValidationErrorResponce : ApiResponces
    {
        public ApiValidationErrorResponce() : base(400)
        {
        }
        public IEnumerable<string> Error{get; set;}
        
    }
}