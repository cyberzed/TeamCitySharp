using System;
using System.Collections.Generic;

namespace TeamCitySharp.DomainEntities
{
    public class Investigation
    {
        public string Id { get; set; }
        public string State { get; set; }
        public string Href { get; set; }

        public User Assignee { get; set; }
        public Assignment Assignment { get; set; }
    }

    public class Assignment
    {
        public User User { get; set; }
        public DateTime Timestamp { get; set; }
    }

    public class InvestigationWrapper
    {
        public List<Investigation> Investigation { get; set; }
    }
}