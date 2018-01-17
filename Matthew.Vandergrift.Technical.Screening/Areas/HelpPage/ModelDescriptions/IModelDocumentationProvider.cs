using System;
using System.Reflection;

namespace Matthew.Vandergrift.Technical.Screening.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}