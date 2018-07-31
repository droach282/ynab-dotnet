namespace YNAB.Models
{
    public class DataResponse<T> where T : IResponse
    {
        public T Data { get; set; }
        public ErrorDetail Error { get; set; }
    }
}