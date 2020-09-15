using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample08.Messages
{
    public class InteractionWorkflow
    {
        public Guid InteractionId { get; set; }
        public int Attempts { get; set; }
        public string Message { get; set; }
    }
}
