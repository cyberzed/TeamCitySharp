using System.Collections.Generic;
using TeamCitySharp.DomainEntities;
using TeamCitySharp.Locators;

namespace TeamCitySharp.ActionTypes
{
    public interface IProblems
    {
        List<ProblemOccurrence> ByBuildLocator(BuildLocator buildLocator);
        List<ProblemOccurrence> All();
    }
}