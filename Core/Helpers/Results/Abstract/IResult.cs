namespace Core.Helpers.Results.Abstract
{
    public interface IResult // add oldu olmadi bize result (netice) lazimdir true yoxsa false di 
    {
        bool Success { get; }
        string Message { get; }
    }
}
