using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0197
{
    /// <inheritdoc cref="ILibraryDescription"/>
    [StrongTypeImplementationMarker]
    public class LibraryDescription : TypedBase<string>, IStrongTypeMarker,
        ILibraryDescription
    {
        public LibraryDescription(string value)
            : base(value)
        {
        }
    }
}