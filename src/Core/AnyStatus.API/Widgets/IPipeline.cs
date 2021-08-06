using System;

namespace AnyStatus.API.Widgets
{
    public interface IPipeline
    {
        string Branch { get; set; }

        string BuildNumber { get; set; }

        DateTime FinishTime { get; set; }

        TimeSpan Duration { get; set; }

        public string Author { get; }
        public string Reason { get; }
    }
}
