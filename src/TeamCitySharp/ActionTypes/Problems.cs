using System.Collections.Generic;
using TeamCitySharp.Connection;
using TeamCitySharp.DomainEntities;
using TeamCitySharp.Locators;

namespace TeamCitySharp.ActionTypes
{
    internal class Problems : IProblems
    {
        private readonly ITeamCityCaller _caller;

        public Problems(ITeamCityCaller caller)
        {
            _caller = caller;
        }

        public List<ProblemOccurrence> All()
        {
            var problems = _caller.Get<ProblemOccurrenceWrapper>("/app/rest/problemOccurrences");

            return problems.ProblemOccurrence;
        }

        public List<ProblemOccurrence> ByBuildLocator(BuildLocator buildLocator)
        {
            var problems = _caller.Get<ProblemOccurrenceWrapper>($"/app/rest/problemOccurrences?locator=build:({buildLocator})");

            return problems.ProblemOccurrence;
        }
    }
}