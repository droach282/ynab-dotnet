namespace YNAB.Models
{
    public class DataResponse<T> where T : IResponse
    {
        public T Data { get; set; }
        public ErrorResponse Error { get; set; }
    }
}