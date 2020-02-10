using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CycleTimer.Data
{
    public class Issue
    {
        public bool Active { get; set; }
        public int Count { get; set; }
        public TimeSpan CurrentTime { get; set; }
        public TimeSpan TotalDownTime { get; set; }
    }
}
