using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0197
{
    /// <summary>
    /// Strongly-types a string as a unadjusted library name.
    /// Library names might be adjusted for many reasons. (For example, is the GitHub repository for the library private?)
    /// This is the primary library name type.
    /// </summary>
    [StrongTypeMarker]
    public interface IUnadjustedLibraryName : IStrongTypeMarker,
        ITyped<string>
    {
    }
}