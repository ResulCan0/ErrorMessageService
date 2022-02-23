namespace ErrorMessageService.Entities.Dto
{
    public class ErrorDetailsDto
    {
        public string AppName { get; set; }
        public int ErrorMessageStatusCode { get; set; }
        public string Description { get; set; }
        public DateTime RequestTime { get; set; }
    }
}
