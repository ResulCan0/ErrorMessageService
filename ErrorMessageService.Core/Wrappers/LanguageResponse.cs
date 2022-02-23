using Core.Wrappers;

namespace ErrorMessageService.Core.Wrappers
{
    public class LanguageResponse<T> : IResponse
    {
        public LanguageResponse(T data, int languagePath = 0, int pageSize = 0, int pageNumber = 0, string message = null)
        {
            Succeeded = true;
            Message = message;
            LanguagePath = languagePath;
            PageSize = pageSize;
            PageNumber = pageNumber;
            Data = data;
        }

        public int ErrorCode { get; set; }
        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
        public T Data { get; set; }
        public int LanguagePath { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
    }
}
