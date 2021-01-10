using System.Collections.Generic;
using Coverlet.Core.Helpers;

namespace Coverlet.Core.Abstractions
{
    public interface ISourceRootTranslator
    {
        string ResolveFilePath(string originalFileName);
        IReadOnlyList<SourceRootMapping> ResolvePathRoot(string pathRoot);
    }
}
