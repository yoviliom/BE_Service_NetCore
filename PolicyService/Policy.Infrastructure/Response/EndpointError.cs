namespace Policy.Infrastructure.Response
{
    public class EndpointError
    {
        public string message { get; set; }

        public EndpointError()
        {
        }

        public EndpointError(string _message)
        {
            message = _message;
        }
    }
}