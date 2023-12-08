namespace app.web.Dtos
{
    public class BaseRespModel<T> where T : class
    {
        public string? TransactionRefNo { get; set; }
        public T? Data { get; set; }
        public BaseRespError? Error { get; set; }
    }

    public class BaseRespError
    {
        public string? Code { get; set; }
        public string? Message { get; set; }
        public List<BaseRespDetail>? Details { get; set; } = new List<BaseRespDetail>();
    }

    public class BaseRespDetail
    {
        public string? ErrorCode { get; set; }
        public string? ErrorDescription { get; set; }
    }
}
