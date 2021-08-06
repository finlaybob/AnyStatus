using System;

namespace AnyStatus.API.Widgets
{
    public interface IPipeline
    {
        string Branch { get; set; }

        string BuildNumber { get; set; }

        DateTime FinishTime { get; set; }

        TimeSpan Duration { get; set; }

        public string Title { get; }
        public string Author { get; }
    }
}
