namespace ErrorMessageService.Entities.Dto
{
    public class ErrorMessageDto
    {
        public int ErrorMessageId { get; set; }
        public int SubStatusCode { get; set; }
        public int StatusCode { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }


    }
}
