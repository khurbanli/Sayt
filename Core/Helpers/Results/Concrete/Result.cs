using Core.Helpers.Results.Abstract;

namespace Core.Helpers.Results.Concrete
{
    public class Result : IResult
    {
        // nested constructor
        public Result(bool success, string message) : this(success)
        {
            //Success = success; 2 defe yazmag refereansda yer tutur ona gore this sekilinde yazmag daha dogrudur
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
