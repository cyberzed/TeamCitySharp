using System.Collections.Generic;
using TeamCitySharp.DomainEntities;
using TeamCitySharp.Locators;

namespace TeamCitySharp.ActionTypes
{
    public interface IInvestigations
    {
        Investigation ByTestId(string id);
        Investigation ByTestName(string name);
        List<Investigation> ByAssigneeLocator(UserLocator userLocator);
        List<Investigation> ByBuildTypeId(string buildTypeId);
    }
}