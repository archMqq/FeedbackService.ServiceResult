using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackService.ServiceResult
{
    public class ServiceErrors
    {
        public string Error {  get; set; }
        [DefaultValue(null)]
        public string[]? Fields { get; set; }
    }
}
