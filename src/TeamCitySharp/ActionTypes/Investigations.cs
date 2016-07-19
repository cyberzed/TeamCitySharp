using System.Collections.Generic;
using TeamCitySharp.Connection;
using TeamCitySharp.DomainEntities;
using TeamCitySharp.Locators;

namespace TeamCitySharp.ActionTypes
{
    internal class Investigations : IInvestigations
    {
        private readonly ITeamCityCaller _caller;

        public Investigations(ITeamCityCaller caller)
        {
            _caller = caller;
        }

        public Investigation ByTestId(string id)
        {
            var investigation = _caller.Get<Investigation>($"/app/rest/investigations?locator:test:(id:{id})");

            return investigation;
        }

        public Investigation ByTestName(string name)
        {
            var investigation = _caller.Get<Investigation>($"/app/rest/investigations?locator:test:(name:{name})");

            return investigation;
        }

        public List<Investigation> ByAssigneeLocator(UserLocator userLocator)
        {
            var investigations = _caller.Get<InvestigationWrapper>($"/app/rest/investigations?locator=assignee:({userLocator})");

            return investigations.Investigation;
        }

        public List<Investigation> ByBuildTypeId(string buildTypeId)
        {
            var investigations = _caller.Get<InvestigationWrapper>($"/app/rest/investigations?locator=buildType:(id:{buildTypeId})");

            return investigations.Investigation;
        }
    }
}