using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackService.ServiceResult
{
    public class ServiceResult<T>
    {
        [DefaultValue(false)]
        public bool BadRequest { get; set; }
        [DefaultValue(false)]
        public bool NotFound { get; set; }
        [DefaultValue(false)]
        public bool InternalServerError { get; set; }
        public T Result { get; set; }
        public ServiceErrors Errors { get; set; }
    }
    }
