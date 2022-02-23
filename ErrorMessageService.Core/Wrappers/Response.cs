﻿namespace Core.Wrappers
{
    public class Response<T> : IResponse
    {
        public Response(T data, string message = null)
        {
            Succeeded = true;
            Message = message;
            Data = data;
        }

        public int ErrorCode { get; set; }
        public bool Succeeded { get; set; }
        public string Message { get; set; }

        public List<string> Errors { get; set; }
        public T Data { get; set; }
    }
}
