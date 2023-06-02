using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0197
{
    /// <summary>
    /// Strongly-types a string as the name of a library.
    /// <inheritdoc cref="Documentation.Library" path="/definition"/>
    /// </summary>
    [StrongTypeMarker]
    public interface ILibraryName : IStrongTypeMarker,
        ITyped<string>
    {
    }
}