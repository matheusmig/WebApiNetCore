namespace Services
{
    public class ServiceResponse<T>
    {
        public bool IsSuccessful { get; set; } = false;
        public T Data { get; set; } = default(T);
        public string AdditionalMessage { get; set; }
    }
}
