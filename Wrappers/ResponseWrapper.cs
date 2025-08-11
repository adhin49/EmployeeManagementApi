namespace EmployeeManagementApi.Wrappers
{
    public class ResponseWrapper<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public ResponseWrapper(T data, string message = null)
        {
            Success = true;
            Message = message;
            Data = data;
        }

        public ResponseWrapper(string message)
        {
            Success = false;
            Message = message;
        }
    }
}
