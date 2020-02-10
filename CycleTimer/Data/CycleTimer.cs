using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CycleTimer.Data
{
    public class CycleTimer
    {
        public int CurrentCount { get; set;}
        public TimeSpan CurrentTime { get; set; }

        public TimeSpan TimeOverCycle { get; set; }
        public TimeSpan CurrentTimeOverCycle { get; set; }

        public Cycle CurrentCycle { get; set; }

        public Issue LineDown { get; set; }
        public Issue TechnicalIssue { get; set; }
        public Issue MaterialIssue { get; set;  }

        public Health Health { get; set; }
    }
}
