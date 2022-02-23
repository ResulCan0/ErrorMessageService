using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
