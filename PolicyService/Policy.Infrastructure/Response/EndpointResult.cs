using Newtonsoft.Json;
using System;
using System.Net;

namespace Policy.Infrastructure.Response
{
    public class EndpointMetaData
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }
    }

    public class EndpointResult
    {
        public EndpointResult()
        {
        }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("metadata")]
        public EndpointMetaData Metadata { get; set; }

        [JsonProperty("data")]
        public object Data { get; set; }

        public EndpointResult(HttpStatusCode _statusCode, object _data)
        {
            Code = Convert.ToString((int)_statusCode);
            Message = _statusCode.ToString();
            Data = _data;
            Metadata = new EndpointMetaData
            {
                Created = DateTime.UtcNow.ToString("o"),
                Modified = DateTime.UtcNow.ToString("o"),
            };
        }

        public EndpointResult(object _data)
        {
            Code = "200";
            Message = "OK";
            Data = _data;
            Metadata = new EndpointMetaData
            {
                Created = DateTime.UtcNow.ToString("o"),
                Modified = DateTime.UtcNow.ToString("o"),
            };
        }
    }
}